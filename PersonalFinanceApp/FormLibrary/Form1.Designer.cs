using PersonalFinanceApp.ClassLibrary;

namespace PersonalFinanceApp
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.btnAddT = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.lblNetPeriod = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.lblNetworth = new System.Windows.Forms.Label();
            this.lblName = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txtCreateProfile = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.dateTimePickerFrom = new System.Windows.Forms.DateTimePicker();
            this.dateTimePickerTo = new System.Windows.Forms.DateTimePicker();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.btnResetPeriod = new System.Windows.Forms.Button();
            this.btnSortPeriod = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.btnRemoveTransaction = new System.Windows.Forms.Button();
            this.cmbboxSrtCategory = new System.Windows.Forms.ComboBox();
            this.btnSortCategory = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.btnEditT = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.tCompNameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tDateDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tAmountDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tCategoryDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tDescriptionDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.transactionBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.btnShowCompDetails = new System.Windows.Forms.Button();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.transactionBindingSource)).BeginInit();
            this.groupBox3.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnAddT
            // 
            this.btnAddT.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnAddT.Location = new System.Drawing.Point(230, 189);
            this.btnAddT.Name = "btnAddT";
            this.btnAddT.Size = new System.Drawing.Size(107, 51);
            this.btnAddT.TabIndex = 1;
            this.btnAddT.Text = "Add transaction";
            this.btnAddT.UseVisualStyleBackColor = true;
            this.btnAddT.Click += new System.EventHandler(this.btnAddT_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.lblNetPeriod);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.lblNetworth);
            this.groupBox1.Controls.Add(this.lblName);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.txtCreateProfile);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.groupBox1.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(475, 157);
            this.groupBox1.TabIndex = 2;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "👤Account Info";
            // 
            // lblNetPeriod
            // 
            this.lblNetPeriod.AutoSize = true;
            this.lblNetPeriod.BackColor = System.Drawing.SystemColors.ControlLight;
            this.lblNetPeriod.Font = new System.Drawing.Font("Segoe UI Semibold", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblNetPeriod.Location = new System.Drawing.Point(352, 110);
            this.lblNetPeriod.Name = "lblNetPeriod";
            this.lblNetPeriod.Size = new System.Drawing.Size(14, 23);
            this.lblNetPeriod.TabIndex = 7;
            this.lblNetPeriod.Text = ".";
          
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI Semibold", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label2.Location = new System.Drawing.Point(15, 111);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(331, 23);
            this.label2.TabIndex = 6;
            this.label2.Text = "Change corresponding to sorting criterias:";
            // 
            // lblNetworth
            // 
            this.lblNetworth.AutoSize = true;
            this.lblNetworth.BackColor = System.Drawing.SystemColors.ControlLight;
            this.lblNetworth.Font = new System.Drawing.Font("Segoe UI Semibold", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblNetworth.Location = new System.Drawing.Point(154, 77);
            this.lblNetworth.Name = "lblNetworth";
            this.lblNetworth.Size = new System.Drawing.Size(14, 23);
            this.lblNetworth.TabIndex = 5;
            this.lblNetworth.Text = ".";
            // 
            // lblName
            // 
            this.lblName.AutoSize = true;
            this.lblName.BackColor = System.Drawing.SystemColors.ControlLight;
            this.lblName.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.lblName.Font = new System.Drawing.Font("Segoe UI Semibold", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblName.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.lblName.Location = new System.Drawing.Point(110, 43);
            this.lblName.Name = "lblName";
            this.lblName.Size = new System.Drawing.Size(14, 23);
            this.lblName.TabIndex = 3;
            this.lblName.Text = ".";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI Semibold", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label3.Location = new System.Drawing.Point(15, 77);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(133, 23);
            this.label3.TabIndex = 2;
            this.label3.Text = "All time change:";
            // 
            // txtCreateProfile
            // 
            this.txtCreateProfile.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.txtCreateProfile.Location = new System.Drawing.Point(369, 15);
            this.txtCreateProfile.Name = "txtCreateProfile";
            this.txtCreateProfile.Size = new System.Drawing.Size(100, 51);
            this.txtCreateProfile.TabIndex = 7;
            this.txtCreateProfile.Text = "Edit profile";
            this.txtCreateProfile.UseVisualStyleBackColor = true;
            this.txtCreateProfile.Click += new System.EventHandler(this.txtCreateProfile_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI Semibold", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(15, 43);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(89, 23);
            this.label1.TabIndex = 0;
            this.label1.Text = "Full name:";
            // 
            // dateTimePickerFrom
            // 
            this.dateTimePickerFrom.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.dateTimePickerFrom.Location = new System.Drawing.Point(76, 39);
            this.dateTimePickerFrom.Name = "dateTimePickerFrom";
            this.dateTimePickerFrom.Size = new System.Drawing.Size(300, 27);
            this.dateTimePickerFrom.TabIndex = 3;
           
            // 
            // dateTimePickerTo
            // 
            this.dateTimePickerTo.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.dateTimePickerTo.Location = new System.Drawing.Point(76, 72);
            this.dateTimePickerTo.Name = "dateTimePickerTo";
            this.dateTimePickerTo.Size = new System.Drawing.Size(300, 27);
            this.dateTimePickerTo.TabIndex = 4;
          
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.btnResetPeriod);
            this.groupBox2.Controls.Add(this.btnSortPeriod);
            this.groupBox2.Controls.Add(this.label5);
            this.groupBox2.Controls.Add(this.label4);
            this.groupBox2.Controls.Add(this.dateTimePickerFrom);
            this.groupBox2.Controls.Add(this.dateTimePickerTo);
            this.groupBox2.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.groupBox2.Location = new System.Drawing.Point(493, 12);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(403, 157);
            this.groupBox2.TabIndex = 5;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "🗓Sort by date";
            // 
            // btnResetPeriod
            // 
            this.btnResetPeriod.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnResetPeriod.Location = new System.Drawing.Point(227, 110);
            this.btnResetPeriod.Name = "btnResetPeriod";
            this.btnResetPeriod.Size = new System.Drawing.Size(170, 37);
            this.btnResetPeriod.TabIndex = 7;
            this.btnResetPeriod.Text = "Reset";
            this.btnResetPeriod.UseVisualStyleBackColor = true;
            this.btnResetPeriod.Click += new System.EventHandler(this.btnResetPeriod_Click);
            // 
            // btnSortPeriod
            // 
            this.btnSortPeriod.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnSortPeriod.Location = new System.Drawing.Point(16, 110);
            this.btnSortPeriod.Name = "btnSortPeriod";
            this.btnSortPeriod.Size = new System.Drawing.Size(170, 37);
            this.btnSortPeriod.TabIndex = 6;
            this.btnSortPeriod.Text = "Sort";
            this.btnSortPeriod.UseVisualStyleBackColor = true;
            this.btnSortPeriod.Click += new System.EventHandler(this.btnSortPeriod_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Segoe UI Semibold", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label5.Location = new System.Drawing.Point(16, 76);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(31, 23);
            this.label5.TabIndex = 5;
            this.label5.Text = "To:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Segoe UI Semibold", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label4.Location = new System.Drawing.Point(16, 43);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(54, 23);
            this.label4.TabIndex = 3;
            this.label4.Text = "From:";
            // 
            // btnRemoveTransaction
            // 
            this.btnRemoveTransaction.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnRemoveTransaction.Location = new System.Drawing.Point(121, 189);
            this.btnRemoveTransaction.Name = "btnRemoveTransaction";
            this.btnRemoveTransaction.Size = new System.Drawing.Size(107, 51);
            this.btnRemoveTransaction.TabIndex = 9;
            this.btnRemoveTransaction.Text = "Remove transaction";
            this.btnRemoveTransaction.UseVisualStyleBackColor = true;
            this.btnRemoveTransaction.Click += new System.EventHandler(this.btnRemoveTransaction_Click);
            // 
            // cmbboxSrtCategory
            // 
            this.cmbboxSrtCategory.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.cmbboxSrtCategory.FormattingEnabled = true;
            this.cmbboxSrtCategory.Location = new System.Drawing.Point(16, 26);
            this.cmbboxSrtCategory.Name = "cmbboxSrtCategory";
            this.cmbboxSrtCategory.Size = new System.Drawing.Size(173, 28);
            this.cmbboxSrtCategory.TabIndex = 10;
            // 
            // btnSortCategory
            // 
            this.btnSortCategory.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnSortCategory.Location = new System.Drawing.Point(201, 26);
            this.btnSortCategory.Name = "btnSortCategory";
            this.btnSortCategory.Size = new System.Drawing.Size(95, 31);
            this.btnSortCategory.TabIndex = 11;
            this.btnSortCategory.Text = "Sort";
            this.btnSortCategory.UseVisualStyleBackColor = true;
            this.btnSortCategory.Click += new System.EventHandler(this.btnSortCategory_Click);
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.button1.Location = new System.Drawing.Point(302, 26);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(95, 31);
            this.button1.TabIndex = 8;
            this.button1.Text = "Reset";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.btnResetPeriod_Click);
            // 
            // btnEditT
            // 
            this.btnEditT.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnEditT.Location = new System.Drawing.Point(12, 189);
            this.btnEditT.Name = "btnEditT";
            this.btnEditT.Size = new System.Drawing.Size(107, 51);
            this.btnEditT.TabIndex = 12;
            this.btnEditT.Text = "Edit transaction";
            this.btnEditT.UseVisualStyleBackColor = true;
            this.btnEditT.Click += new System.EventHandler(this.btnEditT_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToResizeColumns = false;
            this.dataGridView1.AllowUserToResizeRows = false;
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.tCompNameDataGridViewTextBoxColumn,
            this.tDateDataGridViewTextBoxColumn,
            this.tAmountDataGridViewTextBoxColumn,
            this.tCategoryDataGridViewTextBoxColumn,
            this.tDescriptionDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.transactionBindingSource;
            this.dataGridView1.Location = new System.Drawing.Point(12, 243);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 29;
            this.dataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView1.Size = new System.Drawing.Size(884, 289);
            this.dataGridView1.TabIndex = 13;
            // 
            // tCompNameDataGridViewTextBoxColumn
            // 
            this.tCompNameDataGridViewTextBoxColumn.DataPropertyName = "TCompName";
            this.tCompNameDataGridViewTextBoxColumn.HeaderText = "Company name";
            this.tCompNameDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.tCompNameDataGridViewTextBoxColumn.Name = "tCompNameDataGridViewTextBoxColumn";
            this.tCompNameDataGridViewTextBoxColumn.ReadOnly = true;
            this.tCompNameDataGridViewTextBoxColumn.Width = 160;
            // 
            // tDateDataGridViewTextBoxColumn
            // 
            this.tDateDataGridViewTextBoxColumn.DataPropertyName = "TDate";
            this.tDateDataGridViewTextBoxColumn.HeaderText = "Date";
            this.tDateDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.tDateDataGridViewTextBoxColumn.Name = "tDateDataGridViewTextBoxColumn";
            this.tDateDataGridViewTextBoxColumn.ReadOnly = true;
            this.tDateDataGridViewTextBoxColumn.Width = 160;
            // 
            // tAmountDataGridViewTextBoxColumn
            // 
            this.tAmountDataGridViewTextBoxColumn.DataPropertyName = "TAmount";
            this.tAmountDataGridViewTextBoxColumn.HeaderText = "Amount";
            this.tAmountDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.tAmountDataGridViewTextBoxColumn.Name = "tAmountDataGridViewTextBoxColumn";
            this.tAmountDataGridViewTextBoxColumn.ReadOnly = true;
            this.tAmountDataGridViewTextBoxColumn.Width = 160;
            // 
            // tCategoryDataGridViewTextBoxColumn
            // 
            this.tCategoryDataGridViewTextBoxColumn.DataPropertyName = "TCategory";
            this.tCategoryDataGridViewTextBoxColumn.HeaderText = "Category";
            this.tCategoryDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.tCategoryDataGridViewTextBoxColumn.Name = "tCategoryDataGridViewTextBoxColumn";
            this.tCategoryDataGridViewTextBoxColumn.ReadOnly = true;
            this.tCategoryDataGridViewTextBoxColumn.Width = 160;
            // 
            // tDescriptionDataGridViewTextBoxColumn
            // 
            this.tDescriptionDataGridViewTextBoxColumn.DataPropertyName = "TDescription";
            this.tDescriptionDataGridViewTextBoxColumn.HeaderText = "Description";
            this.tDescriptionDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.tDescriptionDataGridViewTextBoxColumn.Name = "tDescriptionDataGridViewTextBoxColumn";
            this.tDescriptionDataGridViewTextBoxColumn.ReadOnly = true;
            this.tDescriptionDataGridViewTextBoxColumn.Width = 190;
            // 
            // transactionBindingSource
            // 
            this.transactionBindingSource.DataSource = typeof(Transaction);
            // 
            // btnShowCompDetails
            // 
            this.btnShowCompDetails.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnShowCompDetails.Location = new System.Drawing.Point(393, 189);
            this.btnShowCompDetails.Name = "btnShowCompDetails";
            this.btnShowCompDetails.Size = new System.Drawing.Size(94, 51);
            this.btnShowCompDetails.TabIndex = 8;
            this.btnShowCompDetails.Text = "Company details";
            this.btnShowCompDetails.UseVisualStyleBackColor = true;
            this.btnShowCompDetails.Click += new System.EventHandler(this.btnShowCompDetails_Click);
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.cmbboxSrtCategory);
            this.groupBox3.Controls.Add(this.btnSortCategory);
            this.groupBox3.Controls.Add(this.button1);
            this.groupBox3.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.groupBox3.Location = new System.Drawing.Point(493, 168);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(403, 69);
            this.groupBox3.TabIndex = 14;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "📂Sort by category";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.ClientSize = new System.Drawing.Size(907, 544);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.btnShowCompDetails);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.btnEditT);
            this.Controls.Add(this.btnRemoveTransaction);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.btnAddT);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Financial management app";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.transactionBindingSource)).EndInit();
            this.groupBox3.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        private Button btnAddT;
        private GroupBox groupBox1;
        private Label label3;
        private DateTimePicker dateTimePickerFrom;
        private DateTimePicker dateTimePickerTo;
        private GroupBox groupBox2;
        private Label label5;
        private Label label4;
        private Button btnSortPeriod;
        private Label lblNetworth;
        private Label lblName;
        private Label label1;
        private Button txtCreateProfile;
        private Label lblNetPeriod;
        private Label label2;
        private DataGridViewTextBoxColumn dateDataGridViewTextBoxColumn;
        private Button btnRemoveTransaction;
        private DataGridViewTextBoxColumn tNameDataGridViewTextBoxColumn;
        private Button btnResetPeriod;
        private ComboBox cmbboxSrtCategory;
        private Button btnSortCategory;
        private Button button1;
        private Button btnEditT;
        private DataGridView dataGridView1;
        private BindingSource transactionBindingSource;
        private DataGridViewTextBoxColumn tCompNameDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn tDateDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn tAmountDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn tCategoryDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn tDescriptionDataGridViewTextBoxColumn;
        private Button btnShowCompDetails;
        private GroupBox groupBox3;
    }

   
}