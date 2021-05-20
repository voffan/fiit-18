
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
            this.TextBox2 = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.TextBox3 = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.TextBox4 = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.TextBox5 = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.TextBox6 = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.TextBox7 = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.Button1 = new System.Windows.Forms.Button();
            this.Button2 = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.comboBoxSchool = new System.Windows.Forms.ComboBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
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
            // TextBox2
            // 
            this.TextBox2.Location = new System.Drawing.Point(199, 48);
            this.TextBox2.Margin = new System.Windows.Forms.Padding(4);
            this.TextBox2.Name = "TextBox2";
            this.TextBox2.Size = new System.Drawing.Size(244, 22);
            this.TextBox2.TabIndex = 10;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(63, 203);
            this.label9.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(52, 17);
            this.label9.TabIndex = 9;
            this.label9.Text = "Адрес:";
            // 
            // TextBox3
            // 
            this.TextBox3.Location = new System.Drawing.Point(199, 87);
            this.TextBox3.Margin = new System.Windows.Forms.Padding(4);
            this.TextBox3.Name = "TextBox3";
            this.TextBox3.Size = new System.Drawing.Size(244, 22);
            this.TextBox3.TabIndex = 11;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(60, 284);
            this.label8.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(85, 17);
            this.label8.TabIndex = 8;
            this.label8.Text = "Должность:";
            // 
            // TextBox4
            // 
            this.TextBox4.Location = new System.Drawing.Point(199, 124);
            this.TextBox4.Margin = new System.Windows.Forms.Padding(4);
            this.TextBox4.Name = "TextBox4";
            this.TextBox4.Size = new System.Drawing.Size(244, 22);
            this.TextBox4.TabIndex = 12;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(60, 165);
            this.label7.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(115, 17);
            this.label7.TabIndex = 7;
            this.label7.Text = "Дата рождения:";
            // 
            // TextBox5
            // 
            this.TextBox5.Location = new System.Drawing.Point(199, 161);
            this.TextBox5.Margin = new System.Windows.Forms.Padding(4);
            this.TextBox5.Name = "TextBox5";
            this.TextBox5.Size = new System.Drawing.Size(105, 22);
            this.TextBox5.TabIndex = 13;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(60, 246);
            this.label6.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(72, 17);
            this.label6.TabIndex = 6;
            this.label6.Text = "Телефон:";
            // 
            // TextBox6
            // 
            this.TextBox6.Location = new System.Drawing.Point(199, 199);
            this.TextBox6.Margin = new System.Windows.Forms.Padding(4);
            this.TextBox6.Name = "TextBox6";
            this.TextBox6.Size = new System.Drawing.Size(244, 22);
            this.TextBox6.TabIndex = 14;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(63, 124);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(75, 17);
            this.label5.TabIndex = 5;
            this.label5.Text = "Отчество:";
            // 
            // TextBox7
            // 
            this.TextBox7.Location = new System.Drawing.Point(199, 238);
            this.TextBox7.Margin = new System.Windows.Forms.Padding(4);
            this.TextBox7.Name = "TextBox7";
            this.TextBox7.Size = new System.Drawing.Size(188, 22);
            this.TextBox7.TabIndex = 15;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(60, 52);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(74, 17);
            this.label3.TabIndex = 4;
            this.label3.Text = "Фамилия:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(60, 91);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(39, 17);
            this.label4.TabIndex = 3;
            this.label4.Text = "Имя:";
            // 
            // Button1
            // 
            this.Button1.Location = new System.Drawing.Point(64, 347);
            this.Button1.Margin = new System.Windows.Forms.Padding(4);
            this.Button1.Name = "Button1";
            this.Button1.Size = new System.Drawing.Size(157, 36);
            this.Button1.TabIndex = 17;
            this.Button1.Text = "Добавить";
            this.Button1.UseVisualStyleBackColor = true;
            this.Button1.Click += new System.EventHandler(this.Button1_Click);
            // 
            // Button2
            // 
            this.Button2.Location = new System.Drawing.Point(287, 347);
            this.Button2.Margin = new System.Windows.Forms.Padding(4);
            this.Button2.Name = "Button2";
            this.Button2.Size = new System.Drawing.Size(157, 36);
            this.Button2.TabIndex = 18;
            this.Button2.Text = "Отмена";
            this.Button2.UseVisualStyleBackColor = true;
            this.Button2.Click += new System.EventHandler(this.Button2_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(63, 318);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(54, 17);
            this.label1.TabIndex = 19;
            this.label1.Text = "Школа:";
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(199, 277);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(121, 24);
            this.comboBox1.TabIndex = 21;
            // 
            // comboBoxSchool
            // 
            this.comboBoxSchool.FormattingEnabled = true;
            this.comboBoxSchool.Location = new System.Drawing.Point(199, 314);
            this.comboBoxSchool.Name = "comboBoxSchool";
            this.comboBoxSchool.Size = new System.Drawing.Size(121, 24);
            this.comboBoxSchool.TabIndex = 22;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.comboBoxSchool);
            this.groupBox1.Controls.Add(this.comboBox1);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.Button2);
            this.groupBox1.Controls.Add(this.Button1);
            this.groupBox1.Controls.Add(this.label4);
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
            this.groupBox1.Location = new System.Drawing.Point(16, 15);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(4);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(4);
            this.groupBox1.Size = new System.Drawing.Size(523, 390);
            this.groupBox1.TabIndex = 19;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Добавление нового сотрудника";
            // 
            // AddEmployee
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(560, 423);
            this.Controls.Add(this.groupBox1);
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.MaximumSize = new System.Drawing.Size(578, 470);
            this.MinimumSize = new System.Drawing.Size(578, 470);
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
        private System.Windows.Forms.TextBox TextBox2;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox TextBox3;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox TextBox4;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox TextBox5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox TextBox6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox TextBox7;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button Button1;
        private System.Windows.Forms.Button Button2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.ComboBox comboBoxSchool;
        private System.Windows.Forms.GroupBox groupBox1;
    }
}