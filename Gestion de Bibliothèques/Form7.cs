using DGVPrinterHelper;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Gestion_de_Bibliothèques
{
    public partial class Form7 : System.Windows.Forms.Form
    {
        //Connection with database
        SqlConnection DB = new SqlConnection("server=DESKTOP-9992H95;DataBase=library;Integrated Security=true");
        public Form7()
        {
            InitializeComponent();
            //Get information from database "Les_Stagiaires"
            SqlDataAdapter ad = new SqlDataAdapter("select * from Stagiaire", DB);
            DataTable A = new DataTable();
            ad.Fill(A);
            DataGridView1.DataSource = A;
        }

        private void Liste_Load(object sender, EventArgs e)
        {
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //For Deleting "Stagiaires"
            SqlCommand daa = new SqlCommand("delete from Stagiaire where id='" + Convert.ToInt32(DataGridView1.CurrentRow.Cells[0].Value) + "'", DB);
            DB.Open();
            daa.ExecuteNonQuery();
            SqlDataAdapter ad = new SqlDataAdapter("select * from Stagiaire", DB);
            DataTable A = new DataTable();
            ad.Fill(A);
            DataGridView1.DataSource = A;
            DB.Close();

            //For showing message if deleting successed
            MessageBox.Show("stagiaire supprimé avec succès");
        }

        

        private void guna2Button3_Click(object sender, EventArgs e)
        {
            // Imprimer Stagiaire
            DGVPrinter print = new DGVPrinter();
            print.Title = "Les Stagiaires";
            print.SubTitle = string.Format(DateTime.Now.ToString("dd-MM-yyyy hh:mm:ss tt"));
            print.PrintDataGridView(DataGridView1);
           
        }

        private void guna2Button2_Click(object sender, EventArgs e)
        {
            SqlConnection DB = null;
            DB = new SqlConnection(@"Data Source=.;Initial Catalog=library;Integrated Security=True;");
            //For Deleting "Livre"
            SqlCommand daa = new SqlCommand("delete from Stagiaire where id='" + Convert.ToInt32(DataGridView1.CurrentRow.Cells[0].Value) + "'", DB);
            DB.Open();
            daa.ExecuteNonQuery();
            SqlDataAdapter ad = new SqlDataAdapter("select * from Stagiaire", DB);
            DataTable A = new DataTable();
            ad.Fill(A);
            DataGridView1.DataSource = A;
            DB.Close();

            //For showing message if deleting successed
            MessageBox.Show("Le Stagiaire supprimé avec succès");
        }
    }
}
