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

        public static Brigadier CreateBrigadier(this TrainContext db, string surname, string name, string middlename, bool sex)
        {
            using var conn = new NpgsqlConnection(db.Database.GetConnectionString());
            conn.Open();
            using var cmd = new NpgsqlCommand($"SELECT create_brigadier({surname}, {name}, {middlename}, {sex})", conn);
            var id = (int)cmd.ExecuteScalar()!;
            return db.Brigadiers.First(b => b.BrigadierId == id);
        }

        public static Client CreateClient(this TrainContext db, string surname, string name, string middlename, bool sex)
        {
            using var conn = new NpgsqlConnection(db.Database.GetConnectionString());
            conn.Open();
            using var cmd = new NpgsqlCommand($"SELECT create_client({surname}, {name}, {middlename}, {sex})", conn);
            var id = (int)cmd.ExecuteScalar()!;
            return db.Clients.First(b => b.ClientId == id);
        }

        public static Inspector CreateInspector(this TrainContext db, string surname, string name, string middlename, bool sex)
        {
            using var conn = new NpgsqlConnection(db.Database.GetConnectionString());
            conn.Open();
            using var cmd = new NpgsqlCommand($"SELECT create_inspector({surname}, {name}, {middlename}, {sex})", conn);
            var id = (int)cmd.ExecuteScalar()!;
            return db.Inspectors.First(b => b.InspectorId == id);
        }

        public static Receptionist CreateReceptionist(this TrainContext db, string surname, string name, string middlename, bool sex)
        {
            using var conn = new NpgsqlConnection(db.Database.GetConnectionString());
            conn.Open();
            using var cmd = new NpgsqlCommand($"SELECT create_receptionist({surname}, {name}, {middlename}, {sex})", conn);
            var id = (int)cmd.ExecuteScalar()!;
            return db.Receptionists.First(b => b.ReceptionistId == id);
        }

        public static Wagon CreateWagon(this TrainContext db, string model, string type, int seats_number, DateTime creation_year, string serial_number)
        {
            using var conn = new NpgsqlConnection(db.Database.GetConnectionString());
            conn.Open();
            using var cmd = new NpgsqlCommand($"SELECT create_wagon({model}, {type}, {seats_number}, {creation_year}, {serial_number})", conn);
            var id = (int)cmd.ExecuteScalar()!;
            return db.Wagons.First(b => b.WagonId == id);
        }

        public static WagonReceptionDoc CreateWagonReceptionDoc(this TrainContext db, string name, DateTime reception_date, DateTime approx_date, string defect, Wagon wagon, Client client, Receptionist receptionist)
        {
            using var conn = new NpgsqlConnection(db.Database.GetConnectionString());
            conn.Open();
            using var cmd = new NpgsqlCommand($"SELECT create_wagon_reception_doc({name}, {reception_date}, {approx_date}, {defect}, {wagon.WagonId}, {client.ClientId}, {receptionist.ReceptionistId})", conn);
            var id = (int)cmd.ExecuteScalar()!;
            return db.WagonReceptionDocs.First(b => b.RecDocId == id);
        }

        public static WagonReturnDoc CreateWagonReturnDoc(this TrainContext db, string name, DateTime return_date, Wagon wagon, Client client, Brigadier brigadier)
        {
            using var conn = new NpgsqlConnection(db.Database.GetConnectionString());
            conn.Open();
            using var cmd = new NpgsqlCommand($"SELECT create_wagon_return_doc({name}, {return_date}, {wagon.WagonId}, {client.ClientId}, {brigadier.BrigadierId})", conn);
            var id = (int)cmd.ExecuteScalar()!;
            return db.WagonReturnDocs.First(b => b.ReturnDocId == id);
        }

        public static Work CreateWork(this TrainContext db, DateTime planned_deadline, DateTime actual_deadline, Brigade brigade, WorkType workType, WorkOrder workOrder)
        {
            using var conn = new NpgsqlConnection(db.Database.GetConnectionString());
            conn.Open();
            using var cmd = new NpgsqlCommand($"SELECT create_work({planned_deadline}, {actual_deadline}, {brigade.BrigadeId}, {workType.WorkTypeId}, {workOrder.WorkOrderId})", conn);
            var id = (int)cmd.ExecuteScalar()!;
            return db.Works.First(b => b.WorkId == id);
        }

        public static Work CreateWork(this TrainContext db, DateTime planned_deadline, Brigade brigade, WorkType workType, WorkOrder workOrder)
        {
            using var conn = new NpgsqlConnection(db.Database.GetConnectionString());
            conn.Open();
            using var cmd = new NpgsqlCommand($"SELECT create_work({planned_deadline}, {brigade.BrigadeId}, {workType.WorkTypeId}, {workOrder.WorkOrderId})", conn);
            var id = (int)cmd.ExecuteScalar()!;
            return db.Works.First(b => b.WorkId == id);
        }

        public static WorkOrder CreateWorkOrder(this TrainContext db, string name, Inspector inspector, Wagon wagon)
        {
            using var conn = new NpgsqlConnection(db.Database.GetConnectionString());
            conn.Open();
            using var cmd = new NpgsqlCommand($"SELECT create_work_order({name}, {inspector.InspectorId}, {wagon.WagonId})", conn);
            var id = (int)cmd.ExecuteScalar()!;
            return db.WorkOrders.First(b => b.WorkOrderId == id);
        }

        public static WorkType CreateWorkType(this TrainContext db, string name)
        {
            using var conn = new NpgsqlConnection(db.Database.GetConnectionString());
            conn.Open();
            using var cmd = new NpgsqlCommand($"SELECT create_work_type({name})", conn);
            var id = (int)cmd.ExecuteScalar()!;
            return db.WorkTypes.First(b => b.WorkTypeId == id);
        }

        public static Worker CreateWorker(this TrainContext db, string surname, string name, string middlename, bool sex)
        {
            using var conn = new NpgsqlConnection(db.Database.GetConnectionString());
            conn.Open();
            using var cmd = new NpgsqlCommand($"SELECT create_worker({surname}, {name}, {middlename}, {sex})", conn);
            var id = (int)cmd.ExecuteScalar()!;
            return db.Workers.First(b => b.WorkerId == id);
        }

        public static List<Brigadier> GetBrigadierPerformedWork(this TrainContext db, Work work)
        {
            return db.Brigadiers.FromSqlRaw($"select * from get_brigadier_perfomed_work({work.WorkId});").ToList();
        }

        public static List<Worker> GetWorkersPerformedWork(this TrainContext db, Work work)
        {
            return db.Workers.FromSqlRaw($"select * from get_workers_perfomed_work({work.WorkId});").ToList();
        }

        public static List<Work> GetWorksPerformedByWorker(this TrainContext db, Worker worker)
        {
            return db.Works.FromSqlRaw($"select * from get_works_perfomed_by_worker({worker.WorkerId});").ToList();
        }

        public static List<Wagon> WagonInspectBy(this TrainContext db, Inspector inspector)
        {
            return db.Wagons.FromSqlRaw($"select * from wagon_inspect_by({inspector.InspectorId});").ToList();
        }

        public static List<Wagon> WagonReceptBy(this TrainContext db, Receptionist receptionist)
        {
            return db.Wagons.FromSqlRaw($"select * from wagon_recept_by({receptionist.ReceptionistId});").ToList();
        }

        public static List<Wagon> WagonReparedBy(this TrainContext db, Worker worker)
        {
            return db.Wagons.FromSqlRaw($"select * from wagon_repared_by({worker.WorkerId});").ToList();
        }

        public static List<Wagon> WagonResponseBy(this TrainContext db, Brigadier brigadier)
        {
            return db.Wagons.FromSqlRaw($"select * from wagon_response_by({brigadier.BrigadierId});").ToList();
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