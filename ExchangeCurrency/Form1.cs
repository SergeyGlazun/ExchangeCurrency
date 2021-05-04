using Model.Models;
using PresentationCurrency;
using PresentationCurrency.Calculation;
using PresentationCurrency.ConvetTipe;
using PresentationCurrency.Models;
using System;
using System.Linq;
using System.Windows.Forms;

namespace ExchangeCurrency
{
    public partial class Form1 : Form
    {

        Conversion conection = new Conversion();

        ConnectParseHTML connectParseHTML = new ConnectParseHTML();

        CalculationCurrency calculation = new CalculationCurrency();
        
        public Form1()
        {
            InitializeComponent();

            dataGridView1.DataSource = connectParseHTML.Connect();
            dataGridView1.Columns[0].HeaderText = "Валюта";
            dataGridView1.Columns[1].HeaderText = "Покупка";
            dataGridView1.Columns[2].HeaderText = "Продажа";
            dataGridView1.Columns[3].HeaderText = "единиц";
            

            AddListBox(comboBoxOf);
            AddListBox(comboBoxIn);
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
           
            textBoxResalt.Text = calculation.ConvertCurrency(conection.Sum, conection.OfName, conection.InName).ToString();
        }

        private void comboBoxOf_SelectedIndexChanged(object sender, EventArgs e)
        {
            AbstractCondetToDecimal abstractCondet = new CondetToDecimalSell();
            conection.OfName= abstractCondet.intitialName(comboBoxOf.Text);
                      
        }

        private void comboBoxIn_SelectedIndexChanged(object sender, EventArgs e)
        {

            AbstractCondetToDecimal abstractCondet = new ConvertToDecimalBuy();
            conection.InName =  abstractCondet.intitialName(comboBoxIn.Text);
           
        }

        private void AddListBox(ComboBox comboBox)
        {
            var nameCurrency = connectParseHTML.Connect().GroupBy(item => item.Name).ToList();

            foreach (var item in nameCurrency)
            {
                comboBox.Items.Add(item.Key);
            }
        }
    }
}
