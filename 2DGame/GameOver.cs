using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _2DGame
{
    public partial class GameOver : UserControl
    {
        public GameOver()
        {
            InitializeComponent();
        }

        private void playAgainButton_Click(object sender, EventArgs e)
        {
            MainScreen ms = new MainScreen();
            Form y = this.FindForm();
            y.Controls.Remove(this);
            y.Controls.Add(ms);
            ms.Focus();
            //takes you back to main menu
        }

        private void exitButton_Click(object sender, EventArgs e)
        {
            Application.Exit();
            //exits game
        }

        private void playAgainButton_Enter(object sender, EventArgs e)
        {
            playAgainButton.BackColor = Color.LightSeaGreen;
            exitButton.BackColor = Color.Cyan;
            // allows you to see which choice you're on
           
        }

        private void exitButton_Enter(object sender, EventArgs e)
        {
            exitButton.BackColor = Color.LightSeaGreen;
            playAgainButton.BackColor = Color.Cyan;
            // allows you to see which choice you're on

        }
    }
}
