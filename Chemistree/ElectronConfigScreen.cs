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

        /*public static string formatElectronConfig() {
            UnicodeConverter uni = new UnicodeConverter();

        }*/

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

                // Must convert the superscripts in the electron configuration to unicode.
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
