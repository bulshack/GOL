using System;
using System.Drawing;
using System.IO;
using System.Windows.Forms ;
using System.Collections.Generic;


namespace Class1_Intro
{ 
    //The Universe
    public partial class Form1 : Form
    {   
        
        // The universe array
        bool[,] universe = new bool[20, 20]; 
        bool[,] Pad = new bool[20, 20];
        bool[,] temp = new bool[20, 20];
        // Drawing colors
        Color gridColor = Color.Black;
        Color cellColor = Color.Cyan;
        Color deadcellC = Color.White;
        // The Timer class
        Timer timer = new Timer(); 
   
        // Generation count
        int generations = 0;
        int LivingCells = 0; 
        //forms
        GetSeedForRand dudex = new GetSeedForRand();
        Settings option = new Settings(); 
        //Ini 
        public bool[,] Universe { get => universe; set => universe = value; }

        public Form1()
        {
            
            InitializeComponent();
            //For security I ini the Color in the option Menu// in case the user do not select any color
            option.OneColor = gridColor;
            option.SecondColor = deadcellC;
            option.OneMoreColor = cellColor;
            //universe[1, 1] = true;

            // Init Timer 
            timer.Tick += Timer_Tick;
            timer.Interval = 20;
            option.interval = timer.Interval;
           // option.interval = timer.Interval;
            CellsAlive.Text = "Living Cells: " + LivingCells.ToString();

           
           

        }
        //timer
        private void Timer_Tick(object sender, EventArgs e)
        {
            NextGeneration();
            countlivingcells();
        }
        //Next Generation function
        private void NextGeneration()
        {
            temp = universe;

            for (int y = 0; y < universe.GetLength(1); y++)
            {
                for (int x = 0; x < universe.GetLength(0); x++)
                {
                    var state = universe[x, y];


                    int neighbors = countNeighbor(x, y);

                    if (state == false && neighbors == 3)
                    {
                        Pad[x, y] = true;
                    }
                    else if (state == true && (neighbors < 2 || neighbors > 3))
                    {
                        Pad[x, y] = false;
                    }
                    else
                    {
                        Pad[x, y] = state;
                    }
                }
            }

            universe = Pad;

            Pad = temp;

            generations++;

            toolStripStatusLabelGerenations.Text = "Generations = " + generations.ToString();

        

            graphicsPanel1.Invalidate();
        }
        //CountNeighbor Functions
        private int countNeighbor( int x, int y)
        {
            int sum = 0;

            for (int i = -1; i < 2; i++)
            {
                // Iterate through the universe in the x, left to right
                for (int j = -1; j < 2; j++)
                {
                    //let col = (x + i + cols) % cols;
                    //let row = (y + j + rows) % rows;
                    //sum += grid[col][row];

                    int col = (y + i + universe.GetLength(1)) % universe.GetLength(1);

                    int row = (x + j + universe.GetLength(0)) % universe.GetLength(0);

                    if (universe[row, col] == true)
                    {
                        sum++;
                    }
                }

            }

            if (universe[x, y])
            {
                sum--;
            }

           // graphicsPanel1.Invalidate();


            return sum;
        }
        //Graphic Tools
        private void graphicsPanel1_Paint(object sender, PaintEventArgs e)
        {
            // USE FLOATS!
            Font font = new Font("Arial", 10f);

            StringFormat stringFormat = new StringFormat();
            stringFormat.Alignment = StringAlignment.Center;
            stringFormat.LineAlignment = StringAlignment.Center;

           
            // The width and height of each cell in pixels
            int cellWidth = graphicsPanel1.ClientSize.Width / universe.GetLength(0);
            int cellHeight = graphicsPanel1.ClientSize.Height / universe.GetLength(1);

            // A Pen for drawing the grid lines (color, width)
           Pen gridPen = new Pen(gridColor, 1);  


            // Brush
            Brush cellBrush = new SolidBrush(cellColor);
            Brush DeadCellBrush = new SolidBrush(deadcellC);
            // Iterate through the universe in the y, top to bottom
            for (int y = 0; y < universe.GetLength(1); y++)
            {
                // Iterate through the universe in the x, left to right
                for (int x = 0; x < universe.GetLength(0); x++)
                {
                    // A rectangle to represent each cell in pixels
                    // RectangleF for floats!
                    Rectangle cellRect = Rectangle.Empty;
                    cellRect.X = x * cellWidth;
                    cellRect.Y = y * cellHeight;
                    cellRect.Width = cellWidth;
                    cellRect.Height = cellHeight;

                    // Fill the cell with a brush
                    if (universe[x, y] == true)
                    {
                        e.Graphics.FillRectangle(cellBrush, cellRect);
                    }
                    else if (universe[x,y] == false)
                    {
                        e.Graphics.FillRectangle(DeadCellBrush, cellRect);
                    } 


                    

                    e.Graphics.DrawString(countNeighbor(x, y).ToString(), font, Brushes.Black, cellRect, stringFormat);

                    // e.Graphics.DrawString(countNeighbor( x, y).ToString(), font, Brushes.Black, cellRect, stringFormat);

                    // Outline the cell with a pen
                    e.Graphics.DrawRectangle(gridPen, cellRect.X, cellRect.Y, cellRect.Width, cellRect.Height);
                }
            }

            // Cleaning up pens and brushes
            gridPen.Dispose();
            cellBrush.Dispose();
            

        }
        //Graphic Tools
        private void graphicsPanel1_MouseClick(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                // USE FLOATS!

                // The width and height of each cell in pixels
                int cellWidth = graphicsPanel1.ClientSize.Width / universe.GetLength(0);
                int cellHeight = graphicsPanel1.ClientSize.Height / universe.GetLength(1);


                int x = e.X / cellWidth;
                int y = e.Y / cellHeight;

                universe[x, y] = !universe[x, y];

                countlivingcells();

                graphicsPanel1.Invalidate();
            }
        }
        //this function is to Reset the Universe
        private void newToolStripMenuItem_Click(object sender, EventArgs e)
        {
            // In case the Timer is On... 

            timer.Enabled = false;

            // Iterate through the universe in the y, top to bottom
            for (int y = 0; y < universe.GetLength(1); y++)
            {
                // Iterate through the universe in the x, left to right
                for (int x = 0; x < universe.GetLength(0); x++)
                {
                    universe[x, y] = false;
                }
            }

            // set Generations To 0 and Living Cells
            generations = 0;
            LivingCells = 0;
            toolStripStatusLabelGerenations.Text = "Generations = " + generations.ToString();
            CellsAlive.Text = "Living Cells: " + LivingCells.ToString();
            graphicsPanel1.Invalidate();
        }
        //Next Generation Bott
        private void toolStripButton3_Click(object sender, EventArgs e)
        {
            NextGeneration();
            graphicsPanel1.Invalidate();
        }
        //PlayB
        private void PlayB_Click(object sender, EventArgs e)
        {

            timer.Enabled = true;
        }
        //StopB
        private void Stop_Timer_Click(object sender, EventArgs e)
        {
            timer.Enabled = false;
        }
        //Random
        private void basicRandomToolStripMenuItem_Click(object sender, EventArgs e)
        {
            int actual_state;
            Random dude = new Random();
            for (int y = 0; y < universe.GetLength(1); y++)
            {
                for (int x = 0; x < universe.GetLength(0); x++)
                {

                    actual_state = dude.Next(0, 2);

                    if (actual_state == 0)
                    {
                        universe[x, y] = false;
                    }
                    else
                    {
                        universe[x, y] = true;
                    }
                }
            }
            countlivingcells();
            graphicsPanel1.Invalidate();
        }
        //Random Dialog
        private void seedRandomToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if(dudex.ShowDialog() == DialogResult.OK)

