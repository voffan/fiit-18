
namespace rental
{
    partial class Form1
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.b_Disks = new System.Windows.Forms.Button();
            this.b_Movies = new System.Windows.Forms.Button();
            this.b_Clients = new System.Windows.Forms.Button();
            this.b_Orders = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToResizeColumns = false;
            this.dataGridView1.AllowUserToResizeRows = false;
            this.dataGridView1.BackgroundColor = System.Drawing.SystemColors.ButtonShadow;
            this.dataGridView1.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Sunken;
            this.dataGridView1.Location = new System.Drawing.Point(143, 161);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.dataGridView1.Size = new System.Drawing.Size(645, 277);
            this.dataGridView1.TabIndex = 0;
            // 
            // b_Disks
            // 
            this.b_Disks.Location = new System.Drawing.Point(37, 190);
            this.b_Disks.Name = "b_Disks";
            this.b_Disks.Size = new System.Drawing.Size(75, 23);
            this.b_Disks.TabIndex = 6;
            this.b_Disks.Text = "Диски";
            this.b_Disks.Click += new System.EventHandler(this.b_Disks_Click);
            // 
            // b_Movies
            // 
            this.b_Movies.Location = new System.Drawing.Point(37, 219);
            this.b_Movies.Name = "b_Movies";
            this.b_Movies.Size = new System.Drawing.Size(75, 23);
            this.b_Movies.TabIndex = 5;
            this.b_Movies.Text = "Фильмы";
            this.b_Movies.Click += new System.EventHandler(this.b_Movies_Click);
            // 
            // b_Clients
            // 
            this.b_Clients.Location = new System.Drawing.Point(37, 248);
            this.b_Clients.Name = "b_Clients";
            this.b_Clients.Size = new System.Drawing.Size(75, 23);
            this.b_Clients.TabIndex = 4;
            this.b_Clients.Text = "Клиенты";
            this.b_Clients.UseVisualStyleBackColor = true;
            this.b_Clients.Click += new System.EventHandler(this.b_Clients_Click);
            // 
            // b_Orders
            // 
            this.b_Orders.Location = new System.Drawing.Point(37, 161);
            this.b_Orders.Name = "b_Orders";
            this.b_Orders.Size = new System.Drawing.Size(75, 23);
            this.b_Orders.TabIndex = 7;
            this.b_Orders.Text = "Заказы";
            this.b_Orders.UseVisualStyleBackColor = true;
            this.b_Orders.Click += new System.EventHandler(this.b_Orders_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(34, 36);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(49, 13);
            this.label1.TabIndex = 8;
            this.label1.Text = "App Title";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(143, 132);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 9;
            this.button1.Text = "AddClient";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(808, 458);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.b_Orders);
            this.Controls.Add(this.b_Clients);
            this.Controls.Add(this.b_Movies);
            this.Controls.Add(this.b_Disks);
            this.Controls.Add(this.dataGridView1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button b_Disks;
        private System.Windows.Forms.Button b_Movies;
        private System.Windows.Forms.Button b_Clients;
        private System.Windows.Forms.Button b_Orders;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button button1;
    }
}

