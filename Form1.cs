using Backprop;
using System;
using System.Windows.Forms;

namespace BackPropagation
{
    public partial class Form1 : Form
    {
        private NeuralNet neuralNetwork;
        double[,] dataSet;

        public Form1()
        {
            InitializeComponent();
        }
        private void CreateNeuralNetwork()
        {
            neuralNetwork = new NeuralNet(4, 4, 1);
        }
        private void SetNetwork()
        {
            for (int i = 0; i < dataSet.GetLength(0); i++)
            {
                for (int j = 0; j < dataSet.GetLength(1) - 1; j++)
                {
                    neuralNetwork.setInputs(j, dataSet[i, j]);
                }
                neuralNetwork.setDesiredOutput(0, dataSet[i, dataSet.GetLength(1) - 1]);
                neuralNetwork.learn();
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (neuralNetwork == null)
            {
                MessageBox.Show("Please initialize the neural network by clicking Button 1 first.");
                return;
            }

            int epoch = findMinEpochs();
            train(epoch);
            MessageBox.Show($"Training completed in {epoch} epochs.");
            textBox3.Text = "" + epoch;
        }
        private double getError()
        {
            double errorSum = 0;
            for (int i = 0; i < dataSet.GetLength(0); i++)
            {
                for (int j = 0; j < dataSet.GetLength(1) - 1; j++)
                {
                    neuralNetwork.setInputs(j, dataSet[i, j]);
                }
                neuralNetwork.run();
                errorSum += Math.Abs(neuralNetwork.getOuputData(0) - dataSet[i, dataSet.GetLength(1) - 1]);
            }
            return errorSum / dataSet.GetLength(0);
        }
        private int findMinEpochs()
        {
            int l = 0, r = 10000;
            double errorThreshold = 0.01;

            while (l < r)
            {
                int m = (l + r) / 2;
                train(m);

                if (getError() < errorThreshold)
                {
                    r = m;
                }
                else
                {
                    l = m + 1;
                }
            }

            return l;
        }
        private void train(int epochs)
        {
            CreateNeuralNetwork();
            for (int i = 0; i < epochs; i++)
            {
                SetNetwork();
            }
        }


        private void button1_Click(object sender, EventArgs e)
        {
            neuralNetwork = new NeuralNet(4,8, 1);
            dataSet = new double[,]
            {
                { 0.0, 0.0, 0.0, 0.0, 0.0 },
                { 0.0, 0.0, 0.0, 1.0, 0.0 },
                { 0.0, 0.0, 1.0, 0.0, 0.0 },
                { 0.0, 0.0, 1.0, 1.0, 0.0 },
                { 0.0, 1.0, 0.0, 0.0, 0.0 },
                { 0.0, 1.0, 0.0, 1.0, 0.0 },
                { 0.0, 1.0, 1.0, 0.0, 0.0 },
                { 0.0, 1.0, 1.0, 1.0, 0.0 },
                { 1.0, 0.0, 0.0, 0.0, 0.0 },
                { 1.0, 0.0, 0.0, 1.0, 0.0 },
                { 1.0, 0.0, 1.0, 0.0, 0.0 },
                { 1.0, 0.0, 1.0, 1.0, 0.0 },
                { 1.0, 1.0, 0.0, 0.0, 0.0 },
                { 1.0, 1.0, 0.0, 1.0, 0.0 },
                { 1.0, 1.0, 1.0, 0.0, 0.0 },
                { 1.0, 1.0, 1.0, 1.0, 1.0 }
            };

        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (neuralNetwork == null)
            {
                MessageBox.Show("Please initialize the neural network by clicking Button 1 first.");
                return;
            }
            neuralNetwork.setInputs(0, Convert.ToDouble(textBox1.Text));
            neuralNetwork.setInputs(1, Convert.ToDouble(textBox2.Text));
            neuralNetwork.setInputs(2, Convert.ToDouble(textBox5.Text));
            neuralNetwork.setInputs(3, Convert.ToDouble(textBox4.Text));
            neuralNetwork.run();
            textBox12.Text = neuralNetwork.getOuputData(0).ToString();

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void textBox12_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
