using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PremierTest
{
    public partial class FormMain : Form
    {
        public FormMain()
        {
            InitializeComponent();
        }

        private void btn_Test_Click(object sender, EventArgs e)
        {
            string sexe = (radioButton_SexeM.Checked == true) ? "Masculin" : "Féminin";
            MessageBox.Show("Bonjour " + textBox_NomPerso.Text + 
                "\nTu es un " + comboBox_SelectRace.SelectedItem +
                "\nDe sexe : " + sexe +
                "\nTu es un : "+ comboBox_choixClass.SelectedItem);
        }

        private void groupBox_Intro_Enter(object sender, EventArgs e)
        {

        }

        private void button_ValiderPresentation_Click(object sender, EventArgs e)
        {
            groupBox_Caractéristiques.Show();
        }
    }
}
