using SRK.Menu_Forms;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace SRK.Login_Forms
{
    public partial class kier_login : Form
    {
        public EventHandler kierowcy;
        public kier_login()
        {
            InitializeComponent();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            // Łączenie z bazą danych
            string connectionString = "server=217.154.242.232;" +
                                      "database=login;" +
                                      "user id=app;" +
                                      "password=j3589wIzVR;";
            using (SqlConnection sqlcon = new SqlConnection(connectionString))
            {
                try
                {
                    sqlcon.Open();
                    string query = "SELECT * FROM login_user WHERE login = @login AND haslo = @haslo";
                    SqlCommand cmd = new SqlCommand(query, sqlcon);
                    cmd.Parameters.AddWithValue("@login", textBox1.Text.Trim());
                    cmd.Parameters.AddWithValue("@haslo", textBox2.Text.Trim());

                    SqlDataAdapter sda = new SqlDataAdapter(cmd);
                    DataTable dtbl = new DataTable();
                    sda.Fill(dtbl);

                    if (dtbl.Rows.Count > 0)
                    {
                        this.Hide(); // Ukryj login
                        menu_kiero objFrmMain = new menu_kiero();
                        objFrmMain.ShowDialog(); // Czekaj aż użytkownik zamknie menu
                        this.Close(); // Dopiero teraz zamknij login
                    }
                    else
                    {
                        MessageBox.Show("Nieprawidłowy login lub hasło", "Błąd logowania", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Błąd połączenia z bazą danych: " + ex.Message, "Błąd", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

     
        private void kier_login_Load(object sender, EventArgs e)
        {

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

        private void textBox2_TextChanged(object sender, EventArgs e)
        {
            textBox2.PasswordChar = '*';
        }
    }
}
