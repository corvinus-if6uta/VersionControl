using gyak6.MnbServiceReference;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace gyak6
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        public void GetExchangeRates()
        {
            return;
        }

        public void asd()
        {
            var mnbService = new MNBArfolyamServiceSoapClient();

            var request = new GetExchangeRatesRequestBody()
            {
                currencyNames = "EUR",
                startDate = "2020-01-01",
                endDate = "2020-06-30"
            };

            var response = MnbService.GetExchangeRates(request);

            var result = response.GetExchangeRatesResult;
        }

        public object MnbService { get => mnbService; set => mnbService = value; 
        
    }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}
