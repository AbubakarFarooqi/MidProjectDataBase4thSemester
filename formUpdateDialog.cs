using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Data.SqlClient;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MidProject
{
    public partial class formUpdateDialog : Form
    {
        string regNo;
        public event EventHandler onSuccessUpdate;
        public formUpdateDialog(string regNo, string firstName, string lasName, string contact, string email,
                                    string dob, string gender)
        {
            InitializeComponent();
            txtContact.Text = contact;
            txtEmail.Text = email;
            txtFirstName.Text = firstName;
            txtLastName.Text = lasName;
            txtRegNo.Text = regNo;
            cbxGender.Text = gender;
            tpDOB.Text = dob;
            this.regNo = regNo;
        }

        private void btnCancel_Click(object sender, EventArgs e)
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

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            if (isEveryFieldSet()) // check all fields must be filled
            {
                try
                {
                    var con = Configuration.getInstance().getConnection();
                    SqlCommand cmd;
                    /*cmd.Parameters.AddWithValue("@Gender", cbxGender.Text.ToString());
                    int gender = int.Parse(cmd.ExecuteScalar().ToString());*/
                    cmd = new SqlCommand("update person set FirstName = @firstName, LastName = @lastName, Contact = @contact, Email = @email, DateOfBirth = @dob ,Gender = (select id  from Lookup where Value = @gender) where id = (select id  from student where RegistrationNo =" + "\'" + regNo + "\'" + " )", con);
                    cmd.Parameters.AddWithValue("@firstName", txtFirstName.Text);
                    cmd.Parameters.AddWithValue("@lastName", txtLastName.Text);
                    cmd.Parameters.AddWithValue("@contact", txtContact.Text);
                    cmd.Parameters.AddWithValue("@email", txtEmail.Text);
                    cmd.Parameters.AddWithValue("@dob", Validations.parseDate(tpDOB.Text));
                    cmd.Parameters.AddWithValue("@gender", cbxGender.Text.ToString());
                    cmd.ExecuteNonQuery();

                    cmd = new SqlCommand("update student set RegistrationNo = @regNo where RegistrationNo = " + "\'" + regNo + "\'", con);
                    cmd.Parameters.AddWithValue("@regNo", txtRegNo.Text);
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Data Has Been Successfully Updated", "Success");
                    onSuccessUpdate?.Invoke(this, null);
                    this.Close();

                }
                catch (SqlException ex)
                {
                    MessageBox.Show("Something Went Wrong while Updating Database. Kindly check your Connection and Credentials", "Failure");
                }

            }
        }
    }
}
