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
    public partial class DBInput : Form
    {
        private DBConnection conn;

        public DBInput()
        {
            InitializeComponent();
            conn = new DBConnection();
            conn.ConnectToDB();
        }

        public void ClickBtnSubmit(object sender, EventArgs args)
        {
            Element e = new Element();
            e.abbr = txtbxAbbr.Text;
            e.name = txtbxName.Text;
            e.atomicNumber = txtbxAtomicNumber.Text;
            e.periodicGroup = txtbxPeriodicGroup.Text;
            e.periodicPeriod = txtbxPeriodicPeriod.Text;
            e.electronConfiguration = txtbxElectronConfiguration.Text;
            if (conn.SubmitDB(e))
            {
                lblResult.Text = "Success";
                txtbxAbbr.Text = "";
                txtbxName.Text = "";
                txtbxAtomicNumber.Text = "";
                txtbxPeriodicGroup.Text = "";
                txtbxPeriodicPeriod.Text = "";
                txtbxElectronConfiguration.Text = "";
            }
            else
            {
                lblResult.Text = "Error";
            }
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnMenu_Click(object sender, EventArgs e)
        {
            //this.Hide();
            //MainMenu s1 = new MainMenu();
            //s1.ShowDialog();
            this.Close();
        }

        private void btnClearTextBoxes_Click(object sender, EventArgs e)
        {
            ClearAllText(this);
        }


        private void ClearAllText(Control con)
        {
            foreach (Control c in con.Controls)
            {
                if (c is TextBox)
                    ((TextBox)c).Clear();
                else
                    ClearAllText(c);
            }
        }

        
    }
}
