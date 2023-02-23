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
using System.IO;
using System.Reflection;
using iText.Kernel.Pdf;
using iText.Layout;
using iText.Layout.Element;
using iText.Layout.Properties;
using iText.Kernel.Pdf.Canvas.Draw;

namespace MidProject
{
    public partial class formManageStudents : Form
    {
        SqlConnection con = Configuration.getInstance().getConnection();
        formSearchDialog formSearch;
        formUpdateStudentDialog formUpdate;
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

            formUpdate = new formUpdateStudentDialog(regNo, firstName, lastName, contact, email, dob, gender);
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


        //----------------

        private void imgBtnPdf_Click(object sender, EventArgs e)
        {
            try
            {

                string path = "12";
                using (var fbd = new FolderBrowserDialog())
                {
                    DialogResult result = fbd.ShowDialog();

                    if (result == DialogResult.OK && !string.IsNullOrWhiteSpace(fbd.SelectedPath))
                    {
                        path = fbd.SelectedPath;
                    }
                }

                path += "\\fypAllStudents.pdf";
                PdfWriter writer = new PdfWriter(path);
                iText.Kernel.Pdf.PdfDocument pdf = new iText.Kernel.Pdf.PdfDocument(writer);
                Document document = new Document(pdf);
                Paragraph header = new Paragraph("Final Year Project")
                .SetTextAlignment(TextAlignment.CENTER)
                .SetFontSize(20).SetBold();
                document.Add(header);
                header = new Paragraph("List of All Students")
                .SetTextAlignment(TextAlignment.CENTER)
                .SetFontSize(15);
                document.Add(header);
                LineSeparator ls = new LineSeparator(new SolidLine());
                document.Add(ls);
                header = new Paragraph("\n\n");
                document.Add(header);

                int dgvrowcount = DGV.Rows.Count;
                int dgvcolumncount = DGV.Columns.Count;

                // Set The Table like new float [] {15f, 15f, 15f, 15f, 15f }
                Table table = new Table(new float[] { 15f, 15f, 15f, 15f, 15f, 15f, 15f }).SetHorizontalAlignment(iText.Layout.Properties.HorizontalAlignment.CENTER);
                table.SetAutoLayout();

                //table.SetWidth(iText.Layout.Properties.UnitValue.CreatePercentValue(100));

                // Print The DGV Header To Table Header
                for (int i = 0; i < dgvcolumncount; i++)
                {
                    Cell headerCells = new Cell()
                                  .SetBackgroundColor(iText.Kernel.Colors.ColorConstants.LIGHT_GRAY)
                                  .SetTextAlignment(iText.Layout.Properties.TextAlignment.CENTER);
                    //headerCells.SetNextRenderer(new RoundedCornersCellRenderer(headerCells));
                    var gteCell = headerCells.Add(new Paragraph(DGV.Columns[i].HeaderText));
                    table.AddHeaderCell(gteCell);
                }

                // Print The DGV Cells To Table Cells
                for (int i = 0; i < dgvrowcount; i++)
                {
                    for (int c = 0; c < dgvcolumncount; c++)
                    {
                        Cell cells = new Cell()
                                  .SetBackgroundColor(iText.Kernel.Colors.ColorConstants.WHITE)
                                  .SetTextAlignment(iText.Layout.Properties.TextAlignment.CENTER);

                        var gteCell = cells.Add(new Paragraph(DGV.Rows[i].Cells[DGV.Columns[c].HeaderText].Value.ToString()));
                        table.AddCell(gteCell);
                    }
                }
                document.Add(table);
                document.Close();
                MessageBox.Show("Document Has Been saved", "Success");
            }
            catch (Exception ee)
            {
                MessageBox.Show("Could Not Print");
            }
        }
    }
}
