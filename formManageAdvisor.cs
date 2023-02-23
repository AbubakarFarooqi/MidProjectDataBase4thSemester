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
    public partial class formManageAdvisor : Form
    {
        SqlConnection con = Configuration.getInstance().getConnection();
        formSearchDialog formSearch;
        formUpdateStudentDialog formUpdate;
        SqlDataAdapter da;
        DataTable dt;
        public formManageAdvisor()
        {
            InitializeComponent();
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            formSearch = new formSearchDialog("Enter ID");
            formSearch.searchClick += new EventHandler(onSearch);
            formSearch.ShowDialog();
        }

        private void onSearch(object sender, EventArgs e)
        {
            bool isFound = false;
            string ID = formSearch.RegNo; //  form return ID
            for (int i = 0; i < DGV.RowCount; i++)
            {
                // finding row that contain reg no
                if (DGV.Rows[i].Cells[0].Value.ToString() == ID)
                {
                    DGV.ClearSelection();
                    DGV.Rows[i].Selected = true;
                    sbVertical.Value = i + 1;
                    isFound = true;
                    break;
                }
            }
            formSearch.isFound = isFound;

        }

        private void formManageAdvisor_Load(object sender, EventArgs e)
        {
            DGV.MultiSelect = false;
            DGV.ScrollBars = ScrollBars.None;
            SqlCommand cmd = new SqlCommand("select A.Id as [Advisor ID] , FirstName , LastName , Contact , Email , DateOfBirth as [Date of Birth] , (select value from Lookup where id = A.Designation) AS Designation ,A.salary, (select value from Lookup where id = p.Gender) as Gender from advisor A join person p  on A.id = p.id ", con);
            da = new SqlDataAdapter(cmd);
            dt = new DataTable();
            da.Fill(dt);
            DGV.DataSource = dt;
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Are You Sure to Delete " + DGV.SelectedRows[0].Cells[0].Value.ToString(), "Caution", MessageBoxButtons.YesNo);
            if (result == DialogResult.Yes)
            {
                try
                {
                    SqlCommand cmd = new SqlCommand("delete Advisor where Id = @id", con);
                    cmd.Parameters.AddWithValue("@id", DGV.SelectedRows[0].Cells[0].Value.ToString());
                    cmd.ExecuteNonQuery();
                    cmd = new SqlCommand("delete  person where id = @id", con);
                    cmd.Parameters.AddWithValue("@id", DGV.SelectedRows[0].Cells[0].Value.ToString());
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Record Has Been successfully Deleted");
                    updateDGV();
                }
                catch (SqlException ex)
                {
                    MessageBox.Show("Something Went Wrong while Updating Database. Kindly check your Connection and Credentials", "Failure");
                }
            }
        }
        private void updateDGV()
        {
            SqlCommand cmd = new SqlCommand("select A.Id as [Advisor ID] , FirstName , LastName , Contact , Email , DateOfBirth as [Date of Birth] , (select value from Lookup where id = A.Designation) AS Designation ,A.salary, (select value from Lookup where id = p.Gender) as Gender from advisor A join person p  on A.id = p.id ", con);
            da = new SqlDataAdapter(cmd);
            dt = new DataTable();
            da.Fill(dt);
            DGV.DataSource = dt;
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            int rowIdx = DGV.SelectedRows[0].Index;
            string id = DGV.Rows[rowIdx].Cells[0].Value.ToString();
            string firstName = DGV.Rows[rowIdx].Cells[1].Value.ToString();
            string lastName = DGV.Rows[rowIdx].Cells[2].Value.ToString();
            string contact = DGV.Rows[rowIdx].Cells[3].Value.ToString();
            string email = DGV.Rows[rowIdx].Cells[4].Value.ToString();
            string dob = DGV.Rows[rowIdx].Cells[5].Value.ToString();
            string designation = DGV.Rows[rowIdx].Cells[6].Value.ToString();
            string salary = DGV.Rows[rowIdx].Cells[7].Value.ToString();
            string gender = DGV.Rows[rowIdx].Cells[8].Value.ToString();

            formUpdate = new formUpdateDialog(id, firstName, lastName, contact, email, dob, designation, salary, gender);
            //formUpdate.onSuccessUpdate += new EventHandler(onSuccessUpdate);
            formUpdate.ShowDialog();
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
