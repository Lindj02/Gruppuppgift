﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Gruppuppgift
{
    public class ButtonHandlers
    {
        public delegate void SaveReceptDelegate(string title, string description, string picturePatch, string type, string selectedCategory);

        public static void SaveButton_Click(
               Recept selectedRecept,
               string title,
               string description,
               string picturePatch,
               string type,
               string comboBoxText,
               Action writeDataToFile,
               SaveReceptDelegate saveRecept,
               Action savePictures,
               Action loadDataFromFile,
               Action updateUI
            )
        {
            if (selectedRecept != null)
            {
                //Uppdatera det valda receptet
                selectedRecept.Title = title;
                selectedRecept.Description = description;
                selectedRecept.PicturePatch = picturePatch;
                selectedRecept.Type = type;

                //Skriv om filen
                writeDataToFile();

                MessageBox.Show("Receptet har uppdaterats!");
            }
            else
            {
                //Skapa ett nytt recept
                saveRecept(title, description, picturePatch, type, comboBoxText);
                MessageBox.Show("Ett nytt recept har lagts till!");
            }

            savePictures();
            loadDataFromFile();
            updateUI();
        }
    }
}
