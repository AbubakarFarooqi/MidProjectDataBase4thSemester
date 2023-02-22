using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace MidProject
{
    public partial class formManageStudents : Form
    {
        SqlConnection con = Configuration.getInstance().getConnection();
        formSearchDialog form;
        public formManageStudents()
        {
            InitializeComponent();
        }

        private void formManageStudents_Load(object sender, EventArgs e)
        {
            DGV.ScrollBars = ScrollBars.None;
            SqlCommand cmd = new SqlCommand("select s.RegistrationNo as [Registration Number] , FirstName , LastName , Contact , Email , DateOfBirth as [Date of Birth] , Gender from student s join person p on s.id = p.id ", con);
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            da.Fill(dt);
            DGV.DataSource = dt;
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            form = new formSearchDialog("Registration Number");
            form.searchClick += new EventHandler(onSearch);
            form.ShowDialog();

        }

        private void onSearch(object sender, EventArgs e)
        {
            bool isFound = false;
            string regNo = form.RegNo; //  form return reg no
            for (int i = 0; i < DGV.RowCount; i++)
            {
                // finding row that contain reg no
                if (DGV.Rows[i].Cells[0].Value.ToString() == regNo)
                {
                    DGV.ClearSelection();
                    DGV.Rows[i].Selected = true;
                    sbVertical.Value = i + 1;
                    isFound = true;
                    break;
                }
            }
            form.isFound = isFound;

        }
    }
}
