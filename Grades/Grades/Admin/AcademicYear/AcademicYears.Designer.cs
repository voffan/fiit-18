﻿
namespace Grades
{
    partial class AcademicYears
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
            this.components = new System.ComponentModel.Container();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.idDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.startDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.endDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.academicYearBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dBDataSet = new Grades.DBDataSet();
            this.academicYearTableAdapter = new Grades.DBDataSetTableAdapters.AcademicYearTableAdapter();
            this.Button3 = new System.Windows.Forms.Button();
            this.Button2 = new System.Windows.Forms.Button();
            this.Button1 = new System.Windows.Forms.Button();
            this.Button4 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.academicYearBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dBDataSet)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idDataGridViewTextBoxColumn,
            this.startDataGridViewTextBoxColumn,
            this.endDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.academicYearBindingSource;
            this.dataGridView1.Location = new System.Drawing.Point(33, 15);
            this.dataGridView1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.dataGridView1.MaximumSize = new System.Drawing.Size(457, 181);
            this.dataGridView1.MinimumSize = new System.Drawing.Size(457, 181);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.Size = new System.Drawing.Size(457, 181);
            this.dataGridView1.TabIndex = 0;
            this.dataGridView1.CellEndEdit += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellEndEdit);
            // 
            // idDataGridViewTextBoxColumn
            // 
            this.idDataGridViewTextBoxColumn.DataPropertyName = "Id";
            this.idDataGridViewTextBoxColumn.HeaderText = "Id";
            this.idDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.idDataGridViewTextBoxColumn.Name = "idDataGridViewTextBoxColumn";
            this.idDataGridViewTextBoxColumn.ReadOnly = true;
            this.idDataGridViewTextBoxColumn.Width = 50;
            // 
            // startDataGridViewTextBoxColumn
            // 
            this.startDataGridViewTextBoxColumn.DataPropertyName = "Start";
            this.startDataGridViewTextBoxColumn.HeaderText = "Start";
            this.startDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.startDataGridViewTextBoxColumn.Name = "startDataGridViewTextBoxColumn";
            this.startDataGridViewTextBoxColumn.Width = 125;
            // 
            // endDataGridViewTextBoxColumn
            // 
            this.endDataGridViewTextBoxColumn.DataPropertyName = "End";
            this.endDataGridViewTextBoxColumn.HeaderText = "End";
            this.endDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.endDataGridViewTextBoxColumn.Name = "endDataGridViewTextBoxColumn";
            this.endDataGridViewTextBoxColumn.Width = 125;
            // 
            // academicYearBindingSource
            // 
            this.academicYearBindingSource.DataMember = "AcademicYear";
            this.academicYearBindingSource.DataSource = this.dBDataSet;
            // 
            // dBDataSet
            // 
            this.dBDataSet.DataSetName = "DBDataSet";
            this.dBDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // academicYearTableAdapter
            // 
            this.academicYearTableAdapter.ClearBeforeFill = true;
            // 
            // Button3
            // 
            this.Button3.Location = new System.Drawing.Point(397, 215);
            this.Button3.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Button3.MaximumSize = new System.Drawing.Size(93, 42);
            this.Button3.MinimumSize = new System.Drawing.Size(93, 42);
            this.Button3.Name = "Button3";
            this.Button3.Size = new System.Drawing.Size(93, 42);
            this.Button3.TabIndex = 6;
            this.Button3.Text = "Закрыть";
            this.Button3.UseVisualStyleBackColor = true;
            this.Button3.Click += new System.EventHandler(this.Button3_Click);
            // 
            // Button2
            // 
            this.Button2.Location = new System.Drawing.Point(151, 215);
            this.Button2.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Button2.MaximumSize = new System.Drawing.Size(131, 42);
            this.Button2.MinimumSize = new System.Drawing.Size(131, 42);
            this.Button2.Name = "Button2";
            this.Button2.Size = new System.Drawing.Size(131, 42);
            this.Button2.TabIndex = 5;
            this.Button2.Text = "Редактировать";
            this.Button2.UseVisualStyleBackColor = true;
            this.Button2.Click += new System.EventHandler(this.Button2_Click);
            // 
            // Button1
            // 
            this.Button1.Location = new System.Drawing.Point(33, 215);
            this.Button1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Button1.MaximumSize = new System.Drawing.Size(109, 42);
            this.Button1.MinimumSize = new System.Drawing.Size(109, 42);
            this.Button1.Name = "Button1";
            this.Button1.Size = new System.Drawing.Size(109, 42);
            this.Button1.TabIndex = 4;
            this.Button1.Text = "Добавить";
            this.Button1.UseVisualStyleBackColor = true;
            this.Button1.Click += new System.EventHandler(this.Button1_Click);
            // 
            // Button4
            // 
            this.Button4.Location = new System.Drawing.Point(289, 215);
            this.Button4.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Button4.MaximumSize = new System.Drawing.Size(100, 42);
            this.Button4.MinimumSize = new System.Drawing.Size(100, 42);
            this.Button4.Name = "Button4";
            this.Button4.Size = new System.Drawing.Size(100, 42);
            this.Button4.TabIndex = 7;
            this.Button4.Text = "Удалить";
            this.Button4.UseVisualStyleBackColor = true;
            this.Button4.Click += new System.EventHandler(this.Button4_Click);
            // 
            // AcademicYears
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(532, 308);
            this.Controls.Add(this.Button4);
            this.Controls.Add(this.Button3);
            this.Controls.Add(this.Button2);
            this.Controls.Add(this.Button1);
            this.Controls.Add(this.dataGridView1);
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.MaximumSize = new System.Drawing.Size(550, 355);
            this.MinimumSize = new System.Drawing.Size(550, 355);
            this.Name = "AcademicYears";
            this.Text = "AcademicYears";
            this.Load += new System.EventHandler(this.AcademicYears_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.academicYearBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dBDataSet)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private DBDataSet dBDataSet;
        private System.Windows.Forms.BindingSource academicYearBindingSource;
        private DBDataSetTableAdapters.AcademicYearTableAdapter academicYearTableAdapter;
        private System.Windows.Forms.Button Button3;
        private System.Windows.Forms.Button Button2;
        private System.Windows.Forms.Button Button1;
        private System.Windows.Forms.Button Button4;
        private System.Windows.Forms.DataGridViewTextBoxColumn idDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn startDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn endDataGridViewTextBoxColumn;
    }
}