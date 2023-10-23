namespace Gruppuppgift
{
    public partial class Form1 : Form
    {
        private List<Recept> recepts;

        public Form1()
        {
            InitializeComponent();
            recepts = new List<Recept>();
        }



        private void LoadDataFromFile()
        {

            string filePath = @"C:\Recept.txt";
            using (StreamReader reader = new StreamReader(filePath))
            {
                string rad;

                while ((rad = reader.ReadLine()) != null)
                {
                    string[] columnNames = rad.Split('|');
                    string title = columnNames[0];
                    string description = columnNames[1];
                    string type = columnNames[2];

                }
            }
        }

        private void scrollbarK_Scroll(object sender, ScrollEventArgs e)
        {

        }
    }
}