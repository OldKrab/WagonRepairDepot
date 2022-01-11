using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WagonRepairDepot
{
    public partial class AuthenticationForm : Form
    {
        private bool _success { set; get; }

        public AuthenticationForm()
        {
            InitializeComponent();
        }

        private void buttonRememberPassword_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Придется вспомнить", "Беда");
        }

        private void buttonLogin_Click(object sender, EventArgs e)
        {
            try
            {
                var trainContext =  new Contexts.TrainContext(textBoxLogin.Text, textBoxPassword.Text).Brigades.First();
                _success = true;
                Close();
            }
            catch(Exception ex)
            {
                MessageBox.Show("Не получилось авторизоваться, проверьте вводимые данные. \n\n" + ex.Message, "Беда");
            }
        }

        public bool isSuccess()
        {
            return _success;
        }
    }
}
