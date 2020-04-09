using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Chemistree_GUI_V1
{
    public partial class IoCompoundScreen : Form
    {
        public IoCompoundScreen()
        {
            InitializeComponent();
        }

        public static string displayIonNumber(int n)
        {
            string number;

            if (n == 1)
            {
                number = "";

            }
            else
            {
                number = convertToSubscript(n).ToString();
            }

            return number;
        }

        public static string convertToSubscript(int n)
        {
            string subscript;

            switch (n)
            {
                case 0:
                    subscript = "\u2080";
                    break;
                case 1:
                    subscript = "\u2081";
                    break;
                case 2:
                    subscript = "\u2082";
                    break;
                case 3:
                    subscript = "\u2083";
                    break;
                case 4:
                    subscript = "\u2084";
                    break;
                case 5:
                    subscript = "\u2085";
                    break;
                case 6:
                    subscript = "\u2086";
                    break;
                case 7:
                    subscript = "\u2087";
                    break;
                case 8:
                    subscript = "\u2088";
                    break;
                case 9:
                    subscript = "\u2089";
                    break;
                default:
                    subscript = "";
                    break;
            }
            return subscript;
        }
        public static string convertToSuperscript(int n)
        {
            string superscript;

            switch (n)
            {
                case 0:
                    superscript = "\u2070";
                    break;
                case 1:
                    superscript = "\u2071";
                    break;
                case 2:
                    superscript = "\u2072";
                    break;
                case 3:
                    superscript = "\u2073";
                    break;
                case 4:
                    superscript = "\u2074";
                    break;
                case 5:
                    superscript = "\u2075";
                    break;
                case 6:
                    superscript = "\u2076";
                    break;
                case 7:
                    superscript = "\u2077";
                    break;
                case 8:
                    superscript = "\u2078";
                    break;
                case 9:
                    superscript = "\u2079";
                    break;
                default:
                    superscript = "";
                    break;
            }
            return superscript;
        }

        public static void findIonNums(int cCharge, int aCharge, out int cNum, out int aNum)
        {
            int chargeDifference;
            int commonFactor;

            // Determines the difference between each charge.
            chargeDifference = cCharge + aCharge;

            // Assigns a common factor based on the charge difference.
            if (chargeDifference == 0)
            {
                commonFactor = cCharge;

            }
            else
            {
                commonFactor = Math.Abs(cCharge * aCharge);
            }

            // Determines the necessary number of cations and anions.
            cNum = Math.Abs(commonFactor / cCharge);
            aNum = Math.Abs(commonFactor / aCharge);
        }

        private void IoCompoundScreen_Load(object sender, EventArgs e)
        {

        }

        private void navigation_panal_Paint(object sender, PaintEventArgs e)
        {

        }

        private void roundedButton1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Hide();
            MainMenu s1 = new MainMenu();
            s1.Show();
            //this.Close();
        }

        private void nav_exit_btn_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void compount_panel_Paint(object sender, PaintEventArgs e)
        {

        }

        private void result_panel_Paint(object sender, PaintEventArgs e)
        {

        }

        private void create_compound_btn_Click(object sender, EventArgs e)
        {
            // Ionic compound
            string ionicCompound, ionicName, errorMessage;

            // Colors
            Color blue = Color.FromArgb(54, 175, 255);
            Color red = Color.FromArgb(255, 54, 54);

            // Cation properties
            string cationAbbr = cation_input.Text;
            int cationChg = int.Parse(cationChg_txt.Text);
            string cationName;
            int cationNum;

            string anionAbbr = anion_input.Text;
            int anionChg = int.Parse(anionChg_txt.Text);
            string anionName;
            int anionNum;

            // Functionality needed to look up the cation and anion in the database to validate it and see 
            // whether it exists or not, and was entered in the correct panel.
            /** Query parameters: abbr & charge (composite primary key (?)) **/

            // Functionality needed to pull out the formal name of the ion in the database.
            /** Query parameters: abbr & charge (composite primary key (?)) **/

            // ionQuery(cationAbbr, cationChg, out cationName);
            // ionQuery(anionAbbr, anionChg, out anionName);

            // Function determines how many anions and cations are needed to form the ionic compound.
            findIonNums(cationChg, anionChg, out cationNum, out anionNum);
            ionicCompound = cationAbbr + displayIonNumber(cationNum) + anionAbbr + displayIonNumber(anionNum);
            // ionicName = cationName + " " + anionName;

            /** 
             * If successful and validated 
             * 
             * **/
            ionicCompound_label.Text = ionicCompound;
            ionicCompound_label.ForeColor = blue;

            // ionicName_label.Text = ionicName;
            ionicName_label.Text = "Insert ionic name";

            /** 
             * If there are errors 
             * 
             * **/
            //ionicCompound_label.Text = "Error";
            //ionicCompound_label.ForeColor = red;
            //ionicName_label.Text = errorMessage;
        }

        private void nav_exit_btn_Click_1(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
