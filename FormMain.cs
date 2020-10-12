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
            Console.WriteLine("\n Début de la définition des caractéristiques de votre Personnage \n");
            Console.WriteLine("\n");
        }
        public int ConfigurerCarac()
        {
            Lanceur PremierLancéD6 = new Lanceur();
            Lanceur DeuxièmeLancéD6 = new Lanceur();
            Lanceur TroisièmeLancéD6 = new Lanceur();
            Lanceur QuatrièmeLancéD6 = new Lanceur();
            int Caracteristique;
            int PremierLancé = PremierLancéD6.Lanceur1D6();
            int DeuxiemeLancé = DeuxièmeLancéD6.Lanceur1D6();
            int TroisiemeLancé = TroisièmeLancéD6.Lanceur1D6();
            int QuatriemeLancé = QuatrièmeLancéD6.Lanceur1D6();

            Console.WriteLine("Les résultats des lancés sont: {0}, {1}, {2}, {3}", PremierLancé, DeuxiemeLancé, TroisiemeLancé, QuatriemeLancé);

            // DropLowest.

            int[] ValeurDesLancés = { PremierLancé, DeuxiemeLancé, TroisiemeLancé, QuatriemeLancé };
            Array.Sort(ValeurDesLancés);
            Console.WriteLine("{0} Est la valeure de lancé la plus basse des quatres lancés.", ValeurDesLancés[0]);

            Caracteristique = ValeurDesLancés[1] + ValeurDesLancés[2] + ValeurDesLancés[3];
            return Caracteristique;
        }

        private void progressBar_Lancement_Click(object sender, EventArgs e)
        {
            int PremiereCaracteristique = ConfigurerCarac();
            int DeuxiemeCaracteristique = ConfigurerCarac();
            int TroisiemeCaracteristique = ConfigurerCarac();
            int QuatriemeCaracteristique = ConfigurerCarac();
            int CinquiemeCaracteristique = ConfigurerCarac();
            int SixiemeCaracteristique = ConfigurerCarac();

            // La pluspart des gens ont une moyenne des cractéristiques évoluant autour de 10/11
            // Le personnage est hors norme. 
            // Sa moyenne doit être supérieur à 12 = normal 
            // Augmenter au diminuer la difficulté du jeu en augmentant ou diminuant la moyenne des caractéristiques
            // Non implémenté.
            // 13 = facile
            // 11 = difficile etc...

            int MoyenneDesCarac;
            bool MoyenneIsValide = false;

            while (!MoyenneIsValide == true)
            {
                MoyenneDesCarac = (PremiereCaracteristique + DeuxiemeCaracteristique + TroisiemeCaracteristique + QuatriemeCaracteristique + CinquiemeCaracteristique + SixiemeCaracteristique) / 6;
                Console.WriteLine("\n La Moyenne des caracteristique est : " + MoyenneDesCarac);
                if (MoyenneDesCarac >= 12)
                {
                    Console.WriteLine("Votre Personnage est valide. \n");
                    MoyenneIsValide = true;
                }
                else
                {
                    Console.WriteLine("Votre Personnage est invalide.\n");
                    Console.WriteLine("Nous relançons les dés de caracteristiques.");
                    PremiereCaracteristique = ConfigurerCarac();
                    DeuxiemeCaracteristique = ConfigurerCarac();
                    TroisiemeCaracteristique = ConfigurerCarac();
                    QuatriemeCaracteristique = ConfigurerCarac();
                    CinquiemeCaracteristique = ConfigurerCarac();
                    SixiemeCaracteristique = ConfigurerCarac();
                    MoyenneIsValide = false;
                }
            }

            Console.WriteLine("");
            Console.WriteLine("Votre première caracteristique [1] vaut : " + PremiereCaracteristique);
            Console.WriteLine("Votre deuxième caracteristique [2] vaut : " + DeuxiemeCaracteristique);
            Console.WriteLine("Votre troisième caracteristique [3] vaut : " + TroisiemeCaracteristique);
            Console.WriteLine("Votre quatrième caracteristique [4]vaut : " + QuatriemeCaracteristique);
            Console.WriteLine("Votre cinquième caracteristique [5] vaut : " + CinquiemeCaracteristique);
            Console.WriteLine("Votre sixième caracteristique [6] vaut : " + SixiemeCaracteristique);

            Console.WriteLine("\n Vous devez désormais répartir ses valeurs entre les caractéristiques.");
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label_DragTest_DragDrop(object sender, DragEventArgs e)
        {

        }
    }
}
