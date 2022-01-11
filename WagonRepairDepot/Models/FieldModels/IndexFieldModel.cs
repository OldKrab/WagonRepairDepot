using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;

namespace WagonRepairDepot
{
    class IndexFieldModel : IFieldModel, IDisposable
    {
        public string Name { get; set; }

        private Label _label;
        private ComboBox _combo;
        private int[] _ids;
        public object Value { get => _ids[_combo.SelectedIndex];
            set { 
                _combo.SelectedIndex = Array.IndexOf( _ids, (int)value);
            }
        }
        public int Height => 35;
        public void BindWithWindow(Form form, int x, int y, int width)
        {
            this._label.Location = new System.Drawing.Point(x, y);
            this._combo.Location = new System.Drawing.Point(x, y + 15);
            this._label.Size = new System.Drawing.Size(x + width, 15);
            this._combo.Size = new System.Drawing.Size(x + width, 20);
            form.Controls.Add(this._label);
            form.Controls.Add(this._combo);
        }
        public void MadeReadOnly()
        {
            _combo.Enabled = false;
        }
        public void BindWithWindow(Form form)
        {
            throw new NotImplementedException();
        }
        public void BindWithPanel(FlowLayoutPanel panel)
        {
            panel.Controls.Add(this._label);
            panel.Controls.Add(this._combo);
            this._label.Size = new System.Drawing.Size(panel.Width - 10, 15);
            this._combo.Size = new System.Drawing.Size(panel.Width - 10, 20);
        }
        public IndexFieldModel(string name, IEnumerable<int> values, IEnumerable<string> items)
        {
            Name = name;

            this._label = new Label();
            this._label.AutoSize = true;
            this._label.Name = name;

            this._label.Text = name;

            this._combo = new ComboBox();
            this._combo.FormattingEnabled = true;
            this._combo.Name = "comboBox1";
            this._combo.DropDownStyle = ComboBoxStyle.DropDownList;
            this._combo.Items.AddRange(items.ToArray());
            this._ids = values.ToArray();
        }

        public void Dispose()
        {
            throw new NotImplementedException();
        }
    }

}
