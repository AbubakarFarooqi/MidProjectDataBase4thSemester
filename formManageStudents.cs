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
        formSearchDialog formSearch;
        formUpdateDialog formUpdate;
        SqlDataAdapter da;
        DataTable dt;
        public formManageStudents()
        {
            InitializeComponent();
        }

        private void formManageStudents_Load(object sender, EventArgs e)
        {
            DGV.MultiSelect = false;
            DGV.ScrollBars = ScrollBars.None;
            SqlCommand cmd = new SqlCommand("select s.RegistrationNo as [Registration Number] , FirstName , LastName , Contact , Email , DateOfBirth as [Date of Birth] , (select value from Lookup where id = p.Gender) as Gender from student s join person p  on s.id = p.id ", con);
            da = new SqlDataAdapter(cmd);
            dt = new DataTable();
            da.Fill(dt);
            DGV.DataSource = dt;
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            formSearch = new formSearchDialog("Registration Number");
            formSearch.searchClick += new EventHandler(onSearch);
            formSearch.ShowDialog();

        }

        private void onSearch(object sender, EventArgs e)
        {
            bool isFound = false;
            string regNo = formSearch.RegNo; //  form return reg no
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
            formSearch.isFound = isFound;

        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            int rowIdx = DGV.SelectedRows[0].Index;
            string regNo = DGV.Rows[rowIdx].Cells[0].Value.ToString();
            string firstName = DGV.Rows[rowIdx].Cells[1].Value.ToString();
            string lastName = DGV.Rows[rowIdx].Cells[2].Value.ToString();
            string contact = DGV.Rows[rowIdx].Cells[3].Value.ToString();
            string email = DGV.Rows[rowIdx].Cells[4].Value.ToString();
            string dob = DGV.Rows[rowIdx].Cells[5].Value.ToString();
            string gender = DGV.Rows[rowIdx].Cells[6].Value.ToString();

            formUpdate = new formUpdateDialog(regNo, firstName, lastName, contact, email, dob, gender);
            formUpdate.onSuccessUpdate += new EventHandler(onSuccessUpdate);
            formUpdate.ShowDialog();
        }

        private void onSuccessUpdate(object sender, EventArgs e)
        {
            updateDGV();
        }
        private void updateDGV()
        {
            SqlCommand cmd = new SqlCommand("select s.RegistrationNo as [Registration Number] , FirstName , LastName , Contact , Email , DateOfBirth as [Date of Birth] , Gender from student s join person p on s.id = p.id ", con);
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
                    SqlCommand cmd = new SqlCommand("select id from student where RegistrationNo = @regNo", con);
                    cmd.Parameters.AddWithValue("@regNo", DGV.SelectedRows[0].Cells[0].Value.ToString());
                    string id = cmd.ExecuteScalar().ToString();
                    cmd = new SqlCommand("delete student where RegistrationNo = @regNo", con);
                    cmd.Parameters.AddWithValue("@regNo", DGV.SelectedRows[0].Cells[0].Value.ToString());
                    cmd.ExecuteNonQuery();
                    cmd = new SqlCommand("delete  person where id = @id", con);
                    cmd.Parameters.AddWithValue("@id", id);
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
    }
}
