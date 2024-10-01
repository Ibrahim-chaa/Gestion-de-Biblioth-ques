using Guna.UI2.WinForms.Suite;
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

namespace Gestion_de_Bibliothèques
{
    public partial class Form5 : System.Windows.Forms.Form
    {
        //Connecting with database
        SqlConnection DB = new SqlConnection("server=DESKTOP-9992H95;DataBase=library;Integrated Security=true");

        public Form5()
        {
            InitializeComponent();
        }

        private void guna2Button1_Click_1(object sender, EventArgs e)
        {
            SqlConnection DB = null;
            DB = new SqlConnection(@"Data Source=.;Initial Catalog=library;Integrated Security=True;");
            string check = TextBox1.Text.Trim();
            string checks = TextBox2.Text.Trim();
            if (!string.IsNullOrEmpty(check) && !string.IsNullOrWhiteSpace(check) && !string.IsNullOrEmpty((checks)) && !string.IsNullOrWhiteSpace((checks)))
            {
                //add "stagiers"
                SqlCommand cmd = new SqlCommand("insert into Stagiaire values('" + dateTimePicker1.Text + "','" + TextBox1.Text + "','" + comboBox1.Text + "','" + TextBox1.Text + "','" + ComboBox2.Text + "','" + DateTimePicker2.Text + "','" + DateTimePicker4.Text + "')", DB);
                DB.Open();
                cmd.ExecuteNonQuery();
                DB.Close();

                //show message for adding "stagiers"
                MessageBox.Show("ajouter un stagiaire avec succès", "", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show("Saisir les informations requises...!!", "", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            {
     DB.Close();
 }
        }

        private void TextBox1_KeyPress(object sender, KeyPressEventArgs e)
        {
            //enter only letter
            if (!char.IsLetter(e.KeyChar) && !char.IsControl(e.KeyChar) && !char.IsWhiteSpace(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void TextBox2_KeyPress(object sender, KeyPressEventArgs e)
        {
            TextBox2.MaxLength = 6;
            if (!char.IsNumber(e.KeyChar) && !char.IsControl(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void guna2Button1_Click(object sender, EventArgs e)
        {

        }

        private void Form5_Load(object sender, EventArgs e)
        {

        }

        private void DateTimePicker3_ValueChanged(object sender, EventArgs e)
        {

        }

        private void ComboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
