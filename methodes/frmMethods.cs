using System;
using System.Windows.Forms;

namespace methodes
{
    public partial class frmMethods : Form
    {
        public frmMethods()
        {
            InitializeComponent();
        }

        // hieronder staan 4 verschillende methodes die allemaal kunnen gebruikt worden
        // binnen deze app om twee cijfers op te tellen 
        // onder iedere methode staat het click event voor een knop
        // daarin moet de methode dan ook nog gebruikt worden

        // methode 1: void methode zonder parameters
        private void Add1()
        {
            // cijfers ophalen uit de textboxes + opslaan in double variabelen
            double nr1 = Convert.ToDouble(txtNumber1.Text);
            double nr2 = Convert.ToDouble(txtNumber2.Text);

            // optellen en resultaat opslaan in aparte variabele
            double sum = nr1 + nr2;

            // resultaat in onderste textbox plaatsen
            txtResult.Text = sum.ToString();
        }

        // Add1 methode wordt hieronder gebruikt bij de eerste button

        private void btnAdd1_Click(object sender, EventArgs e)
        {
            // geen parameters en geen return, de methode kan hier dus gewoon gezet worden zonder extra code
            // alle code zit al in de methode zelf
            // deze methode kan je niet overzetten naar een andere app tenzij je in die andere app
            // exact hetzelfde soort formulier met dezelfde namen opbouwt
            Add1();
        }

        // methode 2: void methode met parameters
        // d1 en d2 zijn hier dus 'parameters'
        private void Add2(double d1, double d2)
        {
            // optellen en resultaat opslaan in aparte variabele
            double sum = d1 + d2;

            // resultaat in onderste textbox plaatsen
            txtResult.Text = sum.ToString();
        }

        // Add2 methode wordt hieronder gebruikt bij de tweede button

        private void btnAdd2_Click(object sender, EventArgs e)
        {
            // deze keer moet ik de parameters invullen tussen haakjes want ik heb parameters voorzien bij de methode
            // ik moet wel binnen de haakjes ook de conversie doen want ik heb gezegd dat ik als parameters 'double' waarden gebruik
            // deze methode kan al iets makkelijker overgezet worden, enkel de txtResult kan voor problemen zorgen in de methode

            //double d1 = Convert.ToDouble(txtNumber1.Text);
            //double d2 = Convert.ToDouble(txtNumber2.Text);
            //Add2(d1, d2);

            Add2(Convert.ToDouble(txtNumber1.Text),
                Convert.ToDouble(txtNumber2.Text));
        }

        // methode 3: return methode zonder parameters
        private double Add3()
        {
            // cijfers ophalen uit de textboxes + opslaan in double variabelen
            double d1 = Convert.ToDouble(txtNumber1.Text);
            double d2 = Convert.ToDouble(txtNumber2.Text);

            // optellen en resultaat opslaan
            double sum = d1 + d2;

            // resultaat terug sturen uit de methode als 'uitkomst' van de methode (return)
            return sum;
        }

        // Add3 methode wordt hieronder gebruikt bij de derde button

        private void btnAdd3_Click(object sender, EventArgs e)
        {
            // hier moet ik enkel nog vermelden wat er moet gebeuren met de 'uitkomst' van de methode
            // moet ook omgezet worden naar string want de uitkomst van de methode is een decimal
            // opnieuw minder bruikbaar om over te zetten naar een andere app omdat de nieuwe app dan ook een txtNumber1 en txtNumber2 nodig heeft

            //double sum = Add3();
            //txtResult.Text = sum.ToString();

            txtResult.Text = Add3().ToString();            
        }

        // methode 4: return methode met parameters
        private double Add4(double d1, double d2)
        {
            // optellen en resultaat opslaan in variabele
            double sum = d1 + d2;

            // resultaat terug sturen uit de methode als 'uitkomst' van de methode (return)
            return sum;
        }

        // Add4 methode wordt hieronder gebruikt bij de vierde button

        private void btnAdd4_Click(object sender, EventArgs e)
        {
            // het gebruik van methode 4 is wel iets complexer omdat er nog verschillende zaken moeten gebeuren
            // 1) vermelden waar de uitkomst moet komen (in txtResult)
            // 2) conversie van de textbox waarden naar decimal om op te tellen
            // 3) uiteindelijk ook weer naar string omzetten om in de textbox te krijgen
            // deze methode is echter het meest makkelijk te hergebruiken in een andere app omdat er in de methode zelf nog geen namen van controls (textboxes, buttons, ...) staan
            
            double d1 = Convert.ToDouble(txtNumber1.Text);
            double d2 = Convert.ToDouble(txtNumber2.Text);
            double sum = Add4(d1, d2);
            txtResult.Text = sum.ToString();
        }

    }
}
