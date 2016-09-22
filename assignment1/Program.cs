using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
namespace assignment1
{
    class Program
    {
        static void Main(string[] args)
        {

            WineItem myWineItem = new WineItem();

            //3964 is the number of current items in the list
            //Create an array of type WineItem to hold a bunch of wineItems
            WineItem[] wineItems = new WineItem[3964];

            //call CSV Processor to Load File while allowing user to choose the file
            Console.WriteLine("What is the name of the CSV file that you would like to load?");
            String pathToCsvFile = Console.ReadLine();
            ImportCSV(pathToCsvFile, wineItems);

            //Instantiate a new UI Class to call methods after processing CSV File and reading contents.
            userInterface ui = new userInterface();

            IList<WineItem> collectionOfWine = new List<WineItem>(wineItems);






            //Get users input choice
            int choice = ui.GetUserInput();
            while (choice != 4)
            {
                //If the chioce they made is 1, Print the entire list of wine items
                if (choice == 1)
                {

                    //Create a string to concat the output
                    string allOutput = "";

                    //Loop through all the wine Items to concat them together.
                    foreach (WineItem wine in wineItems)
                    {
                        if (wine != null)
                        {
                            allOutput += wine.ToString() +
                                        Environment.NewLine;
                        }
                    }
                    //Once the concat is done, have the UI class print out the result
                    ui.PrintAllOutput(allOutput);
                }

                //If the choice they made is 2, search for item id provided by user and if found print it out
                if (choice == 2)
                {
                    collectionOfWine.Add(myWineItem);
                }
                //If the choice they made is 3, allow user to add a new wine item to the list
                if (choice == 3)
                {

                }

                //Get the next choice from the user.
                choice = ui.GetUserInput();
            }
        }
        static bool ImportCSV(string pathToCsvFile, WineItem[] wineItems)
        {
            // Declare a variable for the stream reader.Not going to instanciate it yet.
            StreamReader streamReader = null;

            //Start a try since the path to the file could be incorrect, and thus
            //throw an exception
            try
            {
                //Declare a string for each line we will read in.
                string line;

                //Instanciate the streamReader. If the path to file is incorrect it will
                //throw an exception that we can catch
                streamReader = new StreamReader(pathToCsvFile);

                //Setup a counter that we aren't using yet.
                int counter = 0;

                //While there is a line to read, read the line and put it in the line var.
                while ((line = streamReader.ReadLine()) != null)
                {
                    //Call the process line method and send over the read in line,
                    //the wineItems array (which is passed by reference automatically),
                    //and the counter, which will be used as the index for the array.
                    //We are also incrementing the counter after we send it in with the ++ operator.
                    processLine(line, wineItems, counter++);
                }

                //All the reads are successful, return true.
                return true;
            }
            catch (Exception e)
            {
                //Output the exception string, and the stack trace.
                //The stack trace is all of the method calls that lead to
                //where the exception occured.
                Console.WriteLine(e.ToString());
                Console.WriteLine();
                Console.WriteLine(e.StackTrace);

                //Return false, reading failed
                return false;
            }
            //Used to ensure the the code within it gets executed regardless of whether the
            //try succeeds or the catch gets executed.
            finally
            {
                //Check to make sure that the streamReader is actually instantiated before
                //trying to call a method on it. 
                if (streamReader != null)
                {
                    //Close the streamReader because its the right thing to do.
                    streamReader.Close();
                }

            }

        }
        static void processLine(string line, WineItem[] wineItems, int index)
        {
            //declare a string array and assign the split line to it.
            string[] parts = line.Split(',');

            //Assign the parts to local variables that mean something
            string id = parts[0];
            string description = parts[1];
            string pack = parts[2];

            //Use the variables to instanciate a new Employee and assign it to
            //the spot in the employees array indexed by the index that was passed in.
            wineItems[index] = new WineItem(id, description, pack);
        }
        static string LinearSearch(WineItem[] wineItem)
        {

            Console.WriteLine("What is the id number of the WineItem that you are looking for?");
            String idSearch = Console.ReadLine();
            Console.WriteLine("Attempting Search...");


            return idSearch;
        }

    }
}
