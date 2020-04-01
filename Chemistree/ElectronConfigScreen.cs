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
        public ElectronConfigScreen()
        {
            InitializeComponent();
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
            //this.Close();
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
    }
}
