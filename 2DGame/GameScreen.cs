using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Media;

namespace _2DGame
{
    public partial class GameScreen : UserControl
    {
        Random random = new Random();
        int tick = 0;

        //crab variables
        List<Crab> topCrabs = new List<Crab>();
        List<Crab> bottomCrabs = new List<Crab>();
        const int CRAB_SIZE = 20;
        int crabSpeed = 4, crabSpace = 120;
        SolidBrush topCrabBrush = new SolidBrush(Color.Red);
        SolidBrush bottomCrabBrush = new SolidBrush(Color.Orange);
        Image topCrabsColour, bottomCrabsColour;
        Image Brian;
        Image Craig;

        //bubble variables
        List<Bubbles> bubbles = new List<Bubbles>();
        const int BUBBLE_SPEED = 8, BUBBLE_SIZE = 20;
        SolidBrush bubbleBrush = new SolidBrush(Color.MidnightBlue);
        Image Bubble;


        //hero variables
        Hero hero;
        int heroSpeed = 6;
        const int HERO_WIDTH = 20, HERO_HEIGHT = 40;
        SolidBrush heroBrush = new SolidBrush(Color.Aquamarine);
        Image Barry = Properties.Resources.Barry;
        int score;
        SoundPlayer scoreSound = new SoundPlayer(Properties.Resources.glass_ping_Go445_1207030150);

        

        public GameScreen()
        {
            InitializeComponent();

            Brian = Properties.Resources.Brian;
            Craig = Properties.Resources.Craig;
            Bubble = Properties.Resources.Bubble;

        }

        private void GameScreen_Load(object sender, EventArgs e)
        {
            hero = new Hero(HERO_WIDTH, HERO_HEIGHT, this.Width / 2 - HERO_WIDTH / 2, this.Height - HERO_HEIGHT - 30);
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
                topCrabsColour = Brian;
            }
            else
            {
                topCrabsColour = Craig;
            }

            if (bottomCrabColour == 1)
            {
                bottomCrabsColour = Brian;
            }
            else
            {
                bottomCrabsColour = Craig;
            }

            Crab topCrab = new Crab(CRAB_SIZE, 0, topCrabY, topCrabsColour);
            Crab bottomCrab = new Crab(CRAB_SIZE, 0, bottomCrabY, bottomCrabsColour);
            topCrabs.Add(topCrab);
            bottomCrabs.Add(bottomCrab);
        }

        public void MakeBubbles()
        {
            int bubbleX = random.Next(30, this.Width - 29);
            Bubbles bubble = new Bubbles(BUBBLE_SIZE, bubbleX, 0);
            bubbles.Add(bubble);
        }

        private void gameLoopTimer_Tick(object sender, EventArgs e)
        {
            
            tick++;

            if (tick == 200)
            {
                MakeBubbles();
            }

            if (tick == 400)
            {
                crabSpeed++;
                crabSpace = crabSpace - 10;
                MakeBubbles();
                tick = 0;
            }

            foreach (Bubbles b in bubbles)
            {
                b.Move(BUBBLE_SPEED);
            }

            if (bubbles.Count() >= 1)
            {
                if (bubbles[0].y > this.Height)
                {
                    bubbles.RemoveAt(0);
                }
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

            if (Form1.leftArrowDown == true || Form1.rightArrowDown == true || Form1.downArrowDown == true || Form1.upArrowDown)
            {
                hero.Move(heroSpeed);
            }

            Rectangle heroRec = new Rectangle(hero.x, hero.y, hero.width, hero.height);

            if (topCrabs.Count() >= 1)
            {
                foreach (Crab c in topCrabs)
                {
                    Rectangle tCrabs = new Rectangle(c.x, c.y, c.size, c.size);
                    if (heroRec.IntersectsWith(tCrabs))
                    {
                        gameLoopTimer.Enabled = false;
                        GameOver go = new GameOver();
                        Form f = this.FindForm();
                        f.Controls.Remove(this);
                        f.Controls.Add(go);
                    }

                }
            }

            if (bottomCrabs.Count() >= 1)
            {
                foreach (Crab c in bottomCrabs)
                {
                    Rectangle bCrabs = new Rectangle(c.x, c.y, c.size, c.size);
                    if (heroRec.IntersectsWith(bCrabs))
                    {
                        gameLoopTimer.Enabled = false;
                        GameOver go = new GameOver();
                        Form f = this.FindForm();
                        f.Controls.Remove(this);
                        f.Controls.Add(go);
                    }

                }
            }

            if (hero.y < 0)
            {
                score++;
                hero.y = this.Height - hero.height - 20;
                scoreSound.Play();
            }

            if (bubbles.Count() >= 1)
            {
                foreach(Bubbles b in bubbles)
                {
                    Rectangle bubble = new Rectangle(b.x, b.y, b.size, b.size);
                    if (heroRec.IntersectsWith(bubble))
                    {
                        if (crabSpeed > 1)
                        {
                            crabSpeed--;
                        }
                    }
                }
            }
            


            Refresh();
        }
        private void GameScreen_Paint(object sender, PaintEventArgs e)
        {
            foreach (Crab c in topCrabs)
            {
                //topCrabBrush.Color = c.colour;
                //e.Graphics.FillRectangle(topCrabBrush, c.x, c.y, c.size, c.size);
                Image image = topCrabsColour;
                e.Graphics.DrawImage(c.image, c.x, c.y, c.size, c.size); 
            }

            foreach (Crab c in bottomCrabs)
            {
                //bottomCrabBrush.Color = c.colour;
                //e.Graphics.FillRectangle(bottomCrabBrush, c.x, c.y, c.size, c.size);
                e.Graphics.DrawImage(c.image, c.x, c.y, c.size, c.size);
            }

            foreach(Bubbles b in bubbles)
            {
                //e.Graphics.FillRectangle(bubbleBrush, b.x, b.y, b.size, b.size);
                e.Graphics.DrawImage(Bubble, b.x, b.y, b.size, b.size);
            }
            e.Graphics.DrawImage(Barry, hero.x, hero.y, hero.width, hero.height);
            //e.Graphics.FillRectangle(heroBrush, hero.x, hero.y, hero.width, hero.height);
            Font font = new Font("Arial", 16);
            e.Graphics.DrawString(Convert.ToString(score), font, bubbleBrush, this.Width - 40, this.Height- 40);


        }


    }
}
