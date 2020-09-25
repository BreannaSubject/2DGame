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
        int tick = 0;

        //crab variables
        List<Crab> topCrabs = new List<Crab>();
        List<Crab> bottomCrabs = new List<Crab>();
        const int CRAB_SIZE = 30;
        int crabSpeed = 3, crabSpace = 150;
        SolidBrush topCrabBrush = new SolidBrush(Color.Red);
        SolidBrush bottomCrabBrush = new SolidBrush(Color.Orange);
        Color topCrabsColour, bottomCrabsColour; 

        //bubble variables
        List<Bubbles> bubbles = new List<Bubbles>();
        const int BUBBLE_SPEED = 10, BUBBLE_SIZE = 30;
        

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
            int topCrabY = random.Next(20, 201 - CRAB_SIZE);
            int bottomCrabY = random.Next(200 + CRAB_SIZE, 401 - CRAB_SIZE);
            int topCrabColour = random.Next(1, 3);
            int bottomCrabColour = random.Next(1, 3);
            

            if (topCrabColour == 1)
            {
                topCrabsColour = Color.Red;
            }
            else
            {
                topCrabsColour = Color.Orange;
            }

            if (bottomCrabColour == 1)
            {
                bottomCrabsColour = Color.Red;
            }
            else
            {
                bottomCrabsColour = Color.Orange;
            }

            Crab topCrab = new Crab(CRAB_SIZE, 0, topCrabY, topCrabsColour);
            Crab bottomCrab = new Crab(CRAB_SIZE, 0, bottomCrabY, bottomCrabsColour);
            topCrabs.Add(topCrab);
            bottomCrabs.Add(bottomCrab);
        }

        private void gameLoopTimer_Tick(object sender, EventArgs e)
        {
            tick++;

            if (tick == 400)
            {
                crabSpeed++;
                crabSpace = crabSpace - 10;
                tick = 0;
            }
            foreach (Crab c in topCrabs)
            {
                c.Move(crabSpeed);

            }

            if (topCrabs[0].x > 900)
            {
                topCrabs.RemoveAt(0);
            }

            if (topCrabs[topCrabs.Count - 1].x >= crabSpace)
            {
                MakeCrabs();
            }

            foreach (Crab c in bottomCrabs)
            {
                c.Move(crabSpeed);

            }

            if (bottomCrabs[0].x > 900)
            {
                bottomCrabs.RemoveAt(0);
            }

            if (bottomCrabs[bottomCrabs.Count - 1].x >= crabSpace)
            {
                MakeCrabs();
            }




            Refresh();
        }
        private void GameScreen_Paint(object sender, PaintEventArgs e)
        {
            foreach (Crab c in topCrabs)
            {
                topCrabBrush.Color = c.colour;
                e.Graphics.FillRectangle(topCrabBrush, c.x, c.y, c.size, c.size);
            }

            foreach (Crab c in bottomCrabs)
            {
                bottomCrabBrush.Color = c.colour;
                e.Graphics.FillRectangle(bottomCrabBrush, c.x, c.y, c.size, c.size);
            }
        }


    }
}
