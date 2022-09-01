using System;
using System.Collections.Generic;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;
using System.Threading;
using System.IO;

namespace HanoiTower
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            
            CheckForIllegalCrossThreadCalls = false;
            DoubleBuffered = true;
            this.FormClosed += AppExit;
            t = new Thread(AutoThread);
            r = new Random();
            SaveToFileThread = new Thread(SaveToFileMeth);
            
           

        }
        public int Move = 1;
        public List<Plate> Plates = new List<Plate>();
        Thread t;
        Random r;
        bool stopThread = false;
        bool suspendThread = false;

        protected override void OnPaint(PaintEventArgs e)
        {
            base.OnPaint(e);
            e.Graphics.DrawRectangle(Pens.Black, new Rectangle(200, 30, 10, 300));
            e.Graphics.DrawRectangle(Pens.Black, new Rectangle(500, 30, 10, 300));
            e.Graphics.DrawRectangle(Pens.Black, new Rectangle(800, 30, 10, 300));

            Plates = Plates.OrderByDescending(x => x.Size).ToList();
            int[] numberofplatesinplaces = new int[3];
            
            foreach(Plate p in Plates)
            {
                if (p.Place == 3)
                    p.Place = 0;
                else if (p.Place == -1)
                    p.Place = 2;
                if(ColoredBox.Checked)
                    e.Graphics.FillRectangle(new SolidBrush(p.c), new Rectangle(p.Place * 300+ 205 - 5*p.Size, 322 - numberofplatesinplaces[p.Place] * 10, 10 * p.Size, 10));
                else
                    e.Graphics.FillRectangle(Brushes.Black, new Rectangle(p.Place * 300 + 205 - 5 * p.Size, 322 - numberofplatesinplaces[p.Place] * 10, 10 * p.Size, 10));
                numberofplatesinplaces[p.Place]++;
            }
            if (!SFastBox.Checked)
            {
                NumberOfMoves.Text = "Move: " + Move + "/" + (Math.Pow(2, (int)NumberOfPlates.Value));
            }
        }       
        public void AppExit(object sender, EventArgs e)
        {
            stopThread = true;
            
        }
        public void MakeMove()
        {
            if (Move < (Math.Pow(2, (int)NumberOfPlates.Value)))
            {
                foreach (Plate p in Plates)
                {
                    if (Move == Math.Pow(2, p.Size) * p.TimesMoved + Math.Pow(2, p.Size - 1))
                    {
                        if (p.Size % 2 == 0 + NumberOfPlates.Value % 2)
                        {
                            p.Place--;
                            if (p.Place == -1)
                                p.Place = 2;
                            p.TimesMoved++;
                        }
                        else
                        {
                            p.Place++;
                            if (p.Place == 3)
                                p.Place = 0;
                            p.TimesMoved++;
                        }
                    }
                }
                Move++;
            }
            this.Invalidate();
        }
        private void NextMoveButton_Click(object sender, EventArgs e)
        {
            MakeMove();
        }

        private void ResetButton_Click(object sender, EventArgs e)
        {
            this.Invalidate();
            Plates.Clear();
            for(int a = 0; a < NumberOfPlates.Value; a++)
            {
                Plates.Add(new Plate(a + 1, Color.FromArgb(r.Next(30, 230), r.Next(30, 230), r.Next(30, 230))));
            }
            Move = 1;
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void AutomaticMove_Click(object sender, EventArgs e)
        {
            
            if (t.ThreadState == ThreadState.Unstarted)
            {
                t.Start();
                AutomaticMove.Text = "Stop";
            }
            else
            {
                if (!suspendThread)
                {
                    suspendThread = true;
                    AutomaticMove.Text = "Resume";
                }
                else
                {
                    suspendThread = false;
                    AutomaticMove.Text = "Stop";
                }
            }
           

        }
        public void AutoThread()
        {
            while (true)
            {
                if (SFastBox.Checked)
                {

                }
                   
                else if(FastBox.Checked)
                    Thread.Sleep(20);
                else
                    Thread.Sleep(100);
                MakeMove();
                if (stopThread)
                    break;
                sus:
                if (suspendThread && !stopThread)
                    goto sus;
                else if (stopThread)
                    break;
                
            }
        }

        private void Exitbutton_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void NumberOfPlates_ValueChanged(object sender, EventArgs e)
        {
            this.Invalidate();
            Plates.Clear();
            for (int a = 0; a < NumberOfPlates.Value; a++)
            {
                Plates.Add(new Plate(a + 1, Color.FromArgb(r.Next(30, 230), r.Next(30, 230), r.Next(30, 230))));
            }
            Move = 1;
        }

        private void ColoredBox_CheckedChanged(object sender, EventArgs e)
        {
            this.Invalidate();
        }
        Thread SaveToFileThread; 
        public void SaveToFileMeth()
        {
            List<Plate> LocalPlates = new List<Plate>();
            File.WriteAllText("hanoi.txt", "");
            int LocalMove = 1;
            for (int a = 0; a < NumberOfPlates.Value; a++)
            {
                LocalPlates.Add(new Plate(a + 1, Color.FromArgb(r.Next(30, 230), r.Next(30, 230), r.Next(30, 230))));
            }
            
            int maxmove = (int)(Math.Pow(2, (int)NumberOfPlates.Value));

            do
            {
                if (stopThread)
                {
                    break;
                }
                string toAdd = "";
                if (LocalMove < (Math.Pow(2, (int)NumberOfPlates.Value)))
                {
                    foreach (Plate p in LocalPlates)
                    {

                        if (LocalMove == Math.Pow(2, p.Size) * p.TimesMoved + Math.Pow(2, p.Size - 1))
                        {
                            toAdd += p.Place + "->";
                            if (p.Size % 2 == 0 + NumberOfPlates.Value % 2)
                            {
                                p.Place--;
                                if (p.Place == -1)
                                    p.Place = 2;
                                p.TimesMoved++;
                            }
                            else
                            {
                                p.Place++;
                                if (p.Place == 3)
                                    p.Place = 0;
                                p.TimesMoved++;
                            }
                            toAdd += p.Place + "\n";
                        }
                    }
                    LocalMove++;
                }

                File.AppendAllText("hanoi.txt", toAdd);
            }
            while (LocalMove < maxmove);
            MessageBox.Show("Sequence succesfully saved to a text file");
            

        }

        private void SaveToFile_Click(object sender, EventArgs e)
        {
            if(SaveToFileThread.ThreadState == ThreadState.Unstarted)
                SaveToFileThread.Start();
            else
            {
                SaveToFileThread = new Thread(SaveToFileMeth);
                SaveToFileThread.Start();
            }
                              
        }
    }
    public class Plate
    {
        public Plate(int size, Color C)
        {
            Size = size;
            c = C;
           
        }
        public int Size = 1;
        public int TimesMoved = 0;
        public int Place = 0;
        public Color c = new Color();
    }
}
