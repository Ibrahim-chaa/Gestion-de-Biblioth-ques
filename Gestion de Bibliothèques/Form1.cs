using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace Gestion_de_Bibliothèques
{
    public partial class Form1 : System.Windows.Forms.Form
    {
        SqlConnection connect = new SqlConnection(@"Data Source=.;Initial Catalog=library;Integrated Security=True;");
        public Form1()
        {
            InitializeComponent();
        }

        private void guna2CirclePictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void guna2PictureBox1_Click(object sender, EventArgs e)
        {
            
            this.Close();
            
        }

        private void guna2PictureBox2_Click(object sender, EventArgs e)
        {

        }

        private void cbx_CheckedChanged(object sender, EventArgs e)
        {
            if (cbx.Checked == true)
            {
                txtPassword.UseSystemPasswordChar = false;
            }
            else
            {
                txtPassword.UseSystemPasswordChar = true;
            }
        
    }

        private void guna2Button3_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form2 form2 = new Form2(); 
            form2.Show();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void guna2Button1_Click(object sender, EventArgs e)
        {
            String username,password;
            username = txtUser.Text;
            password = txtPassword.Text;
           

            try
            {
                String querry = "SELECT * FROM UsPss WHERE username = '"+txtUser.Text+"' AND password = '"+txtPassword.Text+ "'";
                SqlDataAdapter sda = new SqlDataAdapter(querry,connect);
                DataTable dt = new DataTable();
                sda.Fill(dt);
                if (dt.Rows.Count > 0)
                {
                    username = txtUser.Text;
                    password = txtPassword.Text;

                    //
                    MessageBox.Show($"Bienvenue, {username} !", "", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    this.Hide();
                    Form4 form4 = new Form4();
                    form4.Show();
                }
                

               
                else
                {
                    MessageBox.Show("vérifier vos infromations", "",MessageBoxButtons.OK,MessageBoxIcon.Error) ;
                    
                  
                }
            }
            catch 
            {
                MessageBox.Show("vérifier vos infromations", "", MessageBoxButtons.OK, MessageBoxIcon.Warning) ;
            }
            finally 
            {
                connect.Close();
            }

            }

        private void guna2Button2_Click(object sender, EventArgs e)
        {

            this.Hide();
            Form3 form3 = new Form3();
            form3.Show();

        }
    }
        }
    

