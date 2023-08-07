using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Calc2
{
    public partial class Form1 : Form 

    {

        public double value1;
        public double value2;
        public double result;
        public String operation;
        public String operationActuality;

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void txValue1_TextChanged(object sender, EventArgs e)
        {

        }
        private void cbOperation_SelectedIndexChanged(object sender, EventArgs e)
        {
        
        operation  = cbOperation.Text; 
               
          

        

        }
        private void buttonCalculate_Click(object sender, EventArgs e)
        {


            if (txValue1.Text != null)
            {
                if (operation == "Adição")
                {
                    value1 = double.Parse(txValue1.Text);
                    value2 = double.Parse(txValue2.Text);
                    result = value1 + value2;
                }
                else if (operation == "Subtração")
                {
                    value1 = double.Parse(txValue1.Text);
                    value2 = double.Parse(txValue2.Text);
                    result = value1 - value2;
                }
                else if (operation == "Multiplicação")
                {
                    value1 = double.Parse(txValue1.Text);
                    value2 = double.Parse(txValue2.Text);
                    result = value1 * value2;
                }
                else if (operation == "Divisão")
                {
                    value1 = double.Parse(txValue1.Text);
                    value2 = double.Parse(txValue2.Text);
                    result = value1 / value2;
                }
                else
                {
                    MessageBox.Show("Nenhum tipo de operação foi selecionada ");
                }
                }

            lbResult.Text = result.ToString();
        }

    
    }
}
