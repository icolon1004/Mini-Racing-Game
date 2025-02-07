using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Isaiah_Colon_CPT_206_Final_Project
{
    internal class CarStatsClass
    {
        public int CarID { get; set; }

        public string CarColor { get; set; }

        public int Acceleration { get; set; }

        public int EnemyBumps { get; set; }

        public int CoinScoreMultiplier { get; set; }

        private int _carID;
        public CarStatsClass(int carID)
        {
            _carID = carID;
        }

    }
}
