using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Isaiah_Colon_CPT_206_Final_Project
{
    public partial class StartScreen : Form
    {
        public StartScreen()
        {
            InitializeComponent();
        }

        

        private void optionsPictureBox_Click(object sender, EventArgs e)
        {
            CarSelect carSelect = new CarSelect();
            carSelect.Show();
        }

        private void exitPictureBox_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
