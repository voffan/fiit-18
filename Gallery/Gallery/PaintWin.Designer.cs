
namespace Gallery
{
    partial class PaintWin
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
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.idDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.genreIdDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.exhibitionIdDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.namePaintingDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.artistIdDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.paintingStatusDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.paintingBindingSource = new System.Windows.Forms.BindingSource(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.paintingBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idDataGridViewTextBoxColumn,
            this.genreIdDataGridViewTextBoxColumn,
            this.exhibitionIdDataGridViewTextBoxColumn,
            this.namePaintingDataGridViewTextBoxColumn,
            this.artistIdDataGridViewTextBoxColumn,
            this.paintingStatusDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.paintingBindingSource;
            this.dataGridView1.Location = new System.Drawing.Point(12, 12);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(944, 334);
            this.dataGridView1.TabIndex = 0;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(68, 366);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(102, 73);
            this.button1.TabIndex = 1;
            this.button1.Text = "Добавить";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(202, 366);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(120, 74);
            this.button2.TabIndex = 2;
            this.button2.Text = "Редактировать";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(357, 366);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(114, 73);
            this.button3.TabIndex = 3;
            this.button3.Text = "Удалить";
            this.button3.UseVisualStyleBackColor = true;
            // 
            // idDataGridViewTextBoxColumn
            // 
            this.idDataGridViewTextBoxColumn.DataPropertyName = "Id";
            this.idDataGridViewTextBoxColumn.HeaderText = "Id";
            this.idDataGridViewTextBoxColumn.Name = "idDataGridViewTextBoxColumn";
            // 
            // genreIdDataGridViewTextBoxColumn
            // 
            this.genreIdDataGridViewTextBoxColumn.DataPropertyName = "GenreId";
            this.genreIdDataGridViewTextBoxColumn.HeaderText = "GenreId";
            this.genreIdDataGridViewTextBoxColumn.Name = "genreIdDataGridViewTextBoxColumn";
            // 
            // exhibitionIdDataGridViewTextBoxColumn
            // 
            this.exhibitionIdDataGridViewTextBoxColumn.DataPropertyName = "ExhibitionId";
            this.exhibitionIdDataGridViewTextBoxColumn.HeaderText = "ExhibitionId";
            this.exhibitionIdDataGridViewTextBoxColumn.Name = "exhibitionIdDataGridViewTextBoxColumn";
            // 
            // namePaintingDataGridViewTextBoxColumn
            // 
            this.namePaintingDataGridViewTextBoxColumn.DataPropertyName = "NamePainting";
            this.namePaintingDataGridViewTextBoxColumn.HeaderText = "NamePainting";
            this.namePaintingDataGridViewTextBoxColumn.Name = "namePaintingDataGridViewTextBoxColumn";
            // 
            // artistIdDataGridViewTextBoxColumn
            // 
            this.artistIdDataGridViewTextBoxColumn.DataPropertyName = "ArtistId";
            this.artistIdDataGridViewTextBoxColumn.HeaderText = "ArtistId";
            this.artistIdDataGridViewTextBoxColumn.Name = "artistIdDataGridViewTextBoxColumn";
            // 
            // paintingStatusDataGridViewTextBoxColumn
            // 
            this.paintingStatusDataGridViewTextBoxColumn.DataPropertyName = "PaintingStatus";
            this.paintingStatusDataGridViewTextBoxColumn.HeaderText = "PaintingStatus";
            this.paintingStatusDataGridViewTextBoxColumn.Name = "paintingStatusDataGridViewTextBoxColumn";
            // 
            // paintingBindingSource
            // 
            this.paintingBindingSource.DataSource = typeof(Gallery.Painting);
            // 
            // PaintWin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(652, 532);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.dataGridView1);
            this.Name = "PaintWin";
            this.Text = "PaintWin";
            this.Load += new System.EventHandler(this.PaintWin_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.paintingBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.BindingSource paintingBindingSource;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.DataGridViewTextBoxColumn idDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn genreIdDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn exhibitionIdDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn namePaintingDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn artistIdDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn paintingStatusDataGridViewTextBoxColumn;
    }
}