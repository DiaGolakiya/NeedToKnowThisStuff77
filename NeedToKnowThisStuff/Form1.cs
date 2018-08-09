using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace NeedToKnowThisStuff
{




    //todo we need to create sound

    //todo we need to unit taste and major two class
    //todo resouce folder to store S & N


    public partial class Form1 : Form
    {

        GameCode myGameCode = new GameCode();
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //my counter increased by 1 each time i click button
            myGameCode.count += 1;

            //show the counter for testing
            this.Text = myGameCode.count.ToString();
            //if random number = the counter show the cat dont run more code from below.
            int rnd = myGameCode.RNDgenerator();
            lbxOutput.Items.Insert(0, rnd);
            if (myGameCode.count == 4)
            {
                pbxImage.Image = Resource1.thU3740R4D;
                lbxOutput.Items.Add(0 + "I dont know");
                MessageBox.Show("The....");

                myGameCode.count = 0;
                // dont run any code from below
                return;
            }

            switch (myGameCode.count)
            {
                case 1:
                    pbxImage.Image = Resource1.thU3740R4D;
                    break;
                case 2:
                    pbxImage.Image = Resource1.th;
                    break;
                case 3:
                    pbxImage.Image = Resource1.thA0RCXDKU;
                    break;
                case 4:
                    pbxImage.Image = Resource1.thPRUWVFIN;
                    break;


            }

            return;
            if (myGameCode.count == 1)
            {
                pbxImage.Image = Resource1.th;

            }
            else if (myGameCode.count == 2)
            {
                pbxImage.Image = Resource1.thA0RCXDKU;

            }
            else if (myGameCode.count == 3)
            {
                pbxImage.Image = Resource1.thPRUWVFIN;

            }

            //we need a random Number generator
            //we can do this comment way as well.



            // lbxOutput.Items.Add(RNDgenerator());

        }

        private int RNDgenerator()
        {
            Random rndNumber = new Random();
            int rnd = rndNumber.Next(1, 7);
            return rnd;

            //we can do this in real world
            //return  rndNumber.Next(1, 7);
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }
    }
}
