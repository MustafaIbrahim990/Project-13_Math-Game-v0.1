using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Math_Game_Course_14
{
    public partial class frmStarterGameScreen : Form
    {
        public frmStarterGameScreen()
        {
            InitializeComponent();
        }

        private void frmStarterGameScreen_Load(object sender, EventArgs e)
        {

        }

        //-------------------------------------------------//

        private void btnPlay_Click(object sender, EventArgs e)
        {
            //this.Hide();
            Form frm = new frmGameInfoScreen();
            frm.ShowDialog();
        }
    }
}