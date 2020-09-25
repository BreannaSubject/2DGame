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
    public partial class GameScreen : UserControl
    {
        Random random = new Random();

        //crab variables
        List<Crab> crabs = new List<Crab>();
        const int CRAB_SIZE = 30;
        int crabSpeed = 6;
        SolidBrush crabBrush = new SolidBrush(Color.Red);
        Color crabsColour; 

        //jewel variables
        List<Jewel> jewels = new List<Jewel>();
        const int JEWEL_SPEED = 10, JEWEL_WIDTH = 30, JEWEL_HEIGHT = 50;
        Boolean jewelColour;

        //hero variables
        Hero hero;
        int heroSpeed;
        const int HERO_WIDTH = 30, HERO_HEIGHT = 50;

        

        public GameScreen()
        {
            InitializeComponent();
        }

        private void GameScreen_Load(object sender, EventArgs e)
        {
            MakeCrabs();
        }

        private void GameScreen_PreviewKeyDown(object sender, PreviewKeyDownEventArgs e)
        {
            switch (e.KeyCode)
            {
                case Keys.Left:
                    Form1.leftArrowDown = true;
                    break;
                case Keys.Right:
                    Form1.rightArrowDown = true;
                    break;
                case Keys.Up:
                    Form1.upArrowDown = true;
                    break;
                case Keys.Down:
                    Form1.downArrowDown = true;
                    break;

            }
        }

        private void GameScreen_KeyUp(object sender, KeyEventArgs e)
        {
            switch (e.KeyCode)
            {
                case Keys.Left:
                    Form1.leftArrowDown = false;
                    break;
                case Keys.Right:
                    Form1.rightArrowDown = false;
                    break;
                case Keys.Up:
                    Form1.upArrowDown = false;
                    break;
                case Keys.Down:
                    Form1.downArrowDown = false;
                    break;

            }
        }

        public void MakeCrabs()
        {
            int crabY = random.Next(80, 421);
            int crabColour = random.Next(1, 3);

            if (crabColour == 1)
            {
                crabsColour = Color.Red;
            }
            else
            {
                crabsColour = Color.Orange;
            }

            Crab crab = new Crab(CRAB_SIZE, 0, crabY, crabsColour);
            crabs.Add(crab);
        }

        private void gameLoopTimer_Tick(object sender, EventArgs e)
        {
            foreach (Crab c in crabs)
            {
                c.Move(crabSpeed);

            }

            if (crabs[0].x > 800)
            {
                crabs.RemoveAt(0);
            }

            if (crabs[crabs.Count - 1].x >= 60)
            {
                MakeCrabs();
            }
           


            Refresh();
        }
        private void GameScreen_Paint(object sender, PaintEventArgs e)
        {
            foreach (Crab c in crabs)
            {
                crabBrush.Color = c.colour;
                e.Graphics.FillRectangle(crabBrush, c.x, c.y, c.size, c.size);
            }
        }


    }
}
