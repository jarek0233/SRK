using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SRK.Login_Forms
{
    public partial class dyspo_login : Form
    {
        public EventHandler dyspozytor;
        public dyspo_login()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            panel_log frm = new panel_log();
            frm.plogin += (s, ea) =>
            {

            };
            this.Hide();
            frm.ShowDialog();
            this.Close();
        }

    }
}
