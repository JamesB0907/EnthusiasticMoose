﻿using System;

class Program
{
    static void Main()
    {
        MainFunction();
    }

    static void MainFunction()
    {
        Console.WriteLine(@"Welcome to the Enthusiastic Moose Simulator!
        --------------------------------------------");
        Console.WriteLine();

        MooseSays("H I, I'M  E N T H U S I A S T I C !");
        MooseSays("I really am enthusiastic");

        AskQuestion("Is Canada real?", "Really? It seems very unlikely.", "I KNEW IT !!!");
        AskQuestion("Are you enthusiastic?", "Yay!", "You should try it!");
        AskQuestion("Do you love C# yet?", "Good job sucking up to your instructor!", "You will...oh, yes, you will...");
        AskQuestion("Do you want to know a secret?", "ME TOO!!!! I love secrets...tell me one!", "Oh, no...secrets are the best, I love to share them!");
    }

    static void MooseSays(string message)
    {
        Console.WriteLine($@"
                                       _.--^^^--,
                                    .'          `\
  .-^^^^^^-.                      .'              |
 /          '.                   /            .-._/
|             `.                |             |
 \              \          .-._ |          _   \
  `^^'-.         \_.-.     \   `          ( \__/
        |             )     '=.       .,   \
       /             (         \     /  \  /
     /`               `\        |   /    `'
     '..-`\        _.-. `\ _.__/   .=.
          |  _    / \  '.-`    `-.'  /
          \_/ |  |   './ _     _  \.'
               '-'    | /       \ |
                      |  .-. .-.  |
                      \ / o| |o \ /
                       |   / \   |    {message}
                      / `^`   `^` \
                     /             \
                    | '._.'         \
                    |  /             |
                     \ |             |
                      ||    _    _   /
                      /|\  (_\  /_) /
                      \ \'._  ` '_.'
                       `^^` `^^^`
    ");
    }

    static void AskQuestion(string question, string yesResponse, string noResponse)
    {
        bool isTrue = MooseAsks(question);
        string response = isTrue ? yesResponse : noResponse;
        MooseSays(response);
    }

    static bool MooseAsks(string question)
    {
        Console.Write($"{question} (Y/N): ");
        string answer = Console.ReadLine().ToLower();

        while (answer != "y" && answer != "n")
        {
            Console.Write($"{question} (Y/N): ");
            answer = Console.ReadLine().ToLower();
        }

        return answer == "y";
    }
}
