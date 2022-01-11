using System.Windows.Forms;

namespace WagonRepairDepot
{
    class StringFieldModel : IFieldModel
    {
        public string Name { get; set; }

        private Label _label;
        private TextBox _text;
        public object Value { get => _text.Text; set { _text.Text = (string)value; } }
        public int Height => 35;
        public void BindWithWindow(Form form, int x, int y, int width)
        {
            this._label.Location = new System.Drawing.Point(x, y);
            this._text.Location = new System.Drawing.Point(x, y + 15);
            this._label.Size = new System.Drawing.Size(x + width, 15);
            this._text.Size = new System.Drawing.Size(x + width, 20);
            form.Controls.Add(this._label);
            form.Controls.Add(this._text);
        }
        public void MadeReadOnly()
        {
            _text.ReadOnly = true;
        }
        public void BindWithPanel(FlowLayoutPanel panel)
        {
            panel.Controls.Add(this._label);
            panel.Controls.Add(this._text);
            this._label.Size = new System.Drawing.Size(panel.Width - 10, 15);
            this._text.Size = new System.Drawing.Size(panel.Width - 10, 20);
        }
        public StringFieldModel(string name)
        {
            Name = name;

            this._label = new Label();
            this._label.AutoSize = true;
            this._label.Name = name;

            this._label.Text = name;


            this._text = new TextBox();
            this._text.Name = "name_numeric";
        }
    }

}
