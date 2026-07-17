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
    public partial class frmStartScreen : Form
    {
        public frmStartScreen()
        {
            InitializeComponent();
        }

        private DialogResult ShowConfirmExitMessageBox()
        {
            return MessageBox.Show("Are You Sure You Want To Exit The Program ?", "Confirm!",
                MessageBoxButtons.OKCancel, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2);
        }

        private void Exit()
        {
            if (ShowConfirmExitMessageBox() == DialogResult.OK)
            {
                this.Close();
            }
        }

        private void Start()
        {
            Form NewForm = new frmMainScreen();
            NewForm.Show();
        }

        private void btn_Click(object sender, EventArgs e)
        {
            switch (((Button)sender).Tag)
            {
                case "Start":

                    Start();
                    break;

                case "Exit":
                    Exit();
                    break;
            }
        }
    }
}
