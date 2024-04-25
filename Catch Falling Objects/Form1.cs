using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Diagnostics;
using System.Media;
using System.IO;

namespace Catch_Falling_Objects
{
    public partial class Form1 : Form
    {

        private List<Image> pokemonImages = new List<Image>();  //list of images for pokemon sprite .png files
        private Random random = new Random();   //object for random generation of sprites
        public Form1()
        {
            InitializeComponent();
        }
        private void LoadPokemonSprites() 
        
        {
            string path = @"D:\Users\Kunal\Desktop\pokemon\main-sprites1\black-white";
            string[] files = Directory.GetFiles(path, "*.png"); // get all files that are png

            foreach (string file in files) {

                //get pkmn number from the filename
                string fileName = Path.GetFileNameWithoutExtension(file);
                int pokemonNumber;
                if(int.TryParse(fileName, out pokemonNumber) ) //convert string it signed number
                {
                    if(pokemonNumber >= 1 && pokemonNumber <= 649) //check if it's within pokedex
                    {
                        Image pokemonImage = Image.FromFile(file);
                        pokemonImages.Add(pokemonImage); //add to the list
                        //Console.WriteLine(pokemonImages[pokemonNumber]);
                    }
                }
            }
        }

        /*want to display a random pokemon to the pictureBox UI on the Windows Form*/
        private void displayRandPkmn() { }


        /*generate a random pokemon number*/
        private void getRandPkmnImage() { }


        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void aboutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            SystemSounds.Asterisk.Play();
            MessageBox.Show("Drag each Pokemon Sprite into it's corresponding generation within the alotted time. See how high you can get your score!");
        }
    }
}
