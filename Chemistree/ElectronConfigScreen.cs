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

        private void navigation_panal_Paint(object sender, PaintEventArgs e)
        {

        }

        private void compound_choice_label_Click(object sender, EventArgs e)
        {

        }

        private void nav_menu_btn_Click(object sender, EventArgs e)
        {
            this.Hide();
            MainMenu s1 = new MainMenu();
            s1.Show();
        }

        private void result_panel_Paint(object sender, PaintEventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

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
            // 
            Button s = (System.Windows.Forms.Button)sender;

            //the button text is passed into the argument of queryDB();
            conn.queryDB(s.Text);
            //Element e = conn.queryDB();
  

            // Element e = conn.queryDB(s.text);
            // resultLabel.text = "" + e.name + " " + e.abbr;
             
        }

 
    }
}
