using ExchangeCurrency.Bank;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Windows.Forms;

namespace ExchangeCurrency
{
    public partial class Form1 : Form
    {
       
        Conection conection = new Conection();

        public Form1()
        {
            InitializeComponent();

            conection.LodingStart(dataGridView1, comboBoxOf);
        }             
       
        private void contextMenuStrip1_Opening(object sender, CancelEventArgs e)
        {
            
            conection.LodingIn(comboBoxIn);

        }
       
        private void textBoxInput_TextChanged(object sender, EventArgs e)
        {
            try
            {
                conection.Sum = Convert.ToDecimal(textBoxInput.Text);
            }
            catch
            {
                textBoxInput.Text = "";
            }
            
        }

        private void button1_Click(object sender, EventArgs e)
        {

            textBoxResalt.Text = conection.ConvertCurrency().ToString();
        }

        private void comboBoxOf_SelectedIndexChanged(object sender, EventArgs e)
        {
          
            conection.intitialOfName(comboBoxOf.Text);
            
        }

        private void comboBoxIn_SelectedIndexChanged(object sender, EventArgs e)
        {
            conection.intitialInName(comboBoxIn.Text);
           
        }
    }
}
