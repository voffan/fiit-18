
namespace Grades
{
    partial class AddEmployee
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
            this.employeeBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dBDataSet = new Grades.DBDataSet();
            this.employeeTableAdapter = new Grades.DBDataSetTableAdapters.EmployeeTableAdapter();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.TextBox2 = new System.Windows.Forms.TextBox();
            this.TextBox3 = new System.Windows.Forms.TextBox();
            this.TextBox4 = new System.Windows.Forms.TextBox();
            this.TextBox5 = new System.Windows.Forms.TextBox();
            this.TextBox6 = new System.Windows.Forms.TextBox();
            this.TextBox7 = new System.Windows.Forms.TextBox();
            this.TextBox8 = new System.Windows.Forms.TextBox();
            this.Button1 = new System.Windows.Forms.Button();
            this.Button2 = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.TextBox1 = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.employeeBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dBDataSet)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // employeeBindingSource
            // 
            this.employeeBindingSource.DataMember = "Employee";
            this.employeeBindingSource.DataSource = this.dBDataSet;
            // 
            // dBDataSet
            // 
            this.dBDataSet.DataSetName = "DBDataSet";
            this.dBDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // employeeTableAdapter
            // 
            this.employeeTableAdapter.ClearBeforeFill = true;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(45, 74);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(32, 13);
            this.label4.TabIndex = 3;
            this.label4.Text = "Имя:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(45, 42);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(59, 13);
            this.label3.TabIndex = 4;
            this.label3.Text = "Фамилия:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(47, 101);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(57, 13);
            this.label5.TabIndex = 5;
            this.label5.Text = "Отчество:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(45, 200);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(55, 13);
            this.label6.TabIndex = 6;
            this.label6.Text = "Телефон:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(47, 129);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(89, 13);
            this.label7.TabIndex = 7;
            this.label7.Text = "Дата рождения:";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(45, 231);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(68, 13);
            this.label8.TabIndex = 8;
            this.label8.Text = "Должность:";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(47, 165);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(41, 13);
            this.label9.TabIndex = 9;
            this.label9.Text = "Адрес:";
            // 
            // TextBox2
            // 
            this.TextBox2.Location = new System.Drawing.Point(149, 39);
            this.TextBox2.Name = "TextBox2";
            this.TextBox2.Size = new System.Drawing.Size(184, 20);
            this.TextBox2.TabIndex = 10;
            // 
            // TextBox3
            // 
            this.TextBox3.Location = new System.Drawing.Point(149, 71);
            this.TextBox3.Name = "TextBox3";
            this.TextBox3.Size = new System.Drawing.Size(184, 20);
            this.TextBox3.TabIndex = 11;
            // 
            // TextBox4
            // 
            this.TextBox4.Location = new System.Drawing.Point(149, 101);
            this.TextBox4.Name = "TextBox4";
            this.TextBox4.Size = new System.Drawing.Size(184, 20);
            this.TextBox4.TabIndex = 12;
            // 
            // TextBox5
            // 
            this.TextBox5.Location = new System.Drawing.Point(149, 127);
            this.TextBox5.Name = "TextBox5";
            this.TextBox5.Size = new System.Drawing.Size(80, 20);
            this.TextBox5.TabIndex = 13;
            // 
            // TextBox6
            // 
            this.TextBox6.Location = new System.Drawing.Point(149, 162);
            this.TextBox6.Name = "TextBox6";
            this.TextBox6.Size = new System.Drawing.Size(184, 20);
            this.TextBox6.TabIndex = 14;
            // 
            // TextBox7
            // 
            this.TextBox7.Location = new System.Drawing.Point(149, 193);
            this.TextBox7.Name = "TextBox7";
            this.TextBox7.Size = new System.Drawing.Size(142, 20);
            this.TextBox7.TabIndex = 15;
            // 
            // TextBox8
            // 
            this.TextBox8.Location = new System.Drawing.Point(149, 224);
            this.TextBox8.Name = "TextBox8";
            this.TextBox8.Size = new System.Drawing.Size(142, 20);
            this.TextBox8.TabIndex = 16;
            // 
            // Button1
            // 
            this.Button1.Location = new System.Drawing.Point(81, 300);
            this.Button1.Name = "Button1";
            this.Button1.Size = new System.Drawing.Size(118, 29);
            this.Button1.TabIndex = 17;
            this.Button1.Text = "Добавить";
            this.Button1.UseVisualStyleBackColor = true;
            this.Button1.Click += new System.EventHandler(this.Button1_Click);
            // 
            // Button2
            // 
            this.Button2.Location = new System.Drawing.Point(231, 300);
            this.Button2.Name = "Button2";
            this.Button2.Size = new System.Drawing.Size(118, 29);
            this.Button2.TabIndex = 18;
            this.Button2.Text = "Отмена";
            this.Button2.UseVisualStyleBackColor = true;
            this.Button2.Click += new System.EventHandler(this.Button2_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.TextBox1);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.Button2);
            this.groupBox1.Controls.Add(this.Button1);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.TextBox8);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.TextBox7);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.TextBox6);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.TextBox5);
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Controls.Add(this.TextBox4);
            this.groupBox1.Controls.Add(this.label8);
            this.groupBox1.Controls.Add(this.TextBox3);
            this.groupBox1.Controls.Add(this.label9);
            this.groupBox1.Controls.Add(this.TextBox2);
            this.groupBox1.Location = new System.Drawing.Point(0, 0);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(411, 361);
            this.groupBox1.TabIndex = 19;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Добавление нового сотрудника";
            // 
            // TextBox1
            // 
            this.TextBox1.Location = new System.Drawing.Point(149, 255);
            this.TextBox1.Name = "TextBox1";
            this.TextBox1.Size = new System.Drawing.Size(142, 20);
            this.TextBox1.TabIndex = 20;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(47, 258);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(43, 13);
            this.label1.TabIndex = 19;
            this.label1.Text = "Школа:";
            // 
            // AddEmployee
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(404, 341);
            this.Controls.Add(this.groupBox1);
            this.MaximumSize = new System.Drawing.Size(420, 380);
            this.MinimumSize = new System.Drawing.Size(420, 380);
            this.Name = "AddEmployee";
            this.Text = "AddEmployee";
            this.Load += new System.EventHandler(this.AddEmployee_Load);
            ((System.ComponentModel.ISupportInitialize)(this.employeeBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dBDataSet)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private DBDataSet dBDataSet;
        private System.Windows.Forms.BindingSource employeeBindingSource;
        private DBDataSetTableAdapters.EmployeeTableAdapter employeeTableAdapter;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox TextBox2;
        private System.Windows.Forms.TextBox TextBox3;
        private System.Windows.Forms.TextBox TextBox4;
        private System.Windows.Forms.TextBox TextBox5;
        private System.Windows.Forms.TextBox TextBox6;
        private System.Windows.Forms.TextBox TextBox7;
        private System.Windows.Forms.TextBox TextBox8;
        private System.Windows.Forms.Button Button1;
        private System.Windows.Forms.Button Button2;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox TextBox1;
        private System.Windows.Forms.Label label1;
    }
}