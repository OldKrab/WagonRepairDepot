using System;
using System.Collections.Generic;
using System.Linq;
using Microsoft.EntityFrameworkCore;
using Npgsql;
using WagonRepairDepot.Models;

namespace WagonRepairDepot.Contexts
{
    public static class TrainContextFunctions
    {
        public static List<Wagon> WagonsInspectedBy(this TrainContext db, Inspector inspector)
        {
            return db.Wagons.FromSqlRaw($"select * from wagon_inspect_by({inspector.InspectorId});").ToList();
        }

        public static List<Wagon> ActualWagons(this TrainContext db)
        {
            return db.Wagons.FromSqlRaw($"select * from actual_wagon;").ToList();
        }

        public static List<Wagon> ClientWagons(this TrainContext db, Client client)
        {
            return db.Wagons.FromSqlRaw($"select * from client_wagon({client.ClientId});").ToList();
        }

        public static List<Worker> GetWorkersInBrigade(this TrainContext db, Brigade brigade)
        {
            return db.Workers.FromSqlRaw($"select * from get_workers_in_brigade({brigade.BrigadeId});").ToList();
        }

        public static Brigade CreateBrigade(this TrainContext db, Brigadier brigadier)
        {
            using var conn = new NpgsqlConnection(db.Database.GetConnectionString());
            conn.Open();
            using var cmd = new NpgsqlCommand($"SELECT create_brigade({brigadier.BrigadierId})", conn);
            var id = (int)cmd.ExecuteScalar()!;
            return db.Brigades.First(b => b.BrigadeId == id);
        }

        public static Brigade CreateBrigadier(this TrainContext db, string name, string surname)
        {
            throw new NotImplementedException();
        }


        public static void InsertWorkerIntoBrigade(this TrainContext db,  Worker worker,Brigade brigade)
        {
            using var conn = new NpgsqlConnection(db.Database.GetConnectionString());
            conn.Open();
            using var cmd = new NpgsqlCommand($"CALL insert_worker_into_brigade({worker.WorkerId}, {brigade.BrigadeId})", conn);
            cmd.ExecuteNonQuery();
        }
        public static void RemoveWorkerFromBrigade(this TrainContext db,  Worker worker,Brigade brigade)
        {
            using var conn = new NpgsqlConnection(db.Database.GetConnectionString());
            conn.Open();
            using var cmd = new NpgsqlCommand($"CALL remove_worker_from_brigade({worker.WorkerId}, {brigade.BrigadeId})", conn);
            cmd.ExecuteNonQuery();
        }

    }
}