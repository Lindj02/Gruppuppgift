namespace Gruppuppgift
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            dataGridView1 = new DataGridView();
            btnAdd = new Button();
            btnDelete = new Button();
            btnUpdate = new Button();
            txtSearch = new TextBox();
            btnSearch = new Button();
            txtUserName = new TextBox();
            txtPassword = new TextBox();
            lblUserName = new Label();
            lblPassWord = new Label();
            btnLogIn = new Button();
            lblSearch = new Label();
            lblCategory = new Label();
            comboBox = new ComboBox();
            listBoxRecipe = new ListBox();
            pictureBoxRecipe = new PictureBox();
            txtTitle = new TextBox();
            lblFoodlList = new Label();
            comboBox1 = new ComboBox();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBoxRecipe).BeginInit();
            SuspendLayout();
            // 
            // dataGridView1
            // 
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(323, 416);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowTemplate.Height = 25;
            dataGridView1.Size = new Size(625, 254);
            dataGridView1.TabIndex = 0;
            // 
            // btnAdd
            // 
            btnAdd.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            btnAdd.Location = new Point(424, 676);
            btnAdd.Name = "btnAdd";
            btnAdd.Size = new Size(90, 30);
            btnAdd.TabIndex = 1;
            btnAdd.Text = "Lägg till";
            btnAdd.UseVisualStyleBackColor = true;
            // 
            // btnDelete
            // 
            btnDelete.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            btnDelete.Location = new Point(595, 676);
            btnDelete.Name = "btnDelete";
            btnDelete.Size = new Size(90, 30);
            btnDelete.TabIndex = 2;
            btnDelete.Text = "Ta bort";
            btnDelete.UseVisualStyleBackColor = true;
            // 
            // btnUpdate
            // 
            btnUpdate.Font = new Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
            btnUpdate.Location = new Point(789, 676);
            btnUpdate.Name = "btnUpdate";
            btnUpdate.Size = new Size(90, 30);
            btnUpdate.TabIndex = 3;
            btnUpdate.Text = "Uppdatera";
            btnUpdate.UseVisualStyleBackColor = true;
            // 
            // txtSearch
            // 
            txtSearch.Location = new Point(261, 51);
            txtSearch.Name = "txtSearch";
            txtSearch.Size = new Size(442, 23);
            txtSearch.TabIndex = 4;
            // 
            // btnSearch
            // 
            btnSearch.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            btnSearch.Location = new Point(780, 44);
            btnSearch.Name = "btnSearch";
            btnSearch.Size = new Size(90, 30);
            btnSearch.TabIndex = 5;
            btnSearch.Text = "Sök";
            btnSearch.UseVisualStyleBackColor = true;
            // 
            // txtUserName
            // 
            txtUserName.Location = new Point(1396, 585);
            txtUserName.Name = "txtUserName";
            txtUserName.Size = new Size(124, 23);
            txtUserName.TabIndex = 6;
            // 
            // txtPassword
            // 
            txtPassword.Location = new Point(1396, 630);
            txtPassword.Name = "txtPassword";
            txtPassword.Size = new Size(124, 23);
            txtPassword.TabIndex = 7;
            // 
            // lblUserName
            // 
            lblUserName.AutoSize = true;
            lblUserName.Location = new Point(1262, 588);
            lblUserName.Name = "lblUserName";
            lblUserName.Size = new Size(92, 15);
            lblUserName.TabIndex = 8;
            lblUserName.Text = "Användarnamn:";
            // 
            // lblPassWord
            // 
            lblPassWord.AutoSize = true;
            lblPassWord.Location = new Point(1295, 633);
            lblPassWord.Name = "lblPassWord";
            lblPassWord.Size = new Size(59, 15);
            lblPassWord.TabIndex = 9;
            lblPassWord.Text = "Lösenord:";
            // 
            // btnLogIn
            // 
            btnLogIn.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            btnLogIn.Location = new Point(1424, 675);
            btnLogIn.Name = "btnLogIn";
            btnLogIn.Size = new Size(70, 30);
            btnLogIn.TabIndex = 10;
            btnLogIn.Text = "Logga in";
            btnLogIn.UseVisualStyleBackColor = true;
            // 
            // lblSearch
            // 
            lblSearch.AutoSize = true;
            lblSearch.Location = new Point(194, 54);
            lblSearch.Name = "lblSearch";
            lblSearch.Size = new Size(45, 15);
            lblSearch.TabIndex = 12;
            lblSearch.Text = "Search:";
            // 
            // lblCategory
            // 
            lblCategory.AutoSize = true;
            lblCategory.Location = new Point(185, 101);
            lblCategory.Name = "lblCategory";
            lblCategory.Size = new Size(54, 15);
            lblCategory.TabIndex = 13;
            lblCategory.Text = "Kategori:";
            // 
            // comboBox
            // 
            comboBox.FormattingEnabled = true;
            comboBox.Location = new Point(261, 98);
            comboBox.Name = "comboBox";
            comboBox.Size = new Size(442, 23);
            comboBox.TabIndex = 15;
            comboBox.SelectedIndexChanged += comboBox_SelectedIndexChanged;
            // 
            // listBoxRecipe
            // 
            listBoxRecipe.FormattingEnabled = true;
            listBoxRecipe.ItemHeight = 15;
            listBoxRecipe.Location = new Point(323, 230);
            listBoxRecipe.Name = "listBoxRecipe";
            listBoxRecipe.Size = new Size(625, 169);
            listBoxRecipe.TabIndex = 16;
            listBoxRecipe.SelectedIndexChanged += listBox1_SelectedIndexChanged;
            // 
            // pictureBoxRecipe
            // 
            pictureBoxRecipe.Location = new Point(12, 173);
            pictureBoxRecipe.Name = "pictureBoxRecipe";
            pictureBoxRecipe.Size = new Size(289, 300);
            pictureBoxRecipe.TabIndex = 17;
            pictureBoxRecipe.TabStop = false;
            // 
            // txtTitle
            // 
            txtTitle.Location = new Point(471, 182);
            txtTitle.Name = "txtTitle";
            txtTitle.Size = new Size(288, 23);
            txtTitle.TabIndex = 18;
            // 
            // lblFoodlList
            // 
            lblFoodlList.AutoSize = true;
            lblFoodlList.Location = new Point(185, 137);
            lblFoodlList.Name = "lblFoodlList";
            lblFoodlList.Size = new Size(49, 15);
            lblFoodlList.TabIndex = 19;
            lblFoodlList.Text = "Matlista";
            // 
            // comboBox1
            // 
            comboBox1.FormattingEnabled = true;
            comboBox1.Location = new Point(261, 134);
            comboBox1.Name = "comboBox1";
            comboBox1.Size = new Size(442, 23);
            comboBox1.TabIndex = 20;
            comboBox1.SelectedIndexChanged += comboBox1_SelectedIndexChanged;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1548, 743);
            Controls.Add(comboBox1);
            Controls.Add(lblFoodlList);
            Controls.Add(txtTitle);
            Controls.Add(pictureBoxRecipe);
            Controls.Add(listBoxRecipe);
            Controls.Add(comboBox);
            Controls.Add(lblCategory);
            Controls.Add(lblSearch);
            Controls.Add(btnLogIn);
            Controls.Add(lblPassWord);
            Controls.Add(lblUserName);
            Controls.Add(txtPassword);
            Controls.Add(txtUserName);
            Controls.Add(btnSearch);
            Controls.Add(txtSearch);
            Controls.Add(btnUpdate);
            Controls.Add(btnDelete);
            Controls.Add(btnAdd);
            Controls.Add(dataGridView1);
            Name = "Form1";
            Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBoxRecipe).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DataGridView dataGridView1;
        private Button btnAdd;
        private Button btnDelete;
        private Button btnUpdate;
        private TextBox txtSearch;
        private Button btnSearch;
        private TextBox txtUserName;
        private TextBox txtPassword;
        private Label lblUserName;
        private Label lblPassWord;
        private Button btnLogIn;
        private Label lblSearch;
        private Label lblCategory;
        private ComboBox comboBox;
        private ListBox listBoxRecipe;
        private PictureBox pictureBoxRecipe;
        private TextBox txtTitle;
        private Label lblFoodlList;
        private ComboBox comboBox1;
    }
}