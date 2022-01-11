using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WagonRepairDepot
{
    public partial class RedactorFrom : Form
    {
        private object _startObject;
        private object _changedOvject;
        private List<IFieldModel> _fields;
        private DbContext _context;

        public RedactorFrom(object @object, Models.IFormModel formModel)
        {
            _context = new Contexts.TrainContext();
            _startObject = @object;
            _changedOvject = _startObject;

            InitializeComponent();
            _fields = formModel.FieldModels.ToList();

            BindPanel(this.flowLayoutPanel1);
            Read();
            SetSaveButton();
            SetCreateButton();
            SetDeleteButton();
        }

        public void SetSaveButton()
        {
            Button saveButton = new Button();
            saveButton.Text = "Сохранить изменения";
            saveButton.Click += Save;
            this.flowLayoutPanel1.Controls.Add(saveButton);
        }

        public void SetCreateButton()
        {
            Button saveButton = new Button();
            saveButton.Text = "Создать";
            saveButton.Click += Create;
            this.flowLayoutPanel1.Controls.Add(saveButton);
        }

        public void SetDeleteButton()
        {
            Button saveButton = new Button();
            saveButton.Text = "Удалить";
            saveButton.Click += Delete;
            this.flowLayoutPanel1.Controls.Add(saveButton);
        }

        private void BindPanel(FlowLayoutPanel panel)
        {
            foreach(var field in _fields)
            {
                field.BindWithPanel(panel);
            }
        }

        private List<PropertyInfo> ReadProperty()
        {
            return _startObject.GetType().GetProperties().ToList();
        }

        private void Write()
        {
            foreach(var (property, value) in ReadProperty().Zip(_fields))
            {
                property.SetValue(_changedOvject, value.Value);
            }
        }

        private void Read()
        {
            foreach (var (property, value) in ReadProperty().Zip(_fields))
            {
                value.Value = property.GetValue(_changedOvject);
            }
        }

        private void Save(object? sender, EventArgs e)
        {
            Write();
            object origenal = _context.Find(_changedOvject.GetType(), this._fields.First().Value);
            foreach (var property in ReadProperty())
            {
                property.SetValue(origenal, property.GetValue(_changedOvject));
            }
            _context.SaveChanges();
        }

        private void Create(object? sender, EventArgs e)
        {
            this._fields.First().Value = null;
            Write();
            _context.Add(_changedOvject);
            _context.SaveChanges();
        }

        private void Delete(object? sender, EventArgs e)
        {
            Write();
            _context.Remove(_changedOvject);
            _context.SaveChanges();
            //this.Close();
        }


        private void flowLayoutPanel1_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
