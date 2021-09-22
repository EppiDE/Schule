using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
//@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@
//@@@@@@@ Author: Marc Eppinger
//@@@@@@@ Programmname: 
//@@@@@@@ Description:- Employeemanagement (contact data)
//@@@@@@@             - no saving
//@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@


namespace AdressVerwaltung
{
    public partial class FormEmOr : Form
    {
        public FormEmOr()
        {
            InitializeComponent();
            //Set a custom format containing the string "of the year"
            dateTimePickerBirthday.Format = DateTimePickerFormat.Custom;
            dateTimePickerBirthday.CustomFormat = "dd.MM.yyyy";
            dateTimePickerBirthday.Value = defaultDT;
            dateTimePickerBirthday.MaxDate = DateTime.Today;
            
    }

        List<CEmployee> ListCEmployees = new List<CEmployee>();
        public DateTime defaultDT = new DateTime(2000, 1, 1);
        CEmployee g_CEmployee = new CEmployee();

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

        private void readTextIntoClass(CEmployee l_CEmployee)
        {
            l_CEmployee.SPreName = textBoxPrename.Text;
            l_CEmployee.SSurName = textBoxSurname.Text;
            l_CEmployee.SPostition = textBoxPosition.Text;
            l_CEmployee.DtBirthday = dateTimePickerBirthday.Value;
        }

        private void readAddressIntoList(CEmployee l_Cemployee)
        {
            CEmployee.stAddress l_Address = new CEmployee.stAddress(textBoxAddCat.Text, textBoxAddStreet.Text, textBoxNum.Text, textBoxAddZIP.Text, textBoxAddAdd.Text);
            l_Cemployee.lAddress.Add(l_Address);
        }

        private void buttonAdd_Click(object sender, EventArgs e)
        {
            panelAddEmployee.Enabled = true;
            panelAddEmployee.Visible = true;
            textBoxID.Text = Convert.ToString(CEmployee.EmpID);
        }

        private void buttonDelete_Click(object sender, EventArgs e)
        {

        }

        private void buttonUpdate_Click(object sender, EventArgs e)
        {
            dataGridViewEmployees.BeginEdit(true);
            
        }

        private void textBoxSurname_TextChanged(object sender, EventArgs e)
        {

        }

        private void buttonCancelAdd_Click(object sender, EventArgs e)
        {
            panelAddEmployee.Visible = false;
            panelAddEmployee.Enabled = false;
            CEmployee.EmpID--;
            clearTextBoxesAddPanel();
        }
        private void clearTextBoxesAddPanel()
        {
            textBoxAddAdd.Clear();
            textBoxAddCat.Clear();
            textBoxAddCity.Clear();
            textBoxAddStreet.Clear();
            textBoxAddZIP.Clear();
            textBoxPosition.Clear();
            textBoxPrename.Clear();
            textBoxSurname.Clear();
            dateTimePickerBirthday.Value = defaultDT;
        }

        private void buttonCloseApp_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void FormEmOr_Load(object sender, EventArgs e)
        {

        }

        private void buttonDetail_Click(object sender, EventArgs e)
        {

        }

        private void buttonAddAddress_Click(object sender, EventArgs e)
        {
            readAddressIntoList(g_CEmployee);
        }

        private void buttonAddEmployee_Click(object sender, EventArgs e)
        {
            CEmployee l_CEmployee = new CEmployee();
            l_CEmployee = g_CEmployee;
            readTextIntoClass(l_CEmployee);
            writeClassIntoDataGridEmp(l_CEmployee);
        }
        private void writeClassIntoDataGridEmp (CEmployee l_CEmployee)
        {
            //dataGridViewEmployees.AllowUserToAddRows;
            int x = dataGridViewEmployees.Rows.Add(textBoxID.Text, textBoxPrename.Text, textBoxSurname.Text, dateTimePickerBirthday.ToString(),
                                           textBoxPosition.Text, l_CEmployee.lAddress[0].ToString());
            dataGridViewEmployees.Rows[x].Tag = g_CEmployee;
            g_CEmployee = (CEmployee)dataGridViewEmployees.Rows[x].Tag; //TODO Try catch
            dataGridViewEmployees.BeginEdit(true);
            
        }
    }
}
