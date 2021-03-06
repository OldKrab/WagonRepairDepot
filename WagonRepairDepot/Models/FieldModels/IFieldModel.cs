using System.Windows.Forms;

namespace WagonRepairDepot
{
    public interface IFieldModel
    {
        public object Value { get; set; }
        public string Name { get; set; }
        public void BindWithWindow(Form form, int x, int y, int width);
        public void BindWithPanel(FlowLayoutPanel panel);


        public void MadeReadOnly();

        public int Height { get; }
    }
}
