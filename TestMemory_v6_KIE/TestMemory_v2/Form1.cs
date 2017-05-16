using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using NLog;

namespace TestMemory_v2
{
    public partial class Memory_Screen : Form
    {
        // Variable declaration start -----------------------------------------------------------------------

        // Creating variable, to check, if first item is already open
        PictureBox firstClicked = null;

        // Creating variable to save the secound item, when @firstClicked is already set
        PictureBox secondClicked = null;

        // Creating a variable to select random items in the @AssignIconsToList() methode
        Random random = new Random();

        // Creating a vriable with the src of the background card
        string absolutNull = "C:/Users/Niki/Desktop/Schule/ITP/Praxis/CloneRep/TestMemory_v6_KIE/Logosimages/0.png";

        //int ctb = 1;

        int counter;

        Logger logger = LogManager.GetCurrentClassLogger();

        String start = DateTime.Now.ToString("HH:mm:ss tt");
        String end;

        // Creating a variable to save all the src's of the logos
        List<string> icons = new List<string>()
        {
            "C:/Users/Niki/Desktop/Schule/ITP/Praxis/CloneRep/TestMemory_v6_KIE/Logosimages/1.png",
            "C:/Users/Niki/Desktop/Schule/ITP/Praxis/CloneRep/TestMemory_v6_KIE/Logosimages/2.png",
            "C:/Users/Niki/Desktop/Schule/ITP/Praxis/CloneRep/TestMemory_v6_KIE/Logosimages/3.png",
            "C:/Users/Niki/Desktop/Schule/ITP/Praxis/CloneRep/TestMemory_v6_KIE/Logosimages/4.png",
            "C:/Users/Niki/Desktop/Schule/ITP/Praxis/CloneRep/TestMemory_v6_KIE/Logosimages/5.png",
            "C:/Users/Niki/Desktop/Schule/ITP/Praxis/CloneRep/TestMemory_v6_KIE/Logosimages/6.png",
            "C:/Users/Niki/Desktop/Schule/ITP/Praxis/CloneRep/TestMemory_v6_KIE/Logosimages/7.png",
            "C:/Users/Niki/Desktop/Schule/ITP/Praxis/CloneRep/TestMemory_v6_KIE/Logosimages/8.png",
            "C:/Users/Niki/Desktop/Schule/ITP/Praxis/CloneRep/TestMemory_v6_KIE/Logosimages/9.png",
            "C:/Users/Niki/Desktop/Schule/ITP/Praxis/CloneRep/TestMemory_v6_KIE/Logosimages/10.png",
            "C:/Users/Niki/Desktop/Schule/ITP/Praxis/CloneRep/TestMemory_v6_KIE/Logosimages/11.png",
            "C:/Users/Niki/Desktop/Schule/ITP/Praxis/CloneRep/TestMemory_v6_KIE/Logosimages/12.png",
            "C:/Users/Niki/Desktop/Schule/ITP/Praxis/CloneRep/TestMemory_v6_KIE/Logosimages/13.png"

        };

        // Creating a variable, that will save the rdm selected srcs
        List<string> icons2 = new List<string>(){};
        List<string> icons3 = new List<string>(){};
        List<string> icons4 = new List<string>(){};


        // Variable declaration end -------------------------------------------------------------------------
        // methode declaration start ------------------------------------------------------------------------


        // Creating a methode, that assignes the srcs in a rdm order to the @icons2 List
        private void AssignIconsToList()
        {

            for (int i = 0; i < 8; i++)
            {
                int randomNumber = random.Next(icons.Count);
                icons3.Add(icons[randomNumber]);
                icons.RemoveAt(randomNumber);
            }

            for (int j = 0; j < 8; j++)
            {
                icons4.Add(icons3[j]);
            }

            for (int g = 0; g < 8; g++)
            {
                int randomNumber = random.Next(icons3.Count);
                icons2.Add(icons3[randomNumber]);
                icons3.RemoveAt(randomNumber);

                int randomNumber1 = random.Next(icons4.Count);
                icons2.Add(icons4[randomNumber1]);
                icons4.RemoveAt(randomNumber1);
            }




            // loop repeates 16 times because of the 16 srcs in @icons. -> more? need a variable or .length of @icons
           

            foreach (Control control in tableLayoutPanel2.Controls)
            {
                PictureBox iconPic = control as PictureBox;
                iconPic.ImageLocation = absolutNull;
                iconPic.SizeMode = PictureBoxSizeMode.Zoom;
            }

                // Following is for testin purposes
                // Console.WriteLine(icons2);
            }

