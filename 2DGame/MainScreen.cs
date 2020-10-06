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
    public partial class MainScreen : UserControl
    {
        bool spaceDown = false;
        public MainScreen()
        {
            InitializeComponent();
        }

        private void MainScreen_KeyDown(object sender, KeyEventArgs e)
        {
            if (Keys.Space == e.KeyCode) 
            {
                spaceDown = true;
            }

            if (spaceDown == true) //checks if the space bar has been pressed
            {
                //goes to game
                GameScreen gs = new GameScreen();
                Form f = this.FindForm();
                f.Controls.Remove(this);
                f.Controls.Add(gs);
            }
        }
    }
}
