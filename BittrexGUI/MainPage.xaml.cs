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
using BittrexSharp;
using BittrexSharp.Domain;
using BittrexSharp.Exceptions;
using BittrexSharp.BittrexOrderSimulation;



// The Blank Page item template is documented at https://go.microsoft.com/fwlink/?LinkId=402352&clcid=0x409

namespace BittrexGUI
{
    /// <summary>
    /// An empty page that can be used on its own or navigated to within a Frame.
    /// </summary>
    public sealed partial class MainPage : Page
    {
        Bittrex bittrex = new Bittrex("3ef55d86bd234c2cb380edc363fcce62", "b84ebfcf715e470ba3fe5f44f2fde77d");

        public MainPage()
        {
            this.InitializeComponent();
        }

        private async void Button_Click(object sender, RoutedEventArgs e)
        {
            var task = bittrex.GetBalances();
            var balances = await task;
            var holdings = balances.Result;
            List<CurrencyBalance> coins = new List<CurrencyBalance>();
            foreach (var coin in holdings)
            {
                if (coin.Balance > 0)
                {
                    coins.Add(coin);
                    HoldingsBox.Text += "Coin: " + coin.Currency + " | Balance: " + coin.Balance.ToString() + "\n";
                }
            }
            HoldingsBox.Text += "Calculating... Calculations done.\n";
            HoldingsBox.Text += "Smolst penor in universe: Daniel Chester's penor ;}}}";

        }
    }
}
