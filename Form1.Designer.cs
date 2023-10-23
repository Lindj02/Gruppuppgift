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
            textBox1 = new TextBox();
            lblSearch = new Label();
            lblCategory = new Label();
            scrollbarCategory = new VScrollBar();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // dataGridView1
            // 
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(57, 151);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowTemplate.Height = 25;
            dataGridView1.Size = new Size(870, 420);
            dataGridView1.TabIndex = 0;
            // 
            // btnAdd
            // 
            btnAdd.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            btnAdd.Location = new Point(71, 624);
            btnAdd.Name = "btnAdd";
            btnAdd.Size = new Size(90, 30);
            btnAdd.TabIndex = 1;
            btnAdd.Text = "Lägg till";
            btnAdd.UseVisualStyleBackColor = true;
            // 
            // btnDelete
            // 
            btnDelete.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            btnDelete.Location = new Point(275, 624);
            btnDelete.Name = "btnDelete";
            btnDelete.Size = new Size(90, 30);
            btnDelete.TabIndex = 2;
            btnDelete.Text = "Ta bort";
            btnDelete.UseVisualStyleBackColor = true;
            // 
            // btnUpdate
            // 
            btnUpdate.Font = new Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
            btnUpdate.Location = new Point(495, 624);
            btnUpdate.Name = "btnUpdate";
            btnUpdate.Size = new Size(90, 30);
            btnUpdate.TabIndex = 3;
            btnUpdate.Text = "Uppdatera";
            btnUpdate.UseVisualStyleBackColor = true;
            // 
            // txtSearch
            // 
            txtSearch.Location = new Point(178, 48);
            txtSearch.Name = "txtSearch";
            txtSearch.Size = new Size(442, 23);
            txtSearch.TabIndex = 4;
            // 
            // btnSearch
            // 
            btnSearch.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            btnSearch.Location = new Point(690, 41);
            btnSearch.Name = "btnSearch";
            btnSearch.Size = new Size(90, 30);
            btnSearch.TabIndex = 5;
            btnSearch.Text = "Sök";
            btnSearch.UseVisualStyleBackColor = true;
            // 
            // txtUserName
            // 
            txtUserName.Location = new Point(1507, 585);
            txtUserName.Name = "txtUserName";
            txtUserName.Size = new Size(124, 23);
            txtUserName.TabIndex = 6;
            // 
            // txtPassword
            // 
            txtPassword.Location = new Point(1507, 630);
            txtPassword.Name = "txtPassword";
            txtPassword.Size = new Size(124, 23);
            txtPassword.TabIndex = 7;
            // 
            // lblUserName
            // 
            lblUserName.AutoSize = true;
            lblUserName.Location = new Point(1402, 588);
            lblUserName.Name = "lblUserName";
            lblUserName.Size = new Size(92, 15);
            lblUserName.TabIndex = 8;
            lblUserName.Text = "Användarnamn:";
            // 
            // lblPassWord
            // 
            lblPassWord.AutoSize = true;
            lblPassWord.Location = new Point(1435, 633);
            lblPassWord.Name = "lblPassWord";
            lblPassWord.Size = new Size(59, 15);
            lblPassWord.TabIndex = 9;
            lblPassWord.Text = "Lösenord:";
            // 
            // btnLogIn
            // 
            btnLogIn.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            btnLogIn.Location = new Point(1534, 678);
            btnLogIn.Name = "btnLogIn";
            btnLogIn.Size = new Size(70, 30);
            btnLogIn.TabIndex = 10;
            btnLogIn.Text = "Logga in";
            btnLogIn.UseVisualStyleBackColor = true;
            // 
            // textBox1
            // 
            textBox1.Location = new Point(178, 95);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(442, 23);
            textBox1.TabIndex = 11;
            // 
            // lblSearch
            // 
            lblSearch.AutoSize = true;
            lblSearch.Location = new Point(116, 51);
            lblSearch.Name = "lblSearch";
            lblSearch.Size = new Size(45, 15);
            lblSearch.TabIndex = 12;
            lblSearch.Text = "Search:";
            // 
            // lblCategory
            // 
            lblCategory.AutoSize = true;
            lblCategory.Location = new Point(107, 98);
            lblCategory.Name = "lblCategory";
            lblCategory.Size = new Size(54, 15);
            lblCategory.TabIndex = 13;
            lblCategory.Text = "Kategori:";
            // 
            // scrollbarCategory
            // 
            scrollbarCategory.Location = new Point(623, 82);
            scrollbarCategory.Name = "scrollbarCategory";
            scrollbarCategory.Size = new Size(17, 50);
            scrollbarCategory.TabIndex = 14;
            scrollbarCategory.Scroll += scrollbarK_Scroll;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1794, 743);
            Controls.Add(scrollbarCategory);
            Controls.Add(lblCategory);
            Controls.Add(lblSearch);
            Controls.Add(textBox1);
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
        private TextBox textBox1;
        private Label lblSearch;
        private Label lblCategory;
        private VScrollBar scrollbarCategory;
    }
}