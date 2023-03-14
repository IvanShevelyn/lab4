
using System.Windows.Forms;

namespace lab4
{
    partial class Form1
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
            this.addDepartment = new System.Windows.Forms.Button();
            this.departmentDataGridView = new System.Windows.Forms.DataGridView();
            this.workerDataGridView = new System.Windows.Forms.DataGridView();
            this.AddWorker = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.changeNameOfDepartment = new System.Windows.Forms.Button();
            this.deleteDepartment = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.deleteWorker = new System.Windows.Forms.Button();
            this.changeWorker = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.SortWorkersByName = new System.Windows.Forms.Button();
            this.ascendingNameCheckBox = new System.Windows.Forms.CheckBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.AscendingSalaryCheckBox = new System.Windows.Forms.CheckBox();
            this.SortWorkersBySalary = new System.Windows.Forms.Button();
            this.SaveData = new System.Windows.Forms.Button();
            this.LoadData = new System.Windows.Forms.Button();
            this.AllWorkersDataGridView = new System.Windows.Forms.DataGridView();
            this.label4 = new System.Windows.Forms.Label();
            this.panel3 = new System.Windows.Forms.Panel();
            this.SortWorkersByDepartment = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.departmentDataGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.workerDataGridView)).BeginInit();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.AllWorkersDataGridView)).BeginInit();
            this.panel3.SuspendLayout();
            this.SuspendLayout();
            // 
            // addDepartment
            // 
            this.addDepartment.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.addDepartment.Location = new System.Drawing.Point(243, 10);
            this.addDepartment.Name = "addDepartment";
            this.addDepartment.Size = new System.Drawing.Size(302, 55);
            this.addDepartment.TabIndex = 1;
            this.addDepartment.Text = "Add Department";
            this.addDepartment.UseVisualStyleBackColor = true;
            this.addDepartment.Click += new System.EventHandler(this.addDepartment_Click);
            // 
            // departmentDataGridView
            // 
            this.departmentDataGridView.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.departmentDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.departmentDataGridView.Location = new System.Drawing.Point(12, 32);
            this.departmentDataGridView.Name = "departmentDataGridView";
            this.departmentDataGridView.ReadOnly = true;
            this.departmentDataGridView.RowHeadersWidth = 62;
            this.departmentDataGridView.RowTemplate.Height = 28;
            this.departmentDataGridView.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.departmentDataGridView.Size = new System.Drawing.Size(564, 499);
            this.departmentDataGridView.TabIndex = 2;
            this.departmentDataGridView.CurrentCellChanged += new System.EventHandler(this.departmentDataGridView_CurrentCellChanged);
            // 
            // workerDataGridView
            // 
            this.workerDataGridView.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.workerDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.workerDataGridView.Location = new System.Drawing.Point(590, 32);
            this.workerDataGridView.Name = "workerDataGridView";
            this.workerDataGridView.ReadOnly = true;
            this.workerDataGridView.RowHeadersWidth = 62;
            this.workerDataGridView.RowTemplate.Height = 28;
            this.workerDataGridView.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.workerDataGridView.Size = new System.Drawing.Size(564, 499);
            this.workerDataGridView.TabIndex = 2;
            // 
            // AddWorker
            // 
            this.AddWorker.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.AddWorker.Location = new System.Drawing.Point(14, 10);
            this.AddWorker.Name = "AddWorker";
            this.AddWorker.Size = new System.Drawing.Size(532, 55);
            this.AddWorker.TabIndex = 3;
            this.AddWorker.Text = "Add worker to department";
            this.AddWorker.UseVisualStyleBackColor = true;
            this.AddWorker.Click += new System.EventHandler(this.AddWorker_Click);
            // 
            // panel1
            // 
            this.panel1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.panel1.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.changeNameOfDepartment);
            this.panel1.Controls.Add(this.deleteDepartment);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.addDepartment);
            this.panel1.Controls.Add(this.textBox1);
            this.panel1.Location = new System.Drawing.Point(13, 537);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(563, 141);
            this.panel1.TabIndex = 5;
            // 
            // changeNameOfDepartment
            // 
            this.changeNameOfDepartment.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.changeNameOfDepartment.Location = new System.Drawing.Point(11, 71);
            this.changeNameOfDepartment.Name = "changeNameOfDepartment";
            this.changeNameOfDepartment.Size = new System.Drawing.Size(216, 57);
            this.changeNameOfDepartment.TabIndex = 8;
            this.changeNameOfDepartment.Text = "Change name of the department";
            this.changeNameOfDepartment.UseVisualStyleBackColor = true;
            this.changeNameOfDepartment.Click += new System.EventHandler(this.changeNameOfDepartment_Click);
            // 
            // deleteDepartment
            // 
            this.deleteDepartment.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.deleteDepartment.Location = new System.Drawing.Point(243, 71);
            this.deleteDepartment.Name = "deleteDepartment";
            this.deleteDepartment.Size = new System.Drawing.Size(302, 57);
            this.deleteDepartment.TabIndex = 6;
            this.deleteDepartment.Text = "Delete department";
            this.deleteDepartment.UseVisualStyleBackColor = true;
            this.deleteDepartment.Click += new System.EventHandler(this.deleteDepartment_Click);
            // 
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(7, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(220, 20);
            this.label1.TabIndex = 5;
            this.label1.Text = "Enter the department\'s name:";
            // 
            // textBox1
            // 
            this.textBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.textBox1.Location = new System.Drawing.Point(11, 32);
            this.textBox1.Multiline = true;
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(216, 32);
            this.textBox1.TabIndex = 4;
            // 
            // label2
            // 
            this.label2.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(9, 9);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(164, 20);
            this.label2.TabIndex = 6;
            this.label2.Text = "Table of departments:";
            // 
            // deleteWorker
            // 
            this.deleteWorker.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.deleteWorker.Location = new System.Drawing.Point(288, 71);
            this.deleteWorker.Name = "deleteWorker";
            this.deleteWorker.Size = new System.Drawing.Size(258, 57);
            this.deleteWorker.TabIndex = 7;
            this.deleteWorker.Text = "Delete worker from department";
            this.deleteWorker.UseVisualStyleBackColor = true;
            this.deleteWorker.Click += new System.EventHandler(this.deleteWorker_Click);
            // 
            // changeWorker
            // 
            this.changeWorker.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.changeWorker.Location = new System.Drawing.Point(14, 71);
            this.changeWorker.Name = "changeWorker";
            this.changeWorker.Size = new System.Drawing.Size(258, 57);
            this.changeWorker.TabIndex = 9;
            this.changeWorker.Text = "Change worker information";
            this.changeWorker.UseVisualStyleBackColor = true;
            this.changeWorker.Click += new System.EventHandler(this.changeWorker_Click);
            // 
            // label3
            // 
            this.label3.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(586, 9);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(315, 20);
            this.label3.TabIndex = 7;
            this.label3.Text = "Table of workers from selected department:";
            // 
            // SortWorkersByName
            // 
            this.SortWorkersByName.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.SortWorkersByName.Location = new System.Drawing.Point(11, 10);
            this.SortWorkersByName.Name = "SortWorkersByName";
            this.SortWorkersByName.Size = new System.Drawing.Size(135, 55);
            this.SortWorkersByName.TabIndex = 10;
            this.SortWorkersByName.Text = "Sort by name";
            this.SortWorkersByName.UseVisualStyleBackColor = true;
            this.SortWorkersByName.Click += new System.EventHandler(this.SortWorkersByName_Click);
            // 
            // ascendingNameCheckBox
            // 
            this.ascendingNameCheckBox.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.ascendingNameCheckBox.AutoSize = true;
            this.ascendingNameCheckBox.Location = new System.Drawing.Point(152, 26);
            this.ascendingNameCheckBox.Name = "ascendingNameCheckBox";
            this.ascendingNameCheckBox.Size = new System.Drawing.Size(174, 24);
            this.ascendingNameCheckBox.TabIndex = 11;
            this.ascendingNameCheckBox.Text = "Ascending by name";
            this.ascendingNameCheckBox.UseVisualStyleBackColor = true;
            // 
            // panel2
            // 
            this.panel2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.panel2.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.panel2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel2.Controls.Add(this.changeWorker);
            this.panel2.Controls.Add(this.AddWorker);
            this.panel2.Controls.Add(this.deleteWorker);
            this.panel2.Location = new System.Drawing.Point(590, 537);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(564, 141);
            this.panel2.TabIndex = 12;
            // 
            // AscendingSalaryCheckBox
            // 
            this.AscendingSalaryCheckBox.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.AscendingSalaryCheckBox.AutoSize = true;
            this.AscendingSalaryCheckBox.Location = new System.Drawing.Point(152, 88);
            this.AscendingSalaryCheckBox.Name = "AscendingSalaryCheckBox";
            this.AscendingSalaryCheckBox.Size = new System.Drawing.Size(175, 24);
            this.AscendingSalaryCheckBox.TabIndex = 13;
            this.AscendingSalaryCheckBox.Text = "Ascending by salary";
            this.AscendingSalaryCheckBox.UseVisualStyleBackColor = true;
            // 
            // SortWorkersBySalary
            // 
            this.SortWorkersBySalary.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.SortWorkersBySalary.Location = new System.Drawing.Point(11, 71);
            this.SortWorkersBySalary.Name = "SortWorkersBySalary";
            this.SortWorkersBySalary.Size = new System.Drawing.Size(135, 57);
            this.SortWorkersBySalary.TabIndex = 12;
            this.SortWorkersBySalary.Text = "Sort by salary";
            this.SortWorkersBySalary.UseVisualStyleBackColor = true;
            this.SortWorkersBySalary.Click += new System.EventHandler(this.SortWorkersBySalary_Click);
            // 
            // SaveData
            // 
            this.SaveData.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.SaveData.Location = new System.Drawing.Point(363, 73);
            this.SaveData.Name = "SaveData";
            this.SaveData.Size = new System.Drawing.Size(181, 55);
            this.SaveData.TabIndex = 13;
            this.SaveData.Text = "Save data";
            this.SaveData.UseVisualStyleBackColor = true;
            this.SaveData.Click += new System.EventHandler(this.SaveData_Click);
            // 
            // LoadData
            // 
            this.LoadData.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.LoadData.Location = new System.Drawing.Point(560, 73);
            this.LoadData.Name = "LoadData";
            this.LoadData.Size = new System.Drawing.Size(168, 55);
            this.LoadData.TabIndex = 14;
            this.LoadData.Text = "Load data";
            this.LoadData.UseVisualStyleBackColor = true;
            this.LoadData.Click += new System.EventHandler(this.LoadData_Click);
            // 
            // AllWorkersDataGridView
            // 
            this.AllWorkersDataGridView.AllowUserToOrderColumns = true;
            this.AllWorkersDataGridView.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.AllWorkersDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.AllWorkersDataGridView.Enabled = false;
            this.AllWorkersDataGridView.Location = new System.Drawing.Point(1168, 32);
            this.AllWorkersDataGridView.Name = "AllWorkersDataGridView";
            this.AllWorkersDataGridView.RowHeadersWidth = 62;
            this.AllWorkersDataGridView.RowTemplate.Height = 28;
            this.AllWorkersDataGridView.Size = new System.Drawing.Size(744, 499);
            this.AllWorkersDataGridView.TabIndex = 15;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(1167, 9);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(148, 20);
            this.label4.TabIndex = 16;
            this.label4.Text = "Table of all workers:";
            // 
            // panel3
            // 
            this.panel3.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.panel3.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.panel3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel3.Controls.Add(this.SortWorkersByDepartment);
            this.panel3.Controls.Add(this.AscendingSalaryCheckBox);
            this.panel3.Controls.Add(this.SortWorkersBySalary);
            this.panel3.Controls.Add(this.LoadData);
            this.panel3.Controls.Add(this.ascendingNameCheckBox);
            this.panel3.Controls.Add(this.SortWorkersByName);
            this.panel3.Controls.Add(this.SaveData);
            this.panel3.Location = new System.Drawing.Point(1168, 537);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(744, 141);
            this.panel3.TabIndex = 17;
            // 
            // SortWorkersByDepartment
            // 
            this.SortWorkersByDepartment.Location = new System.Drawing.Point(363, 10);
            this.SortWorkersByDepartment.Name = "SortWorkersByDepartment";
            this.SortWorkersByDepartment.Size = new System.Drawing.Size(365, 55);
            this.SortWorkersByDepartment.TabIndex = 15;
            this.SortWorkersByDepartment.Text = "Sort by department";
            this.SortWorkersByDepartment.UseVisualStyleBackColor = true;
            this.SortWorkersByDepartment.Click += new System.EventHandler(this.SortWorkersByDepartment_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1924, 744);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.AllWorkersDataGridView);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.workerDataGridView);
            this.Controls.Add(this.departmentDataGridView);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Company Editor";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.departmentDataGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.workerDataGridView)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.AllWorkersDataGridView)).EndInit();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button addDepartment;
        private System.Windows.Forms.DataGridView departmentDataGridView;
        private System.Windows.Forms.DataGridView workerDataGridView;
        private System.Windows.Forms.Button AddWorker;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button deleteDepartment;
        private Button deleteWorker;
        private Button changeNameOfDepartment;
        private Button changeWorker;
        private Label label3;
        private Button SortWorkersByName;
        private CheckBox ascendingNameCheckBox;
        private Panel panel2;
        private CheckBox AscendingSalaryCheckBox;
        private Button SortWorkersBySalary;
        private Button SaveData;
        private Button LoadData;
        private DataGridView AllWorkersDataGridView;
        private Label label4;
        private Panel panel3;
        private Button SortWorkersByDepartment;
    }
}

