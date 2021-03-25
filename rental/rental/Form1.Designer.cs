
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
            this.AppTitle = new System.Windows.Forms.Label();
            this.b_Add = new System.Windows.Forms.Button();
            this.b_Edit = new System.Windows.Forms.Button();
            this.b_Delete = new System.Windows.Forms.Button();
            this.b_Rental = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToResizeColumns = false;
            this.dataGridView1.AllowUserToResizeRows = false;
            this.dataGridView1.BackgroundColor = System.Drawing.SystemColors.ButtonShadow;
            this.dataGridView1.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Sunken;
            this.dataGridView1.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.dataGridView1.Location = new System.Drawing.Point(126, 36);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.dataGridView1.Size = new System.Drawing.Size(645, 277);
            this.dataGridView1.TabIndex = 0;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);


            // 
            // b_Disks
            // 
            this.b_Disks.BackColor = System.Drawing.Color.White;
            this.b_Disks.Location = new System.Drawing.Point(24, 37);
            this.b_Disks.Name = "b_Disks";
            this.b_Disks.Size = new System.Drawing.Size(85, 37);
            this.b_Disks.TabIndex = 6;
            this.b_Disks.Text = "Диски";
            this.b_Disks.UseVisualStyleBackColor = false;
            this.b_Disks.Click += new System.EventHandler(this.b_Disks_Click);
            // 
            // b_Movies
            // 
            this.b_Movies.BackColor = System.Drawing.Color.White;
            this.b_Movies.Location = new System.Drawing.Point(24, 80);
            this.b_Movies.Name = "b_Movies";
            this.b_Movies.Size = new System.Drawing.Size(85, 37);
            this.b_Movies.TabIndex = 5;
            this.b_Movies.Text = "Фильмы";
            this.b_Movies.UseVisualStyleBackColor = false;
            this.b_Movies.Click += new System.EventHandler(this.b_Movies_Click);
            // 
            // b_Clients
            // 
            this.b_Clients.BackColor = System.Drawing.Color.White;
            this.b_Clients.Location = new System.Drawing.Point(24, 123);
            this.b_Clients.Name = "b_Clients";
            this.b_Clients.Size = new System.Drawing.Size(85, 37);
            this.b_Clients.TabIndex = 4;
            this.b_Clients.Text = "Клиенты";
            this.b_Clients.UseVisualStyleBackColor = false;
            this.b_Clients.Click += new System.EventHandler(this.b_Clients_Click);
            // 
            // b_Orders
            // 
            this.b_Orders.BackColor = System.Drawing.Color.White;
            this.b_Orders.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.b_Orders.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.b_Orders.FlatAppearance.BorderSize = 5;
            this.b_Orders.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.b_Orders.Location = new System.Drawing.Point(24, 166);
            this.b_Orders.Name = "b_Orders";
            this.b_Orders.Size = new System.Drawing.Size(85, 37);
            this.b_Orders.TabIndex = 7;
            this.b_Orders.Text = "Заказы";
            this.b_Orders.UseVisualStyleBackColor = false;
            this.b_Orders.Click += new System.EventHandler(this.b_Orders_Click);
            // 
            // AppTitle
            // 
            this.AppTitle.AutoSize = true;
            this.AppTitle.Location = new System.Drawing.Point(733, 12);
            this.AppTitle.Name = "AppTitle";
            this.AppTitle.Size = new System.Drawing.Size(38, 13);
            this.AppTitle.TabIndex = 8;
            this.AppTitle.Text = "Rental";
            // 
            // b_Add
            // 
            this.b_Add.Location = new System.Drawing.Point(126, 7);
            this.b_Add.Name = "b_Add";
            this.b_Add.Size = new System.Drawing.Size(75, 23);
            this.b_Add.TabIndex = 9;
            this.b_Add.Text = "Add";
            this.b_Add.UseVisualStyleBackColor = true;
            this.b_Add.Click += new System.EventHandler(this.b_Add_Click);
            // 
            // b_Edit
            // 
            this.b_Edit.Location = new System.Drawing.Point(207, 7);
            this.b_Edit.Name = "b_Edit";
            this.b_Edit.Size = new System.Drawing.Size(75, 23);
            this.b_Edit.TabIndex = 10;
            this.b_Edit.Text = "Edit";
            this.b_Edit.UseVisualStyleBackColor = true;
            this.b_Edit.Click += new System.EventHandler(this.b_Edit_Click);
            // 
            // b_Delete
            // 
            this.b_Delete.Location = new System.Drawing.Point(288, 7);
            this.b_Delete.Name = "b_Delete";
            this.b_Delete.Size = new System.Drawing.Size(75, 23);
            this.b_Delete.TabIndex = 11;
            this.b_Delete.Text = "Delete";
            this.b_Delete.UseVisualStyleBackColor = true;
            this.b_Delete.Click += new System.EventHandler(this.b_Delete_Click);
            // 
            // b_Rental
            // 
            this.b_Rental.BackColor = System.Drawing.Color.White;
            this.b_Rental.Location = new System.Drawing.Point(24, 209);
            this.b_Rental.Name = "b_Rental";
            this.b_Rental.Size = new System.Drawing.Size(85, 37);
            this.b_Rental.TabIndex = 12;
            this.b_Rental.Text = "Rental";
            this.b_Rental.UseVisualStyleBackColor = false;
            this.b_Rental.Click += new System.EventHandler(this.b_Rental_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(40, 12);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(52, 13);
            this.label1.TabIndex = 13;
            this.label1.Text = "Таблицы";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Silver;
            this.ClientSize = new System.Drawing.Size(803, 339);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.b_Rental);
            this.Controls.Add(this.b_Delete);
            this.Controls.Add(this.b_Edit);
            this.Controls.Add(this.b_Add);
            this.Controls.Add(this.AppTitle);
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
        private System.Windows.Forms.Label AppTitle;
        private System.Windows.Forms.Button b_Add;
        private System.Windows.Forms.Button b_Edit;
        private System.Windows.Forms.Button b_Delete;
        private System.Windows.Forms.Button b_Rental;
        private System.Windows.Forms.Label label1;
    }
}

