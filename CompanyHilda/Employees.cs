using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CompanyHilda
{
    public partial class Employees : Form
    {
        public Employees()
        {
            InitializeComponent();
        }

        private void departmentsBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.departmentsBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.companyDataSet);
            

        }

        private void Employees_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'companyDataSet.Departments' table. You can move, or remove it, as needed.
            this.departmentsTableAdapter.Fill(this.companyDataSet.Departments);

        }
    }
}
