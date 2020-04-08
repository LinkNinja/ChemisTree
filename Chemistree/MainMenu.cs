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
    public partial class MainMenu : Form
    {
        public MainMenu()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click_1(object sender, EventArgs e)
        {

        }

        private void roundedButton1_Click(object sender, EventArgs e)
        {
            this.Hide();
            IoCompoundScreen s2 = new IoCompoundScreen();
            s2.ShowDialog();
            this.Close();
        }

        private void exit_btn_Click(object sender, EventArgs e)
        {
            // Close application when exit buton clicked
            this.Close(); 
        }

        private void roundedButton2_Click(object sender, EventArgs e)
        {
            this.Hide();
            ElectronConfigScreen s3 = new ElectronConfigScreen();
            s3.ShowDialog();
            this.Close();
        }

        private void btnInput_Click(object sender, EventArgs e)
        {
            this.Hide();
            DBInput s4 = new DBInput();
            s4.ShowDialog();
            this.Close();
        }
    }
}
