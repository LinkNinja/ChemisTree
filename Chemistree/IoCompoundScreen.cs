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

        }

        private void nav_exit_btn_Click_1(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
