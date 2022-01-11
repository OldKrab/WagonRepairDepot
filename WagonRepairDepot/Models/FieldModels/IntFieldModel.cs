using System;
using System.Windows.Forms;

namespace WagonRepairDepot
{
    class IntFieldModel : IFieldModel
    {
        private Label _label;
        private NumericUpDown _numeric;
        public object Value { get => (int)_numeric.Value; set { _numeric.Value = (int)value; } }
        public int Height => 35;
        public string Name { get; set; }
        public void BindWithWindow(Form form, int x, int y, int width)
        {
            this._label.Location = new System.Drawing.Point(x, y);
            this._numeric.Location = new System.Drawing.Point(x, y + 15);
            this._label.Size = new System.Drawing.Size(x + width, 15);
            this._numeric.Size = new System.Drawing.Size(x + width, 20);
            form.Controls.Add(this._label);
            form.Controls.Add(this._numeric);
        }


        public void BindWithPanel(FlowLayoutPanel panel)
        {
            panel.Controls.Add(this._label);
            panel.Controls.Add(this._numeric);
            this._label.Size = new System.Drawing.Size(panel.Width - 10, 15);
            this._numeric.Size = new System.Drawing.Size(panel.Width - 10, 20);
        }

        public void MadeReadOnly()
        {
            _numeric.ReadOnly = true;
        }

        public IntFieldModel(string name)
        {
            Name = name;
            this._label = new Label();
            this._label.AutoSize = true;
            this._label.Name = name;

            this._label.Text = name;


            this._numeric = new NumericUpDown();
            this._numeric.Name = "name_numeric";
        }
    }

    class DateFieldModel : IFieldModel
    {
        public string Name { get; set; }

        private Label _label;
        private DateTimePicker _date;
        public object Value { get => _date.Value; set { _date.Value =  (DateTime)value; } }
        public int Height => 35;
        public void BindWithWindow(Form form, int x, int y, int width)
        {
            this._label.Location = new System.Drawing.Point(x, y);
            this._date.Location = new System.Drawing.Point(x, y + 15);
            this._label.Size = new System.Drawing.Size(x + width, 15);
            this._date.Size = new System.Drawing.Size(x + width, 20);
            form.Controls.Add(this._label);
            form.Controls.Add(this._date);
        }
        public void BindWithWindow(Form form)
        {
            throw new NotImplementedException();
        }
        public void BindWithPanel(FlowLayoutPanel panel)
        {
            panel.Controls.Add(this._label);
            panel.Controls.Add(this._date);
            this._label.Size = new System.Drawing.Size(panel.Width - 10, 15);
            this._date.Size = new System.Drawing.Size(panel.Width - 10, 20);
            Value = DateTime.Now;
        }

        public void MadeReadOnly()
        {
            _date.Enabled = false;
        }
        public DateFieldModel(string name)
        {
            Name = name;
            this._label = new Label();
            this._label.AutoSize = true;
            this._label.Name = name;

            this._label.Text = name;

            this._date = new DateTimePicker();
        }
    }


    class BoolFieldModel : IFieldModel
    {
        public string Name { get; set; }

        private Label _label;
        private RadioButton _true_button;
        private RadioButton _false_button;
        public object Value { get => _true_button.Checked; set { _false_button.Checked = !(_true_button.Checked = (bool)value); }}
        public int Height => 35;
        public void BindWithWindow(Form form, int x, int y, int width)
        {
            this._label.Location = new System.Drawing.Point(x, y);
            this._true_button.Location = new System.Drawing.Point(x, y + 15);
            this._false_button.Location = new System.Drawing.Point(x, y + 35);

            this._label.Size = new System.Drawing.Size(x + width, 15);
            this._true_button.Size = new System.Drawing.Size(x + width, 20);
            this._true_button.Size = new System.Drawing.Size(x + width, 20);
            form.Controls.Add(this._label);
            form.Controls.Add(this._true_button);
            form.Controls.Add(this._false_button);
        }
        public void MadeReadOnly()
        {
            _false_button.Enabled = false;
            _true_button.Enabled = false;
        }    
        public void BindWithPanel(FlowLayoutPanel panel)
        {
            panel.Controls.Add(this._label);
            panel.Controls.Add(this._true_button);
            panel.Controls.Add(this._false_button);
            this._label.Size = new System.Drawing.Size(panel.Width - 10, 15);
            this._true_button.Size = new System.Drawing.Size(panel.Width - 10, 15);
            this._true_button.Size = new System.Drawing.Size(panel.Width - 10, 15);
        }

        public BoolFieldModel(string name, string true_label, string false_label)
        {
            Name = name;
            this._label = new Label();
            this._label.AutoSize = true;
            this._label.Name = name;
            this._label.Text = name;

            this._true_button = new RadioButton();
            this._true_button.Text = true_label;
            this._false_button = new RadioButton();
            this._false_button.Text = false_label;

        }
    }

}
