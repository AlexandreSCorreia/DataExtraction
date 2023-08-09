
namespace DataExtraction
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.labelFilterValue = new System.Windows.Forms.Label();
            this.buttonClearFilter = new System.Windows.Forms.Button();
            this.buttonAddFilter = new System.Windows.Forms.Button();
            this.textBoxValueFilter = new System.Windows.Forms.TextBox();
            this.comboBoxOptions = new System.Windows.Forms.ComboBox();
            this.comboBoxColumns = new System.Windows.Forms.ComboBox();
            this.comboBoxAndOr = new System.Windows.Forms.ComboBox();
            this.labelFilter = new System.Windows.Forms.Label();
            this.comboBoxTableView = new System.Windows.Forms.ComboBox();
            this.labelTableOrView = new System.Windows.Forms.Label();
            this.comboBoxDataBaseName = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.buttonDirectory = new System.Windows.Forms.Button();
            this.labelDirectory = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.buttonStart = new System.Windows.Forms.Button();
            this.buttonCancel = new System.Windows.Forms.Button();
            this.buttonViewData = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.labelFilterValue);
            this.groupBox1.Controls.Add(this.buttonClearFilter);
            this.groupBox1.Controls.Add(this.buttonAddFilter);
            this.groupBox1.Controls.Add(this.textBoxValueFilter);
            this.groupBox1.Controls.Add(this.comboBoxOptions);
            this.groupBox1.Controls.Add(this.comboBoxColumns);
            this.groupBox1.Controls.Add(this.comboBoxAndOr);
            this.groupBox1.Controls.Add(this.labelFilter);
            this.groupBox1.Controls.Add(this.comboBoxTableView);
            this.groupBox1.Controls.Add(this.labelTableOrView);
            this.groupBox1.Controls.Add(this.comboBoxDataBaseName);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.buttonDirectory);
            this.groupBox1.Controls.Add(this.labelDirectory);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(521, 262);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Settings";
            // 
            // labelFilterValue
            // 
            this.labelFilterValue.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.labelFilterValue.Location = new System.Drawing.Point(25, 192);
            this.labelFilterValue.Name = "labelFilterValue";
            this.labelFilterValue.Size = new System.Drawing.Size(469, 52);
            this.labelFilterValue.TabIndex = 13;
            // 
            // buttonClearFilter
            // 
            this.buttonClearFilter.Location = new System.Drawing.Point(419, 166);
            this.buttonClearFilter.Name = "buttonClearFilter";
            this.buttonClearFilter.Size = new System.Drawing.Size(75, 23);
            this.buttonClearFilter.TabIndex = 12;
            this.buttonClearFilter.Text = "Clear";
            this.buttonClearFilter.UseVisualStyleBackColor = true;
            this.buttonClearFilter.Click += new System.EventHandler(this.buttonClearFilter_Click);
            // 
            // buttonAddFilter
            // 
            this.buttonAddFilter.Location = new System.Drawing.Point(338, 166);
            this.buttonAddFilter.Name = "buttonAddFilter";
            this.buttonAddFilter.Size = new System.Drawing.Size(75, 23);
            this.buttonAddFilter.TabIndex = 11;
            this.buttonAddFilter.Text = "Add";
            this.buttonAddFilter.UseVisualStyleBackColor = true;
            this.buttonAddFilter.Click += new System.EventHandler(this.buttonAddFilter_Click);
            // 
            // textBoxValueFilter
            // 
            this.textBoxValueFilter.Location = new System.Drawing.Point(314, 137);
            this.textBoxValueFilter.Name = "textBoxValueFilter";
            this.textBoxValueFilter.Size = new System.Drawing.Size(180, 20);
            this.textBoxValueFilter.TabIndex = 10;
            // 
            // comboBoxOptions
            // 
            this.comboBoxOptions.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxOptions.FormattingEnabled = true;
            this.comboBoxOptions.Location = new System.Drawing.Point(221, 137);
            this.comboBoxOptions.Name = "comboBoxOptions";
            this.comboBoxOptions.Size = new System.Drawing.Size(87, 21);
            this.comboBoxOptions.TabIndex = 9;
            // 
            // comboBoxColumns
            // 
            this.comboBoxColumns.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxColumns.FormattingEnabled = true;
            this.comboBoxColumns.Location = new System.Drawing.Point(97, 137);
            this.comboBoxColumns.Name = "comboBoxColumns";
            this.comboBoxColumns.Size = new System.Drawing.Size(118, 21);
            this.comboBoxColumns.TabIndex = 8;
            // 
            // comboBoxAndOr
            // 
            this.comboBoxAndOr.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxAndOr.FormattingEnabled = true;
            this.comboBoxAndOr.Location = new System.Drawing.Point(25, 137);
            this.comboBoxAndOr.Name = "comboBoxAndOr";
            this.comboBoxAndOr.Size = new System.Drawing.Size(66, 21);
            this.comboBoxAndOr.TabIndex = 7;
            // 
            // labelFilter
            // 
            this.labelFilter.AutoSize = true;
            this.labelFilter.Location = new System.Drawing.Point(22, 121);
            this.labelFilter.Name = "labelFilter";
            this.labelFilter.Size = new System.Drawing.Size(29, 13);
            this.labelFilter.TabIndex = 6;
            this.labelFilter.Text = "Filter";
            // 
            // comboBoxTableView
            // 
            this.comboBoxTableView.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxTableView.FormattingEnabled = true;
            this.comboBoxTableView.Location = new System.Drawing.Point(134, 82);
            this.comboBoxTableView.Name = "comboBoxTableView";
            this.comboBoxTableView.Size = new System.Drawing.Size(360, 21);
            this.comboBoxTableView.TabIndex = 5;
            this.comboBoxTableView.SelectedIndexChanged += new System.EventHandler(this.comboBoxTableView_SelectedIndexChanged);
            // 
            // labelTableOrView
            // 
            this.labelTableOrView.AutoSize = true;
            this.labelTableOrView.Location = new System.Drawing.Point(19, 82);
            this.labelTableOrView.Name = "labelTableOrView";
            this.labelTableOrView.Size = new System.Drawing.Size(62, 13);
            this.labelTableOrView.TabIndex = 4;
            this.labelTableOrView.Text = "Table/View";
            // 
            // comboBoxDataBaseName
            // 
            this.comboBoxDataBaseName.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxDataBaseName.FormattingEnabled = true;
            this.comboBoxDataBaseName.Location = new System.Drawing.Point(134, 55);
            this.comboBoxDataBaseName.Name = "comboBoxDataBaseName";
            this.comboBoxDataBaseName.Size = new System.Drawing.Size(360, 21);
            this.comboBoxDataBaseName.TabIndex = 3;
            this.comboBoxDataBaseName.SelectedIndexChanged += new System.EventHandler(this.comboBoxDataBaseName_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(19, 55);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(88, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "Data Base Name";
            // 
            // buttonDirectory
            // 
            this.buttonDirectory.Location = new System.Drawing.Point(373, 24);
            this.buttonDirectory.Name = "buttonDirectory";
            this.buttonDirectory.Size = new System.Drawing.Size(121, 23);
            this.buttonDirectory.TabIndex = 1;
            this.buttonDirectory.Text = "Select Directory";
            this.buttonDirectory.UseVisualStyleBackColor = true;
            this.buttonDirectory.Click += new System.EventHandler(this.buttonDirectory_Click);
            // 
            // labelDirectory
            // 
            this.labelDirectory.AutoSize = true;
            this.labelDirectory.Location = new System.Drawing.Point(22, 29);
            this.labelDirectory.Name = "labelDirectory";
            this.labelDirectory.Size = new System.Drawing.Size(0, 13);
            this.labelDirectory.TabIndex = 0;
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(12, 312);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.Size = new System.Drawing.Size(521, 166);
            this.dataGridView1.TabIndex = 1;
            // 
            // buttonStart
            // 
            this.buttonStart.Location = new System.Drawing.Point(350, 494);
            this.buttonStart.Name = "buttonStart";
            this.buttonStart.Size = new System.Drawing.Size(102, 23);
            this.buttonStart.TabIndex = 2;
            this.buttonStart.Text = "Start Extraction";
            this.buttonStart.UseVisualStyleBackColor = true;
            this.buttonStart.Click += new System.EventHandler(this.buttonStart_Click);
            // 
            // buttonCancel
            // 
            this.buttonCancel.Location = new System.Drawing.Point(458, 494);
            this.buttonCancel.Name = "buttonCancel";
            this.buttonCancel.Size = new System.Drawing.Size(75, 23);
            this.buttonCancel.TabIndex = 3;
            this.buttonCancel.Text = "Cancel";
            this.buttonCancel.UseVisualStyleBackColor = true;
            this.buttonCancel.Click += new System.EventHandler(this.buttonCancel_Click);
            // 
            // buttonViewData
            // 
            this.buttonViewData.Location = new System.Drawing.Point(12, 283);
            this.buttonViewData.Name = "buttonViewData";
            this.buttonViewData.Size = new System.Drawing.Size(75, 23);
            this.buttonViewData.TabIndex = 4;
            this.buttonViewData.Text = "View Data";
            this.buttonViewData.UseVisualStyleBackColor = true;
            this.buttonViewData.Click += new System.EventHandler(this.buttonViewData_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(546, 529);
            this.Controls.Add(this.buttonViewData);
            this.Controls.Add(this.buttonCancel);
            this.Controls.Add(this.buttonStart);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.groupBox1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "DataExtraction";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label labelFilterValue;
        private System.Windows.Forms.Button buttonClearFilter;
        private System.Windows.Forms.Button buttonAddFilter;
        private System.Windows.Forms.TextBox textBoxValueFilter;
        private System.Windows.Forms.ComboBox comboBoxOptions;
        private System.Windows.Forms.ComboBox comboBoxColumns;
        private System.Windows.Forms.ComboBox comboBoxAndOr;
        private System.Windows.Forms.Label labelFilter;
        private System.Windows.Forms.ComboBox comboBoxTableView;
        private System.Windows.Forms.Label labelTableOrView;
        private System.Windows.Forms.ComboBox comboBoxDataBaseName;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button buttonDirectory;
        private System.Windows.Forms.Label labelDirectory;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button buttonStart;
        private System.Windows.Forms.Button buttonCancel;
        private System.Windows.Forms.Button buttonViewData;
    }
}

