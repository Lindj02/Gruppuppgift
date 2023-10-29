
using Microsoft.VisualBasic.ApplicationServices;
using System.ComponentModel;
using System.Security.Cryptography.X509Certificates;
using System.Windows.Forms;

namespace Gruppuppgift
{
    public partial class Form1 : Form
    {
        private BindingList<Recept> receptsBindingList;
        private User user;
        public string filePath = @"..\..\..\recept.txt";
        HashSet<string> categories = new HashSet<string>();

        //Class Logger.cs
        private Logger logger;

        public Form1()
        {
            InitializeComponent();
            receptsBindingList = new BindingList<Recept>();
            LoadDataFromFile();
            categories.Add("Alla kategorier");
            comboBox.Items.AddRange(categories.ToArray());
            new ReceptController(this, receptsBindingList);
            this.WindowState = FormWindowState.Maximized;
            // Sätt DataGridView's DataSource till receptsBindingList
            dataGridView1.DataSource = receptsBindingList;

            ///////////////////////////////////////
            ////////// Jorge - Jensen /////////////
            ///////////////////////////////////////

            //Form properties
            FormProperties.SetFormProperties(this);

            //Error log printer
            logger = new Logger();

            // Subscribe to the LogAdded event
            logger.LogAdded += Logger_LogAdded;

        }



        private void LoadDataFromFile()
        {
            try
            {
                receptsBindingList.Clear();

                using (StreamReader reader = new StreamReader(filePath))
                {
                    string rad;
                    while ((rad = reader.ReadLine()) != null)
                    {
                        string[] columnNames = rad.Split('|');
                        string title = columnNames[0];
                        string description = columnNames[1];
                        string type = columnNames[2];

                        Recept recept = new Recept { Title = title, Description = description, Type = type };
                        receptsBindingList.Add(recept);
                        categories.Add(type);
                    }
                }
            }
            catch (Exception ex)
            {
                LogError(ex);
                MessageBox.Show("Ett fel uppstod vid inläsning av filen.");
            }
        }

        //jorge-00.00.02
        private void Logger_LogAdded(object sender, Logger.LogAddedEventArgs e)
        {

            // Show the ErrorForm with the new log message
            ErrorForm errorForm = new ErrorForm(e.LogMessage);

            //This will display the form without blocking Form1
            errorForm.Show();

        }

        //Print the logs in a .txt file.
        private void LogError(Exception ex)
        {
            string errorTime = $"[{ DateTime.Now}] -";

            string errorMessage = $" {ex.Message}";

            string logFilePath = @"..\..\..\ErrorLog.txt";


            try
            {

                File.AppendAllText(logFilePath, errorTime + errorMessage + Environment.NewLine);

                // Add this line to log the error
                logger.AddLogEntry(errorMessage);

            }
            catch
            {

                //If no way to print the error then handle the error

            }
        }


        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }


        public void comboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            string selectedCategory = comboBox.SelectedItem.ToString();
            comboBox1.Items.Clear();
            BindingList<Recept> filteredRecepts;

            if (selectedCategory == "Alla kategorier")
            {
                // Visa alla recept
                filteredRecepts = new BindingList<Recept>(receptsBindingList);
                foreach (Recept recept in receptsBindingList)
                {
                    comboBox1.Items.Add(recept.Title);
                }
            }
            else
            {
                // Filtrera recept baserat på kategori
                filteredRecepts = new BindingList<Recept>(
                    receptsBindingList.Where(recept => recept.Type == selectedCategory).ToList()
                );
                foreach (Recept recept in filteredRecepts)
                {
                    comboBox1.Items.Add(recept.Title);
                }
            }

