using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MidProject
{
    public partial class formMain : Form
    {

        bool isSubMenuIsShowing;
        private Form activeForm = null;
        public formMain()
        {
            InitializeComponent();
            isSubMenuIsShowing = false;
            hideAllSubmenu();
        }
        private void openChildForm(Form childForm)
        {
            if (activeForm != null) activeForm.Close();
            activeForm = childForm;
            childForm.TopLevel = false;
            childForm.FormBorderStyle = FormBorderStyle.None;
            childForm.Dock = DockStyle.Fill;
            pnlChildForm.Controls.Add(childForm);
            pnlChildForm.Tag = childForm;
            childForm.BringToFront();
            childForm.Show();
        }
        void hideAllSubmenu()
        {
            this.pnlSudentSubMenu.Hide();
        }
        private void guna2ImageButton1_Click(object sender, EventArgs e)
        {


        }


        private void btnStudent_Click(object sender, EventArgs e)
        {

        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void guna2Button1_Click(object sender, EventArgs e)
        {
            hideAllSubmenu();
            openChildForm(new formAddStudent());

        }

        private void btnDeleteStudent_Click(object sender, EventArgs e)
        {

        }

        private void btnStudent_Click_1(object sender, EventArgs e)
        {
            hideAllSubmenu();
            if (isSubMenuIsShowing)
            {
                isSubMenuIsShowing = false;
            }
            else
            {
                this.pnlSudentSubMenu.Show();
                isSubMenuIsShowing = true;
            }
        }

        private void btnManageStudents_Click(object sender, EventArgs e)
        {
            hideAllSubmenu();
            openChildForm(new formManageStudents());
        }
    }
}
