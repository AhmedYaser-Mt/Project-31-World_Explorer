using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Project_31___The_World_Explorer__
{
    public partial class frmMainScreen : Form
    {
        public frmMainScreen()
        {
            InitializeComponent();
        }

        private void ShowSearchErrorMessageBox()
        {
            MessageBox.Show("Result is Not Found!", "Error!", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }

        private void ShowAfricaScreen()
        {
            Form frm = new frmAfricaScreen();
            frm.Show();
        }

        private void ShowAsiaScreen()
        {
            Form frm = new frmAsiaScreen();
            frm.Show();
        }

        private void ShowEuropeScreen()
        {
            Form frm = new frmEuropeScreen();
            frm.Show();
        }

        private void ShowAustraliaScreen()
        {
            Form frm = new frmAustraliaScreen();
            frm.Show();
        }

        private void ShowAntarcticaScreen()
        {
            Form frm = new frmAntarcticaScreen();
            frm.Show();
        }

        private void ShowNorthAmericaScreen()
        {
            Form frm = new frmNorthAmericaScreen();
            frm.Show();
        }

        private void ShowSouthAmericaScreen()
        {
            Form frm = new frmSouthAmericaScreen();
            frm.Show();
        }

        private void Search()
        {
            switch (txtSearch.Text.ToLower())
            {
                case "antarctica":

                    ShowAntarcticaScreen();
                    break;

                case "asia":

                    ShowAsiaScreen();
                    break;

                case "africa":

                    ShowAfricaScreen();
                    break;

                case "australia":

                    ShowAustraliaScreen();
                    break;

                case "europe":

                    ShowEuropeScreen();
                    break;

                case "north america":

                    ShowNorthAmericaScreen();
                    break;

                case "south america":

                    ShowSouthAmericaScreen();
                    break;

                default:

                    ShowSearchErrorMessageBox();
                    break;
            }
        }

        private void btn_MouseEnter(object sender, EventArgs e)
        {
            lblContinent.Text = ((Button)sender).Tag.ToString();
        }

        private void btn_MouseLeave(object sender, EventArgs e)
        {
            lblContinent.Text = "?";
        }

        private void btn_Click(object sender, EventArgs e)
        {
            switch (((Button)sender).Tag)
            {
                case "Antarctica":

                    ShowAntarcticaScreen();
                    break;

                case "Asia":

                    ShowAsiaScreen();
                    break;

                case "Africa":

                    ShowAfricaScreen();
                    break;

                case "Australia":

                    ShowAustraliaScreen();
                    break;

                case "Europe":

                    ShowEuropeScreen();
                    break;

                case "North America":

                    ShowNorthAmericaScreen();
                    break;

                case "South America":

                    ShowSouthAmericaScreen();
                    break;

                case "Search":

                    Search();
                    break;
            }
        }
    }
}
