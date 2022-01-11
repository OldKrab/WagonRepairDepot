using System.Windows.Forms;

namespace WagonRepairDepot
{
    public interface IFieldModel
    {
        public object Value { get; set; }
        public void BindToWindow(Form form, int x, int y, int width);
        public void BindWithPanel(FlowLayoutPanel panel);
        public int Height { get; }
    }
}
