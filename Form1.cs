using Microsoft.VisualBasic.ApplicationServices;
using System.ComponentModel;
using System.Drawing;
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
        public HashSet<string> Categories
        {
            get { return categories; }
            set { categories = value; }
        }

        public TextBox TxtTitle => txtTitle;
        public TextBox TxtDescription => txtDescription1;
        public TextBox TxtCat => txtCat;
        public Recept SelectedRecept { get; set; }

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
            foreach (DataGridViewColumn col in dataGridView1.Columns)
            {
                col.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            }
            //Form properties
            FormProperties.SetFormProperties(this);

            //Error log printer
            logger = new Logger();


            // Subscribe to the LogAdded event
            logger.LogAdded += Logger_LogAdded;
        }


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
            string errorTime = $"[{DateTime.Now}] -";

            string errorMessage = $" {ex.Message}";

            string logFilePath = @"......\ErrorLog.txt";

            try
            {

                File.AppendAllText(logFilePath, errorTime + errorMessage + Environment.NewLine);

                // Add this line to log the error
                //logger.AddLogEntry(errorMessage);

                if (logger != null)
                {
                    logger.AddLogEntry(errorMessage);
                }

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
            if (comboBox.SelectedItem != null)
            {
                string selectedCategory = comboBox.SelectedItem.ToString();
                BindingList<Recept> filteredRecepts;

                if (selectedCategory == "Alla kategorier")
                {
                    // Visa alla recept
                    filteredRecepts = new BindingList<Recept>(receptsBindingList);
                   
                }
                else
                {
                    // Filtrera recept baserat på kategori
                    filteredRecepts = new BindingList<Recept>(
                        receptsBindingList.Where(recept => recept.Type == selectedCategory).ToList()
                    );
                   
                }

                // Uppdatera DataGridView med filtrerade recept
                dataGridView1.DataSource = filteredRecepts;
                //comboBox.Items.Clear();
                //comboBox.Items.AddRange(categories.ToArray());
            }
        }


        public void ClearTextBoxes()
        {
            txtTitle.Clear();
            txtDescription1.Clear();
            txtCat.Clear();

            // Rensa även valt recept för att undvika oavsiktlig redigering
            selectedRecept = null;
        }

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
                    writer.WriteLine($"{Titel}|{Description}{selectedCategory}");
                }
            }
            // Skapa ett nytt Recept och lägg till det i BindingList
            Recept newRecept = new Recept { Title = Titel, Description = Description, Type = Type ?? selectedCategory };
            receptsBindingList.Add(newRecept);

            // Lägg till den nya kategorin om den inte redan finns
            bool categoryAdded = categories.Add(Type ?? selectedCategory);

            if (categoryAdded)
            {
                // Uppdatera ComboBox om en ny kategori har lagts till
                UpdateCategoriesComboBox();
            }

            UpdateUI(); // Uppdatera UI med den nya datan
        }
        public void UpdateCategoriesComboBox()
        {
            comboBox.Items.Clear();
            comboBox.Items.AddRange(categories.ToArray());
            comboBox.SelectedIndex = comboBox.Items.Count - 1; // Välj den nyligen tillagda kategorin
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

                //Defined in Logger.cs
                string errorMessage = "error_001";
                string errorMsg = logger.GetErrorMessage(errorMessage);

                if (errorMsg != null)
                {

                    LogError(new Exception(errorMsg));
                    logger.AddLogEntry(errorMsg);

                    ErrorForm errorForm = new ErrorForm(logger.GetLogEntries());
                    errorForm.Show();

                    //Do not proceed with the search
                    return;

                }
                else
                {

                    //Handle case where error message is not found

                }

            }

            var filteredList = new BindingList<Recept>(receptsBindingList
                .Where(x => x.Title.IndexOf(searchText, StringComparison.OrdinalIgnoreCase) >= 0 || x.Type.IndexOf(searchText, StringComparison.OrdinalIgnoreCase) >= 0)
                .ToList());

            dataGridView1.DataSource = filteredList;
        }


        private void btnSave_Click_1(object sender, EventArgs e)
        {
            ButtonHandlers.SaveButton_Click(
                selectedRecept,
                txtTitle.Text,
                txtDescription1.Text,
                txtCat.Text,
                comboBox.Text,
                WriteDataToFile,
                SaveRecept,
                LoadDataFromFile,
                UpdateUI
            );
        }


        internal void LoadDataFromFile()
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

        public void WriteDataToFile()
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

            foreach (DataGridViewColumn col in dataGridView1.Columns)
            {
                col.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            }
        }
    }
}