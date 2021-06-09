
namespace Grades
{
    partial class StudentMenu
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
            this.buttonMarks = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // buttonMarks
            // 
            this.buttonMarks.Location = new System.Drawing.Point(174, 149);
            this.buttonMarks.Name = "buttonMarks";
            this.buttonMarks.Size = new System.Drawing.Size(478, 122);
            this.buttonMarks.TabIndex = 0;
            this.buttonMarks.Text = "Мои оценки";
            this.buttonMarks.UseVisualStyleBackColor = true;
            this.buttonMarks.Click += new System.EventHandler(this.buttonMarks_Click);
            // 
            // StudentMenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.buttonMarks);
            this.Name = "StudentMenu";
            this.Text = "StudentMenu";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button buttonMarks;
    }
}