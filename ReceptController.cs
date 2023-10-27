using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Gruppuppgift

{
    public class ReceptController
    {
        private Form1 view;
        private BindingList<Recept> receptsBindingList;
        private User user;
        public ReceptController(Form1 view, BindingList<Recept> receptsBindingList)
        {
            this.view = view;
            this.receptsBindingList = receptsBindingList;




            // Koppla händelser
            view.btnLogIn.Click += BtnLogIn_Click;
            view.btnDelete.Click += BtnDelete_Click;
            // ... andra knapphändelser
        }


        internal void BtnLogIn_Click(object sender, EventArgs e)
        {

            string inputUsername = view.txtUserName.Text;
            string inputPassword = view.txtPassword.Text;

            user = new User();

            if (user.Authenticate(inputUsername, inputPassword))
            {
                // 
                view.btnAdd.Visible = true;
                view.btnDelete.Visible = true;

                view.btnLogout.Visible = true;
                view.lblpicturePath.Visible = true;

                view.lblCat.Visible = true;
                view.txtCat.Visible = true;
                view.btnLogIn.Visible = false;
                view.btnSave.Visible = true;
                view.btnOpenFIleDialog.Visible = true;
                MessageBox.Show("Du är nu inloggad och kan ändra recept");
                view.txtUserName.Text = "";
                view.txtPassword.Text = "";
            }
            else
            {
                MessageBox.Show("Fel användarnamn eller lösenord. Försök igen.");
            }
        }

        internal void BtnDelete_Click(object sender, EventArgs e)
        {
            if (view.dataGridView1.SelectedRows.Count > 0)
            {
                Recept selectedRecept = (Recept)view.dataGridView1.SelectedRows[0].DataBoundItem;
                if (selectedRecept != null)
                {
                    // Ta bort från binding list
                    receptsBindingList.Remove(selectedRecept);

                    // Uppdatera UI direkt efter borttagning
                    view.UpdateUI();

                    // Skriv nu om hela filen med den uppdaterade listan
                    SaveDataToFile();

                    MessageBox.Show("Receptet har tagits bort!");
                }
            }
            else
            {
                MessageBox.Show("Vänligen välj ett recept att ta bort.");
            }
        }
        private void SaveDataToFile()
        {
            string filePath = view.filePath;
            using (StreamWriter writer = new StreamWriter(filePath))
            {
                foreach (Recept recept in receptsBindingList)
                {
                    writer.WriteLine($"{recept.Title}|{recept.Description}|{recept.Type}");
                }
            }
        }
    }
}
