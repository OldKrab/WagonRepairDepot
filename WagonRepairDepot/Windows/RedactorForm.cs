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

        public void MadeReadOnly()
        {
            foreach (var field in _fields)
            {
                field.MadeReadOnly();
            }
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
            HandleExist();
            if (HandleConstant())
            {
                Write();
                object origenal = _context.Find(ProxyUtil.GetUnproxiedType(_changedOvject), this._index.Value);
                foreach (var property in ReadProperty())
                {
                    if (property.SetMethod is not null)
                        property.SetValue(origenal, property.GetValue(_changedOvject));
                }
                _context.SaveChanges();
            }
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
            HandleExist();
            if (HandleConstant())
            {
                Write();
                _context.Remove(_changedOvject);
                _context.SaveChanges();
                _context.ChangeTracker.Clear();
                this.Close();
            }
        }
        private void Refresh(object? sender, EventArgs e)
        {
            HandleExist();
            _changedOvject =_startObject = _context.Find(ProxyUtil.GetUnproxiedType(_changedOvject), _index.Value);
            Read(); 
        }


        private void HandleExist()
        {
            if (!ChecToExist())
            {
                var result = MessageBox.Show("Обрабатываемый объект больше не существет в базе данных, вы можете востановить копию объекта в базу данных (да), или прекратить работу с ним (нет). Если вы хотите продолжить работу с копией объекта в режиме только для чтения нажмите кнопку (отмена)", "Объект не обнаружен в базе данных", MessageBoxButtons.YesNoCancel);
                if (result == DialogResult.No)
                {
                    this.Close();
                }
                else if (result == DialogResult.Yes)
                {
                    Write();
                    _context.Add(_changedOvject);
                    _context.SaveChanges();
                }
                else
                {
                    //TODO: добавить работу в режиме только для чтения
                    this.Close();
                }
            }
        }
        private bool HandleConstant()
        {
            if (!ChecToConstant())
            {
                var result = MessageBox.Show(
                    "Обрабатываемый объект был изменен, ваши действия могут привести к непредвиденным резульатам," +
                    "нажмите на кнопку (да), если все равно собиреатесь продолжить." +
                    "нажмите на кнопку (нет) если хотите посмотреть изменения объекта." +
                    "Если вы хотите вернутся к редактированию нажмите на  кнопку (отмена)", "Объект был изменен во время редактирования в базе данных", MessageBoxButtons.YesNoCancel);
                if (result == DialogResult.No)
                {
                    //TODO: добавить чтение объекта
                    return false;
                }
                else if (result == DialogResult.Yes)
                {
                    return true;
                }
                else
                {
                    return false;
                }
            }
            return true;
        }
        private bool ChecToExist()
        {
            try
            {
                _context.Entry(_startObject).State = EntityState.Detached;
                object origenal = _context.Find(ProxyUtil.GetUnproxiedType(_changedOvject), _index.Value);
                if (origenal is null)
                {
                    return false;
                }
                _context.Entry(origenal).State = EntityState.Detached;

            }
            catch
            {
                return false;
            }
            return true;
        }
        private bool ChecToConstant()
        {
            _context.Entry(_startObject).State = EntityState.Detached;
            object origenal = _context.Find(ProxyUtil.GetUnproxiedType(_changedOvject), _index.Value);
            _context.Entry(origenal).State = EntityState.Detached;
            foreach (var property in ReadProperty())
            {
                if (property.GetCustomAttribute(typeof(DisplayNameAttribute)) is not null && ! property.GetValue(origenal).Equals(property.GetValue(_changedOvject)) ){
                    return false;
                };
            }
            return true;
        }



        private void flowLayoutPanel1_Paint(object sender, PaintEventArgs e)
        {

        }
        private void RedactorForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            //Form ifrm = Application.OpenForms[0];
            //ifrm.Show();
        }
    }
}
