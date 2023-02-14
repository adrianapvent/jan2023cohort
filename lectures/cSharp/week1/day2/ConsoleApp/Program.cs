// See https://aka.ms/new-console-template for more information
Console.WriteLine("Hello, World!");
// guess the number game
// Random number - global - the function to create one and the answer
// user input - in loop - because this is what gets repeated
// check answer vs guess - conditionals -  in loop
// var or something to hold guess and answer - stored out pulled in
// loop to allow for more guesses - while loop
// an exit

// bool playing = True;
// while (playing){}

Random rand = new Random();
int answer = rand.Next(1,6);
int guess = 0;
int round = 3;
Console.WriteLine("Welcome to our Guessing Game!");
while(round > 0) {
    Console.WriteLine("Please guess a number between 1-5");
    Console.WriteLine($"Current round number is {round}");
    // Console.WriteLine($"Answer is {answer}");
    bool check = false;
    while(!check) {
        string temp = Console.ReadLine();
        check = int.TryParse(temp, out guess);
        if(!check) {
            Console.WriteLine("Please use a number, you just lost a round");
            round--;
            if (round == 0) {
                Console.WriteLine($"That was your last turn Game Over!");
                check = true;
                round = 0;
            }
        }
        else {
            if (guess > 5 || guess < 1) {
                Console.WriteLine($"Please chose another number between 1 and 5 you have lost 1 turn");
                guess = Convert.ToInt32(Console.ReadLine());
                round--;
            }
                Console.WriteLine($"Your guess is {guess}");
            if (answer == guess) {
                Console.WriteLine($"Your guess of {guess} was correct");
                round = 0;
            }
            else if (guess > answer) {
                Console.WriteLine($"Your guess of {guess} was too high");
                round--;
                if (round == 0) {
                    Console.WriteLine($"That was your last turn Game Over!");
                }
            }
            else {
                Console.WriteLine($"Your guess of {guess} was too low");
                round--;
                if (round == 0) {
                    Console.WriteLine($"That was your last turn Game Over!");
                }
            }
        }
    }

}