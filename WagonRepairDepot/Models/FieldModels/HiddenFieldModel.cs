using System.Windows.Forms;

namespace WagonRepairDepot
{
    class HiddenFieldModel : IFieldModel
    {
        public string Name { get; set; }

        private object _object;
        public object Value { get => _object; set { _object = value; } }
        public int Height => 35;
        public void BindWithWindow(Form form, int x, int y, int width)
        {
        }
        public void BindWithWindow(Form form)
        {
        }
        public void BindWithPanel(FlowLayoutPanel panel)
        {
        }

        public void MadeReadOnly()
        {
        }

        public HiddenFieldModel(string name)
        {
            Name = name;
        }
    }

}
