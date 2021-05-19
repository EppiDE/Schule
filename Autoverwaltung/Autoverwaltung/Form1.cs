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
{
    public partial class FormVerwaltung : Form
    {
        public FormVerwaltung()
        {
            InitializeComponent();
        }

        public struct strucAuto
        {
            public string Marke;
            public string Modell;
            public string Farbe;
            public int Baujahr;
            public string Spitzname;
            public double Kaufpreis;
            /*public override string ToString()
            {
                return Spitzname;
            }*/
            
        }
        

        List<strucAuto> listAuto = new List<strucAuto>();

        private void buttonNeuAnlegen_Click(object sender, EventArgs e)
        {
            addListToListbox(addItemToList());
        }

        private strucAuto addItemToList()
        {
            strucAuto scLocalAuto = new strucAuto();
            int intParsedValue;
            double dbParsedValue;
            scLocalAuto.Marke = textBoxMarke.Text;
            scLocalAuto.Modell = textBoxModell.Text;
            scLocalAuto.Farbe = textBoxFarbe.Text;
            if (textBoxSpitzname.Text.Length > 0)
            {
                scLocalAuto.Spitzname = textBoxSpitzname.Text;
            }
            else
            {
                scLocalAuto.Spitzname = "404";
            }

            if (int.TryParse(textBoxBaujahr.Text, out intParsedValue))
            {
                scLocalAuto.Baujahr = Convert.ToInt32(textBoxBaujahr.Text);
            }
            else if (textBoxBaujahr == null || !int.TryParse(textBoxBaujahr.Text, out intParsedValue))
            {
                scLocalAuto.Baujahr = 0;
            }
            if (textBoxBaujahr.Text.Length > 0 && !int.TryParse(textBoxBaujahr.Text, out intParsedValue))
            {
                MessageBox.Show("Ungültige Jahreszahl!\r\nBitte Aktualisieren!");
            }
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
        private void addListToListbox(strucAuto lscAuto)
        {
            listBoxGarageAutos.Items.Clear();
            listAuto.Add(lscAuto);
            foreach (strucAuto localstrucAuto in listAuto)
            {
                listBoxGarageAutos.Items.Add(localstrucAuto);
            }
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
            textBoxKaufpreis.Text = localScAuto.Spitzname;
        }
        private void clearTextboxes()
        {
            textBoxBaujahr.ResetText();
            textBoxFarbe.ResetText();
            textBoxKaufpreis.ResetText();
            textBoxMarke.ResetText();
            textBoxModell.ResetText();
            textBoxSpitzname.ResetText();
        }
        private void listGarageAutos_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (listBoxGarageAutos.SelectedIndex < 0)
            {
                buttonAktualisieren.Enabled = false;
                buttonLoeschen.Enabled = false;
                //clearTextboxes();
            }
            else
            {
                buttonAktualisieren.Enabled = true;
                buttonLoeschen.Enabled = true;
                showSelectedItem();
            }
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void buttonOkay_Click(object sender, EventArgs e)
        {
            panelWelcomeScreen.Enabled = false;
            panelWelcomeScreen.Visible = false;
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

        private void buttonClearTextfields_Click(object sender, EventArgs e)
        {
            clearTextboxes();
        }
    }
}
