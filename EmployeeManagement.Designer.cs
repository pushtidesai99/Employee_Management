namespace EmployeePromact1
{
    partial class Employee
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
            this.Department = new System.Windows.Forms.TabControl();
            this.DepartmentTab = new System.Windows.Forms.TabPage();
            this.ResetButton = new System.Windows.Forms.Button();
            this.dgvDepartment = new System.Windows.Forms.DataGridView();
            this.DeleteDeptBtn = new System.Windows.Forms.Button();
            this.UpdateDeptBtn = new System.Windows.Forms.Button();
            this.AddDeptBtn = new System.Windows.Forms.Button();
            this.DeptDesctxt = new System.Windows.Forms.TextBox();
            this.DeptAbrtxt = new System.Windows.Forms.TextBox();
            this.DeptNametxt = new System.Windows.Forms.TextBox();
            this.Description = new System.Windows.Forms.Label();
            this.Abbreviation = new System.Windows.Forms.Label();
            this.DepartmentName = new System.Windows.Forms.Label();
            this.EmployeeTab = new System.Windows.Forms.TabPage();
            this.ResetEmpBtn = new System.Windows.Forms.Button();
            this.AddEmpBtn = new System.Windows.Forms.Button();
            this.EmpDeptcombo = new System.Windows.Forms.ComboBox();
            this.EmpContact = new System.Windows.Forms.TextBox();
            this.EmpAddresstxt = new System.Windows.Forms.TextBox();
            this.EmpQualificationtxt = new System.Windows.Forms.TextBox();
            this.EmpSurnametxt = new System.Windows.Forms.TextBox();
            this.EmpNametxt = new System.Windows.Forms.TextBox();
            this.Dept = new System.Windows.Forms.Label();
            this.ContactNo = new System.Windows.Forms.Label();
            this.Address = new System.Windows.Forms.Label();
            this.Qualification = new System.Windows.Forms.Label();
            this.Surname = new System.Windows.Forms.Label();
            this.EmplyeeName = new System.Windows.Forms.Label();
            this.ListEmployeeTab = new System.Windows.Forms.TabPage();
            this.dgvEmployeegrid = new System.Windows.Forms.DataGridView();
            this.EditEmpbtn = new System.Windows.Forms.Button();
            this.EditEmployeebtn = new System.Windows.Forms.Button();
            this.Department.SuspendLayout();
            this.DepartmentTab.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDepartment)).BeginInit();
            this.EmployeeTab.SuspendLayout();
            this.ListEmployeeTab.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvEmployeegrid)).BeginInit();
            this.SuspendLayout();
            // 
            // Department
            // 
            this.Department.Controls.Add(this.DepartmentTab);
            this.Department.Controls.Add(this.EmployeeTab);
            this.Department.Controls.Add(this.ListEmployeeTab);
            this.Department.Font = new System.Drawing.Font("Calibri", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Department.ImeMode = System.Windows.Forms.ImeMode.KatakanaHalf;
            this.Department.ItemSize = new System.Drawing.Size(155, 50);
            this.Department.Location = new System.Drawing.Point(0, 0);
            this.Department.Margin = new System.Windows.Forms.Padding(5);
            this.Department.Name = "Department";
            this.Department.SelectedIndex = 0;
            this.Department.Size = new System.Drawing.Size(1125, 577);
            this.Department.TabIndex = 0;
            // 
            // DepartmentTab
            // 
            this.DepartmentTab.BackColor = System.Drawing.Color.Gainsboro;
            this.DepartmentTab.Controls.Add(this.ResetButton);
            this.DepartmentTab.Controls.Add(this.dgvDepartment);
            this.DepartmentTab.Controls.Add(this.DeleteDeptBtn);
            this.DepartmentTab.Controls.Add(this.UpdateDeptBtn);
            this.DepartmentTab.Controls.Add(this.AddDeptBtn);
            this.DepartmentTab.Controls.Add(this.DeptDesctxt);
            this.DepartmentTab.Controls.Add(this.DeptAbrtxt);
            this.DepartmentTab.Controls.Add(this.DeptNametxt);
            this.DepartmentTab.Controls.Add(this.Description);
            this.DepartmentTab.Controls.Add(this.Abbreviation);
            this.DepartmentTab.Controls.Add(this.DepartmentName);
            this.DepartmentTab.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.DepartmentTab.Location = new System.Drawing.Point(4, 54);
            this.DepartmentTab.Name = "DepartmentTab";
            this.DepartmentTab.Padding = new System.Windows.Forms.Padding(3);
            this.DepartmentTab.Size = new System.Drawing.Size(1117, 519);
            this.DepartmentTab.TabIndex = 0;
            this.DepartmentTab.Text = "Department";
            // 
            // ResetButton
            // 
            this.ResetButton.BackColor = System.Drawing.Color.Cornsilk;
            this.ResetButton.Font = new System.Drawing.Font("Bodoni MT", 15.75F, System.Drawing.FontStyle.Bold);
            this.ResetButton.ForeColor = System.Drawing.Color.SeaGreen;
            this.ResetButton.Location = new System.Drawing.Point(375, 227);
            this.ResetButton.Name = "ResetButton";
            this.ResetButton.Size = new System.Drawing.Size(115, 50);
            this.ResetButton.TabIndex = 10;
            this.ResetButton.Text = "RESET";
            this.ResetButton.UseVisualStyleBackColor = false;
            // 
            // dgvDepartment
            // 
            this.dgvDepartment.BackgroundColor = System.Drawing.Color.AliceBlue;
            this.dgvDepartment.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.Raised;
            this.dgvDepartment.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            this.dgvDepartment.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvDepartment.Location = new System.Drawing.Point(517, 20);
            this.dgvDepartment.Name = "dgvDepartment";
            this.dgvDepartment.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvDepartment.Size = new System.Drawing.Size(600, 397);
            this.dgvDepartment.TabIndex = 9;
            this.dgvDepartment.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvDepartment_CellClick);
            // 
            // DeleteDeptBtn
            // 
            this.DeleteDeptBtn.BackColor = System.Drawing.Color.Red;
            this.DeleteDeptBtn.Font = new System.Drawing.Font("Bodoni MT", 15.75F, System.Drawing.FontStyle.Bold);
            this.DeleteDeptBtn.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.DeleteDeptBtn.Location = new System.Drawing.Point(254, 227);
            this.DeleteDeptBtn.Name = "DeleteDeptBtn";
            this.DeleteDeptBtn.Size = new System.Drawing.Size(115, 50);
            this.DeleteDeptBtn.TabIndex = 8;
            this.DeleteDeptBtn.Text = "DELETE";
            this.DeleteDeptBtn.UseVisualStyleBackColor = false;
            this.DeleteDeptBtn.Click += new System.EventHandler(this.DelDept);
            // 
            // UpdateDeptBtn
            // 
            this.UpdateDeptBtn.BackColor = System.Drawing.Color.Gold;
            this.UpdateDeptBtn.Font = new System.Drawing.Font("Bodoni MT", 15.75F, System.Drawing.FontStyle.Bold);
            this.UpdateDeptBtn.ForeColor = System.Drawing.Color.Sienna;
            this.UpdateDeptBtn.Location = new System.Drawing.Point(133, 227);
            this.UpdateDeptBtn.Name = "UpdateDeptBtn";
            this.UpdateDeptBtn.Size = new System.Drawing.Size(115, 50);
            this.UpdateDeptBtn.TabIndex = 7;
            this.UpdateDeptBtn.Text = "UPDATE";
            this.UpdateDeptBtn.UseVisualStyleBackColor = false;
            this.UpdateDeptBtn.Click += new System.EventHandler(this.UpdateDept_Click);
            // 
            // AddDeptBtn
            // 
            this.AddDeptBtn.BackColor = System.Drawing.Color.Green;
            this.AddDeptBtn.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.AddDeptBtn.FlatAppearance.BorderSize = 3;
            this.AddDeptBtn.Font = new System.Drawing.Font("Bodoni MT", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.AddDeptBtn.ForeColor = System.Drawing.Color.Lime;
            this.AddDeptBtn.Location = new System.Drawing.Point(12, 227);
            this.AddDeptBtn.Name = "AddDeptBtn";
            this.AddDeptBtn.Size = new System.Drawing.Size(115, 50);
            this.AddDeptBtn.TabIndex = 6;
            this.AddDeptBtn.Text = "ADD";
            this.AddDeptBtn.UseVisualStyleBackColor = false;
            this.AddDeptBtn.Click += new System.EventHandler(this.AddDept_Click);
            // 
            // DeptDesctxt
            // 
            this.DeptDesctxt.Font = new System.Drawing.Font("Calibri", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DeptDesctxt.Location = new System.Drawing.Point(179, 137);
            this.DeptDesctxt.Name = "DeptDesctxt";
            this.DeptDesctxt.Size = new System.Drawing.Size(252, 26);
            this.DeptDesctxt.TabIndex = 5;
            // 
            // DeptAbrtxt
            // 
            this.DeptAbrtxt.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.DeptAbrtxt.Font = new System.Drawing.Font("Calibri", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DeptAbrtxt.Location = new System.Drawing.Point(179, 85);
            this.DeptAbrtxt.Name = "DeptAbrtxt";
            this.DeptAbrtxt.Size = new System.Drawing.Size(175, 26);
            this.DeptAbrtxt.TabIndex = 4;
            // 
            // DeptNametxt
            // 
            this.DeptNametxt.Font = new System.Drawing.Font("Calibri", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DeptNametxt.Location = new System.Drawing.Point(179, 36);
            this.DeptNametxt.Name = "DeptNametxt";
            this.DeptNametxt.Size = new System.Drawing.Size(175, 26);
            this.DeptNametxt.TabIndex = 3;
            // 
            // Description
            // 
            this.Description.AutoSize = true;
            this.Description.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Description.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.Description.Location = new System.Drawing.Point(21, 137);
            this.Description.Name = "Description";
            this.Description.Size = new System.Drawing.Size(97, 19);
            this.Description.TabIndex = 2;
            this.Description.Text = "Description";
            // 
            // Abbreviation
            // 
            this.Abbreviation.AutoSize = true;
            this.Abbreviation.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Abbreviation.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.Abbreviation.Location = new System.Drawing.Point(21, 85);
            this.Abbreviation.Name = "Abbreviation";
            this.Abbreviation.Size = new System.Drawing.Size(106, 19);
            this.Abbreviation.TabIndex = 1;
            this.Abbreviation.Text = "Abbreviation";
            // 
            // DepartmentName
            // 
            this.DepartmentName.AutoSize = true;
            this.DepartmentName.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DepartmentName.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.DepartmentName.Location = new System.Drawing.Point(21, 36);
            this.DepartmentName.Name = "DepartmentName";
            this.DepartmentName.Size = new System.Drawing.Size(146, 19);
            this.DepartmentName.TabIndex = 0;
            this.DepartmentName.Text = "Department Name";
            // 
            // EmployeeTab
            // 
            this.EmployeeTab.BackColor = System.Drawing.Color.Gainsboro;
            this.EmployeeTab.Controls.Add(this.EditEmployeebtn);
            this.EmployeeTab.Controls.Add(this.ResetEmpBtn);
            this.EmployeeTab.Controls.Add(this.AddEmpBtn);
            this.EmployeeTab.Controls.Add(this.EmpDeptcombo);
            this.EmployeeTab.Controls.Add(this.EmpContact);
            this.EmployeeTab.Controls.Add(this.EmpAddresstxt);
            this.EmployeeTab.Controls.Add(this.EmpQualificationtxt);
            this.EmployeeTab.Controls.Add(this.EmpSurnametxt);
            this.EmployeeTab.Controls.Add(this.EmpNametxt);
            this.EmployeeTab.Controls.Add(this.Dept);
            this.EmployeeTab.Controls.Add(this.ContactNo);
            this.EmployeeTab.Controls.Add(this.Address);
            this.EmployeeTab.Controls.Add(this.Qualification);
            this.EmployeeTab.Controls.Add(this.Surname);
            this.EmployeeTab.Controls.Add(this.EmplyeeName);
            this.EmployeeTab.Font = new System.Drawing.Font("Calibri", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.EmployeeTab.Location = new System.Drawing.Point(4, 54);
            this.EmployeeTab.Name = "EmployeeTab";
            this.EmployeeTab.Padding = new System.Windows.Forms.Padding(3);
            this.EmployeeTab.Size = new System.Drawing.Size(1117, 519);
            this.EmployeeTab.TabIndex = 1;
            this.EmployeeTab.Text = "Employee";
            // 
            // ResetEmpBtn
            // 
            this.ResetEmpBtn.BackColor = System.Drawing.Color.Cornsilk;
            this.ResetEmpBtn.Font = new System.Drawing.Font("Bodoni MT", 15.75F, System.Drawing.FontStyle.Bold);
            this.ResetEmpBtn.ForeColor = System.Drawing.Color.SeaGreen;
            this.ResetEmpBtn.Location = new System.Drawing.Point(701, 276);
            this.ResetEmpBtn.Name = "ResetEmpBtn";
            this.ResetEmpBtn.Size = new System.Drawing.Size(192, 80);
            this.ResetEmpBtn.TabIndex = 15;
            this.ResetEmpBtn.Text = "RESET";
            this.ResetEmpBtn.UseVisualStyleBackColor = false;
            this.ResetEmpBtn.Click += new System.EventHandler(this.ResetEmpBtn_Click);
            // 
            // AddEmpBtn
            // 
            this.AddEmpBtn.BackColor = System.Drawing.Color.Green;
            this.AddEmpBtn.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.AddEmpBtn.FlatAppearance.BorderSize = 3;
            this.AddEmpBtn.Font = new System.Drawing.Font("Bodoni MT", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.AddEmpBtn.ForeColor = System.Drawing.Color.Lime;
            this.AddEmpBtn.Location = new System.Drawing.Point(701, 31);
            this.AddEmpBtn.Name = "AddEmpBtn";
            this.AddEmpBtn.Size = new System.Drawing.Size(192, 80);
            this.AddEmpBtn.TabIndex = 12;
            this.AddEmpBtn.Text = "ADD";
            this.AddEmpBtn.UseVisualStyleBackColor = false;
            this.AddEmpBtn.Click += new System.EventHandler(this.AddEmp_Click);
            // 
            // EmpDeptcombo
            // 
            this.EmpDeptcombo.Location = new System.Drawing.Point(254, 322);
            this.EmpDeptcombo.Name = "EmpDeptcombo";
            this.EmpDeptcombo.Size = new System.Drawing.Size(294, 34);
            this.EmpDeptcombo.TabIndex = 16;
            // 
            // EmpContact
            // 
            this.EmpContact.Location = new System.Drawing.Point(254, 273);
            this.EmpContact.Name = "EmpContact";
            this.EmpContact.Size = new System.Drawing.Size(294, 33);
            this.EmpContact.TabIndex = 10;
            // 
            // EmpAddresstxt
            // 
            this.EmpAddresstxt.Location = new System.Drawing.Point(254, 174);
            this.EmpAddresstxt.Multiline = true;
            this.EmpAddresstxt.Name = "EmpAddresstxt";
            this.EmpAddresstxt.Size = new System.Drawing.Size(294, 82);
            this.EmpAddresstxt.TabIndex = 9;
            // 
            // EmpQualificationtxt
            // 
            this.EmpQualificationtxt.Location = new System.Drawing.Point(254, 126);
            this.EmpQualificationtxt.Name = "EmpQualificationtxt";
            this.EmpQualificationtxt.Size = new System.Drawing.Size(294, 33);
            this.EmpQualificationtxt.TabIndex = 8;
            // 
            // EmpSurnametxt
            // 
            this.EmpSurnametxt.Location = new System.Drawing.Point(254, 78);
            this.EmpSurnametxt.Name = "EmpSurnametxt";
            this.EmpSurnametxt.Size = new System.Drawing.Size(193, 33);
            this.EmpSurnametxt.TabIndex = 7;
            // 
            // EmpNametxt
            // 
            this.EmpNametxt.Location = new System.Drawing.Point(254, 34);
            this.EmpNametxt.Name = "EmpNametxt";
            this.EmpNametxt.Size = new System.Drawing.Size(193, 33);
            this.EmpNametxt.TabIndex = 6;
            // 
            // Dept
            // 
            this.Dept.AutoSize = true;
            this.Dept.Location = new System.Drawing.Point(77, 322);
            this.Dept.Name = "Dept";
            this.Dept.Size = new System.Drawing.Size(115, 26);
            this.Dept.TabIndex = 5;
            this.Dept.Text = "Department";
            // 
            // ContactNo
            // 
            this.ContactNo.AutoSize = true;
            this.ContactNo.Location = new System.Drawing.Point(77, 274);
            this.ContactNo.Name = "ContactNo";
            this.ContactNo.Size = new System.Drawing.Size(116, 26);
            this.ContactNo.TabIndex = 4;
            this.ContactNo.Text = "Contact NO.";
            // 
            // Address
            // 
            this.Address.AutoSize = true;
            this.Address.Location = new System.Drawing.Point(77, 175);
            this.Address.Name = "Address";
            this.Address.Size = new System.Drawing.Size(79, 26);
            this.Address.TabIndex = 3;
            this.Address.Text = "Address";
            // 
            // Qualification
            // 
            this.Qualification.AutoSize = true;
            this.Qualification.Location = new System.Drawing.Point(77, 127);
            this.Qualification.Name = "Qualification";
            this.Qualification.Size = new System.Drawing.Size(121, 26);
            this.Qualification.TabIndex = 2;
            this.Qualification.Text = "Qualification";
            // 
            // Surname
            // 
            this.Surname.AutoSize = true;
            this.Surname.Location = new System.Drawing.Point(77, 79);
            this.Surname.Name = "Surname";
            this.Surname.Size = new System.Drawing.Size(88, 26);
            this.Surname.TabIndex = 1;
            this.Surname.Text = "Surname";
            // 
            // EmplyeeName
            // 
            this.EmplyeeName.AutoSize = true;
            this.EmplyeeName.Location = new System.Drawing.Point(77, 34);
            this.EmplyeeName.Name = "EmplyeeName";
            this.EmplyeeName.Size = new System.Drawing.Size(152, 26);
            this.EmplyeeName.TabIndex = 0;
            this.EmplyeeName.Text = "Employee Name";
            // 
            // ListEmployeeTab
            // 
            this.ListEmployeeTab.Controls.Add(this.dgvEmployeegrid);
            this.ListEmployeeTab.Controls.Add(this.EditEmpbtn);
            this.ListEmployeeTab.Location = new System.Drawing.Point(4, 54);
            this.ListEmployeeTab.Name = "ListEmployeeTab";
            this.ListEmployeeTab.Size = new System.Drawing.Size(1117, 519);
            this.ListEmployeeTab.TabIndex = 2;
            this.ListEmployeeTab.Text = "List Employee";
            this.ListEmployeeTab.UseVisualStyleBackColor = true;
            // 
            // dgvEmployeegrid
            // 
            this.dgvEmployeegrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvEmployeegrid.Location = new System.Drawing.Point(0, 0);
            this.dgvEmployeegrid.Name = "dgvEmployeegrid";
            this.dgvEmployeegrid.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvEmployeegrid.Size = new System.Drawing.Size(1019, 424);
            this.dgvEmployeegrid.TabIndex = 15;
            this.dgvEmployeegrid.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvEmployeegrid_CellClick);
            // 
            // EditEmpbtn
            // 
            this.EditEmpbtn.BackColor = System.Drawing.Color.Gold;
            this.EditEmpbtn.Font = new System.Drawing.Font("Bodoni MT", 15.75F, System.Drawing.FontStyle.Bold);
            this.EditEmpbtn.ForeColor = System.Drawing.Color.Maroon;
            this.EditEmpbtn.Location = new System.Drawing.Point(229, 439);
            this.EditEmpbtn.Name = "EditEmpbtn";
            this.EditEmpbtn.Size = new System.Drawing.Size(154, 68);
            this.EditEmpbtn.TabIndex = 14;
            this.EditEmpbtn.Text = "EDIT";
            this.EditEmpbtn.UseVisualStyleBackColor = false;
            this.EditEmpbtn.Click += new System.EventHandler(this.EditEmpbtn_Click);
            // 
            // EditEmployeebtn
            // 
            this.EditEmployeebtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.EditEmployeebtn.Font = new System.Drawing.Font("Bodoni MT", 15.75F, System.Drawing.FontStyle.Bold);
            this.EditEmployeebtn.ForeColor = System.Drawing.Color.Maroon;
            this.EditEmployeebtn.Location = new System.Drawing.Point(701, 150);
            this.EditEmployeebtn.Name = "EditEmployeebtn";
            this.EditEmployeebtn.Size = new System.Drawing.Size(192, 80);
            this.EditEmployeebtn.TabIndex = 17;
            this.EditEmployeebtn.Text = "EDIT";
            this.EditEmployeebtn.UseVisualStyleBackColor = false;
            this.EditEmployeebtn.Click += new System.EventHandler(this.EditEmpbtn_Click);
            // 
            // Employee
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1139, 610);
            this.Controls.Add(this.Department);
            this.Name = "Employee";
            this.Text = "Employee";
            this.Load += new System.EventHandler(this.Employee_Load);
            this.Department.ResumeLayout(false);
            this.DepartmentTab.ResumeLayout(false);
            this.DepartmentTab.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDepartment)).EndInit();
            this.EmployeeTab.ResumeLayout(false);
            this.EmployeeTab.PerformLayout();
            this.ListEmployeeTab.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvEmployeegrid)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl Department;
        private System.Windows.Forms.TabPage DepartmentTab;
        private System.Windows.Forms.TabPage EmployeeTab;
        private System.Windows.Forms.TabPage ListEmployeeTab;
        private System.Windows.Forms.Label DepartmentName;
        private System.Windows.Forms.Label Abbreviation;
        private System.Windows.Forms.Button DeleteDeptBtn;
        private System.Windows.Forms.Button UpdateDeptBtn;
        private System.Windows.Forms.Button AddDeptBtn;
        private System.Windows.Forms.TextBox DeptDesctxt;
        private System.Windows.Forms.TextBox DeptAbrtxt;
        private System.Windows.Forms.TextBox DeptNametxt;
        private System.Windows.Forms.Label Description;
        private System.Windows.Forms.Label Dept;
        private System.Windows.Forms.Label ContactNo;
        private System.Windows.Forms.Label Address;
        private System.Windows.Forms.Label Qualification;
        private System.Windows.Forms.Label Surname;
        private System.Windows.Forms.Label EmplyeeName;
        private System.Windows.Forms.Button AddEmpBtn;
        private System.Windows.Forms.Button EditEmpbtn;
        private System.Windows.Forms.DataGridView dgvDepartment;
        private System.Windows.Forms.Button ResetButton;
        private System.Windows.Forms.Button ResetEmpBtn;
        public System.Windows.Forms.TextBox EmpContact;
        public System.Windows.Forms.TextBox EmpAddresstxt;
        public System.Windows.Forms.TextBox EmpQualificationtxt;
        public System.Windows.Forms.TextBox EmpSurnametxt;
        public System.Windows.Forms.TextBox EmpNametxt;
        public System.Windows.Forms.DataGridView dgvEmployeegrid;
        public System.Windows.Forms.ComboBox EmpDeptcombo;
        private System.Windows.Forms.Button EditEmployeebtn;
    }
}

