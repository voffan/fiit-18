
namespace Gallery
{
    partial class Form2
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form2));
            System.Windows.Forms.Label idLabel;
            System.Windows.Forms.Label surnameLabel;
            System.Windows.Forms.Label nameLabel;
            System.Windows.Forms.Label middle_NameLabel;
            System.Windows.Forms.Label passport_idLabel;
            System.Windows.Forms.Label passport_seriesLabel;
            System.Windows.Forms.Label phoneLabel;
            System.Windows.Forms.Label positionLabel;
            System.Windows.Forms.Label depIdLabel;
            System.Windows.Forms.Label statusLabel;
            System.Windows.Forms.Label discriminatorLabel;
            this.button1 = new System.Windows.Forms.Button();
            
            this.personBindingSource = new System.Windows.Forms.BindingSource(this.components);
      
            this.personBindingNavigator = new System.Windows.Forms.BindingNavigator(this.components);
            this.bindingNavigatorMoveFirstItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMovePreviousItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorSeparator = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorPositionItem = new System.Windows.Forms.ToolStripTextBox();
            this.bindingNavigatorCountItem = new System.Windows.Forms.ToolStripLabel();
            this.bindingNavigatorSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorMoveNextItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMoveLastItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorAddNewItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorDeleteItem = new System.Windows.Forms.ToolStripButton();
            this.personBindingNavigatorSaveItem = new System.Windows.Forms.ToolStripButton();
            this.idTextBox = new System.Windows.Forms.TextBox();
            this.surnameTextBox = new System.Windows.Forms.TextBox();
            this.nameTextBox = new System.Windows.Forms.TextBox();
            this.middle_NameTextBox = new System.Windows.Forms.TextBox();
            this.passport_idTextBox = new System.Windows.Forms.TextBox();
            this.passport_seriesTextBox = new System.Windows.Forms.TextBox();
            this.phoneTextBox = new System.Windows.Forms.TextBox();
            this.positionTextBox = new System.Windows.Forms.TextBox();
            this.depIdTextBox = new System.Windows.Forms.TextBox();
            this.statusTextBox = new System.Windows.Forms.TextBox();
            this.discriminatorTextBox = new System.Windows.Forms.TextBox();
            idLabel = new System.Windows.Forms.Label();
            surnameLabel = new System.Windows.Forms.Label();
            nameLabel = new System.Windows.Forms.Label();
            middle_NameLabel = new System.Windows.Forms.Label();
            passport_idLabel = new System.Windows.Forms.Label();
            passport_seriesLabel = new System.Windows.Forms.Label();
            phoneLabel = new System.Windows.Forms.Label();
            positionLabel = new System.Windows.Forms.Label();
            depIdLabel = new System.Windows.Forms.Label();
            statusLabel = new System.Windows.Forms.Label();
            discriminatorLabel = new System.Windows.Forms.Label();
           
            ((System.ComponentModel.ISupportInitialize)(this.personBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.personBindingNavigator)).BeginInit();
            this.personBindingNavigator.SuspendLayout();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(103, 331);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 1;
            this.button1.Text = "button1";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // dBDataSet
            // 

            // 
            // personBindingSource
            // 
            this.personBindingSource.DataMember = "Person";
       
            // 
            // personTableAdapter
            // 
            
            // 
            // tableAdapterManager
            // 
           
            // 
            // personBindingNavigator
            // 
            this.personBindingNavigator.AddNewItem = this.bindingNavigatorAddNewItem;
            this.personBindingNavigator.BindingSource = this.personBindingSource;
            this.personBindingNavigator.CountItem = this.bindingNavigatorCountItem;
            this.personBindingNavigator.DeleteItem = this.bindingNavigatorDeleteItem;
            this.personBindingNavigator.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.bindingNavigatorMoveFirstItem,
            this.bindingNavigatorMovePreviousItem,
            this.bindingNavigatorSeparator,
            this.bindingNavigatorPositionItem,
            this.bindingNavigatorCountItem,
            this.bindingNavigatorSeparator1,
            this.bindingNavigatorMoveNextItem,
            this.bindingNavigatorMoveLastItem,
            this.bindingNavigatorSeparator2,
            this.bindingNavigatorAddNewItem,
            this.bindingNavigatorDeleteItem,
            this.personBindingNavigatorSaveItem});
            this.personBindingNavigator.Location = new System.Drawing.Point(0, 0);
            this.personBindingNavigator.MoveFirstItem = this.bindingNavigatorMoveFirstItem;
            this.personBindingNavigator.MoveLastItem = this.bindingNavigatorMoveLastItem;
            this.personBindingNavigator.MoveNextItem = this.bindingNavigatorMoveNextItem;
            this.personBindingNavigator.MovePreviousItem = this.bindingNavigatorMovePreviousItem;
            this.personBindingNavigator.Name = "personBindingNavigator";
            this.personBindingNavigator.PositionItem = this.bindingNavigatorPositionItem;
            this.personBindingNavigator.Size = new System.Drawing.Size(800, 25);
            this.personBindingNavigator.TabIndex = 2;
            this.personBindingNavigator.Text = "bindingNavigator1";
            // 
            // bindingNavigatorMoveFirstItem
            // 
            this.bindingNavigatorMoveFirstItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveFirstItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveFirstItem.Image")));
            this.bindingNavigatorMoveFirstItem.Name = "bindingNavigatorMoveFirstItem";
            this.bindingNavigatorMoveFirstItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveFirstItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorMoveFirstItem.Text = "Переместить в начало";
            // 
            // bindingNavigatorMovePreviousItem
            // 
            this.bindingNavigatorMovePreviousItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMovePreviousItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMovePreviousItem.Image")));
            this.bindingNavigatorMovePreviousItem.Name = "bindingNavigatorMovePreviousItem";
            this.bindingNavigatorMovePreviousItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMovePreviousItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorMovePreviousItem.Text = "Переместить назад";
            // 
            // bindingNavigatorSeparator
            // 
            this.bindingNavigatorSeparator.Name = "bindingNavigatorSeparator";
            this.bindingNavigatorSeparator.Size = new System.Drawing.Size(6, 25);
            // 
            // bindingNavigatorPositionItem
            // 
            this.bindingNavigatorPositionItem.AccessibleName = "Положение";
            this.bindingNavigatorPositionItem.AutoSize = false;
            this.bindingNavigatorPositionItem.Name = "bindingNavigatorPositionItem";
            this.bindingNavigatorPositionItem.Size = new System.Drawing.Size(50, 23);
            this.bindingNavigatorPositionItem.Text = "0";
            this.bindingNavigatorPositionItem.ToolTipText = "Текущее положение";
            // 
            // bindingNavigatorCountItem
            // 
            this.bindingNavigatorCountItem.Name = "bindingNavigatorCountItem";
            this.bindingNavigatorCountItem.Size = new System.Drawing.Size(43, 15);
            this.bindingNavigatorCountItem.Text = "для {0}";
            this.bindingNavigatorCountItem.ToolTipText = "Общее число элементов";
            // 
            // bindingNavigatorSeparator1
            // 
            this.bindingNavigatorSeparator1.Name = "bindingNavigatorSeparator";
            this.bindingNavigatorSeparator1.Size = new System.Drawing.Size(6, 6);
            // 
            // bindingNavigatorMoveNextItem
            // 
            this.bindingNavigatorMoveNextItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveNextItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveNextItem.Image")));
            this.bindingNavigatorMoveNextItem.Name = "bindingNavigatorMoveNextItem";
            this.bindingNavigatorMoveNextItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveNextItem.Size = new System.Drawing.Size(23, 20);
            this.bindingNavigatorMoveNextItem.Text = "Переместить вперед";
            // 
            // bindingNavigatorMoveLastItem
            // 
            this.bindingNavigatorMoveLastItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveLastItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveLastItem.Image")));
            this.bindingNavigatorMoveLastItem.Name = "bindingNavigatorMoveLastItem";
            this.bindingNavigatorMoveLastItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveLastItem.Size = new System.Drawing.Size(23, 20);
            this.bindingNavigatorMoveLastItem.Text = "Переместить в конец";
            // 
            // bindingNavigatorSeparator2
            // 
            this.bindingNavigatorSeparator2.Name = "bindingNavigatorSeparator";
            this.bindingNavigatorSeparator2.Size = new System.Drawing.Size(6, 6);
            // 
            // bindingNavigatorAddNewItem
            // 
            this.bindingNavigatorAddNewItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorAddNewItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorAddNewItem.Image")));
            this.bindingNavigatorAddNewItem.Name = "bindingNavigatorAddNewItem";
            this.bindingNavigatorAddNewItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorAddNewItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorAddNewItem.Text = "Добавить";
            // 
            // bindingNavigatorDeleteItem
            // 
            this.bindingNavigatorDeleteItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorDeleteItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorDeleteItem.Image")));
            this.bindingNavigatorDeleteItem.Name = "bindingNavigatorDeleteItem";
            this.bindingNavigatorDeleteItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorDeleteItem.Size = new System.Drawing.Size(23, 20);
            this.bindingNavigatorDeleteItem.Text = "Удалить";
            // 
            // personBindingNavigatorSaveItem
            // 
            this.personBindingNavigatorSaveItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.personBindingNavigatorSaveItem.Image = ((System.Drawing.Image)(resources.GetObject("personBindingNavigatorSaveItem.Image")));
            this.personBindingNavigatorSaveItem.Name = "personBindingNavigatorSaveItem";
            this.personBindingNavigatorSaveItem.Size = new System.Drawing.Size(23, 23);
            this.personBindingNavigatorSaveItem.Text = "Сохранить данные";
            this.personBindingNavigatorSaveItem.Click += new System.EventHandler(this.personBindingNavigatorSaveItem_Click);
            // 
            // idLabel
            // 
            idLabel.AutoSize = true;
            idLabel.Location = new System.Drawing.Point(16, 31);
            idLabel.Name = "idLabel";
            idLabel.Size = new System.Drawing.Size(19, 13);
            idLabel.TabIndex = 2;
            idLabel.Text = "Id:";
            // 
            // idTextBox
            // 
            this.idTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.personBindingSource, "Id", true));
            this.idTextBox.Location = new System.Drawing.Point(103, 28);
            this.idTextBox.Name = "idTextBox";
            this.idTextBox.Size = new System.Drawing.Size(100, 20);
            this.idTextBox.TabIndex = 3;
            // 
            // surnameLabel
            // 
            surnameLabel.AutoSize = true;
            surnameLabel.Location = new System.Drawing.Point(16, 57);
            surnameLabel.Name = "surnameLabel";
            surnameLabel.Size = new System.Drawing.Size(52, 13);
            surnameLabel.TabIndex = 4;
            surnameLabel.Text = "Surname:";
            // 
            // surnameTextBox
            // 
            this.surnameTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.personBindingSource, "Surname", true));
            this.surnameTextBox.Location = new System.Drawing.Point(103, 54);
            this.surnameTextBox.Name = "surnameTextBox";
            this.surnameTextBox.Size = new System.Drawing.Size(100, 20);
            this.surnameTextBox.TabIndex = 5;
            // 
            // nameLabel
            // 
            nameLabel.AutoSize = true;
            nameLabel.Location = new System.Drawing.Point(16, 83);
            nameLabel.Name = "nameLabel";
            nameLabel.Size = new System.Drawing.Size(38, 13);
            nameLabel.TabIndex = 6;
            nameLabel.Text = "Name:";
            // 
            // nameTextBox
            // 
            this.nameTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.personBindingSource, "Name", true));
            this.nameTextBox.Location = new System.Drawing.Point(103, 80);
            this.nameTextBox.Name = "nameTextBox";
            this.nameTextBox.Size = new System.Drawing.Size(100, 20);
            this.nameTextBox.TabIndex = 7;
            // 
            // middle_NameLabel
            // 
            middle_NameLabel.AutoSize = true;
            middle_NameLabel.Location = new System.Drawing.Point(16, 109);
            middle_NameLabel.Name = "middle_NameLabel";
            middle_NameLabel.Size = new System.Drawing.Size(72, 13);
            middle_NameLabel.TabIndex = 8;
            middle_NameLabel.Text = "Middle Name:";
            // 
            // middle_NameTextBox
            // 
            this.middle_NameTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.personBindingSource, "Middle_Name", true));
            this.middle_NameTextBox.Location = new System.Drawing.Point(103, 106);
            this.middle_NameTextBox.Name = "middle_NameTextBox";
            this.middle_NameTextBox.Size = new System.Drawing.Size(100, 20);
            this.middle_NameTextBox.TabIndex = 9;
            // 
            // passport_idLabel
            // 
            passport_idLabel.AutoSize = true;
            passport_idLabel.Location = new System.Drawing.Point(16, 135);
            passport_idLabel.Name = "passport_idLabel";
            passport_idLabel.Size = new System.Drawing.Size(62, 13);
            passport_idLabel.TabIndex = 10;
            passport_idLabel.Text = "Passport id:";
            // 
            // passport_idTextBox
            // 
            this.passport_idTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.personBindingSource, "Passport_id", true));
            this.passport_idTextBox.Location = new System.Drawing.Point(103, 132);
            this.passport_idTextBox.Name = "passport_idTextBox";
            this.passport_idTextBox.Size = new System.Drawing.Size(100, 20);
            this.passport_idTextBox.TabIndex = 11;
            // 
            // passport_seriesLabel
            // 
            passport_seriesLabel.AutoSize = true;
            passport_seriesLabel.Location = new System.Drawing.Point(16, 161);
            passport_seriesLabel.Name = "passport_seriesLabel";
            passport_seriesLabel.Size = new System.Drawing.Size(81, 13);
            passport_seriesLabel.TabIndex = 12;
            passport_seriesLabel.Text = "Passport series:";
            // 
            // passport_seriesTextBox
            // 
            this.passport_seriesTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.personBindingSource, "Passport_series", true));
            this.passport_seriesTextBox.Location = new System.Drawing.Point(103, 158);
            this.passport_seriesTextBox.Name = "passport_seriesTextBox";
            this.passport_seriesTextBox.Size = new System.Drawing.Size(100, 20);
            this.passport_seriesTextBox.TabIndex = 13;
            // 
            // phoneLabel
            // 
            phoneLabel.AutoSize = true;
            phoneLabel.Location = new System.Drawing.Point(16, 187);
            phoneLabel.Name = "phoneLabel";
            phoneLabel.Size = new System.Drawing.Size(41, 13);
            phoneLabel.TabIndex = 14;
            phoneLabel.Text = "Phone:";
            // 
            // phoneTextBox
            // 
            this.phoneTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.personBindingSource, "Phone", true));
            this.phoneTextBox.Location = new System.Drawing.Point(103, 184);
            this.phoneTextBox.Name = "phoneTextBox";
            this.phoneTextBox.Size = new System.Drawing.Size(100, 20);
            this.phoneTextBox.TabIndex = 15;
            // 
            // positionLabel
            // 
            positionLabel.AutoSize = true;
            positionLabel.Location = new System.Drawing.Point(16, 213);
            positionLabel.Name = "positionLabel";
            positionLabel.Size = new System.Drawing.Size(47, 13);
            positionLabel.TabIndex = 16;
            positionLabel.Text = "Position:";
            // 
            // positionTextBox
            // 
            this.positionTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.personBindingSource, "Position", true));
            this.positionTextBox.Location = new System.Drawing.Point(103, 210);
            this.positionTextBox.Name = "positionTextBox";
            this.positionTextBox.Size = new System.Drawing.Size(100, 20);
            this.positionTextBox.TabIndex = 17;
            // 
            // depIdLabel
            // 
            depIdLabel.AutoSize = true;
            depIdLabel.Location = new System.Drawing.Point(16, 239);
            depIdLabel.Name = "depIdLabel";
            depIdLabel.Size = new System.Drawing.Size(42, 13);
            depIdLabel.TabIndex = 18;
            depIdLabel.Text = "Dep Id:";
            // 
            // depIdTextBox
            // 
            this.depIdTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.personBindingSource, "DepId", true));
            this.depIdTextBox.Location = new System.Drawing.Point(103, 236);
            this.depIdTextBox.Name = "depIdTextBox";
            this.depIdTextBox.Size = new System.Drawing.Size(100, 20);
            this.depIdTextBox.TabIndex = 19;
            // 
            // statusLabel
            // 
            statusLabel.AutoSize = true;
            statusLabel.Location = new System.Drawing.Point(16, 265);
            statusLabel.Name = "statusLabel";
            statusLabel.Size = new System.Drawing.Size(40, 13);
            statusLabel.TabIndex = 20;
            statusLabel.Text = "Status:";
            // 
            // statusTextBox
            // 
            this.statusTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.personBindingSource, "Status", true));
            this.statusTextBox.Location = new System.Drawing.Point(103, 262);
            this.statusTextBox.Name = "statusTextBox";
            this.statusTextBox.Size = new System.Drawing.Size(100, 20);
            this.statusTextBox.TabIndex = 21;
            // 
            // discriminatorLabel
            // 
            discriminatorLabel.AutoSize = true;
            discriminatorLabel.Location = new System.Drawing.Point(16, 291);
            discriminatorLabel.Name = "discriminatorLabel";
            discriminatorLabel.Size = new System.Drawing.Size(70, 13);
            discriminatorLabel.TabIndex = 22;
            discriminatorLabel.Text = "Discriminator:";
            // 
            // discriminatorTextBox
            // 
            this.discriminatorTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.personBindingSource, "Discriminator", true));
            this.discriminatorTextBox.Location = new System.Drawing.Point(103, 288);
            this.discriminatorTextBox.Name = "discriminatorTextBox";
            this.discriminatorTextBox.Size = new System.Drawing.Size(100, 20);
            this.discriminatorTextBox.TabIndex = 23;
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 465);
            this.Controls.Add(idLabel);
            this.Controls.Add(this.idTextBox);
            this.Controls.Add(surnameLabel);
            this.Controls.Add(this.surnameTextBox);
            this.Controls.Add(nameLabel);
            this.Controls.Add(this.nameTextBox);
            this.Controls.Add(middle_NameLabel);
            this.Controls.Add(this.middle_NameTextBox);
            this.Controls.Add(passport_idLabel);
            this.Controls.Add(this.passport_idTextBox);
            this.Controls.Add(passport_seriesLabel);
            this.Controls.Add(this.passport_seriesTextBox);
            this.Controls.Add(phoneLabel);
            this.Controls.Add(this.phoneTextBox);
            this.Controls.Add(positionLabel);
            this.Controls.Add(this.positionTextBox);
            this.Controls.Add(depIdLabel);
            this.Controls.Add(this.depIdTextBox);
            this.Controls.Add(statusLabel);
            this.Controls.Add(this.statusTextBox);
            this.Controls.Add(discriminatorLabel);
            this.Controls.Add(this.discriminatorTextBox);
            this.Controls.Add(this.personBindingNavigator);
            this.Controls.Add(this.button1);
            this.Name = "Form2";
            this.Text = "Form2";
            this.Load += new System.EventHandler(this.Form2_Load);
         
            ((System.ComponentModel.ISupportInitialize)(this.personBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.personBindingNavigator)).EndInit();
            this.personBindingNavigator.ResumeLayout(false);
            this.personBindingNavigator.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.BindingSource personBindingSource;
        private System.Windows.Forms.BindingNavigator personBindingNavigator;
        private System.Windows.Forms.ToolStripButton bindingNavigatorAddNewItem;
        private System.Windows.Forms.ToolStripLabel bindingNavigatorCountItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorDeleteItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveFirstItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMovePreviousItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator;
        private System.Windows.Forms.ToolStripTextBox bindingNavigatorPositionItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator1;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveNextItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveLastItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator2;
        private System.Windows.Forms.ToolStripButton personBindingNavigatorSaveItem;
        private System.Windows.Forms.TextBox idTextBox;
        private System.Windows.Forms.TextBox surnameTextBox;
        private System.Windows.Forms.TextBox nameTextBox;
        private System.Windows.Forms.TextBox middle_NameTextBox;
        private System.Windows.Forms.TextBox passport_idTextBox;
        private System.Windows.Forms.TextBox passport_seriesTextBox;
        private System.Windows.Forms.TextBox phoneTextBox;
        private System.Windows.Forms.TextBox positionTextBox;
        private System.Windows.Forms.TextBox depIdTextBox;
        private System.Windows.Forms.TextBox statusTextBox;
        private System.Windows.Forms.TextBox discriminatorTextBox;
    }
}