using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EntellectUniCup
{
    public partial class Form1 : Form
    {

        // global variable because I am lazy now 
        string WorldFileName = "";

        public Form1()
        {
            InitializeComponent();
        }

        private void BtnFile_Click(object sender, EventArgs e)
        {
            // open file dialog   
            OpenFileDialog open = new OpenFileDialog
            {
                // txt filters  
                Filter = "Image Files(*.txt;)|*.txt;"
            };
            if (open.ShowDialog() == DialogResult.OK)
            {
                // store string 
                WorldFileName = open.FileName;
                // make the world 
                WorldHandler myworld = new WorldHandler(open.FileName);
                rtxOpenDIsplay.Text = myworld.toString();
               
            }
        }

        private void btnShowTestScore_Click(object sender, EventArgs e)
        {
            // open file dialog   
            OpenFileDialog open1 = new OpenFileDialog
            {
                // txt filters  
                Filter = "text Files(*.txt;)|*.txt;"
            };
            if (open1.ShowDialog() == DialogResult.OK)
            {
                // call your stuff here basically
                TesterClass tc = new TesterClass(open1.FileName, WorldFileName);
                txtScore.Text = tc.ToString();
            }

        }

        private void BtnCalculate_Click(object sender, EventArgs e)
        {
          

        }

        private void openFileDialog2_FileOk(object sender, CancelEventArgs e)
        {

        }
    }
}
