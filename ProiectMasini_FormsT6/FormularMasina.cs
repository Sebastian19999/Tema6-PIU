using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;
using System.Windows.Forms;
using System.Collections;
using System.IO;

using LibrarieModele;
using NivelAccesDate;
using ManagerM;


namespace ProiectMasini_FormsT6
{
    public class FormularMasina : Form
    {

        IStocareData adminMasini;
        //ArrayList optiuniSelectate = new ArrayList();

        private Label firmaLbl, modelLbl, anFLbl, culoareLbl, numeVanzatorLbl, numeCumparatorLbl, pretLbl, dataLbl, optiuniLbl;
        private TextBox firmaTxt, modelTxt, anFTxt, culoareTxt, numeVanzatorTxt, numeCumparatorTxt, pretTxt, dataTxt, optiuniTxt;

        private void FormularMasina_Load(object sender, EventArgs e)
        {

        }

        private void InitializeComponent()
        {
            this.SuspendLayout();
            // 
            // FormularMasina
            // 
            this.ClientSize = new System.Drawing.Size(282, 253);
            this.Name = "FormularMasina";
            this.Load += new System.EventHandler(this.FormularMasina_Load);
            this.ResumeLayout(false);

        }

        private Button adaugaBtn;
        private Label afisareLbl;

        private const int LATIME_CONTROL = 150;
        private const int DIMENSIUNE_PAS_Y = 30;
        private const int DIMENSIUNE_PAS_X = 170;
        private const int LUNGIME_MAX = 15;

