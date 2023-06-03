using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Gai
{
    public partial class avtorization : Form
    {
        public avtorization()
        {
            InitializeComponent();
        }

        private void ApllyBT_Click(object sender, EventArgs e)
        {
            if(RoleCB.SelectedIndex == 0)
            {
                this.Hide();
                Admin admin = new Admin();
                admin.Show();
            }
            if(RoleCB.SelectedIndex == 1)
            {
                this.Hide();
                Client client = new Client();
                client.Show();
            }
        }
    }
}
