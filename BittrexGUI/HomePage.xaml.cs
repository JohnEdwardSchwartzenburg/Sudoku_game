using BittrexSharp.Domain;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices.WindowsRuntime;
using Windows.Foundation;
using Windows.Foundation.Collections;
using Windows.UI.Xaml;
using Windows.UI.Xaml.Controls;
using Windows.UI.Xaml.Controls.Primitives;
using Windows.UI.Xaml.Data;
using Windows.UI.Xaml.Input;
using Windows.UI.Xaml.Media;
using Windows.UI.Xaml.Navigation;

// The Blank Page item template is documented at https://go.microsoft.com/fwlink/?LinkId=234238

namespace BittrexGUI
{
    /// <summary>
    /// An empty page that can be used on its own or navigated to within a Frame.
    /// </summary>
    public sealed partial class HomePage : Page
    {

        
        public HomePage(BittrexSharp.Bittrex bittrex)
        {
            this.InitializeComponent();
            syncHoldings(bittrex);

        }

        private async void syncHoldings(BittrexSharp.Bittrex bittrex)
        {
            var task = bittrex.GetBalances();
            var balances = await task;
            var holdings = balances.Result;

            //list of currencyBalance objects to print to GUI
            List<CurrencyBalance> coins = new List<CurrencyBalance>();


            foreach (var coin in holdings)
            {
                if (coin.Balance > 0)
                {
                    coins.Add(coin);
                }
            }

            HoldingBox2.Text = "Current Holdings: ";

            foreach(var coin in coins)
            {
                HoldingBox2.Text += "Coin: " + coin.Currency + " | Balance: " + coin.Balance.ToString() + "\n";
            }

        }
    }
}
