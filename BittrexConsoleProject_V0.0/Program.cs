using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BittrexSharp;
using BittrexSharp.Domain;
using BittrexSharp.Exceptions;
using BittrexSharp.BittrexOrderSimulation;

namespace BittrexConsoleProject_V0._0
{

    public class Program
    {
        //Tests.IntegrationTests.BittrexTests test = new BittrexTests();
        static void Main()
        {
            #region ideas/comments  
            //IDEAS
            //**********************************************************************************************************************************
            /*List of quick view options available from Main function. Main takes user input and has async method which redirects to 
            * appropriate class with functions for outputting desired info. (Could this be done with a while true statement in main func?)*/
            //**********************************************************************************************************************************


            //COMMENTED OUT CODE
            //**********************************************************************************************************************************
            //Bittrex bittrex = new Bittrex();

            //bool quit = false;
            //while (!quit)
            //{

            //}
            //**********************************************************************************************************************************
            #endregion
            while (true)
            {
                Console.WriteLine("=======================");
                Console.WriteLine("| Bittrex Client v0.0 |");
                Console.WriteLine("=======================");
                Console.WriteLine("Select action...");
                Console.WriteLine("[1] View Ticker...");
                Console.WriteLine("[2] Get market summary...\n");



                MainAsync().GetAwaiter().GetResult();

            }
            Console.ReadLine();           
        }

        #region static async  method of Task type (for tests)
        static async Task MainAsync()
        {
            Bittrex bittrex = new Bittrex();

            Console.WriteLine("Creating Bittrex object...");
            Console.WriteLine("Requesting LTC Ticker...");

            var ticker = await bittrex.GetTicker("BTC-OMG");

            Console.WriteLine("Finished async method...");
            Console.WriteLine("Bid: " + ticker.Result.Bid.ToString());
            Console.WriteLine("Ask: " + ticker.Result.Ask.ToString());
            Console.WriteLine("Last: " + ticker.Result.Last.ToString());
        }
        #endregion
    }
}
