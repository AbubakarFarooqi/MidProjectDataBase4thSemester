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
    public partial class formAddStudent : Form
    {
        public formAddStudent()
        {
            InitializeComponent();
        }

        private void btnCross_Click(object sender, EventArgs e)
        {
            this.Close();
        }


        // This Function Will Check whther each field in the form is filled or not
        private bool isEveryFieldSet()
        {
            bool ret = true;
            if (txtFirstName.Text.Length == 0)
            {
                ret = false;
                epFirstName.SetError(txtFirstName, "Field Cannot be Left Empty");
            }
            if (txtLastName.Text.Length == 0)
            {

                ret = false;
                epLastName.SetError(txtLastName, "Field Cannot be Left Empty");
            }
            if (txtContact.Text.Length == 0)
            {
                ret = false;
                epContact.SetError(txtContact, "Field Cannot be Left Empty");
            }
            if (txtEmail.Text.Length == 0)
            {
                ret = false;
                epEmail.SetError(txtEmail, "Field Cannot be Left Empty");
            }
            if (txtRegNo.Text.Length == 0)
            {
                ret = false;
                epRegNo.SetError(txtRegNo, "Field Cannot be Left Empty");
            }
            return ret;
        }

        private void btnAdd_Click_1(object sender, EventArgs e)
        {
            if (isEveryFieldSet()) // check all fields must be filled
            {
                try
                {
                    var con = Configuration.getInstance().getConnection();
                    SqlCommand cmd = new SqlCommand("select id  from Lookup where Value = @Gender", con);
                    cmd.Parameters.AddWithValue("@Gender", cbxGender.Text.ToString());
                    int gender = int.Parse(cmd.ExecuteScalar().ToString());
                    cmd = new SqlCommand("declare @a table(id int);insert person OUTPUT inserted.id into @a values(@FirstName,@LastName,@Contact,@Email,@DOB,@Gender) insert into Student values ((Select id from @a),@RegNo)", con);
                    cmd.Parameters.AddWithValue("@FirstName", txtFirstName.Text);
                    cmd.Parameters.AddWithValue("@LastName", txtLastName.Text);
                    cmd.Parameters.AddWithValue("@Contact", txtContact.Text);
                    cmd.Parameters.AddWithValue("@Email", txtEmail.Text);
                    cmd.Parameters.AddWithValue("@DOB", Validations.parseDate(tpDOB.Text));
                    cmd.Parameters.AddWithValue("@Gender", gender);
                    cmd.Parameters.AddWithValue("@RegNo", txtRegNo.Text);
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Data Has Been Successfully Uploaded", "Success");

                }
                catch (SqlException ex)
                {
                    MessageBox.Show("Something Went Wrong while Updating Database. Kindly check your Connection and Credentials", "Failure");
                }

            }
        }

        private void tableLayoutPanel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void cbxGender_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
