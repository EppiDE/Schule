using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AdressVerwaltung
{
    public partial class FormEmOr : Form
    {
        public FormEmOr()
        {
            InitializeComponent();
        }

        // Test for GIT
        private void dataGridViewEmp_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            dataGridViewEmployees.BeginEdit(true);
        }
        private void dataGridViewEmp_CellClick(
        object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex == -1 && e.RowIndex == -1)
            {
                //ResetDataGridView();
            }
            dataGridViewEmployees.BeginEdit(true);
        }

        private void buttonAdd_Click(object sender, EventArgs e)
        {
            //dataGridViewEmployees.AllowUserToAddRows;
            dataGridViewEmployees.Rows.Add("001", "Jens", "Fotze");
            dataGridViewEmployees.BeginEdit(true);
        }

        private void buttonDelete_Click(object sender, EventArgs e)
        {

        }

        private void buttonUpdate_Click(object sender, EventArgs e)
        {
            dataGridViewEmployees.BeginEdit(true);
            
        }
    }
}
