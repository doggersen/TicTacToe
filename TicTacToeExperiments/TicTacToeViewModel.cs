using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TicTacToeExperiments
{
    class TicTacToeViewModel : BaseViewModel
    {

        //public string TestString { get; set; }

        private string _testString;
        public string TestString
        {
            get { return _testString; }
            set
            {
                _testString = value;
                
                OnPropertyChanged();
            }
        }

        public void SetupGame()
        {
            Play[] players = new Play[9];
            TestString = "x";
            players[0] = new Play() { slot = "a" };
            players[1] = new Play() { slot = "b" };
            players[2] = new Play() { slot = "c" };
            players[3] = new Play() { slot = "d" };
            players[4] = new Play() { slot = "f" };
            players[5] = new Play() { slot = "g" };
            players[6] = new Play() { slot = "h" };
            players[7] = new Play() { slot = "i" };
            players[8] = new Play() { slot = "j" };
            

            
          
        }
    }
}
