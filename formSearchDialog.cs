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
    public partial class formSearchDialog : Form
    {
        public string RegNo;
        public bool isFound;
        public event EventHandler searchClick;
        public formSearchDialog(string findThis)
        {
            InitializeComponent();
            isFound = false;
            this.txtSearch.PlaceholderText = findThis;
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            RegNo = txtSearch.Text;
            searchClick?.Invoke(this, null);
            if (isFound)
                this.Close();
            else
                this.epNotFound.SetError(txtSearch, "Not Found");
            //this.Hide();
        }
    }
}