        public FormularMasina()
        {

            adminMasini = ManagerMasini.GetAdministratorStocare();

            //setare proprietati 
            this.Size = new System.Drawing.Size(400, 400);
            this.StartPosition = FormStartPosition.Manual;
            this.Location = new System.Drawing.Point(100, 100);
            this.Font = new Font("Arial", 9, FontStyle.Bold);
            this.ForeColor = Color.LimeGreen;
            this.Text = "Situatie student";




            ////////////////////LABELS - START///////////////////////
            
            firmaLbl = new Label();
            firmaLbl.Width = LATIME_CONTROL;
            firmaLbl.Text = "Firma: ";
            this.Controls.Add(firmaLbl);

            firmaTxt = new TextBox();
            firmaTxt.Width = LATIME_CONTROL;
            firmaTxt.Left = DIMENSIUNE_PAS_X;
            this.Controls.Add(firmaTxt);

            modelLbl = new Label();
            modelLbl.Width = LATIME_CONTROL;
            modelLbl.Text = "Model:";
            modelLbl.Top = DIMENSIUNE_PAS_Y;
            this.Controls.Add(modelLbl);

            modelTxt = new TextBox();
            modelTxt.Width = LATIME_CONTROL;
            modelTxt.Location = new System.Drawing.Point(DIMENSIUNE_PAS_X, DIMENSIUNE_PAS_Y);
            this.Controls.Add(modelTxt);

            culoareLbl = new Label();
            culoareLbl.Width = LATIME_CONTROL;
            culoareLbl.Text = "Culoare:";
            culoareLbl.Top = 2 * DIMENSIUNE_PAS_Y;
            this.Controls.Add(culoareLbl);

            culoareTxt = new TextBox();
            culoareTxt.Width = LATIME_CONTROL;
            culoareTxt.Location = new System.Drawing.Point(DIMENSIUNE_PAS_X, 2 * DIMENSIUNE_PAS_Y);
            this.Controls.Add(culoareTxt);

            anFLbl = new Label();
            anFLbl.Width = LATIME_CONTROL;
            anFLbl.Text = "An fabricatie:";
            anFLbl.Top = 3 * DIMENSIUNE_PAS_Y;
            this.Controls.Add(anFLbl);

            anFTxt = new TextBox();
            anFTxt.Width = LATIME_CONTROL;
            anFTxt.Location = new System.Drawing.Point(DIMENSIUNE_PAS_X, 3 * DIMENSIUNE_PAS_Y);
            this.Controls.Add(anFTxt);

            numeVanzatorLbl = new Label();
            numeVanzatorLbl.Width = LATIME_CONTROL;
            numeVanzatorLbl.Text = "Nume vanzator:";
            numeVanzatorLbl.Top = 4 * DIMENSIUNE_PAS_Y;
            this.Controls.Add(numeVanzatorLbl);


            //////////////////////////////LABELS - END////////////////////////



            ///////////////////////////TEXTBOX - START//////////////////////

            numeVanzatorTxt = new TextBox();
            numeVanzatorTxt.Width = LATIME_CONTROL;
            numeVanzatorTxt.Location = new System.Drawing.Point(DIMENSIUNE_PAS_X, 4 * DIMENSIUNE_PAS_Y);
            this.Controls.Add(numeVanzatorTxt);

            numeCumparatorLbl = new Label();
            numeCumparatorLbl.Width = LATIME_CONTROL;
            numeCumparatorLbl.Text = "Nume cumparator:";
            numeCumparatorLbl.Top = 5 * DIMENSIUNE_PAS_Y;
            this.Controls.Add(numeCumparatorLbl);

            numeCumparatorTxt = new TextBox();
            numeCumparatorTxt.Width = LATIME_CONTROL;
            numeCumparatorTxt.Location = new System.Drawing.Point(DIMENSIUNE_PAS_X, 5 * DIMENSIUNE_PAS_Y);
            this.Controls.Add(numeCumparatorTxt);

            dataLbl = new Label();
            dataLbl.Width = LATIME_CONTROL;
            dataLbl.Text = "Data tranzactie:";
            dataLbl.Top = 6 * DIMENSIUNE_PAS_Y;
            this.Controls.Add(dataLbl);

            dataTxt = new TextBox();
            dataTxt.Width = LATIME_CONTROL;
            dataTxt.Location = new System.Drawing.Point(DIMENSIUNE_PAS_X, 6 * DIMENSIUNE_PAS_Y);
            this.Controls.Add(dataTxt);

            pretLbl = new Label();
            pretLbl.Width = LATIME_CONTROL;
            pretLbl.Text = "Pret:";
            pretLbl.Top = 7 * DIMENSIUNE_PAS_Y;
            this.Controls.Add(pretLbl);

            pretTxt = new TextBox();
            pretTxt.Width = LATIME_CONTROL;
            pretTxt.Location = new System.Drawing.Point(DIMENSIUNE_PAS_X, 7 * DIMENSIUNE_PAS_Y);
            this.Controls.Add(pretTxt);


            //////////////////////////TEXTBOX - END//////////////////////////


            optiuniLbl = new Label();
            optiuniLbl.Width = LATIME_CONTROL;
            optiuniLbl.Text = "Optiuni:";
            optiuniLbl.Top = 8 * DIMENSIUNE_PAS_Y;
            this.Controls.Add(optiuniLbl);

            optiuniTxt = new TextBox();
            optiuniTxt.Width = LATIME_CONTROL;
            optiuniTxt.Location = new System.Drawing.Point(DIMENSIUNE_PAS_X, 8 * DIMENSIUNE_PAS_Y);
            this.Controls.Add(optiuniTxt);




            //adaugare control de tip Button pentru adaugarea unui obiect
            adaugaBtn = new Button();
            adaugaBtn.Width = LATIME_CONTROL;
            adaugaBtn.Location = new System.Drawing.Point(DIMENSIUNE_PAS_X, 9 * DIMENSIUNE_PAS_Y);
            adaugaBtn.Text = "Adauga";
            adaugaBtn.Click += OnButtonClicked; 
            this.Controls.Add(adaugaBtn);

            //adaugare control de tip Label pentru afisarea obiectului adaugat
            afisareLbl = new Label();
            afisareLbl.Width = 2 * LATIME_CONTROL;
            afisareLbl.Height = 50;
            afisareLbl.Location = new System.Drawing.Point(40, 10 * DIMENSIUNE_PAS_Y);
            afisareLbl.BackColor = Color.LightYellow;
            afisareLbl.TextAlign = ContentAlignment.MiddleCenter;
            this.Controls.Add(afisareLbl);

            this.FormClosed += OnFormClosed;

        }


       
        /// ///////////////////ADAUGARE ACTIUNE IN CAZUL IN CARE BUTONUL ESTE APASAT///////////////////
        
