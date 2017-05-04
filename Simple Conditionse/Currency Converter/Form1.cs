using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Currency_Converter
{
    public partial class FormConverter : Form
    {
        public FormConverter()
        {
            InitializeComponent();
        }

        private void numericUpDownAmount_Value(object sender, EventArgs e)
        {
            Label result = (Label)this.Controls.Find("labelResult", true).FirstOrDefault();
            NumericUpDown numericUpDownAmount =(NumericUpDown).this.Controls.Find("numericUpDownAmount", true).FirstOrDefault();
            ComboBox comboBox= (comboBox).this.Controls.Find("comboBoxCurrency", true).FirstOrDefault();
            string currency = comboBox.SelectedItem.ToString;
            decimal resultValue = 0;
            if (currency== "EUR")
            {

            }
            if ( currency =="USD")
            {

            }
            if (currency=="GBP")
        }

        private void labelResult_Click(object sender, EventArgs e)
        {
        }

        private void ConvertCurrency()
        {
            
        }
    }
}          

    


