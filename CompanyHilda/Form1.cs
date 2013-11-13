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
    public partial class FormHilda1 : Form
    {
        public FormHilda1()
        {
            InitializeComponent();
        }

        private void salesBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.salesBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.companyDataSet);

        }

        private void FormHilda1_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'companyDataSet.Sales' table. You can move, or remove it, as needed.
            this.salesTableAdapter.Fill(this.companyDataSet.Sales);

        }
    }
}
