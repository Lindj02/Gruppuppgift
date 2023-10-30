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
            lblCat = new Label();
            txtCat = new TextBox();
            btnSave = new Button();
            openFileDialog1 = new OpenFileDialog();
            btnOpenFIleDialog = new Button();
            txtBildkälla = new TextBox();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBoxRecipe).BeginInit();
            SuspendLayout();
            // 
            // dataGridView1
            // 
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(323, 416);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowHeadersWidth = 51;
            dataGridView1.RowTemplate.Height = 25;
            dataGridView1.Size = new Size(624, 254);
            dataGridView1.TabIndex = 0;
            dataGridView1.CellContentClick += dataGridView1_CellContentClick;
            dataGridView1.RowHeaderMouseClick += dataGridView1_RowHeaderMouseClick;
            // 
            // btnAdd
            // 
            btnAdd.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            btnAdd.Location = new Point(442, 677);
            btnAdd.Name = "btnAdd";
            btnAdd.Size = new Size(90, 30);
            btnAdd.TabIndex = 1;
            btnAdd.Text = "Rensa";
            btnAdd.UseVisualStyleBackColor = true;
            btnAdd.Visible = false;
            btnAdd.Click += btnAdd_Click;
            // 
            // btnDelete
            // 
            btnDelete.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            btnDelete.Location = new Point(844, 677);
            btnDelete.Name = "btnDelete";
            btnDelete.Size = new Size(90, 30);
            btnDelete.TabIndex = 2;
            btnDelete.Text = "Ta bort";
            btnDelete.UseVisualStyleBackColor = true;
            btnDelete.Visible = false;
            // 
            // txtSearch
            // 
            txtSearch.Location = new Point(259, 10);
            txtSearch.Name = "txtSearch";
            txtSearch.Size = new Size(442, 23);
            txtSearch.TabIndex = 4;
            txtSearch.TextChanged += txtSearch_TextChanged;
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
            lblUserName.Location = new Point(1261, 588);
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
            btnLogIn.Location = new Point(1282, 676);
            btnLogIn.Name = "btnLogIn";
            btnLogIn.Size = new Size(77, 30);
            btnLogIn.TabIndex = 10;
            btnLogIn.Text = "Logga in";
            btnLogIn.UseVisualStyleBackColor = true;
            // 
            // lblSearch
            // 
            lblSearch.AutoSize = true;
            lblSearch.Location = new Point(192, 13);
            lblSearch.Name = "lblSearch";
            lblSearch.Size = new Size(45, 15);
            lblSearch.TabIndex = 12;
            lblSearch.Text = "Search:";
            // 
            // lblCategory
            // 
            lblCategory.AutoSize = true;
            lblCategory.Location = new Point(183, 60);
            lblCategory.Name = "lblCategory";
            lblCategory.Size = new Size(54, 15);
            lblCategory.TabIndex = 13;
            lblCategory.Text = "Kategori:";
            // 
            // comboBox
            // 
            comboBox.FormattingEnabled = true;
            comboBox.Location = new Point(259, 57);
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
            listBoxRecipe.Size = new Size(626, 169);
            listBoxRecipe.TabIndex = 16;
            listBoxRecipe.SelectedIndexChanged += listBox1_SelectedIndexChanged;
            // 
            // pictureBoxRecipe
            // 
            pictureBoxRecipe.Location = new Point(13, 173);
            pictureBoxRecipe.Name = "pictureBoxRecipe";
            pictureBoxRecipe.Size = new Size(288, 300);
            pictureBoxRecipe.TabIndex = 17;
            pictureBoxRecipe.TabStop = false;
            // 
            // txtTitle
            // 
            txtTitle.Location = new Point(470, 182);
            txtTitle.Name = "txtTitle";
            txtTitle.Size = new Size(288, 23);
            txtTitle.TabIndex = 18;
            // 
            // lblFoodlList
            // 
            lblFoodlList.AutoSize = true;
            lblFoodlList.Location = new Point(183, 121);
            lblFoodlList.Name = "lblFoodlList";
            lblFoodlList.Size = new Size(49, 15);
            lblFoodlList.TabIndex = 19;
            lblFoodlList.Text = "Matlista";
            // 
            // comboBox1
            // 
            comboBox1.FormattingEnabled = true;
            comboBox1.Location = new Point(259, 115);
            comboBox1.Name = "comboBox1";
            comboBox1.Size = new Size(442, 23);
            comboBox1.TabIndex = 20;
            comboBox1.SelectedIndexChanged += comboBox1_SelectedIndexChanged;
            // 
            // btnLogout
            // 
            btnLogout.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            btnLogout.Location = new Point(1438, 676);
            btnLogout.Name = "btnLogout";
            btnLogout.Size = new Size(80, 30);
            btnLogout.TabIndex = 21;
            btnLogout.Text = "Logga Ut";
            btnLogout.UseVisualStyleBackColor = true;
            btnLogout.Visible = false;
            btnLogout.Click += btnLogout_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(994, 211);
            label1.Name = "label1";
            label1.Size = new Size(68, 15);
            label1.TabIndex = 22;
            label1.Text = "Beskrivning";
            // 
            // txtDescription1
            // 
            txtDescription1.Location = new Point(967, 234);
            txtDescription1.Margin = new Padding(3, 2, 3, 2);
            txtDescription1.Multiline = true;
            txtDescription1.Name = "txtDescription1";
            txtDescription1.Size = new Size(290, 167);
            txtDescription1.TabIndex = 23;
            // 
            // lblpicturePath
            // 
            lblpicturePath.AutoSize = true;
            lblpicturePath.Location = new Point(707, 151);
            lblpicturePath.Name = "lblpicturePath";
            lblpicturePath.Size = new Size(27, 15);
            lblpicturePath.TabIndex = 24;
            lblpicturePath.Text = "Bild";
            lblpicturePath.Visible = false;
            // 
            // lblCat
            // 
            lblCat.AutoSize = true;
            lblCat.Location = new Point(174, 89);
            lblCat.Name = "lblCat";
            lblCat.Size = new Size(72, 15);
            lblCat.TabIndex = 26;
            lblCat.Text = "Ny Kategori:";
            lblCat.Visible = false;
            // 
            // txtCat
            // 
            txtCat.Location = new Point(259, 89);
            txtCat.Name = "txtCat";
            txtCat.Size = new Size(442, 23);
            txtCat.TabIndex = 27;
            txtCat.Visible = false;
            // 
            // btnSave
            // 
            btnSave.Location = new Point(323, 677);
            btnSave.Margin = new Padding(2);
            btnSave.Name = "btnSave";
            btnSave.Size = new Size(83, 30);
            btnSave.TabIndex = 0;
            btnSave.Text = "Spara";
            btnSave.Visible = false;
            btnSave.Click += btnSave_Click_1;
            // 
            // openFileDialog1
            // 
            openFileDialog1.FileName = "openFileDialog1";
            // 
            // btnOpenFIleDialog
            // 
            btnOpenFIleDialog.Location = new Point(138, 148);
            btnOpenFIleDialog.Margin = new Padding(2);
            btnOpenFIleDialog.Name = "btnOpenFIleDialog";
            btnOpenFIleDialog.Size = new Size(116, 20);
            btnOpenFIleDialog.TabIndex = 28;
            btnOpenFIleDialog.Text = "Ladda upp bild";
            btnOpenFIleDialog.UseVisualStyleBackColor = true;
            btnOpenFIleDialog.Visible = false;
            btnOpenFIleDialog.Click += btnOpenFIleDialog_Click;
            // 
            // txtBildkälla
            // 
            txtBildkälla.Location = new Point(259, 146);
            txtBildkälla.Name = "txtBildkälla";
            txtBildkälla.Size = new Size(442, 23);
            txtBildkälla.TabIndex = 29;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1620, 765);
            Controls.Add(txtBildkälla);
            Controls.Add(btnOpenFIleDialog);
            Controls.Add(btnSave);
            Controls.Add(txtCat);
            Controls.Add(lblCat);
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
            Name = "Form1";
            Text = "Form1";
            Load += Form1_Load;
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBoxRecipe).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        internal DataGridView dataGridView1;
        internal Button btnAdd;
        private TextBox txtSearch;
        internal TextBox txtUserName;
        internal TextBox txtPassword;
        internal Label lblUserName;
        private Label lblPassWord;
        private Label lblSearch;
        private Label lblCategory;
        private ComboBox comboBox;
        private ListBox listBoxRecipe;
        private PictureBox pictureBoxRecipe;
        private TextBox txtTitle;
        private Label lblFoodlList;
        private ComboBox comboBox1;
        internal Button btnLogout;
        private Label label1;
        private TextBox txtDescription1;
        internal Label lblpicturePath;
        internal Label lblCat;
        internal TextBox txtCat;
        internal Button btnSave;
        private OpenFileDialog openFileDialog1;
        internal Button btnOpenFIleDialog;
        internal Button btnDelete;
        internal Button btnLogIn;
        private TextBox txtBildkälla;
    }
}