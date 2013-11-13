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
    public partial class MasterEmployeeList : Form
    {
        public MasterEmployeeList()
        {
            InitializeComponent();
        }

        private void employeesBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.employeesBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.companyDataSet);

        }

        private void MasterEmployeeList_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'companyDataSet.Departments' table. You can move, or remove it, as needed.
            this.departmentsTableAdapter.Fill(this.companyDataSet.Departments);
            // TODO: This line of code loads data into the 'companyDataSet.Employees' table. You can move, or remove it, as needed.
            this.employeesTableAdapter.Fill(this.companyDataSet.Employees);

        }

        

        private void groupBoxMaster_Enter(object sender, EventArgs e)
        {


        }
    }
}
