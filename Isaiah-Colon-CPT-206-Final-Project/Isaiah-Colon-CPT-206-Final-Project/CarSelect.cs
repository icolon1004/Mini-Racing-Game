using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.Drawing.Text;
using Isaiah_Colon_CPT_206_Final_Project.ProjectFilesDataSetTableAdapters;
using static System.Windows.Forms.AxHost;

namespace Isaiah_Colon_CPT_206_Final_Project
{
    public partial class CarSelect : Form
    {
        

        public CarSelect()
        {
            InitializeComponent();
        }

        public string conString = "";
        public int selectedCar;
                
        public void OpenForm() 
        { 
            RacingForm racingForm = new RacingForm();
            
            racingForm.Show();

        }
        public void CloseForm() 
        {
            CarSelect carSelect = new CarSelect();
            carSelect.Close();

        }

        private void pinkDevilSelectButton_Click(object sender, EventArgs e)
        {
            CloseForm();

            RacingForm racingForm = new RacingForm();
            racingForm.CarNum = 1;
            racingForm.Show();


        }

        private void blackRacecarSelectButton_Click(object sender, EventArgs e)
        {
            CloseForm();

            RacingForm racingForm = new RacingForm();
            racingForm.CarNum = 2;
            racingForm.Show();
        }

        private void blueSudanSelectButton_Click(object sender, EventArgs e)
        {
            CloseForm();

            RacingForm racingForm = new RacingForm();
            racingForm.CarNum = 3;
            racingForm.Show();
        }
    }
}