            // Uppdatera DataGridView med filtrerade recept
            dataGridView1.DataSource = filteredRecepts;
        }


        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            string selectedRecipeTitle = comboBox1.SelectedItem.ToString();
            dataGridView1.DataSource = null;

            var selectedRecept = receptsBindingList.FirstOrDefault(recept => recept.Title == selectedRecipeTitle);

            if (selectedRecept != null)
            {
                dataGridView1.DataSource = new BindingList<Recept> { selectedRecept };
            }
        }

        // private void btnLogIn_Click(object sender, EventArgs e)
        //{

        // }

        private void btnLogout_Click(object sender, EventArgs e)
        {
            if (user != null)
            {
                user.Logout();

                // Göm admin-knapparna
                btnAdd.Visible = false;
                btnDelete.Visible = false;

                btnLogIn.Visible = true;
                btnSave.Visible = false;
                btnLogout.Visible = false;
                lblpicturePath.Visible = false;

                lblCat.Visible = false;
                txtCat.Visible = false;
            }
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            string searchTerm = txtSearch.Text;
            listBoxRecipe.Items.Clear();

            foreach (Recept recept in receptsBindingList)
            {
                if (recept.Title.Contains(searchTerm) || recept.Description.Contains(searchTerm) || recept.Type.Contains(searchTerm))
                {
                    listBoxRecipe.Items.Add("Titel: " + recept.Title);
                    listBoxRecipe.Items.Add("Beskrivning: " + recept.Description);
                    listBoxRecipe.Items.Add("Kategori: " + recept.Type);
                    listBoxRecipe.Items.Add(""); // Lägger till en tom rad mellan varje recept
                }
            }
        }

        // Öppnar form2.cs, obs används inte längre. Eventuellt använda sig av det när gör nytt recept.
        private void btnAdd_Click(object sender, EventArgs e)
        {
            ClearTextBoxes();
        }
        public void ClearTextBoxes()
        {
            txtTitle.Clear();
            txtDescription1.Clear();
            txtCat.Clear();

            // Rensa även valt recept för att undvika oavsiktlig redigering
            selectedRecept = null;
        }

        //private void btnDelete_Click(object sender, EventArgs e)
        //{

        //}



        public void SaveRecept(string Titel, string Description, string Type, string selectedCategory)
        {
            using (StreamWriter writer = new StreamWriter(filePath, true))
            {
                if (!string.IsNullOrEmpty(Type))
                {
                    writer.WriteLine($"{Titel}|{Description}|{Type}");
                }
                else if (!string.IsNullOrEmpty(selectedCategory))
                {
                    writer.WriteLine($"{Titel}|{Description}|{selectedCategory}");
                }
            }
            //MessageBox.Show("Du har sparat ett nytt recept");
            UpdateUI();
        }
        private Recept selectedRecept;

        private void dataGridView1_RowHeaderMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                selectedRecept = (Recept)dataGridView1.Rows[e.RowIndex].DataBoundItem;
                if (selectedRecept != null)
                {
                    txtTitle.Text = selectedRecept.Title;
                    txtDescription1.Text = selectedRecept.Description;
                    txtCat.Text = selectedRecept.Type;
                }
            }
        }

        private void txtSearch_TextChanged(object sender, EventArgs e)
        {
            string searchText = txtSearch.Text.ToLower();

            //Testing error logs
            //This if statement will be deleted before release day.
            //DO NOT TOUCH THIS!
            if (searchText.Contains("#") || searchText.Contains("$"))
            {
                string errorMessage = "Error: You need to use 'a', 'b', 'c' and not '#' or '$'";
                LogError(new Exception(errorMessage));

                //Create an instance of Logger
                Logger logger = new Logger();

                //Simulate an error
                logger.AddLogEntry(errorMessage);

                //Create an instance of ErrorForm and pass the log entries
                ErrorForm errorForm = new ErrorForm(logger.GetLogEntries());

                // Show the ErrorForm non-modally
                errorForm.Show();

                return; // Do not proceed with the search
            }

            var filteredList = new BindingList<Recept>(receptsBindingList
                .Where(x => x.Title.IndexOf(searchText, StringComparison.OrdinalIgnoreCase) >= 0 || x.Type.IndexOf(searchText, StringComparison.OrdinalIgnoreCase) >= 0)
                .ToList());

            dataGridView1.DataSource = filteredList;
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void btnSave_Click_1(object sender, EventArgs e)
        {
            if (selectedRecept != null)
            {
                // Uppdatera det valda receptet
                selectedRecept.Title = txtTitle.Text;
                selectedRecept.Description = txtDescription1.Text;
                selectedRecept.Type = txtCat.Text;

                // Skriv om filen
                WriteDataToFile();

                MessageBox.Show("Receptet har uppdaterats!");
            }
            else
            {
                // Skapa ett nytt recept
                SaveRecept(txtTitle.Text, txtDescription1.Text, txtCat.Text, comboBox.Text);
                MessageBox.Show("Ett nytt recept har lagts till!");
            }

            LoadDataFromFile();
            UpdateUI();
        }

        private void txtpicturePath_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnOpenFIleDialog_Click(object sender, EventArgs e)
        {
            using (OpenFileDialog openFileDialog = new OpenFileDialog())
            {
                // Set the initial directory to C:\
                openFileDialog.InitialDirectory = "C:\\";

                // Set the title of the dialog
                openFileDialog.Title = "Open File";


                openFileDialog.Filter = "All Files|*.*";

                if (openFileDialog.ShowDialog() == DialogResult.OK)
                {

                    string selectedFilePath = openFileDialog.FileName;


                    MessageBox.Show("Selected file: " + selectedFilePath);
                }
            }
        }
        private void WriteDataToFile()
        {
            using (StreamWriter writer = new StreamWriter(filePath))
            {
                foreach (Recept recept in receptsBindingList)
                {
                    writer.WriteLine($"{recept.Title}|{recept.Description}|{recept.Type}");
                }
            }
        }
        internal void UpdateUI()
        {
            // Uppdatera DataGridView
            dataGridView1.DataSource = null;
            dataGridView1.DataSource = receptsBindingList;

            comboBox1.Items.Clear();
            foreach (Recept recept in receptsBindingList)
            {
                comboBox1.Items.Add(recept.Title);
            }


        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        
    }
}
