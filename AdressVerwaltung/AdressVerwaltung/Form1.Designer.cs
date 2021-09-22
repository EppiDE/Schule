
namespace AdressVerwaltung
{
    partial class FormEmOr
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.labelDisplayNames = new System.Windows.Forms.Label();
            this.dataGridViewEmployees = new System.Windows.Forms.DataGridView();
            this.buttonDelete = new System.Windows.Forms.Button();
            this.buttonAdd = new System.Windows.Forms.Button();
            this.buttonUpdate = new System.Windows.Forms.Button();
            this.buttonDetail = new System.Windows.Forms.Button();
            this.panelAddEmployee = new System.Windows.Forms.Panel();
            this.labelNum = new System.Windows.Forms.Label();
            this.textBoxNum = new System.Windows.Forms.TextBox();
            this.buttonCancelAdd = new System.Windows.Forms.Button();
            this.buttonAddEmployee = new System.Windows.Forms.Button();
            this.labelAddAdd = new System.Windows.Forms.Label();
            this.labelAddCity = new System.Windows.Forms.Label();
            this.labelAddZIP = new System.Windows.Forms.Label();
            this.labelAddStreet = new System.Windows.Forms.Label();
            this.labelAddCat = new System.Windows.Forms.Label();
            this.labelBirthday = new System.Windows.Forms.Label();
            this.labelPosition = new System.Windows.Forms.Label();
            this.labelID = new System.Windows.Forms.Label();
            this.labelSurname = new System.Windows.Forms.Label();
            this.labelPreName = new System.Windows.Forms.Label();
            this.buttonAddAddress = new System.Windows.Forms.Button();
            this.textBoxPrename = new System.Windows.Forms.TextBox();
            this.textBoxAddAdd = new System.Windows.Forms.TextBox();
            this.textBoxAddCity = new System.Windows.Forms.TextBox();
            this.textBoxAddZIP = new System.Windows.Forms.TextBox();
            this.textBoxAddStreet = new System.Windows.Forms.TextBox();
            this.textBoxAddCat = new System.Windows.Forms.TextBox();
            this.dateTimePickerBirthday = new System.Windows.Forms.DateTimePicker();
            this.textBoxPosition = new System.Windows.Forms.TextBox();
            this.textBoxID = new System.Windows.Forms.TextBox();
            this.textBoxSurname = new System.Windows.Forms.TextBox();
            this.buttonCloseApp = new System.Windows.Forms.Button();
            this.persID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colPreName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colSurName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colBirthday = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colPosition = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colAddress = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colNumber = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewEmployees)).BeginInit();
            this.panelAddEmployee.SuspendLayout();
            this.SuspendLayout();
            // 
            // labelDisplayNames
            // 
            this.labelDisplayNames.AutoSize = true;
            this.labelDisplayNames.Location = new System.Drawing.Point(12, 28);
            this.labelDisplayNames.Name = "labelDisplayNames";
            this.labelDisplayNames.Size = new System.Drawing.Size(77, 17);
            this.labelDisplayNames.TabIndex = 1;
            this.labelDisplayNames.Text = "Employees";
            // 
            // dataGridViewEmployees
            // 
            this.dataGridViewEmployees.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewEmployees.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.persID,
            this.colPreName,
            this.colSurName,
            this.colBirthday,
            this.colPosition,
            this.colAddress,
            this.colNumber});
            this.dataGridViewEmployees.Location = new System.Drawing.Point(12, 48);
            this.dataGridViewEmployees.Name = "dataGridViewEmployees";
            this.dataGridViewEmployees.RowHeadersWidth = 51;
            this.dataGridViewEmployees.RowTemplate.Height = 24;
            this.dataGridViewEmployees.Size = new System.Drawing.Size(1265, 365);
            this.dataGridViewEmployees.TabIndex = 2;
            this.dataGridViewEmployees.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridViewEmp_CellClick);
            this.dataGridViewEmployees.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridViewEmp_CellContentClick);
            // 
            // buttonDelete
            // 
            this.buttonDelete.Location = new System.Drawing.Point(79, 448);
            this.buttonDelete.Name = "buttonDelete";
            this.buttonDelete.Size = new System.Drawing.Size(125, 55);
            this.buttonDelete.TabIndex = 3;
            this.buttonDelete.Text = "Delete";
            this.buttonDelete.UseVisualStyleBackColor = true;
            this.buttonDelete.Click += new System.EventHandler(this.buttonDelete_Click);
            // 
            // buttonAdd
            // 
            this.buttonAdd.Location = new System.Drawing.Point(277, 448);
            this.buttonAdd.Name = "buttonAdd";
            this.buttonAdd.Size = new System.Drawing.Size(125, 55);
            this.buttonAdd.TabIndex = 4;
            this.buttonAdd.Text = "Add";
            this.buttonAdd.UseVisualStyleBackColor = true;
            this.buttonAdd.Click += new System.EventHandler(this.buttonAdd_Click);
            // 
            // buttonUpdate
            // 
            this.buttonUpdate.Location = new System.Drawing.Point(464, 448);
            this.buttonUpdate.Name = "buttonUpdate";
            this.buttonUpdate.Size = new System.Drawing.Size(125, 55);
            this.buttonUpdate.TabIndex = 5;
            this.buttonUpdate.Text = "Update";
            this.buttonUpdate.UseVisualStyleBackColor = true;
            this.buttonUpdate.Click += new System.EventHandler(this.buttonUpdate_Click);
            // 
            // buttonDetail
            // 
            this.buttonDetail.Location = new System.Drawing.Point(791, 448);
            this.buttonDetail.Name = "buttonDetail";
            this.buttonDetail.Size = new System.Drawing.Size(125, 55);
            this.buttonDetail.TabIndex = 6;
            this.buttonDetail.Text = "Detail View";
            this.buttonDetail.UseVisualStyleBackColor = true;
            this.buttonDetail.Click += new System.EventHandler(this.buttonDetail_Click);
            // 
            // panelAddEmployee
            // 
            this.panelAddEmployee.Controls.Add(this.labelNum);
            this.panelAddEmployee.Controls.Add(this.textBoxNum);
            this.panelAddEmployee.Controls.Add(this.buttonCancelAdd);
            this.panelAddEmployee.Controls.Add(this.buttonAddEmployee);
            this.panelAddEmployee.Controls.Add(this.labelAddAdd);
            this.panelAddEmployee.Controls.Add(this.labelAddCity);
            this.panelAddEmployee.Controls.Add(this.labelAddZIP);
            this.panelAddEmployee.Controls.Add(this.labelAddStreet);
            this.panelAddEmployee.Controls.Add(this.labelAddCat);
            this.panelAddEmployee.Controls.Add(this.labelBirthday);
            this.panelAddEmployee.Controls.Add(this.labelPosition);
            this.panelAddEmployee.Controls.Add(this.labelID);
            this.panelAddEmployee.Controls.Add(this.labelSurname);
            this.panelAddEmployee.Controls.Add(this.labelPreName);
            this.panelAddEmployee.Controls.Add(this.buttonAddAddress);
            this.panelAddEmployee.Controls.Add(this.textBoxPrename);
            this.panelAddEmployee.Controls.Add(this.textBoxAddAdd);
            this.panelAddEmployee.Controls.Add(this.textBoxAddCity);
            this.panelAddEmployee.Controls.Add(this.textBoxAddZIP);
            this.panelAddEmployee.Controls.Add(this.textBoxAddStreet);
            this.panelAddEmployee.Controls.Add(this.textBoxAddCat);
            this.panelAddEmployee.Controls.Add(this.dateTimePickerBirthday);
            this.panelAddEmployee.Controls.Add(this.textBoxPosition);
            this.panelAddEmployee.Controls.Add(this.textBoxID);
            this.panelAddEmployee.Controls.Add(this.textBoxSurname);
            this.panelAddEmployee.Enabled = false;
            this.panelAddEmployee.Location = new System.Drawing.Point(3, -5);
            this.panelAddEmployee.Name = "panelAddEmployee";
            this.panelAddEmployee.Size = new System.Drawing.Size(1283, 508);
            this.panelAddEmployee.TabIndex = 7;
            this.panelAddEmployee.Visible = false;
            // 
            // labelNum
            // 
            this.labelNum.AutoSize = true;
            this.labelNum.Location = new System.Drawing.Point(742, 123);
            this.labelNum.Name = "labelNum";
            this.labelNum.Size = new System.Drawing.Size(58, 17);
            this.labelNum.TabIndex = 24;
            this.labelNum.Text = "Number";
            // 
            // textBoxNum
            // 
            this.textBoxNum.Location = new System.Drawing.Point(742, 143);
            this.textBoxNum.Name = "textBoxNum";
            this.textBoxNum.Size = new System.Drawing.Size(76, 22);
            this.textBoxNum.TabIndex = 23;
            // 
            // buttonCancelAdd
            // 
            this.buttonCancelAdd.Location = new System.Drawing.Point(787, 419);
            this.buttonCancelAdd.Name = "buttonCancelAdd";
            this.buttonCancelAdd.Size = new System.Drawing.Size(109, 38);
            this.buttonCancelAdd.TabIndex = 22;
            this.buttonCancelAdd.Text = "Cancel";
            this.buttonCancelAdd.UseVisualStyleBackColor = true;
            this.buttonCancelAdd.Click += new System.EventHandler(this.buttonCancelAdd_Click);
            // 
            // buttonAddEmployee
            // 
            this.buttonAddEmployee.BackColor = System.Drawing.Color.Honeydew;
            this.buttonAddEmployee.Location = new System.Drawing.Point(245, 402);
            this.buttonAddEmployee.Name = "buttonAddEmployee";
            this.buttonAddEmployee.Size = new System.Drawing.Size(381, 68);
            this.buttonAddEmployee.TabIndex = 21;
            this.buttonAddEmployee.Text = "Add Employee";
            this.buttonAddEmployee.UseVisualStyleBackColor = false;
            this.buttonAddEmployee.Click += new System.EventHandler(this.buttonAddEmployee_Click);
            // 
            // labelAddAdd
            // 
            this.labelAddAdd.AutoSize = true;
            this.labelAddAdd.Location = new System.Drawing.Point(482, 279);
            this.labelAddAdd.Name = "labelAddAdd";
            this.labelAddAdd.Size = new System.Drawing.Size(144, 17);
            this.labelAddAdd.TabIndex = 20;
            this.labelAddAdd.Text = "Additional Information";
            // 
            // labelAddCity
            // 
            this.labelAddCity.AutoSize = true;
            this.labelAddCity.Location = new System.Drawing.Point(482, 230);
            this.labelAddCity.Name = "labelAddCity";
            this.labelAddCity.Size = new System.Drawing.Size(31, 17);
            this.labelAddCity.TabIndex = 19;
            this.labelAddCity.Text = "City";
            // 
            // labelAddZIP
            // 
            this.labelAddZIP.AutoSize = true;
            this.labelAddZIP.Location = new System.Drawing.Point(482, 175);
            this.labelAddZIP.Name = "labelAddZIP";
            this.labelAddZIP.Size = new System.Drawing.Size(67, 17);
            this.labelAddZIP.TabIndex = 18;
            this.labelAddZIP.Text = "ZIP-Code";
            // 
            // labelAddStreet
            // 
            this.labelAddStreet.AutoSize = true;
            this.labelAddStreet.Location = new System.Drawing.Point(482, 123);
            this.labelAddStreet.Name = "labelAddStreet";
            this.labelAddStreet.Size = new System.Drawing.Size(46, 17);
            this.labelAddStreet.TabIndex = 17;
            this.labelAddStreet.Text = "Street";
            // 
            // labelAddCat
            // 
            this.labelAddCat.AutoSize = true;
            this.labelAddCat.Location = new System.Drawing.Point(482, 68);
            this.labelAddCat.Name = "labelAddCat";
            this.labelAddCat.Size = new System.Drawing.Size(65, 17);
            this.labelAddCat.TabIndex = 16;
            this.labelAddCat.Text = "Category";
            // 
            // labelBirthday
            // 
            this.labelBirthday.AutoSize = true;
            this.labelBirthday.Location = new System.Drawing.Point(75, 279);
            this.labelBirthday.Name = "labelBirthday";
            this.labelBirthday.Size = new System.Drawing.Size(60, 17);
            this.labelBirthday.TabIndex = 15;
            this.labelBirthday.Text = "Birthday";
            // 
            // labelPosition
            // 
            this.labelPosition.AutoSize = true;
            this.labelPosition.Location = new System.Drawing.Point(72, 230);
            this.labelPosition.Name = "labelPosition";
            this.labelPosition.Size = new System.Drawing.Size(58, 17);
            this.labelPosition.TabIndex = 14;
            this.labelPosition.Text = "Position";
            // 
            // labelID
            // 
            this.labelID.AutoSize = true;
            this.labelID.Location = new System.Drawing.Point(72, 175);
            this.labelID.Name = "labelID";
            this.labelID.Size = new System.Drawing.Size(87, 17);
            this.labelID.TabIndex = 13;
            this.labelID.Text = "Employee ID";
            // 
            // labelSurname
            // 
            this.labelSurname.AutoSize = true;
            this.labelSurname.Location = new System.Drawing.Point(72, 123);
            this.labelSurname.Name = "labelSurname";
            this.labelSurname.Size = new System.Drawing.Size(65, 17);
            this.labelSurname.TabIndex = 12;
            this.labelSurname.Text = "Surname";
            // 
            // labelPreName
            // 
            this.labelPreName.AutoSize = true;
            this.labelPreName.Location = new System.Drawing.Point(75, 68);
            this.labelPreName.Name = "labelPreName";
            this.labelPreName.Size = new System.Drawing.Size(65, 17);
            this.labelPreName.TabIndex = 11;
            this.labelPreName.Text = "Prename";
            // 
            // buttonAddAddress
            // 
            this.buttonAddAddress.Location = new System.Drawing.Point(485, 342);
            this.buttonAddAddress.Name = "buttonAddAddress";
            this.buttonAddAddress.Size = new System.Drawing.Size(120, 23);
            this.buttonAddAddress.TabIndex = 10;
            this.buttonAddAddress.Text = "Add Address";
            this.buttonAddAddress.UseVisualStyleBackColor = true;
            this.buttonAddAddress.Click += new System.EventHandler(this.buttonAddAddress_Click);
            // 
            // textBoxPrename
            // 
            this.textBoxPrename.Location = new System.Drawing.Point(75, 91);
            this.textBoxPrename.Name = "textBoxPrename";
            this.textBoxPrename.Size = new System.Drawing.Size(260, 22);
            this.textBoxPrename.TabIndex = 9;
            // 
            // textBoxAddAdd
            // 
            this.textBoxAddAdd.Location = new System.Drawing.Point(485, 299);
            this.textBoxAddAdd.Name = "textBoxAddAdd";
            this.textBoxAddAdd.Size = new System.Drawing.Size(334, 22);
            this.textBoxAddAdd.TabIndex = 8;
            // 
            // textBoxAddCity
            // 
            this.textBoxAddCity.Location = new System.Drawing.Point(485, 250);
            this.textBoxAddCity.Name = "textBoxAddCity";
            this.textBoxAddCity.Size = new System.Drawing.Size(334, 22);
            this.textBoxAddCity.TabIndex = 7;
            // 
            // textBoxAddZIP
            // 
            this.textBoxAddZIP.Location = new System.Drawing.Point(485, 195);
            this.textBoxAddZIP.Name = "textBoxAddZIP";
            this.textBoxAddZIP.Size = new System.Drawing.Size(100, 22);
            this.textBoxAddZIP.TabIndex = 6;
            // 
            // textBoxAddStreet
            // 
            this.textBoxAddStreet.Location = new System.Drawing.Point(485, 143);
            this.textBoxAddStreet.Name = "textBoxAddStreet";
            this.textBoxAddStreet.Size = new System.Drawing.Size(237, 22);
            this.textBoxAddStreet.TabIndex = 5;
            // 
            // textBoxAddCat
            // 
            this.textBoxAddCat.Location = new System.Drawing.Point(485, 91);
            this.textBoxAddCat.Name = "textBoxAddCat";
            this.textBoxAddCat.Size = new System.Drawing.Size(334, 22);
            this.textBoxAddCat.TabIndex = 4;
            // 
            // dateTimePickerBirthday
            // 
            this.dateTimePickerBirthday.Location = new System.Drawing.Point(75, 297);
            this.dateTimePickerBirthday.Name = "dateTimePickerBirthday";
            this.dateTimePickerBirthday.Size = new System.Drawing.Size(200, 22);
            this.dateTimePickerBirthday.TabIndex = 3;
            // 
            // textBoxPosition
            // 
            this.textBoxPosition.Location = new System.Drawing.Point(75, 250);
            this.textBoxPosition.Name = "textBoxPosition";
            this.textBoxPosition.Size = new System.Drawing.Size(260, 22);
            this.textBoxPosition.TabIndex = 2;
            // 
            // textBoxID
            // 
            this.textBoxID.Enabled = false;
            this.textBoxID.Location = new System.Drawing.Point(75, 195);
            this.textBoxID.Name = "textBoxID";
            this.textBoxID.Size = new System.Drawing.Size(65, 22);
            this.textBoxID.TabIndex = 1;
            // 
            // textBoxSurname
            // 
            this.textBoxSurname.Location = new System.Drawing.Point(75, 143);
            this.textBoxSurname.Name = "textBoxSurname";
            this.textBoxSurname.Size = new System.Drawing.Size(260, 22);
            this.textBoxSurname.TabIndex = 0;
            this.textBoxSurname.TextChanged += new System.EventHandler(this.textBoxSurname_TextChanged);
            // 
            // buttonCloseApp
            // 
            this.buttonCloseApp.Location = new System.Drawing.Point(1164, 453);
            this.buttonCloseApp.Name = "buttonCloseApp";
            this.buttonCloseApp.Size = new System.Drawing.Size(97, 52);
            this.buttonCloseApp.TabIndex = 8;
            this.buttonCloseApp.Text = "Close";
            this.buttonCloseApp.UseVisualStyleBackColor = true;
            this.buttonCloseApp.Click += new System.EventHandler(this.buttonCloseApp_Click);
            // 
            // persID
            // 
            this.persID.HeaderText = "Personal ID";
            this.persID.MinimumWidth = 6;
            this.persID.Name = "persID";
            this.persID.ReadOnly = true;
            this.persID.Width = 125;
            // 
            // colPreName
            // 
            this.colPreName.HeaderText = "Prename";
            this.colPreName.MinimumWidth = 6;
            this.colPreName.Name = "colPreName";
            this.colPreName.ReadOnly = true;
            this.colPreName.Width = 125;
            // 
            // colSurName
            // 
            this.colSurName.HeaderText = "Surname";
            this.colSurName.MinimumWidth = 6;
            this.colSurName.Name = "colSurName";
            this.colSurName.ReadOnly = true;
            this.colSurName.Width = 125;
            // 
            // colBirthday
            // 
            this.colBirthday.HeaderText = "Birthday";
            this.colBirthday.MinimumWidth = 6;
            this.colBirthday.Name = "colBirthday";
            this.colBirthday.ReadOnly = true;
            this.colBirthday.Width = 125;
            // 
            // colPosition
            // 
            this.colPosition.HeaderText = "Position";
            this.colPosition.MinimumWidth = 6;
            this.colPosition.Name = "colPosition";
            this.colPosition.ReadOnly = true;
            this.colPosition.Width = 125;
            // 
            // colAddress
            // 
            this.colAddress.HeaderText = "Primary Address";
            this.colAddress.MinimumWidth = 6;
            this.colAddress.Name = "colAddress";
            this.colAddress.ReadOnly = true;
            this.colAddress.Width = 125;
            // 
            // colNumber
            // 
            this.colNumber.HeaderText = "Primary Number";
            this.colNumber.MinimumWidth = 6;
            this.colNumber.Name = "colNumber";
            this.colNumber.ReadOnly = true;
            this.colNumber.Width = 125;
            // 
            // FormEmOr
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1286, 515);
            this.Controls.Add(this.buttonDetail);
            this.Controls.Add(this.buttonUpdate);
            this.Controls.Add(this.buttonAdd);
            this.Controls.Add(this.buttonDelete);
            this.Controls.Add(this.buttonCloseApp);
            this.Controls.Add(this.dataGridViewEmployees);
            this.Controls.Add(this.labelDisplayNames);
            this.Controls.Add(this.panelAddEmployee);
            this.Name = "FormEmOr";
            this.Text = "EmOr";
            this.Load += new System.EventHandler(this.FormEmOr_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewEmployees)).EndInit();
            this.panelAddEmployee.ResumeLayout(false);
            this.panelAddEmployee.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label labelDisplayNames;
        private System.Windows.Forms.DataGridView dataGridViewEmployees;
        private System.Windows.Forms.Button buttonDelete;
        private System.Windows.Forms.Button buttonAdd;
        private System.Windows.Forms.Button buttonUpdate;
        private System.Windows.Forms.Button buttonDetail;
        private System.Windows.Forms.Panel panelAddEmployee;
        private System.Windows.Forms.DateTimePicker dateTimePickerBirthday;
        private System.Windows.Forms.TextBox textBoxPosition;
        private System.Windows.Forms.TextBox textBoxID;
        private System.Windows.Forms.TextBox textBoxSurname;
        private System.Windows.Forms.TextBox textBoxAddStreet;
        private System.Windows.Forms.TextBox textBoxAddCat;
        private System.Windows.Forms.TextBox textBoxAddAdd;
        private System.Windows.Forms.TextBox textBoxAddCity;
        private System.Windows.Forms.TextBox textBoxAddZIP;
        private System.Windows.Forms.Label labelAddAdd;
        private System.Windows.Forms.Label labelAddCity;
        private System.Windows.Forms.Label labelAddZIP;
        private System.Windows.Forms.Label labelAddStreet;
        private System.Windows.Forms.Label labelAddCat;
        private System.Windows.Forms.Label labelBirthday;
        private System.Windows.Forms.Label labelPosition;
        private System.Windows.Forms.Label labelID;
        private System.Windows.Forms.Label labelSurname;
        private System.Windows.Forms.Label labelPreName;
        private System.Windows.Forms.Button buttonAddAddress;
        private System.Windows.Forms.TextBox textBoxPrename;
        private System.Windows.Forms.Button buttonCancelAdd;
        private System.Windows.Forms.Button buttonAddEmployee;
        private System.Windows.Forms.Button buttonCloseApp;
        private System.Windows.Forms.Label labelNum;
        private System.Windows.Forms.TextBox textBoxNum;
        private System.Windows.Forms.DataGridViewTextBoxColumn persID;
        private System.Windows.Forms.DataGridViewTextBoxColumn colPreName;
        private System.Windows.Forms.DataGridViewTextBoxColumn colSurName;
        private System.Windows.Forms.DataGridViewTextBoxColumn colBirthday;
        private System.Windows.Forms.DataGridViewTextBoxColumn colPosition;
        private System.Windows.Forms.DataGridViewTextBoxColumn colAddress;
        private System.Windows.Forms.DataGridViewTextBoxColumn colNumber;
    }
}

