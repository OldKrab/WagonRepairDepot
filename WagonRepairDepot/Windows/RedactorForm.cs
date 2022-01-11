using Castle.DynamicProxy;
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
    public partial class RedactorForm : Form
    {
        private object _startObject;
        private object _changedOvject;
        private List<IFieldModel> _fields;
        private DbContext _context;
        private IFieldModel _index;


        public RedactorForm(object @object, Models.IFormModel formModel)
        {
            _context = new Contexts.TrainContext();
            _startObject = @object;
            _changedOvject = _startObject;

            InitializeComponent();
            _fields = formModel.FieldModels.ToList();
            _index = formModel.Identificator;

            BindPanel(this.flowLayoutPanel1);
            Read();
            SetSaveButton();
            SetCreateButton();
            SetDeleteButton();
            SetRefreshButton();
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
        public void SetRefreshButton()
        {
            Button saveButton = new Button();
            saveButton.Text = "Обновить";
            saveButton.Click += Refresh;
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
            foreach (var field in _fields)
            {
                ReadProperty().Find(a =>
                    field.Name == ((DisplayNameAttribute)a.GetCustomAttribute(typeof(DisplayNameAttribute)))?.DisplayName
                    ).SetValue(_changedOvject, field.Value);
            }
        }
        private void Read()
        {
            foreach (var field in _fields)
            {
                field.Value = ReadProperty().Find(a =>
                    field.Name == ((DisplayNameAttribute)a.GetCustomAttribute(typeof(DisplayNameAttribute)))?.DisplayName
                    ).GetValue(_changedOvject);
            }
        }
        private void Save(object? sender, EventArgs e)
        {
            Write();
            object origenal = _context.Find(ProxyUtil.GetUnproxiedType(_changedOvject), this._fields.First().Value);
            foreach (var property in ReadProperty())
            {
                if (property.SetMethod is not null)
                    property.SetValue(origenal, property.GetValue(_changedOvject));
            }
            _context.SaveChanges();
        }
        private void Create(object? sender, EventArgs e)
        {
            int save_key = (int)_index.Value;
            _index.Value = null;
            Write();
            _context.Add(_changedOvject);
            _context.SaveChanges();
            _index.Value = save_key;
        }
        private void Delete(object? sender, EventArgs e)
        {
            Write();
            _context.Remove(_changedOvject);
            _context.SaveChanges();
            //this.Close();
        }
        private void Refresh(object? sender, EventArgs e)
        {
            _changedOvject =_startObject = _context.Find(ProxyUtil.GetUnproxiedType(_changedOvject), _index.Value);
            Read(); 
        }
        private void flowLayoutPanel1_Paint(object sender, PaintEventArgs e)
        {

        }
        private void RedactorForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            Form ifrm = Application.OpenForms[0];
            ifrm.Show();
        }
    }
}
