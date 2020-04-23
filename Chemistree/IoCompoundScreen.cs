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
        private DBConnection conn;

        public IoCompoundScreen()
        {
            InitializeComponent();
            conn = new DBConnection();
            conn.ConnectToDB();
        }

        #region Public Methods
        //
        // Converts the number of ions to a unicode subscript value.
        //
        public static string displayIonNumber(int n)
        {
            string number;
            UnicodeConverter uni = new UnicodeConverter();

            if (n == 1)
            {
                number = "";

            }
            else
            {
                number = uni.convertToSubscript(n).ToString();
            }

            return number;
        }

        //
        // Converts the user's charge input to an integer.
        //
        public static void convertChargeToInt(string ionStr, out int ionInt, int sign, ref string errorMessage) {

            if (!int.TryParse(ionStr, out ionInt)) {
                if (ionStr == "") {
                    ionInt = sign;

                } else {
                    errorMessage = "Error! This is not a valid charge.";
                }

            } else {
                ionInt *= sign;
            }
        }

        //
        // Formats the abbreviation of the ion to include subscripts.
        //
        public static string formatIonAbbr(string ionAbbr) {

            string subNum;
            UnicodeConverter uni = new UnicodeConverter();

            for (int x = 0; x < ionAbbr.Length; x++) {
                for (int i = 0; i <= 9; i++) {

                    if (ionAbbr[x].ToString() == i.ToString()) {
                        subNum = uni.convertToSubscript(i);
                        ionAbbr = ionAbbr.Replace(ionAbbr[x].ToString(), subNum);
                    } 

                }
            }
            
            return ionAbbr;
        }


        //
        // Determines the number of ions necessary to form a compound.
        //
        public static void findIonNums(int cCharge, int aCharge, out int cNum, out int aNum)
        {
            int chargeDifference;
            int commonFactor;

            // Determines the difference between each charge.
            chargeDifference = cCharge + aCharge;

            // Assigns a common factor based on the charge difference.
            if (chargeDifference == 0) {
                commonFactor = cCharge;

            } else {
                commonFactor = Math.Abs(cCharge * aCharge);
            }

            // Determines the necessary number of cations and anions.
            cNum = Math.Abs(commonFactor / cCharge);
            aNum = Math.Abs(commonFactor / aCharge);
        }

        #endregion

        #region Unhandled Events
        private void IoCompoundScreen_Load(object sender, EventArgs e)
        {

        }

        private void navigation_panal_Paint(object sender, PaintEventArgs e)
        {

        }

        private void roundedButton1_Click(object sender, EventArgs e)
        {

        }

        private void compount_panel_Paint(object sender, PaintEventArgs e)
        {

        }

        private void result_panel_Paint(object sender, PaintEventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        #endregion

        #region Handled Events
        private void button1_Click(object sender, EventArgs e)
        {
            this.Hide();
            MainMenu s1 = new MainMenu();
            s1.Show();
        }

        private void nav_exit_btn_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void create_compound_btn_Click(object sender, EventArgs e)
        {
            string ionicCompound, ionicName;
            string errorMessage = "";
            int cationNum, anionNum;

            // Colors
            Color yellow = Color.FromArgb(211, 255, 64);
            Color red = Color.FromArgb(255, 54, 54);

            /** Cation properties **/
            Ion cation = new Ion();
            cation.ionAbbr = cation_input.Text;
            convertChargeToInt(cationChg_txt.Text, out cation.ionCharge, 1, ref errorMessage);

            /** Anion properties **/
            Ion anion = new Ion();
            anion.ionAbbr = anion_input.Text;
            convertChargeToInt(anionChg_txt.Text, out anion.ionCharge, -1, ref errorMessage);

            // These connect to the database and determines whether the ion entered exists or not.
            // This also saves the name of the ion to the object property ionName.
            conn.queryIonDB(ref cation, "cation", ref errorMessage);
            conn.queryIonDB(ref anion, "anion", ref errorMessage);

            // Function determines how many anions and cations are needed to form the ionic compound.
            findIonNums(cation.ionCharge, anion.ionCharge, out cationNum, out anionNum);
            ionicCompound = formatIonAbbr(cation.ionAbbr) + displayIonNumber(cationNum) + formatIonAbbr(anion.ionAbbr) + displayIonNumber(anionNum);
            ionicName = cation.ionName + " " + anion.ionName;

            // Validation successful, and ionic compound was formed.
            if (errorMessage == "") {
                ionicCompound_label.Text = ionicCompound;
                ionicCompound_label.ForeColor = yellow;
                ionicName_label.Text = ionicName;

            // Validation unsuccessful, and ran into an error.
            } else {
                ionicCompound_label.Text = "Error";
                ionicCompound_label.ForeColor = red;
                ionicName_label.Text = errorMessage;
                ionicName_label.Font = new Font("Bahnschrift", 14);
            }

        }

        private void nav_exit_btn_Click_1(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void reset_btn_Click(object sender, EventArgs e)
        {
            ionicCompound_label.Text = "";
            ionicName_label.Text = "";

            cationChg_txt.Text = "";
            cation_input.Text = "";
            anionChg_txt.Text = "";
            anion_input.Text = "";
        }

        #endregion
    }
}
