using ExchangeCurrency.Bank;
using System;
using System.Windows.Forms;

namespace ExchangeCurrency
{
    class Conection
    {
        LodingCurrency lodingCurrency = new LodingCurrency();

        BindingSource source = new BindingSource();

        public decimal OfName { get; set; }

        public decimal InName { get; set; }

        public decimal Sum { get; set; }
        
        public void LodingStart(DataGridView dataGridView1,ComboBox comboBoxOf)
        {
            
            dataGridView1.DataSource = lodingCurrency.Currencies;

            dataGridView1.Columns[0].HeaderText = "Валюта";
            dataGridView1.Columns[1].HeaderText = "Покупка";
            dataGridView1.Columns[2].HeaderText = "Продажа";
            dataGridView1.Columns[3].HeaderText = "единиц";

            source.DataSource = lodingCurrency.Currencies;
            
            foreach (var item in lodingCurrency.Currencies)
            {
                comboBoxOf.Items.Add(item.Name);
            }
        }

        public void LodingIn(ComboBox comboBoxIn)
        {
            comboBoxIn.DataSource = source;
        }

        public void intitialOfName(string comboBoxOf)
        {
            foreach (var item in lodingCurrency.Currencies)
            {
                if(item.Name == comboBoxOf)
                {
                    OfName=  Convert.ToDecimal(item.Sell) ;

                    break;
                }
            }
           
        }

        public void intitialInName(string comboBoxIn)
        {
            foreach (var item in lodingCurrency.Currencies)
            {
                if (item.Name == comboBoxIn)
                {
                    InName = Convert.ToDecimal(item.Sell) / Convert.ToDecimal(item.Categori);

                    break;
                }
            }

        }

        public decimal ConvertCurrency()
        {
            try
            {
                return Math.Round((Sum * OfName / InName),4);
            }
            catch
            {
                MessageBox.Show("Попытка делить на ноль");
                return 0;
            }
           
        }
    }
}
