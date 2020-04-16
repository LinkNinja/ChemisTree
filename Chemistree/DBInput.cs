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
            e.name = txtbxName.Text;
            e.abbr = txtbxAbbr.Text;
            e.atomicNumber = txtbxAtomicNumber.Text;
            e.periodicGroup = txtbxPeriodicGroup.Text;
            e.periodicPeriod = txtbxPeriodicPeriod.Text;

            conn.SubmitDB(e);

        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnMenu_Click(object sender, EventArgs e)
        {
            this.Hide();
            MainMenu s1 = new MainMenu();
            s1.ShowDialog();
            this.Close();
        }
    }
}
