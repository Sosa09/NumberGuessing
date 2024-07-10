namespace NumberGuessing
{
    internal class Program
    {
        static void Main(string[] args)
        {
            
            //Instantiating the Random class object
            Random random = new Random();
            int TOTAL_CHANCES = 10;
            int MAX_GUESSING_NUMBER = 100;
            int MIN_GUESSING_NUMBER = 1;
            bool isDifferenceFive = false;

            //Introduction Text
            Console.WriteLine("Hello, World!, Let's play a game.\n" +
                              "The computer will generate a random nr from 1-100. \n" +
                              "Keep in mind you have 10 chances after that you'll lose 😈\n\n\n");

            while(true)
            {
                //decalre the game values
                int randomNr = random.Next(MIN_GUESSING_NUMBER, MAX_GUESSING_NUMBER);
                int chancesLeft= TOTAL_CHANCES;
                int DIFFERENCE_VALUE = 5;
                bool nrIsGuessed = false;

                while (chancesLeft > 0 && nrIsGuessed == false) 
                {

                     
                    Console.WriteLine($"Chances left: {chancesLeft}");//Display chances left to the end user
                    Console.WriteLine("Choose a nr from 1 - 100: "); //Ask user to choose  nr from 1 to 100
                    
                    int.TryParse(Console.ReadLine(), out int userInput); //Reading user inpyt and parsing into int at the same time as well as avoiding system to crash if userinput is not nr or empty

                    

                    
                    if (randomNr < userInput)
                    {
                        Console.WriteLine("Too High try again");
                        isDifferenceFive = userInput - randomNr <= DIFFERENCE_VALUE;
                    }                  
                    else if (randomNr > userInput) 
                    {
                        Console.WriteLine("Too low try again");
                        isDifferenceFive = randomNr - userInput <= DIFFERENCE_VALUE;

                    }
                    else if (randomNr == userInput)
                        nrIsGuessed=true;

                    if (isDifferenceFive) 
                        Console.WriteLine("You're close !");

                    

                    chancesLeft--; //decrement chancesLeft

                }

                if (nrIsGuessed)
                    Console.WriteLine("Great you found it let's play again.");
                else
                    Console.WriteLine("\"You lost loser :)!");

                Console.WriteLine("Press any key to continue...");
                Console.ReadKey();
                Console.Clear();

            }
        }
    }
}