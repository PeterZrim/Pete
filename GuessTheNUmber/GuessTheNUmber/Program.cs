namespace GuessTheNUmber
{
    class Program
    {
        static void Main(string[] args)
        {                                         // Title
            Console.WriteLine("                   Guess The number game");
            Console.ForegroundColor = ConsoleColor.Blue;
            Console.WriteLine("----------------------------------------------------------------");
            Console.ResetColor();

                                                  // How to play
            Console.WriteLine(" How to play the game,...\n");
            Console.WriteLine(" In this game you have to figure out the number from 1 to 100.\n " +
                               "You have only 5 attempts, after each attempt you get a hint \n " +
                               "whether your attempt was too high or too low.");
            Console.ForegroundColor = ConsoleColor.Blue;
            Console.WriteLine("----------------------------------------------------------------\n");
            Console.ResetColor();


                                                             // Generate random number from 1 to 100
            Random random = new Random();
            int randomNumber = random.Next(1, 101); 

                                                             // Game logic
          
            int MaxAttempts = 5;                             // Declare variable for maximum attempts, which is 5
                                  
            for (int i = 1; i <= MaxAttempts; i++)           //  Declare variable i = 1, as long is i less or equal MaxAttempts which is 5, i++ is plus one,...
            {
                Console.ForegroundColor = ConsoleColor.Green;
                Console.WriteLine($" Attempt {i}:  "); 
                Console.ResetColor();
                Console.Write("Please enter a number  ");
                Console.ForegroundColor = ConsoleColor.Red;
                int guess = Convert.ToInt32(Console.ReadLine());
                Console.ResetColor();

                                                              // Check if the guess is within range
                if (guess < 1 || guess > 100)
                {
                    Console.WriteLine(" The number is out of range, please enter a number between 1 and 100\n");
                }
                else if (guess > randomNumber)
                {
                    Console.WriteLine(" Your guess is too high idiot.\n");
                }
                else if (guess < randomNumber)
                {
                    Console.WriteLine(" Your guess is too low aSshole.\n");
                }
                else
                {
                    Console.WriteLine("----------------------------------------------------------------");
                    Console.ForegroundColor = ConsoleColor.Green;
                    Console.WriteLine(" Congratulations, you MoFo,... you guessed the number!");
                    Console.ResetColor();
                    Console.WriteLine("----------------------------------------------------------------");
                    Console.WriteLine("----------------------------------------------------------------");
                    break;                                      // Exit the loop if the guess is correct
                }

                                                                // If it's the last attempt and the user hasn't guessed it
                if (i == MaxAttempts)
                {
                    Console.WriteLine("----------------------------------------------------------------");
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine($"Dumbass, you've used all {MaxAttempts} attempts. The correct number was {randomNumber}.");
                    Console.ResetColor();
                    Console.WriteLine("----------------------------------------------------------------");
                }
            }


            Console.ReadKey();  
        }
    }
}