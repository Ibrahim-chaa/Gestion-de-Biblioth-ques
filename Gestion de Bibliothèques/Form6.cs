using DGVPrinterHelper;
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
    public partial class Form6 : System.Windows.Forms.Form
    {
        SqlConnection DB = new SqlConnection("server=DESKTOP-9992H95;DataBase=library;Integrated Security=true");

        public Form6()
        {
            InitializeComponent();
        }

        private void guna2Button1_Click(object sender, EventArgs e)
        {
            SqlConnection DB = null;
            DB = new SqlConnection(@"Data Source=.;Initial Catalog=library;Integrated Security=True;");
            string check = TextBox1.Text.Trim();
            string checks = TextBox2.Text.Trim();
            if (!string.IsNullOrEmpty(check) && !string.IsNullOrWhiteSpace(check) && !string.IsNullOrEmpty((checks)) && !string.IsNullOrWhiteSpace((checks)))
            {
                //add "Livre"
                SqlCommand cmd = new SqlCommand("insert into Adel values('" + TextBox1.Text + "','" + TextBox2.Text + "','" + dateTimePicker1.Text + "','" + TextBox3.Text + "')", DB);
                DB.Open();
                cmd.ExecuteNonQuery();
                SqlDataAdapter ad = new SqlDataAdapter("select * from Adel", DB);
                DataTable A = new DataTable();
                ad.Fill(A);
                dataGridView1.DataSource = A;
                DB.Close();

                //show message for adding "Livre"
                MessageBox.Show("ajouter un stagiaire avec succès");

            }
            else
            {
                MessageBox.Show("Saisir les informations requises...!!");
            }
        }

        private void guna2Button2_Click(object sender, EventArgs e)
        {
            string check = TextBox1.Text.Trim();
            string checks = TextBox2.Text.Trim();
            SqlConnection DB = null;
            DB = new SqlConnection(@"Data Source=.;Initial Catalog=library;Integrated Security=True;");
            //For Deleting "Livre"
            SqlCommand daa = new SqlCommand("delete from Adel where ID='" + Convert.ToInt32(dataGridView1.CurrentRow.Cells[0].Value) + "'", DB);
            DB.Open();
            daa.ExecuteNonQuery();
            SqlDataAdapter ad = new SqlDataAdapter("select * from Adel", DB);
            DataTable A = new DataTable();
            ad.Fill(A);
            dataGridView1.DataSource = A;
            DB.Close();

            //For showing message if deleting successed
            MessageBox.Show("Le livre supprimé avec succès"
                ) ;
        }

        private void guna2Button3_Click(object sender, EventArgs e)
        {
            // Imprimer "Les livres"
            DGVPrinter print = new DGVPrinter();
            print.Title = "Les livres";
            print.SubTitle = string.Format(DateTime.Now.ToString("dd-MM-yyyy hh:mm:ss tt"));
            print.PrintDataGridView(dataGridView1);

        }

        private void label2_Click(object sender, EventArgs e)
        {
            
        }

        private void TextBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void TextBox3_KeyPress(object sender, KeyPressEventArgs e)
        {
            
        }
    }
}