        // Test methode, that is not relevant for the softwae functionalaty
        private void AssignIconsToSquares2()
        {
            int i = 0;
            foreach (Control control in tableLayoutPanel2.Controls)
            {
                PictureBox iconPic = control as PictureBox;
                if (iconPic != null)
                {
                    iconPic.ImageLocation = icons2[i];
                    //iconPic.Visible = false;
                    i++;
                }
            }
        }

        // methode to assigne the pictures to the grid
        private void AssignIconsToSquares()
        {
            // The TableLayoutPanel has 16 pictures, therefor we have 16 loops
            foreach (Control control in tableLayoutPanel2.Controls)
            {
                PictureBox iconPic = control as PictureBox;
                if (iconPic != null)
                {   
                    int randomNumber = random.Next(icons.Count);
                    iconPic.ImageLocation = icons[randomNumber];
                    iconPic.Visible = false;
                    icons.RemoveAt(randomNumber);
                }
            }
        }



        public Memory_Screen()
        {
            InitializeComponent();

            AssignIconsToList();

            //AssignIconsToSquares2();

            //AssignIconsToSquares();
        }

        private void PictureBox_click(object sender, EventArgs e)
        {
            if (timer1.Enabled == true)
                return;

            PictureBox clickedPic = sender as PictureBox;

            if (clickedPic.ImageLocation == absolutNull)
            {

                clickedPic.SizeMode = PictureBoxSizeMode.Zoom;

                if (clickedPic == firstClicked)
                    return;

                if (firstClicked == null)
                {
                    //int indexx = Int32.Parse(clickedPic.Name.Substring(10, 1));
                    firstClicked = clickedPic;
                    firstClicked.ImageLocation = icons2[Int32.Parse(clickedPic.Name.Substring(10, 2)) - 1];
                    return;
                }

                secondClicked = clickedPic;
                secondClicked.ImageLocation = icons2[Int32.Parse(clickedPic.Name.Substring(10, 2)) - 1];

                counter++;

                CheckForWinner();

                if (firstClicked.ImageLocation == secondClicked.ImageLocation)
                {
                    firstClicked = null;
                    secondClicked = null;
                    return;
                }

                timer1.Start();

            }
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            timer1.Stop();

            firstClicked.ImageLocation = absolutNull;
            firstClicked.SizeMode = PictureBoxSizeMode.Zoom;
            secondClicked.ImageLocation = absolutNull;
            secondClicked.SizeMode = PictureBoxSizeMode.Zoom;

            firstClicked = null;
            secondClicked = null;
        }

        private void CheckForWinner()
        {
            //Console.WriteLine(ctb + " newCheck");
            //int sf = 1;
            // Go through all of the labels in the TableLayoutPanel, 
            // checking each one to see if its icon is matched
            foreach (Control control in tableLayoutPanel2.Controls)
            {
                PictureBox iconPic = control as PictureBox;

                if (iconPic.ImageLocation != null)
                {
                    //Console.WriteLine("Jochen: " + iconPic.ImageLocation);
                    if (iconPic.ImageLocation == absolutNull)
                    {
                        //Console.WriteLine(iconPic.ImageLocation);
                        //sf++;
                        //ctb++;
                        return;
                    }
                }
            }

            // If the loop didn’t return, it didn't find
            // any unmatched icons
            // That means the user won. Show a message and close the form
            //Console.WriteLine("yees3");
            end = DateTime.Now.ToString("HH:mm:ss tt");
            TimeSpan duration = DateTime.Parse(end).Subtract(DateTime.Parse(start));
            logger.Info(duration.ToString() + " " + counter);
            new After_Screen().Show();
            Close();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            this.TopMost = true;
            this.FormBorderStyle = FormBorderStyle.None;
            this.WindowState = FormWindowState.Maximized;
        }
    }
}
