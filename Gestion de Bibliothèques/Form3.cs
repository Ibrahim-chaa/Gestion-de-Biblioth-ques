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
using Guna.UI2.WinForms.Suite;
using Microsoft.VisualBasic.ApplicationServices;

namespace Gestion_de_Bibliothèques
{
    public partial class Form3 : System.Windows.Forms.Form
    {
        
        public Form3()
        {
            InitializeComponent();
        }

        private void guna2PictureBox1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void guna2Panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void guna2CustomGradientPanel2_Paint(object sender, PaintEventArgs e)
        {

        }
        

        private void guna2Button1_Click(object sender, EventArgs e)
        { 
            SqlConnection connection = null;

            // Lire les valeurs des text box
            string username = txtrUser.Text;
            string oldPassword = txtNPassword.Text;
            string newPassword = txtN1Password.Text;
            string reference = txtRef.Text;
            
            try
            {
             connection = new SqlConnection(@"Data Source=.;Initial Catalog=library;Integrated Security=True;");
             connection.Open();


                // Vérifier l'identité de l'utilisateur dans la base de données
                string checkQuery = "SELECT COUNT(*) FROM UsPss WHERE UserName = @Username AND Reference = @Reference AND Password = @Password";
                using (SqlCommand checkCommand = new SqlCommand(checkQuery, connection))
                {
                    checkCommand.Parameters.AddWithValue("@Username", username);
                    checkCommand.Parameters.AddWithValue("@Reference", reference);
                    checkCommand.Parameters.AddWithValue("@Password", oldPassword);

                    int count = (int)checkCommand.ExecuteScalar();

                    if (count > 0)
                    {
                        // Mettre à jour le mot de passe dans la base de données
                        string updateQuery = "UPDATE UsPss SET Password = @NewPassword WHERE UserName = @Username AND Reference = @Reference";
                        using (SqlCommand updateCommand = new SqlCommand(updateQuery, connection))
                        {
                            updateCommand.Parameters.AddWithValue("@NewPassword", newPassword);
                            updateCommand.Parameters.AddWithValue("@Username", username);
                            updateCommand.Parameters.AddWithValue("@Reference", reference);

                            int rowsAffected = updateCommand.ExecuteNonQuery();

                            if (rowsAffected > 0)
                            {
                                MessageBox.Show("Mot de passe mis à jour avec succès !","",MessageBoxButtons.OK,MessageBoxIcon.Information) ;
                                this.Hide();
                                Form1 form1 = new Form1();
                                form1.Show();
                            }
                            else
                            {
                                MessageBox.Show("Échec de la mise à jour du mot de passe."," ", MessageBoxButtons.OK, MessageBoxIcon.Warning) ;
                            }
                        }
                    }
                    else
                    {
                        MessageBox.Show("Le mot de passe actuel est incorrect. Veuillez réessayer.");
                    }
                }
            }



            catch (Exception ex)
            {
                MessageBox.Show($"Une erreur s'est produite : {ex.Message}");
            }
            finally
            {
                // Fermer la connexion seulement si elle est ouverte
                if (connection != null && connection.State == ConnectionState.Open)
                {
                    connection.Close();
                }
            }
        }

        private void guna2PictureBox2_Click(object sender, EventArgs e)
        {
            this.Close();
            Form1 form1 = new Form1();
            form1.Show();
        }
    }
}