        private void OnButtonClicked(object sender, EventArgs e)
        {
            firmaLbl.ForeColor = Color.Black;
            modelLbl.ForeColor = Color.Black;
            anFLbl.ForeColor = Color.Black;
            culoareLbl.ForeColor = Color.Black;
            numeVanzatorLbl.ForeColor = Color.Black;
            numeCumparatorLbl.ForeColor = Color.Black;
            dataLbl.ForeColor = Color.Black;
            pretLbl.ForeColor = Color.Black;
            optiuniLbl.ForeColor = Color.Black;

            firmaTxt.ForeColor = Color.Black;
            modelTxt.ForeColor = Color.Black;
            anFTxt.ForeColor = Color.Black;
            culoareTxt.ForeColor = Color.Black;
            numeVanzatorTxt.ForeColor = Color.Black;
            numeCumparatorTxt.ForeColor = Color.Black;
            dataTxt.ForeColor = Color.Black;
            pretTxt.ForeColor = Color.Black;
            optiuniTxt.ForeColor = Color.Black;
            CodEroare valideaza = Validare();
            if (valideaza != CodEroare.CORECT)
            {
                switch (valideaza)
                {
                    case CodEroare.FIRMA_INCORECTA:
                        firmaTxt.ForeColor = Color.Red;
                        if (firmaTxt.Text == string.Empty)
                            firmaLbl.ForeColor = Color.Red;
                        break;
                    case CodEroare.MODEL_INCORECT:
                        modelTxt.ForeColor = Color.Red;
                        if (modelTxt.Text == string.Empty)
                            modelLbl.ForeColor = Color.Red;
                        break;
                    case CodEroare.CULOARE_INCORECTA:
                        culoareTxt.ForeColor = Color.Red;
                        if (culoareTxt.Text == string.Empty)
                            culoareLbl.ForeColor = Color.Red;
                        break;
                    case CodEroare.AN_FABRICATIE_INCORECT:
                        anFTxt.ForeColor = Color.Red;
                        if (anFTxt.Text == string.Empty)
                            anFLbl.ForeColor = Color.Red;
                        break;
                    case CodEroare.NUME_VANZATOR_INCORECT:
                        numeVanzatorTxt.ForeColor = Color.Red;
                        if (numeVanzatorTxt.Text == string.Empty)
                            numeVanzatorLbl.ForeColor = Color.Red;
                        break;
                    case CodEroare.NUME_CUMPARATOR_INCORECT:
                        numeCumparatorTxt.ForeColor = Color.Red;
                        if (numeCumparatorTxt.Text == string.Empty)
                            numeCumparatorLbl.ForeColor = Color.Red;
                        break;
                    case CodEroare.DATA_INCORECTA:
                        dataTxt.ForeColor = Color.Red;
                        if (dataTxt.Text == string.Empty)
                            dataLbl.ForeColor = Color.Red;
                        break;
                    case CodEroare.PRET_INCORECT:
                        pretTxt.ForeColor = Color.Red;
                        if (pretTxt.Text == string.Empty)
                            pretLbl.ForeColor = Color.Red;
                        break;
                    case CodEroare.OPTIUNI_INCORECTE:
                        optiuniTxt.ForeColor = Color.Red;
                        if (optiuniTxt.Text == string.Empty)
                            optiuniLbl.ForeColor = Color.Red;
                        break;
                }
            }
            else
            {
                Masina masinaForm = new Masina(numeVanzatorTxt.Text.ToString(), numeCumparatorTxt.Text.ToString()
                    , firmaTxt.Text.ToString(), modelTxt.Text.ToString(), Convert.ToInt32(anFTxt.Text.ToString()),
                    culoareTxt.Text.ToString(), optiuniTxt.Text.ToString(), dataTxt.Text.ToString(), Convert.ToDouble(pretTxt.Text.ToString()), "Sedan", DateTime.Now);
                int lat, lung;
                afisareLbl.Text = "" + masinaForm.toString();
                adminMasini.AddMasina(masinaForm);
                ManagerMasini.addMasina(masinaForm);
            }

            ResetareControale();

        }

        

        private void ResetareControale()
        {
            firmaTxt.Text = string.Empty;
            modelTxt.Text = string.Empty;
            anFTxt.Text = string.Empty;
            culoareTxt.Text = string.Empty;
            numeVanzatorTxt.Text = string.Empty;
            numeCumparatorTxt.Text = string.Empty;
            dataTxt.Text = string.Empty;
            pretTxt.Text = string.Empty;
            optiuniTxt.Text = string.Empty;
            
        }

        



        private void OnFormClosed(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private CodEroare Validare()
        {
            if (firmaTxt.Text == string.Empty || firmaTxt.Text.Length > LUNGIME_MAX)
            {
                return CodEroare.FIRMA_INCORECTA;
            }
            else if (modelTxt.Text == string.Empty || modelTxt.Text.Length > LUNGIME_MAX)
            {
                return CodEroare.MODEL_INCORECT;
            }
            else if (culoareTxt.Text == string.Empty || culoareTxt.Text.Length > LUNGIME_MAX)
            {
                return CodEroare.CULOARE_INCORECTA;
            }
            else if (anFTxt.Text == string.Empty || anFTxt.Text.Length > 4)
            {
                return CodEroare.AN_FABRICATIE_INCORECT;
            }
            else if (numeVanzatorTxt.Text == string.Empty || numeVanzatorTxt.Text.Length > 40)
            {
                return CodEroare.NUME_VANZATOR_INCORECT;
            }
            else if (numeCumparatorTxt.Text == string.Empty || numeCumparatorTxt.Text.Length > 40)
            {
                return CodEroare.NUME_CUMPARATOR_INCORECT;
            }
            else if (dataTxt.Text == string.Empty || dataTxt.Text.Length > LUNGIME_MAX)
            {
                return CodEroare.DATA_INCORECTA;
            }
            else if (pretTxt.Text == string.Empty || pretTxt.Text.Length > LUNGIME_MAX)
            {
                return CodEroare.PRET_INCORECT;
            }
            else if (optiuniTxt.Text == string.Empty)
            {
                return CodEroare.OPTIUNI_INCORECTE;
            }


            return CodEroare.CORECT;
        }

    }
}