            {
                int actual_state;
                Random dude = new Random(dudex.myVar); 

                for (int y = 0; y < universe.GetLength(1); y++)
                {
                    for (int x = 0; x < universe.GetLength(0); x++)
                    {

                        actual_state = dude.Next(0, 2);

                        if (actual_state == 0)
                        {
                            universe[x, y] = false;
                        }
                        else
                        {
                            universe[x, y] = true;
                        }
                    }
                }

                countlivingcells();
                graphicsPanel1.Invalidate();

            }
            else 
            {
               // dudex.Close();
            }

        }
        //Save the file
        private void saveToolStripButton_Click(object sender, EventArgs e)
        {
            int x = 0;
            int y = 0;
           

            //For Saving The Universe
            SaveFileDialog saveFileDialog1 = new SaveFileDialog(); 

            saveFileDialog1.DefaultExt = "cells";

            saveFileDialog1.Title = "Saving The Universe."; 
            
            saveFileDialog1.Filter = "Cells and texts Files (*.txt),(*.cells)|*.txt,*.cells|All files (*.*)|*.*";

           // saveFileDialog1.CheckFileExists = true;

            //saveFileDialog1.CheckPathExists = true;


            if (saveFileDialog1.ShowDialog() == DialogResult.OK)
            {
                // Saves the Image via a FileStream created by the OpenFile method.  

                StreamWriter sw = new StreamWriter(saveFileDialog1.FileName);

                sw.WriteLine("!Name: " + Path.GetFileNameWithoutExtension(saveFileDialog1.FileName));
                sw.WriteLine("!");

                //Pass Thr all the Universe and check for cells' status

                for ( y = 0; y < universe.GetLength(1); y++)
                    {

                    if (y > 0)
                    {
                        sw.WriteLine();
                    }
             
                    

                    for ( x = 0; x < universe.GetLength(0); x++)
                    {

                        

                        if (universe[x, y] == false)
                        {
                            sw.Write(".");
                        }

                        else
                        {
                            sw.Write("O");
                        }
                    }

                    }

                // Saves the Image in the appropriate ImageFormat based upon the  
                // File type selected in the dialog box.  
                // NOTE that the FilterIndex property is one-based.   



                sw.Close();
                        
            }

        }
        //Check Living cells
        void countlivingcells()
        {
            LivingCells = 0; 

            for (int y = 0; y < universe.GetLength(1); y++)
            {
                for (int x = 0; x < universe.GetLength(0); x++)
                {

                    if (universe[x,y] == true)
                    {
                        LivingCells++;
                    } 
                 
                 

                }
            }

            CellsAlive.Text = "Living Cells: " + LivingCells.ToString();
        }
        //Open a file and read and import new Universe
        private void openToolStripButton_Click(object sender, EventArgs e)
        {
           // universe[0, 0] = true;  

            string line = "";
            int counterY = 0;
            int lineX = 0;

            //For Saving The Universe
            OpenFileDialog openfile = new OpenFileDialog();

            openfile.DefaultExt = "cells";

           openfile.Title = "Opening the Universe.";

            openfile.Filter = "cells files (*.cells)|*.cells|Text Files (*.txt)|*.txt|All files (*.*)|*.*";

            openfile.CheckPathExists = true;


            if (openfile.ShowDialog() == DialogResult.OK)
            {

                // Saves the Image via a FileStream created by the OpenFile method.   
                Stream s = new MemoryStream();
                StreamReader sr = new StreamReader(openfile.FileName); 
                
                
                while ((line = sr.ReadLine()) != null)
                {
                    if (line[0] == '!')
                    {
                        continue;
                    }

                    else if (line[1] == '!')
                    {
                        continue;
                    }

                    lineX = line.Length;
             

                    counterY++;
                }


                sr.Close();

                //Resize The Universe 

                universe = new bool[lineX, counterY];
                 Pad = new bool[lineX, counterY];
                 //temp = new bool[lineX, counterY] ;


                lineX--;
                counterY = 0;


                StreamReader st = new StreamReader(openfile.FileName);

                //   StreamReader st = new StreamReader(openfile.FileName);

                while ((line = st.ReadLine()) != null)
                {
                    if (line[0] == '!')
                    {
                        continue;
                    }
       
                        
                    for (int x = 0; x < lineX; x++)
                    {

                        if (line[x] == '.')
                        {
                            universe[x, counterY] = false;
                        }

                        else if (line[x] == 'O')
                        {
                            universe[x, counterY] = true;
                        }

                    }

                    counterY++;

                
                   
                }
                st.Close();

            }

            countlivingcells();
            graphicsPanel1.Invalidate();
        }
        //option Menu
        private void optionsToolStripMenuItem_Click(object sender, EventArgs e)
        {

            if (option.ShowDialog() == DialogResult.OK)
            {        
               // timer.Interval = option.interval; 

               //Updating the colors
                gridColor = option.OneColor;
                deadcellC = option.SecondColor;
                cellColor = option.OneMoreColor;
                //Updating the Interval
                timer.Interval = option.interval;
                //updating the Universe Size
                universe = new bool[option.X, option.Y];
                Pad = new bool[option.X, option.Y];
                temp = new bool[option.X, option.Y];

            }
            graphicsPanel1.Invalidate();
        }
        //
        private void gridViewToolStripMenuItem_Click(object sender, EventArgs e)
        {
           // gridView.CheckOnClick;

        }
    }
}
