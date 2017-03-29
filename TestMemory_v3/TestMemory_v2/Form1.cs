using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TestMemory_v2
{
    public partial class Form1 : Form
    {
        // Variable declaration start -----------------------------------------------------------------------

        // Creating variable, to check, if first item is already open
        PictureBox firstClicked = null;

        // Creating variable to save the secound item, when @firstClicked is already set
        PictureBox secondClicked = null;

        // Creating a variable to select random items in the @AssignIconsToList() methode
        Random random = new Random();

        // Creating a vriable with the src of the background card
        string absolutNull = "C:/4AI/Logoboard_Memory_Entwicklung/TestMemory_v3/Logosimages/0.png";

        // Creating a variable to save all the src's of the logos
        List<string> icons = new List<string>()
        {
            "C:/4AI/Logoboard_Memory_Entwicklung/TestMemory_v3/Logosimages/1.png",
            "C:/4AI/Logoboard_Memory_Entwicklung/TestMemory_v3/Logosimages/1.png",
            "C:/4AI/Logoboard_Memory_Entwicklung/TestMemory_v3/Logosimages/2.png",
            "C:/4AI/Logoboard_Memory_Entwicklung/TestMemory_v3/Logosimages/2.png",
            "C:/4AI/Logoboard_Memory_Entwicklung/TestMemory_v3/Logosimages/3.png",
            "C:/4AI/Logoboard_Memory_Entwicklung/TestMemory_v3/Logosimages/3.png",
            "C:/4AI/Logoboard_Memory_Entwicklung/TestMemory_v3/Logosimages/4.png",
            "C:/4AI/Logoboard_Memory_Entwicklung/TestMemory_v3/Logosimages/4.png",
            "C:/4AI/Logoboard_Memory_Entwicklung/TestMemory_v3/Logosimages/5.png",
            "C:/4AI/Logoboard_Memory_Entwicklung/TestMemory_v3/Logosimages/5.png",
            "C:/4AI/Logoboard_Memory_Entwicklung/TestMemory_v3/Logosimages/6.png",
            "C:/4AI/Logoboard_Memory_Entwicklung/TestMemory_v3/Logosimages/6.png",
            "C:/4AI/Logoboard_Memory_Entwicklung/TestMemory_v3/Logosimages/7.png",
            "C:/4AI/Logoboard_Memory_Entwicklung/TestMemory_v3/Logosimages/7.png",
            "C:/4AI/Logoboard_Memory_Entwicklung/TestMemory_v3/Logosimages/8.png",
            "C:/4AI/Logoboard_Memory_Entwicklung/TestMemory_v3/Logosimages/8.png"
        };

        // Creating a variable, that will save the rdm selected srcs
        List<string> icons2 = new List<string>(){};


        // Variable declaration end -------------------------------------------------------------------------
        // methode declaration start ------------------------------------------------------------------------


        // Creating a methode, that assignes the srcs in a rdm order to the @icons2 List
        private void AssignIconsToList()
        {
            // loop repeates 16 times because of the 16 srcs in @icons. -> more? need a variable or .length of @icons
            for (int i = 0; i < 16; i++)
            {
                int randomNumber = random.Next(icons.Count);
                icons2.Add(icons[randomNumber]);
                icons.RemoveAt(randomNumber);
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



        public Form1()
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

            PictureBox clickedPic= sender as PictureBox;

            if (clickedPic != null)
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
            // Go through all of the labels in the TableLayoutPanel, 
            // checking each one to see if its icon is matched
            foreach (Control control in tableLayoutPanel2.Controls)
            {
                PictureBox iconPic = control as PictureBox;

                if (iconPic != null)
                {
                    if (iconPic.ImageLocation != absolutNull)
                        return;
                }
            }

            // If the loop didn’t return, it didn't find
            // any unmatched icons
            // That means the user won. Show a message and close the form
            MessageBox.Show("You matched all the icons!", "Congratulations");
            Close();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}
