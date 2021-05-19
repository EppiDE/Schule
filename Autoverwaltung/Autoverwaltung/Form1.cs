using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

//@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@
//@@@@@@@ Autor: Marc Eppinger
//@@@@@@@ Programname: Âutoverwaltung
//@@@@@@@ Beschreibung:
//@@@@@@@ – Einfaches Tool zum anlegen einer Autodatenbank (ohne Speicher)
//@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@

namespace Autoverwaltung
    /* TODO: Speichern der Werte ermöglichen. Erst als Stream .csv, dann als SQL
     *       Prüfen ob ein String ein Kommata beinhaltet
     *       Prüfen ob Spitzname schon vorhanden
     *       Prüfen ob Jahreszahl realistisch
     *       Hotkeys anlegen
     *       UI 
     *       Prüffenster für Löschung
     *       Vervollständigung für gängige Farben
    */
{
    public partial class FormVerwaltung : Form
    {
        public FormVerwaltung()
        {
            InitializeComponent();
        }
        // Struktur und Liste für die textBox
        public struct strucAuto
        {
            public string Marke;
            public string Modell;
            public string Farbe;
            public int Baujahr;
            public string Spitzname;
            public double Kaufpreis;
            public override string ToString()
            {
                return Spitzname;
            }
            
        }
        List<strucAuto> listAuto = new List<strucAuto>();
        public string[] stArrayAuto = File.ReadAllLines(@"../../../scores.csv");
        int exam = 3;
        // Methode zum hinzufügen eines strucAuto zur Liste
        private strucAuto addItemToList()
        {   //Anlegen der Variablen
            strucAuto scLocalAuto = new strucAuto();
            int intParsedValue;
            double dbParsedValue;
            scLocalAuto.Marke = textBoxMarke.Text;
            scLocalAuto.Modell = textBoxModell.Text;
            scLocalAuto.Farbe = textBoxFarbe.Text;
            //Prüfen ob ein Spitzname vorhanden
            if (textBoxSpitzname.Text.Length > 0)
            {
                scLocalAuto.Spitzname = textBoxSpitzname.Text;
            }
            // Generischer Spitzname der in der Liste angezeigt wird, sofern keiner eingegeben wurde
            else
            {
                scLocalAuto.Spitzname = "Auto " + (listBoxGarageAutos.Items.Count+1);
            }
            // Testen ob Eingabe korrekt
            // Fall wenn korrekt
            if (int.TryParse(textBoxBaujahr.Text, out intParsedValue))
            {
                scLocalAuto.Baujahr = Convert.ToInt32(textBoxBaujahr.Text);
            }
            // Fall wenn KEINE Angabe gemacht wurde
            else if (textBoxBaujahr == null || !int.TryParse(textBoxBaujahr.Text, out intParsedValue))
            {
                scLocalAuto.Baujahr = 0;
            }
            // Fall wenn EIngabe falsch bspw. Buchstabe
            if (textBoxBaujahr.Text.Length > 0 && !int.TryParse(textBoxBaujahr.Text, out intParsedValue))
            {
                MessageBox.Show("Ungültige Jahreszahl!\r\nBitte Aktualisieren!");
            }
            // Selbe für den Kaufpreis
            if (double.TryParse(textBoxKaufpreis.Text, out dbParsedValue))
            {
                scLocalAuto.Kaufpreis = Convert.ToDouble(textBoxKaufpreis.Text);
            }
            else if (textBoxKaufpreis == null || !double.TryParse(textBoxKaufpreis.Text, out dbParsedValue))
            {
                scLocalAuto.Kaufpreis = 0;
            }
            if (textBoxKaufpreis.Text.Length > 0 && !double.TryParse(textBoxKaufpreis.Text, out dbParsedValue))
            {
                MessageBox.Show("Ungültiger Kaufpreis!\r\nBitte Aktualisieren!");
            }
            return scLocalAuto;
        }
        //Hinzufügen der Liste zur Listbox
        private void addListToListbox(strucAuto lscAuto)
        {
            listBoxGarageAutos.Items.Clear();
            listAuto.Add(lscAuto);
            foreach (strucAuto localstrucAuto in listAuto)
            {
                listBoxGarageAutos.Items.Add(localstrucAuto);
            }
        }
        private void buttonNeuAnlegen_Click(object sender, EventArgs e)
        {
            addListToListbox(addItemToList());
            clearTextboxes();
        }
        
        private void buttonAktualisieren_Click(object sender, EventArgs e)
        {
            int localSelected = listBoxGarageAutos.SelectedIndex;
            listBoxGarageAutos.Items.RemoveAt(localSelected);
            listBoxGarageAutos.Items.Insert(localSelected, addItemToList());
        }

        private void buttonLoeschen_Click(object sender, EventArgs e)
        {
            //int localSelected = listBoxGarageAutos.SelectedIndex;
            //listBoxGarageAutos.Items.RemoveAt(localSelected);
            strucAuto localStrucAutoSelected = new strucAuto();
            localStrucAutoSelected = (strucAuto)listBoxGarageAutos.SelectedItem;
            listBoxGarageAutos.Items.Remove(localStrucAutoSelected);
        }

        private void buttonExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
        private void showSelectedItem()
        {
            strucAuto localScAuto = (strucAuto)listBoxGarageAutos.SelectedItem;
            textBoxModell.Text = localScAuto.Modell;
            textBoxBaujahr.Text = Convert.ToString(localScAuto.Baujahr);
            textBoxFarbe.Text = localScAuto.Farbe;
            textBoxKaufpreis.Text = Convert.ToString(localScAuto.Kaufpreis);
            textBoxMarke.Text = localScAuto.Marke;
            textBoxSpitzname.Text = localScAuto.Spitzname;
        }
        //Methode zum leeren der Textfelder
        private void clearTextboxes()
        {
            textBoxBaujahr.ResetText();
            textBoxFarbe.ResetText();
            textBoxKaufpreis.ResetText();
            textBoxMarke.ResetText();
            textBoxModell.ResetText();
            textBoxSpitzname.ResetText();
        }
        //Eventhandler zum anzeigen der ausgewählten Autos
        private void listGarageAutos_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (listBoxGarageAutos.SelectedIndex < 0)
            {
                buttonAktualisieren.Enabled = false;
                buttonLoeschen.Enabled = false;
                clearTextboxes();
            }
            else
            {
                buttonAktualisieren.Enabled = true;
                buttonLoeschen.Enabled = true;
                showSelectedItem();
            }
        }
        // Schließen des Welcome Panels
        // TODO: Erstellen eines Häkchens, das den WelcomeScreen komplett deaktiviert
        private void buttonOkay_Click(object sender, EventArgs e)
        {
            panelWelcomeScreen.Enabled = false;
            panelWelcomeScreen.Visible = false;
        }
        private void buttonClearTextfields_Click(object sender, EventArgs e)
        {
            clearTextboxes();
        }

        private void saveStreamAsFile(string filePath, Stream inputStream, string fileName)
        {
            DirectoryInfo info = new DirectoryInfo(filePath);
            if (!info.Exists)
            {
                info.Create();
            }

            string path = Path.Combine(filePath, fileName);
            using (FileStream outputFileStream = new FileStream(path, FileMode.Create))
            {
                inputStream.CopyTo(outputFileStream);
            }
        }      
        private void readCsvFile(string path)
        {
           stArrayAuto = File.ReadAllLines(path); // @"../../../scores.csv"
        }
        private void csvFileSafe(IEnumerable<string> strs)
        {
            IEnumerable<IEnumerable<string>> multiColQuery =
           from line in strs
           let elements = line.Split(',')
           //let scores = elements.Skip(1)
           select (from str in elements
                   select str);
            var stRac = multiColQuery.ToList();
            for (int i = 0; i < 5, i++) {
                var stRad = from row in stRad
                            select row.ElementAt(i);
                /*var results = multiColQuery.ToList();
                int columnCount = results[0].Count();
                for (int column = 0; column < columnCount; column++)
                {
                    var results2 = from row in results
                                   select row.ElementAt(column);
                    double average = results2.Average();
                    int max = results2.Max();
                    int min = results2.Min();
                }*/
            }
        }
    }
}
