using SRK.Login_Forms;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SRK
{
    public partial class panel_log : Form
    {
        public EventHandler plogin;
        public panel_log()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            kier_login frm = new kier_login();
            frm.kierowcy += (s, ea) =>
            {

            };
            frm.ShowDialog();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            dyspo_login frm = new dyspo_login();
            frm.dyspozytor += (s, ea) =>
            {

            };
            frm.ShowDialog();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            adm_login frm = new adm_login();
            frm.admini += (s, ea) =>
            {

            };
            frm.ShowDialog();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }
    }
}
