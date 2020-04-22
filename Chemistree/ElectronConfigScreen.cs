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
    public partial class ElectronConfigScreen : Form
    {
        private DBConnection conn;

        public ElectronConfigScreen()
        {
            InitializeComponent();
            conn = new DBConnection();
            conn.ConnectToDB();
        }

        #region Public Methods

        // 
        // Formats the electron configuration appropriately by finding the numbers that need to be converted to superscripts.
        //
        public static string formatElectronConfig(string config) {
            UnicodeConverter uni = new UnicodeConverter();
            string[] splittedConfig = config.Split(',');
            string formattedConfig = "";
            int splitMarker = 0;
            int superNum;
            string superStr;

            for (int i = 0; i < splittedConfig.Length; i++)
            {
                int configLen = splittedConfig[i].Length;

                for (int x = 0; x < configLen; x++)
                {
                    if (splittedConfig[i][x] == '^')
                    {
                        splitMarker = x;
                    }
                }

                for (int y = splitMarker; y < configLen - 1; y++)
                {
                    int.TryParse(splittedConfig[i][y + 1].ToString(), out superNum);
                    superStr = uni.convertToSuperscript(superNum);
                    splittedConfig[i] = splittedConfig[i].Replace(splittedConfig[i][y].ToString(), superStr.ToString());
                }

                splittedConfig[i] = splittedConfig[i].Remove((configLen - 1), 1);
                formattedConfig += splittedConfig[i];

            }

            return formattedConfig;
        }

        #endregion

        #region Unhandled Events

        private void navigation_panal_Paint(object sender, PaintEventArgs e)
        {

        }

        private void compound_choice_label_Click(object sender, EventArgs e)
        {

        }

        private void ElectronConfigScreen_Load(object sender, EventArgs e)
        {

        }

        private void result_panel_Paint_1(object sender, PaintEventArgs e)
        {

        }

        private void lblOutput_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click_1(object sender, EventArgs e)
        {

        }

        private void result_panel_Paint(object sender, PaintEventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        #endregion

        #region Handled Events

        private void nav_menu_btn_Click(object sender, EventArgs e)
        {
            this.Hide();
            MainMenu s1 = new MainMenu();
            s1.Show();
        }

        private void nav_exit_btn_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }


        //a function that will be used to check the database for every element button on the table.


        //Custom method created to be able to use on every element in the table.
        //This will allow us to pass the element letter as text.
        //The text will be passed to the class DBConnection.
        //The text is used to tell the database wich element we are looking for.
        // it will execut a custom function from DB Connection that is execting the search.
        // the search does not return the information.
        //The btn query determines how the information is displayed.
      
        private void btn_query(object sender, EventArgs e)
        {
            Button s = (System.Windows.Forms.Button)sender;

            //the button text is passed into the argument of queryDB();
            (bool result, Element el) = conn.queryDB(s.Text);
            if (result)
            {
                lblElemAbbr.Visible = true;
                lblElemAbbr.Text = $"{el.abbr}";
                string elemInfo = $"Protons {el.atomicNumber} \nElectrons: {el.atomicNumber} \nPeriod: {el.periodicPeriod} \nGroup: {el.periodicGroup}";

                // Must convert the superscripts in the unformatted electron configuration to unicode.
                el.electronConfiguration = formatElectronConfig(el.electronConfiguration);
                lblElectronConfig.Text = $"{el.electronConfiguration}";

                lblElemName.Text = $"{el.name}";
                lblOutput.Text = elemInfo;
            }
            else
            {
                lblOutput.Text = "Error! Element not found in table";
            }
        }

        #endregion
    }
}
