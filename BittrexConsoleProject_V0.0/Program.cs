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
                            Bittrex bittrex = new Bittrex();

            Console.WriteLine("=======================");
            Console.WriteLine("| Bittrex Client v0.0 |");
            Console.WriteLine("=======================");
            System.Threading.Thread.Sleep(500);

            Console.WriteLine("Select action...");
            System.Threading.Thread.Sleep(500);

            Console.WriteLine("[1] View Ticker...");
            System.Threading.Thread.Sleep(500);

            Console.WriteLine("[2] Get market summary...\n");
            System.Threading.Thread.Sleep(500);

            Console.WriteLine("press q to exit...");

            var input = Console.ReadLine();


            //switch case using original console input
            switch (input)
            {
                case "1":
                    //ticker call

                    //requests coin abbreviation from user
                    Console.WriteLine("Enter coin abbreviation for ticker...");
                    //stores input in string coin
                    string coin = Console.ReadLine();
                    //converts input for bittrex request (From "OMG" to "BTC-OMG")
                    coin = "BTC-" + coin;
                    //bool stop used for outter loop
                    //bool stop = false;

                    //outter loop
                    #region outter loop
                    //while (true)
                    //{

                        //middle loop begins, initializing ticker output
                        while (true)
                        {
                            //catches user input (q) in char innerExit
                            
                            
                            Console.Clear();
                            var ticker = bittrex.GetTicker(coin);
                            Console.WriteLine("Market: " + coin);
                            Console.WriteLine("=========================");
                            Console.WriteLine("Bid: " + ticker.Result.Result.Bid.ToString());
                            Console.WriteLine("Ask: " + ticker.Result.Result.Ask.ToString());
                            Console.WriteLine("Last: " + ticker.Result.Result.Last.ToString());
                            Console.WriteLine("Enter q to return to main page...\n");
                            Console.WriteLine("=========================");

                            var innerExit = Console.ReadLine();

                            //sleep 3 seconds between API calls
                            System.Threading.Thread.Sleep(3000);

                            if (innerExit.ToString() == "q")
                            {
                                Console.Clear();
                                Main();
                            }
                    }
                        ////changes outer bool to true if user input detected
                        //if (middleStop)
                        //{
                        //    stop = true;
                        //}
                    //}
                    #endregion
                    break;

                case "2":
                    Environment.Exit(0);
                    break;

                default:
                    Console.Write("Unknown Error!");
                    break;
            }
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
        }

        ////async task called from main method
        //static async Task MainAsync(int input)
        //{
        //    //creates bittrex method
        //    Bittrex bittrex = new Bittrex();

        //    //switch case using original console input
        //    switch (input)
        //    {
                
        //        case 1:
        //            //ticker call

        //            //requests coin abbreviation from user
        //            Console.WriteLine("Enter coin abbreviation for ticker...");
                    
        //            //stores input in string coin
        //            string coin = Console.ReadLine();
                    
        //            //converts input for bittrex request (From "OMG" to "BTC-OMG")
        //            coin = "BTC-" + coin;

        //            //bool stop used for outter loop
        //            bool stop = false;

        //            //outter loop
        //            #region outter loop
        //            while(!stop)
        //            {
        //                //static output before loops
        //                Console.WriteLine("Market: " + coin);
        //                Console.WriteLine("=========================");

        //                //sets midleStop to false. Used for middle loop.
        //                bool middleStop = false;
                        
        //                //middle loop begins, initializing ticker output
        //                while (!middleStop)
        //                {
        //                    var ticker = await bittrex.GetTicker(coin);
        //                    Console.WriteLine("Bid: " + ticker.Result.Bid.ToString());
        //                    Console.WriteLine("ask: " + ticker.Result.Ask.ToString());
        //                    Console.WriteLine("last: " + ticker.Result.Last.ToString());
        //                    Console.WriteLine("Press q to return to main page...\n");
                            
        //                    //sleep 3 seconds between API calls
        //                    System.Threading.Thread.Sleep(3000);

        //                    //catches user input (q) in char innerExit
        //                    char innerExit = (char)Console.Read();

        //                    //sets bool middleStop to true; exits middle loop.
        //                    if (innerExit.Equals("q"))
        //                    {
        //                        middleStop = true;
        //                    }
        //                }
        //                //changes outer bool to true if user input detected
        //                if (middleStop)
        //                {
        //                    stop = true;
        //                }
        //            }
        //            #endregion
        //            return null;
        //            break;
        //        case 2:
        //            Environment.Exit(0);
        //            break;
        //        default:
        //            Console.Write("Unknown Error!");
        //            break;
        //    }

        //    #region experimental code block (commented out)
        //    //Console.WriteLine("Finished async method...");
        //    //Console.WriteLine("Bid: " + ticker.Result.Bid.ToString());
        //    //Console.WriteLine("Ask: " + ticker.Result.Ask.ToString());
        //    //Console.WriteLine("Last: " + ticker.Result.Last.ToString());

        //    //var ticker = await bittrex.GetTicker(coin);
        //    //Console.WriteLine("Market: " + coin);
        //    //Console.WriteLine("=========================");
        //    #endregion
        //}
    }
}
