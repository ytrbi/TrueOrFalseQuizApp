using System;

class Program
{
    static void Main()
    {
        string[] questions = new string[]
        {
            "Eggplant is a vegetable. True or False?",
            "Eggplants are a species in the nightshade family. True or False?"
        };

        bool[] answers = new bool[]
        {
            true,
            true
        };

        bool[] responses = new bool[questions.Length];

        if (questions.Length != answers.Length)
        {
            Console.WriteLine("Warning: Questions and Answers array lengths are not equal!");
            return;
        }

        int askingIndex = 0;
        foreach (string question in questions)
        {
            string input;
            bool isBool;
            bool inputBool;

            Console.WriteLine(question);
            Console.WriteLine("True or False?");
            input = Console.ReadLine();

            isBool = bool.TryParse(input, out inputBool);

            while (!isBool)
            {
                Console.WriteLine("Please respond with 'true' or 'false'.");
                input = Console.ReadLine();
                isBool = bool.TryParse(input, out inputBool);
            }

            responses[askingIndex] = inputBool;
            askingIndex++;
        }

        int scoringIndex = 0;
        int score = 0;
        foreach (bool answer in answers)
        {
            bool response = responses[scoringIndex];

            Console.WriteLine($"{scoringIndex + 1}. Input: {response} | Answer: {answer}");

            if (response == answer)
            {
                score++;
            }

            scoringIndex++;
        }

        Console.WriteLine($"You got {score} out of {questions.Length} correct!");
    }
}
