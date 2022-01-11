using System;
using System.Collections;
using System.Windows.Forms;
using EntityFramework.Exceptions.Common;
using WagonRepairDepot.Contexts;
using WagonRepairDepot.Models;
using WagonRepairDepot.Windows;
using EntityFramework.Exceptions.PostgreSQL;

namespace WagonRepairDepot.Controllers
{
    public class BrigadesController
    {
        private readonly Form1 _form;

        public BrigadesController(Form1 form)
        {
            _form = form;
        }

        public void EditButtonClick(object? sender, EventArgs e)
        {
            using TrainContext db = new();
            var brigade = GetSelectedBrigade(db);
            if (brigade == null) return;
            var editWindow = new EditBrigadeForm(brigade);
            editWindow.ShowDialog();
        }

        public void DeleteButtonClick(object? sender, EventArgs e)
        {
            using TrainContext db = new();
            var brigade = GetSelectedBrigade(db);
            if (brigade == null) return;
            
            if ((brigade = db.Brigades.Find(brigade.BrigadeId)) == null)
            {
                MessageBox.Show("Данная бригада уже удалена извне!");
                return;
            }

            db.Remove(brigade);
            try
            {
                db.SaveChanges(); 
                _form.RefreshDataGrid();
            }
            catch (ReferenceConstraintException ex)
            {
                MessageBox.Show($"{ex.InnerException.Message}", "Error");
            }
        }

        public Brigade? GetSelectedBrigade(TrainContext db)
        {
            var brigade = _form.GetSelectedObject() as Brigade;
            if (brigade == null)
            {
                MessageBox.Show("Выделите бригаду");
                return null;
            }

            return brigade;
        }
    }
}