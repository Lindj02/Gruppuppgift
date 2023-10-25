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
            txtSearch = new TextBox();
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
            btnLogout = new Button();
            label1 = new Label();
            txtDescription1 = new TextBox();
            lblpicturePath = new Label();
            txtpicturePath = new TextBox();
            lblCat = new Label();
            txtCat = new TextBox();
            btnSave = new Button();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBoxRecipe).BeginInit();
            SuspendLayout();
            // 
            // dataGridView1
            // 
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(461, 694);
            dataGridView1.Margin = new Padding(4, 5, 4, 5);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowHeadersWidth = 51;
            dataGridView1.RowTemplate.Height = 25;
            dataGridView1.Size = new Size(892, 424);
            dataGridView1.TabIndex = 0;
            dataGridView1.RowHeaderMouseClick += dataGridView1_RowHeaderMouseClick;
            // 
            // btnAdd
            // 
            btnAdd.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            btnAdd.Location = new Point(632, 1128);
            btnAdd.Margin = new Padding(4, 5, 4, 5);
            btnAdd.Name = "btnAdd";
            btnAdd.Size = new Size(129, 50);
            btnAdd.TabIndex = 1;
            btnAdd.Text = "Lägg till";
            btnAdd.UseVisualStyleBackColor = true;
            btnAdd.Visible = false;
            btnAdd.Click += btnAdd_Click;
            // 
            // btnDelete
            // 
            btnDelete.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            btnDelete.Location = new Point(1206, 1128);
            btnDelete.Margin = new Padding(4, 5, 4, 5);
            btnDelete.Name = "btnDelete";
            btnDelete.Size = new Size(129, 50);
            btnDelete.TabIndex = 2;
            btnDelete.Text = "Ta bort";
            btnDelete.UseVisualStyleBackColor = true;
            btnDelete.Visible = false;
            // 
            // txtSearch
            // 
            txtSearch.Location = new Point(370, 16);
            txtSearch.Margin = new Padding(4, 5, 4, 5);
            txtSearch.Name = "txtSearch";
            txtSearch.Size = new Size(630, 31);
            txtSearch.TabIndex = 4;
            txtSearch.TextChanged += txtSearch_TextChanged;
            // 
            // txtUserName
            // 
            txtUserName.Location = new Point(1994, 975);
            txtUserName.Margin = new Padding(4, 5, 4, 5);
            txtUserName.Name = "txtUserName";
            txtUserName.Size = new Size(175, 31);
            txtUserName.TabIndex = 6;
            // 
            // txtPassword
            // 
            txtPassword.Location = new Point(1994, 1050);
            txtPassword.Margin = new Padding(4, 5, 4, 5);
            txtPassword.Name = "txtPassword";
            txtPassword.Size = new Size(175, 31);
            txtPassword.TabIndex = 7;
            // 
            // lblUserName
            // 
            lblUserName.AutoSize = true;
            lblUserName.Location = new Point(1802, 980);
            lblUserName.Margin = new Padding(4, 0, 4, 0);
            lblUserName.Name = "lblUserName";
            lblUserName.Size = new Size(137, 25);
            lblUserName.TabIndex = 8;
            lblUserName.Text = "Användarnamn:";
            // 
            // lblPassWord
            // 
            lblPassWord.AutoSize = true;
            lblPassWord.Location = new Point(1850, 1055);
            lblPassWord.Margin = new Padding(4, 0, 4, 0);
            lblPassWord.Name = "lblPassWord";
            lblPassWord.Size = new Size(90, 25);
            lblPassWord.TabIndex = 9;
            lblPassWord.Text = "Lösenord:";
            // 
            // btnLogIn
            // 
            btnLogIn.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            btnLogIn.Location = new Point(1831, 1126);
            btnLogIn.Margin = new Padding(4, 5, 4, 5);
            btnLogIn.Name = "btnLogIn";
            btnLogIn.Size = new Size(110, 50);
            btnLogIn.TabIndex = 10;
            btnLogIn.Text = "Logga in";
            btnLogIn.UseVisualStyleBackColor = true;
            btnLogIn.Click += btnLogIn_Click;
            // 
            // lblSearch
            // 
            lblSearch.AutoSize = true;
            lblSearch.Location = new Point(275, 21);
            lblSearch.Margin = new Padding(4, 0, 4, 0);
            lblSearch.Name = "lblSearch";
            lblSearch.Size = new Size(68, 25);
            lblSearch.TabIndex = 12;
            lblSearch.Text = "Search:";
            // 
            // lblCategory
            // 
            lblCategory.AutoSize = true;
            lblCategory.Location = new Point(261, 100);
            lblCategory.Margin = new Padding(4, 0, 4, 0);
            lblCategory.Name = "lblCategory";
            lblCategory.Size = new Size(82, 25);
            lblCategory.TabIndex = 13;
            lblCategory.Text = "Kategori:";
            // 
            // comboBox
            // 
            comboBox.FormattingEnabled = true;
            comboBox.Location = new Point(370, 95);
            comboBox.Margin = new Padding(4, 5, 4, 5);
            comboBox.Name = "comboBox";
            comboBox.Size = new Size(630, 33);
            comboBox.TabIndex = 15;
            comboBox.SelectedIndexChanged += comboBox_SelectedIndexChanged;
            // 
            // listBoxRecipe
            // 
            listBoxRecipe.FormattingEnabled = true;
            listBoxRecipe.ItemHeight = 25;
            listBoxRecipe.Location = new Point(461, 384);
            listBoxRecipe.Margin = new Padding(4, 5, 4, 5);
            listBoxRecipe.Name = "listBoxRecipe";
            listBoxRecipe.Size = new Size(892, 279);
            listBoxRecipe.TabIndex = 16;
            listBoxRecipe.SelectedIndexChanged += listBox1_SelectedIndexChanged;
            // 
            // pictureBoxRecipe
            // 
            pictureBoxRecipe.Location = new Point(18, 289);
            pictureBoxRecipe.Margin = new Padding(4, 5, 4, 5);
            pictureBoxRecipe.Name = "pictureBoxRecipe";
            pictureBoxRecipe.Size = new Size(412, 500);
            pictureBoxRecipe.TabIndex = 17;
            pictureBoxRecipe.TabStop = false;
            // 
            // txtTitle
            // 
            txtTitle.Location = new Point(672, 304);
            txtTitle.Margin = new Padding(4, 5, 4, 5);
            txtTitle.Name = "txtTitle";
            txtTitle.Size = new Size(410, 31);
            txtTitle.TabIndex = 18;
            // 
            // lblFoodlList
            // 
            lblFoodlList.AutoSize = true;
            lblFoodlList.Location = new Point(261, 202);
            lblFoodlList.Margin = new Padding(4, 0, 4, 0);
            lblFoodlList.Name = "lblFoodlList";
            lblFoodlList.Size = new Size(74, 25);
            lblFoodlList.TabIndex = 19;
            lblFoodlList.Text = "Matlista";
            // 
            // comboBox1
            // 
            comboBox1.FormattingEnabled = true;
            comboBox1.Location = new Point(370, 192);
            comboBox1.Margin = new Padding(4, 5, 4, 5);
            comboBox1.Name = "comboBox1";
            comboBox1.Size = new Size(630, 33);
            comboBox1.TabIndex = 20;
            comboBox1.SelectedIndexChanged += comboBox1_SelectedIndexChanged;
            // 
            // btnLogout
            // 
            btnLogout.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            btnLogout.Location = new Point(2054, 1126);
            btnLogout.Margin = new Padding(4, 5, 4, 5);
            btnLogout.Name = "btnLogout";
            btnLogout.Size = new Size(114, 50);
            btnLogout.TabIndex = 21;
            btnLogout.Text = "Logga Ut";
            btnLogout.UseVisualStyleBackColor = true;
            btnLogout.Visible = false;
            btnLogout.Click += btnLogout_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(1420, 352);
            label1.Margin = new Padding(4, 0, 4, 0);
            label1.Name = "label1";
            label1.Size = new Size(102, 25);
            label1.TabIndex = 22;
            label1.Text = "Beskrivning";
            // 
            // txtDescription1
            // 
            txtDescription1.Location = new Point(1381, 390);
            txtDescription1.Margin = new Padding(4);
            txtDescription1.Multiline = true;
            txtDescription1.Name = "txtDescription1";
            txtDescription1.Size = new Size(413, 275);
            txtDescription1.TabIndex = 23;
            // 
            // lblpicturePath
            // 
            lblpicturePath.AutoSize = true;
            lblpicturePath.Location = new Point(261, 248);
            lblpicturePath.Margin = new Padding(4, 0, 4, 0);
            lblpicturePath.Name = "lblpicturePath";
            lblpicturePath.Size = new Size(76, 25);
            lblpicturePath.TabIndex = 24;
            lblpicturePath.Text = "Bildkälla";
            lblpicturePath.Visible = false;
            // 
            // txtpicturePath
            // 
            txtpicturePath.Location = new Point(370, 244);
            txtpicturePath.Margin = new Padding(4, 5, 4, 5);
            txtpicturePath.Name = "txtpicturePath";
            txtpicturePath.Size = new Size(630, 31);
            txtpicturePath.TabIndex = 25;
            txtpicturePath.Visible = false;
            // 
            // lblCat
            // 
            lblCat.AutoSize = true;
            lblCat.Location = new Point(249, 149);
            lblCat.Margin = new Padding(4, 0, 4, 0);
            lblCat.Name = "lblCat";
            lblCat.Size = new Size(109, 25);
            lblCat.TabIndex = 26;
            lblCat.Text = "Ny Kategori:";
            lblCat.Visible = false;
            // 
            // txtCat
            // 
            txtCat.Location = new Point(370, 149);
            txtCat.Margin = new Padding(4, 5, 4, 5);
            txtCat.Name = "txtCat";
            txtCat.Size = new Size(630, 31);
            txtCat.TabIndex = 27;
            txtCat.Visible = false;
            // 
            // btnSave
            // 
            btnSave.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            btnSave.Location = new Point(461, 1126);
            btnSave.Margin = new Padding(4, 5, 4, 5);
            btnSave.Name = "btnSave";
            btnSave.Size = new Size(129, 50);
            btnSave.TabIndex = 28;
            btnSave.Text = "Spara";
            btnSave.UseVisualStyleBackColor = true;
            btnSave.Visible = false;
            btnSave.Click += btnSave_Click_1;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(2211, 1239);
            Controls.Add(btnSave);
            Controls.Add(txtCat);
            Controls.Add(lblCat);
            Controls.Add(txtpicturePath);
            Controls.Add(lblpicturePath);
            Controls.Add(txtDescription1);
            Controls.Add(label1);
            Controls.Add(btnLogout);
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
            Controls.Add(txtSearch);
            Controls.Add(btnDelete);
            Controls.Add(btnAdd);
            Controls.Add(dataGridView1);
            Margin = new Padding(4, 5, 4, 5);
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
        private TextBox txtSearch;
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
        private Button btnLogout;
        private Label label1;
        private TextBox txtDescription1;
        private Label lblpicturePath;
        private TextBox txtpicturePath;
        private Label lblCat;
        private TextBox txtCat;
        private Button btnSave;
    }
}