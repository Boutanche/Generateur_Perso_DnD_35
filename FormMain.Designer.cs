namespace PremierTest
{
    partial class FormMain
    {
        /// <summary>
        /// Variable nécessaire au concepteur.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Nettoyage des ressources utilisées.
        /// </summary>
        /// <param name="disposing">true si les ressources managées doivent être supprimées ; sinon, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Code généré par le Concepteur Windows Form

        /// <summary>
        /// Méthode requise pour la prise en charge du concepteur - ne modifiez pas
        /// le contenu de cette méthode avec l'éditeur de code.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormMain));
            this.btn_Test = new System.Windows.Forms.Button();
            this.label_Titre = new System.Windows.Forms.Label();
            this.textBox_NomPerso = new System.Windows.Forms.TextBox();
            this.label_NomPerso = new System.Windows.Forms.Label();
            this.comboBox_SelectRace = new System.Windows.Forms.ComboBox();
            this.label_SelectRace = new System.Windows.Forms.Label();
            this.label_Sexe = new System.Windows.Forms.Label();
            this.radioButton_SexeM = new System.Windows.Forms.RadioButton();
            this.radioButton_SexeF = new System.Windows.Forms.RadioButton();
            this.label_choixClasse = new System.Windows.Forms.Label();
            this.comboBox_choixClass = new System.Windows.Forms.ComboBox();
            this.groupBox_Intro = new System.Windows.Forms.GroupBox();
            this.button_ValiderPresentation = new System.Windows.Forms.Button();
            this.groupBox_Caractéristiques = new System.Windows.Forms.GroupBox();
            this.label_LancéD = new System.Windows.Forms.Label();
            this.groupBox_Intro.SuspendLayout();
            this.groupBox_Caractéristiques.SuspendLayout();
            this.SuspendLayout();
            // 
            // btn_Test
            // 
            this.btn_Test.Location = new System.Drawing.Point(6, 177);
            this.btn_Test.Name = "btn_Test";
            this.btn_Test.Size = new System.Drawing.Size(75, 23);
            this.btn_Test.TabIndex = 0;
            this.btn_Test.Text = "Test";
            this.btn_Test.UseVisualStyleBackColor = true;
            this.btn_Test.Click += new System.EventHandler(this.btn_Test_Click);
            // 
            // label_Titre
            // 
            this.label_Titre.AutoSize = true;
            this.label_Titre.BackColor = System.Drawing.Color.Black;
            this.label_Titre.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label_Titre.Font = new System.Drawing.Font("Trajan Pro 3", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_Titre.ForeColor = System.Drawing.Color.Honeydew;
            this.label_Titre.Location = new System.Drawing.Point(167, 0);
            this.label_Titre.Name = "label_Titre";
            this.label_Titre.Size = new System.Drawing.Size(578, 41);
            this.label_Titre.TabIndex = 1;
            this.label_Titre.Text = "Générateur de Personnage D&&D 3.5";
            // 
            // textBox_NomPerso
            // 
            this.textBox_NomPerso.Location = new System.Drawing.Point(58, 35);
            this.textBox_NomPerso.Name = "textBox_NomPerso";
            this.textBox_NomPerso.Size = new System.Drawing.Size(153, 20);
            this.textBox_NomPerso.TabIndex = 2;
            this.textBox_NomPerso.Text = "Nom du personnage";
            // 
            // label_NomPerso
            // 
            this.label_NomPerso.AutoSize = true;
            this.label_NomPerso.Location = new System.Drawing.Point(6, 35);
            this.label_NomPerso.Name = "label_NomPerso";
            this.label_NomPerso.Size = new System.Drawing.Size(35, 13);
            this.label_NomPerso.TabIndex = 3;
            this.label_NomPerso.Text = "Nom :";
            // 
            // comboBox_SelectRace
            // 
            this.comboBox_SelectRace.FormattingEnabled = true;
            this.comboBox_SelectRace.Items.AddRange(new object[] {
            "Humain",
            "Nain",
            "Elfe",
            "Halfelin",
            "Demi-Elfe",
            "Demi-Orc"});
            this.comboBox_SelectRace.Location = new System.Drawing.Point(58, 74);
            this.comboBox_SelectRace.Name = "comboBox_SelectRace";
            this.comboBox_SelectRace.Size = new System.Drawing.Size(121, 21);
            this.comboBox_SelectRace.TabIndex = 4;
            this.comboBox_SelectRace.Text = "Race";
            // 
            // label_SelectRace
            // 
            this.label_SelectRace.AutoSize = true;
            this.label_SelectRace.Location = new System.Drawing.Point(9, 74);
            this.label_SelectRace.Name = "label_SelectRace";
            this.label_SelectRace.Size = new System.Drawing.Size(39, 13);
            this.label_SelectRace.TabIndex = 5;
            this.label_SelectRace.Text = "Race :";
            // 
            // label_Sexe
            // 
            this.label_Sexe.AutoSize = true;
            this.label_Sexe.Location = new System.Drawing.Point(9, 114);
            this.label_Sexe.Name = "label_Sexe";
            this.label_Sexe.Size = new System.Drawing.Size(37, 13);
            this.label_Sexe.TabIndex = 6;
            this.label_Sexe.Text = "Sexe :";
            // 
            // radioButton_SexeM
            // 
            this.radioButton_SexeM.AutoSize = true;
            this.radioButton_SexeM.Checked = true;
            this.radioButton_SexeM.Location = new System.Drawing.Point(58, 114);
            this.radioButton_SexeM.Name = "radioButton_SexeM";
            this.radioButton_SexeM.Size = new System.Drawing.Size(67, 17);
            this.radioButton_SexeM.TabIndex = 7;
            this.radioButton_SexeM.TabStop = true;
            this.radioButton_SexeM.Text = "Masculin";
            this.radioButton_SexeM.UseVisualStyleBackColor = true;
            // 
            // radioButton_SexeF
            // 
            this.radioButton_SexeF.AutoSize = true;
            this.radioButton_SexeF.Location = new System.Drawing.Point(131, 114);
            this.radioButton_SexeF.Name = "radioButton_SexeF";
            this.radioButton_SexeF.Size = new System.Drawing.Size(61, 17);
            this.radioButton_SexeF.TabIndex = 8;
            this.radioButton_SexeF.Text = "Féminin";
            this.radioButton_SexeF.UseVisualStyleBackColor = true;
            // 
            // label_choixClasse
            // 
            this.label_choixClasse.AutoSize = true;
            this.label_choixClasse.Location = new System.Drawing.Point(9, 150);
            this.label_choixClasse.Name = "label_choixClasse";
            this.label_choixClasse.Size = new System.Drawing.Size(44, 13);
            this.label_choixClasse.TabIndex = 9;
            this.label_choixClasse.Text = "Classe :";
            // 
            // comboBox_choixClass
            // 
            this.comboBox_choixClass.FormattingEnabled = true;
            this.comboBox_choixClass.Items.AddRange(new object[] {
            "Barbare",
            "Barde",
            "Druide",
            "Ensorceleur",
            "Guerrier",
            "Magicien",
            "Moine",
            "Paladin",
            "Prêtre",
            "Rôdeur",
            "Roublard"});
            this.comboBox_choixClass.Location = new System.Drawing.Point(58, 150);
            this.comboBox_choixClass.Name = "comboBox_choixClass";
            this.comboBox_choixClass.Size = new System.Drawing.Size(121, 21);
            this.comboBox_choixClass.TabIndex = 10;
            this.comboBox_choixClass.Text = "Classe";
            // 
            // groupBox_Intro
            // 
            this.groupBox_Intro.Controls.Add(this.button_ValiderPresentation);
            this.groupBox_Intro.Controls.Add(this.comboBox_choixClass);
            this.groupBox_Intro.Controls.Add(this.label_choixClasse);
            this.groupBox_Intro.Controls.Add(this.btn_Test);
            this.groupBox_Intro.Controls.Add(this.radioButton_SexeF);
            this.groupBox_Intro.Controls.Add(this.radioButton_SexeM);
            this.groupBox_Intro.Controls.Add(this.label_Sexe);
            this.groupBox_Intro.Controls.Add(this.label_SelectRace);
            this.groupBox_Intro.Controls.Add(this.comboBox_SelectRace);
            this.groupBox_Intro.Controls.Add(this.label_NomPerso);
            this.groupBox_Intro.Controls.Add(this.textBox_NomPerso);
            this.groupBox_Intro.Location = new System.Drawing.Point(12, 126);
            this.groupBox_Intro.Name = "groupBox_Intro";
            this.groupBox_Intro.Size = new System.Drawing.Size(216, 204);
            this.groupBox_Intro.TabIndex = 11;
            this.groupBox_Intro.TabStop = false;
            this.groupBox_Intro.Text = "Personnage";
            this.groupBox_Intro.Enter += new System.EventHandler(this.groupBox_Intro_Enter);
            // 
            // button_ValiderPresentation
            // 
            this.button_ValiderPresentation.Location = new System.Drawing.Point(87, 177);
            this.button_ValiderPresentation.Name = "button_ValiderPresentation";
            this.button_ValiderPresentation.Size = new System.Drawing.Size(75, 23);
            this.button_ValiderPresentation.TabIndex = 11;
            this.button_ValiderPresentation.Text = "Valider";
            this.button_ValiderPresentation.UseVisualStyleBackColor = true;
            this.button_ValiderPresentation.Click += new System.EventHandler(this.button_ValiderPresentation_Click);
            // 
            // groupBox_Caractéristiques
            // 
            this.groupBox_Caractéristiques.Controls.Add(this.label_LancéD);
            this.groupBox_Caractéristiques.Location = new System.Drawing.Point(252, 126);
            this.groupBox_Caractéristiques.Name = "groupBox_Caractéristiques";
            this.groupBox_Caractéristiques.Size = new System.Drawing.Size(305, 404);
            this.groupBox_Caractéristiques.TabIndex = 12;
            this.groupBox_Caractéristiques.TabStop = false;
            this.groupBox_Caractéristiques.Text = "Caractéristiques";
            this.groupBox_Caractéristiques.Visible = false;
            // 
            // label_LancéD
            // 
            this.label_LancéD.AutoSize = true;
            this.label_LancéD.Location = new System.Drawing.Point(7, 20);
            this.label_LancéD.Name = "label_LancéD";
            this.label_LancéD.Size = new System.Drawing.Size(161, 13);
            this.label_LancéD.TabIndex = 0;
            this.label_LancéD.Text = "Résultats de vos lancés de dès :";
            // 
            // FormMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.ClientSize = new System.Drawing.Size(895, 609);
            this.Controls.Add(this.groupBox_Caractéristiques);
            this.Controls.Add(this.groupBox_Intro);
            this.Controls.Add(this.label_Titre);
            this.Name = "FormMain";
            this.Text = "Mon Test";
            this.groupBox_Intro.ResumeLayout(false);
            this.groupBox_Intro.PerformLayout();
            this.groupBox_Caractéristiques.ResumeLayout(false);
            this.groupBox_Caractéristiques.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btn_Test;
        private System.Windows.Forms.Label label_Titre;
        private System.Windows.Forms.TextBox textBox_NomPerso;
        private System.Windows.Forms.Label label_NomPerso;
        private System.Windows.Forms.ComboBox comboBox_SelectRace;
        private System.Windows.Forms.Label label_SelectRace;
        private System.Windows.Forms.Label label_Sexe;
        private System.Windows.Forms.RadioButton radioButton_SexeM;
        private System.Windows.Forms.RadioButton radioButton_SexeF;
        private System.Windows.Forms.Label label_choixClasse;
        private System.Windows.Forms.ComboBox comboBox_choixClass;
        private System.Windows.Forms.GroupBox groupBox_Intro;
        private System.Windows.Forms.Button button_ValiderPresentation;
        private System.Windows.Forms.GroupBox groupBox_Caractéristiques;
        private System.Windows.Forms.Label label_LancéD;
    }
}

