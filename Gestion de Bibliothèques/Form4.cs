using DGVPrinterHelper;
using Guna.UI2.HtmlRenderer.Adapters;
using Guna.UI2.WinForms;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics.Eventing.Reader;
using System.Drawing;
using System.Drawing.Text;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Gestion_de_Bibliothèques
{
    public partial class Form4 : System.Windows.Forms.Form
    {
        public Form4()
        {
            InitializeComponent();
            customizeDesign();

        }

        private void customizeDesign()
        {
              PanelLIV.Visible = false;
            PanelLIVV.Visible = false;
            guna2GradientPanel1.Visible = false;
            //
        }
        private void hidePanelMenu()
        {
            if (PanelLIV.Visible == true  )
                PanelLIV.Visible = false;
            if (PanelLIVV.Visible == true )
                PanelLIVV.Visible=false;
            if (guna2GradientPanel1.Visible == true )
                guna2GradientPanel1.Visible=false;
               {


            }

        }

        private void ShowPanelMenu(Panel subMenu)
        {
            if (subMenu.Visible == false) { 
                hidePanelMenu();
            subMenu.Visible = true;

        } 
        else
            {
subMenu.Visible = false;
            }


        }


        private void Form4_Load(object sender, EventArgs e)
        {

        }

        private void btnStg_Click(object sender, EventArgs e)
        {
            
        }

        private void guna2GradientButton2_Click(object sender, EventArgs e)
        {







            hidePanelMenu();
        }

        private void guna2GradientButton3_Click(object sender, EventArgs e)
        {
            hidePanelMenu();
        }

        private void btnLiv_Click(object sender, EventArgs e)
        {




            ShowPanelMenu(PanelLIVV);
        }

        private void guna2GradientButton5_Click(object sender, EventArgs e)
        {
            hidePanelMenu();
        }

        private void guna2GradientButton4_Click(object sender, EventArgs e)
        {



            hidePanelMenu();

        }

        private void guna2GradientButton6_Click(object sender, EventArgs e)
        {


            hidePanelMenu();

        }

        private void guna2GradientButton7_Click(object sender, EventArgs e)
        {
            hidePanelMenu();
        }

        private void guna2PictureBox1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void guna2Panel4_Paint(object sender, PaintEventArgs e)
        {

        }

        private void guna2GradientButton1_Click(object sender, EventArgs e)
        {
            
        }

        private void guna2GradientButton9_Click(object sender, EventArgs e)
        {
            hidePanelMenu();
        }

        private void guna2GradientButton10_Click(object sender, EventArgs e)
        {
            
        }

        private void guna2GradientButton8_Click(object sender, EventArgs e)
        {
            hidePanelMenu();
        }

        private void guna2GradientButton13_Click(object sender, EventArgs e)
        {
            hidePanelMenu();
        }

        private void guna2GradientButton12_Click(object sender, EventArgs e)
        {
            hidePanelMenu();
        }

        private void guna2GradientButton11_Click(object sender, EventArgs e)
        {
            hidePanelMenu();
        }

        private void guna2GradientButton14_Click(object sender, EventArgs e)
        {
            hidePanelMenu();
        }

        private void guna2PictureBox1_Click_1(object sender, EventArgs e)
        {
            this.Close();
        }

        private void guna2GradientButton2_Click_1(object sender, EventArgs e)
        {
             ShowPanelMenu(PanelLIV);
        }

        private void guna2GradientButton5_Click_1(object sender, EventArgs e)
        {
            ShowPanelMenu(PanelLIVV);
        }

        private void guna2GradientButton6_Click_1(object sender, EventArgs e)
        {

            openChildForm(new Form6());


            hidePanelMenu();
        }
        private System.Windows.Forms.Form activeFrom = null;

      private void openChildForm(System.Windows.Forms.Form childForm)
        {
            if (activeFrom != null) 
                activeFrom.Close();
            activeFrom = childForm;
            childForm.TopLevel = false;
            childForm.FormBorderStyle = FormBorderStyle.None;
            childForm.Dock = DockStyle.Fill;
            guna2Panel5CH.Controls.Add(childForm);
            guna2Panel5CH.Tag = childForm;
            childForm.BringToFront();
            childForm.Show();
        }

        private void guna2GradientButton3_Click_1(object sender, EventArgs e)
        {
            openChildForm(new Form5());







            hidePanelMenu();
        }

        private void guna2GradientButton4_Click_1(object sender, EventArgs e)
        {
            openChildForm(new Form7());
        }

        private void guna2GradientButton15_Click(object sender, EventArgs e)
        {


            hidePanelMenu();

        }

        private void guna2GradientButton16_Click(object sender, EventArgs e)
        {
            openChildForm(new Form8());
            hidePanelMenu();
        }
    }
}
