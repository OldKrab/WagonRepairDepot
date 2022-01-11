using System;
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
        private List<Worker> currentWorkers;
        private BindingList<Worker> selectedWorkers;
        private TrainContext db = new();

        public EditBrigadeForm(Brigade brigade)
        {
            InitializeComponent();
            this.brigade = brigade;
            currentWorkers = db.GetWorkersInBrigade(brigade);
            selectedWorkers = new BindingList<Worker>(new List<Worker>(currentWorkers));

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

        private void OkButtonClick(object sender, EventArgs e)
        {
            brigade.Brigadier = (Brigadier)brigadierComboBox.SelectedItem;
            foreach (var worker in selectedWorkers.Where(w => !currentWorkers.Contains(w)))
                db.InsertWorkerIntoBrigade(worker, brigade);
            foreach (var worker in currentWorkers.Where(w => !selectedWorkers.Contains(w)))
                db.RemoveWorkerFromBrigade(worker, brigade);

            db.Entry(brigade).State = EntityState.Modified;
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
