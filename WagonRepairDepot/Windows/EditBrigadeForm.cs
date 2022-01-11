using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data.Entity.Core.Objects;
using System.Linq;
using System.Windows.Forms;
using Microsoft.EntityFrameworkCore;
using Microsoft.VisualBasic.CompilerServices;
using WagonRepairDepot.Contexts;
using WagonRepairDepot.Models;

namespace WagonRepairDepot.Windows
{
    public partial class EditBrigadeForm : Form
    {
        private Brigade brigade;
        private List<Worker> workers;
        private BindingList<Worker> selectedWorkers;

        public EditBrigadeForm(Brigade brigade)
        {
            InitializeComponent();
            using TrainContext db = new();
            this.brigade = brigade;
            workers = db.GetWorkersInBrigade(brigade);
            selectedWorkers = new BindingList<Worker>(new List<Worker>(workers));

            brigadierComboBox.DataSource = db.Brigadiers.ToList();
            brigadierComboBox.SelectedItem = db.Brigadiers.Find(brigade.BrigadierId);
            workerComboBox.DataSource = db.Workers.ToList();
            listBox1.DataSource = selectedWorkers;
        }

        private void AddWorkerButtonClick(object sender, EventArgs e)
        {
            var worker = (Worker)workerComboBox.SelectedItem;
            if (selectedWorkers.Contains(worker))
                MessageBox.Show($"Работник {worker} уже есть в таблице!");
            else
                selectedWorkers.Add(worker);
        }

        private void DeleteWorkerButtonClick(object sender, EventArgs e)
        {
            if (listBox1.SelectedItem != null)
                selectedWorkers.Remove((Worker)listBox1.SelectedItem);
        }

        private bool IsBrigadeChanged()
        {
            using TrainContext db = new();
            var curBrigade = db.Brigades.Find(brigade.BrigadeId);
            var curWorkers = db.GetWorkersInBrigade(curBrigade).Select(w => w.WorkerId);
            var prevWorkers = workers.Select(w => w.WorkerId);


            return curBrigade.BrigadierId != brigade.BrigadierId
                    || curWorkers.Except(prevWorkers).ToList().Count != 0
                    || prevWorkers.Except(curWorkers).ToList().Count != 0;
        }

        private bool IsForceSave()
        {
            var res = MessageBox.Show(
                @"Бригада была изменена извне! Все равно сохранить?",
                @"Внимание", MessageBoxButtons.OKCancel);

            return res == DialogResult.OK;
        }

        private bool IsBrigadeExist()
        {
            using TrainContext db = new();
            return db.Brigades.Find(brigade.BrigadeId) != null;
        }

        private bool IsCreateNewBrigade()
        {
            var res = MessageBox.Show(
                @"Бригада была удалена извне! Сохранить копию текущей версии?",
                @"Внимание", MessageBoxButtons.OKCancel);
            return res == DialogResult.OK;
        }

        private Brigade CreateNewBrigade()
        {
            using TrainContext db = new();
            var brigadier = db.Brigadiers.Find(((Brigadier)brigadierComboBox.SelectedItem).BrigadierId);
            var newBrigade = new Brigade { Brigadier = brigadier };
            db.Add(newBrigade);
            db.SaveChanges();
            foreach (var worker in selectedWorkers)
                db.InsertWorkerIntoBrigade(worker, newBrigade);
            return newBrigade;
        }

        private void OkButtonClick(object sender, EventArgs e)
        {
            if (!IsBrigadeExist())
            {
                if (IsCreateNewBrigade())
                {
                    CreateNewBrigade();
                    Close();
                }

                return;
            }
            using TrainContext db = new();
            if (IsBrigadeChanged())
                if (IsForceSave())
                    workers = db.GetWorkersInBrigade(brigade);
                else
                    return;

            brigade = db.Brigades.Find(brigade.BrigadeId);
            var brigadier = (Brigadier)brigadierComboBox.SelectedItem;
            brigade.Brigadier = brigadier;
            foreach (var worker in selectedWorkers.Where(w => !workers.Exists(w2 => w.WorkerId == w2.WorkerId)))
                db.InsertWorkerIntoBrigade(worker, brigade);
            foreach (var worker in workers.Where(w => !selectedWorkers.ToList().Exists(w2 => w.WorkerId == w2.WorkerId)))
                db.RemoveWorkerFromBrigade(worker, brigade);

            db.SaveChanges();
            DialogResult = DialogResult.OK;
            Close();
        }

        private void CancelButtonClick(object sender, EventArgs e)
        {
            DialogResult = DialogResult.Cancel;
            Close();
        }
    }
}
