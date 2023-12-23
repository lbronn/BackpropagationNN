using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Backprop;

namespace BackPropagations
{
    public partial class Form1 : Form
    {
        NeuralNet nn;

        public Form1()
        {
            InitializeComponent();
        }

        private void btnCreateBPNN_Click(object sender, EventArgs e)
        {
            nn = new NeuralNet(2,100,1);
        }

        private void btnTrainNN_Click(object sender, EventArgs e)
        {

            // OR Gate - 2 inputs
            for (int x = 0; x < 100; x++)
            {
                nn.setInputs(0, 0.00);
                nn.setInputs(1, 0.00);
                nn.setDesiredOutput(0, 0.0);
                nn.learn();

                nn.setInputs(0, 0.00);
                nn.setInputs(1, 1.00);
                nn.setDesiredOutput(0, 1.0);
                nn.learn();

                nn.setInputs(0, 1.00);
                nn.setInputs(1, 0.00);
                nn.setDesiredOutput(0, 1.0);
                nn.learn();

                nn.setInputs(0, 1.00);
                nn.setInputs(1, 1.00);
                nn.setDesiredOutput(0, 1.0);
                nn.learn();
            }

            // AND gate - 4 inputs
        }

        private void btnTest_Click(object sender, EventArgs e)
        {
            nn.setInputs(0, Convert.ToDouble(txtInputA.Text));
            nn.setInputs(1, Convert.ToDouble(txtInputB.Text));
            nn.run();
            txtOutput.Text = "" + nn.getOuputData(0);
        }
    }
}
