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
            s1.ShowDialog();
            this.Close();
        }

        private void result_panel_Paint(object sender, PaintEventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void nav_exit_btn_Click(object sender, EventArgs e)
        {
            this.Close();
        }


        //a function that will be used to check the database for every element button on the table.

        private void btn_query(object sender, EventArgs e)
        {
            Button s = (System.Windows.Forms.Button)sender;

            conn.queryDB(s.Text);
             
        }

 
    }
}
