
namespace Grades
{
    partial class AddCheckPoint
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.TextBox1 = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.Button1 = new System.Windows.Forms.Button();
            this.Button2 = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.TextBox1);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(274, 135);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Добавление контрольной точки";
            // 
            // TextBox1
            // 
            this.TextBox1.Location = new System.Drawing.Point(115, 30);
            this.TextBox1.MaximumSize = new System.Drawing.Size(153, 20);
            this.TextBox1.MinimumSize = new System.Drawing.Size(153, 20);
            this.TextBox1.Name = "TextBox1";
            this.TextBox1.Size = new System.Drawing.Size(153, 20);
            this.TextBox1.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(12, 26);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(97, 24);
            this.label1.TabIndex = 1;
            this.label1.Text = "Название";
            // 
            // Button1
            // 
            this.Button1.Location = new System.Drawing.Point(12, 168);
            this.Button1.MaximumSize = new System.Drawing.Size(109, 33);
            this.Button1.MinimumSize = new System.Drawing.Size(109, 33);
            this.Button1.Name = "Button1";
            this.Button1.Size = new System.Drawing.Size(109, 33);
            this.Button1.TabIndex = 1;
            this.Button1.Text = "Добавить";
            this.Button1.UseVisualStyleBackColor = true;
            this.Button1.Click += new System.EventHandler(this.Button1_Click);
            // 
            // Button2
            // 
            this.Button2.Location = new System.Drawing.Point(171, 168);
            this.Button2.MaximumSize = new System.Drawing.Size(109, 33);
            this.Button2.MinimumSize = new System.Drawing.Size(109, 33);
            this.Button2.Name = "Button2";
            this.Button2.Size = new System.Drawing.Size(109, 33);
            this.Button2.TabIndex = 2;
            this.Button2.Text = "Отмена";
            this.Button2.UseVisualStyleBackColor = true;
            this.Button2.Click += new System.EventHandler(this.Button2_Click);
            // 
            // AddCheckPoint
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(316, 226);
            this.Controls.Add(this.Button2);
            this.Controls.Add(this.Button1);
            this.Controls.Add(this.groupBox1);
            this.MaximumSize = new System.Drawing.Size(332, 265);
            this.MinimumSize = new System.Drawing.Size(332, 265);
            this.Name = "AddCheckPoint";
            this.Text = "AddCheckPoint";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox TextBox1;
        private System.Windows.Forms.Button Button1;
        private System.Windows.Forms.Button Button2;
    }
}