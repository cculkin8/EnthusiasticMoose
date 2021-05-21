using System;
Console.WriteLine("Welcome to the Enthusiastic Moose Simulator!");
Console.WriteLine("--------------------------------------------");

MooseSays("R E N D E R  Y O U R  S O U L  U N T O  M E  M O R T A L");

bool MooseAsks(string question)
{
    Console.Write($"{question} (Y/N): ");
    string answer = Console.ReadLine().ToLower();

    while (answer != "y" && answer != "n")
    {
        Console.Write($"{question} (Y/N): ");
        answer = Console.ReadLine().ToLower();
    }

    if (answer == "y")
    {
        return true;
    }
    else
    {
        return false;
    }
}

Question("Give soul?","T H E  G O D S  T H A N K  Y O U", "B E  C R U S H E D  U N D E R  M Y  M I G H T");
Question("T E L L  M E,  D O  Y O U  B L E E D?", "Oh, wasn't expecting that answer.", "You should try it!");
Question("Do you love C# yet?", "We have bribed Andy accordingly then.", "You will, by force or by coercion");
Question("Do you want to know a secret?", "I' M  B E H I N D  Y O U", "I' M  B E H I N D  Y O U");


void Question(string question, string trueanswer, string falseanswer)
{

    bool isTrue = MooseAsks(question);
    if (isTrue)
    {
        MooseSays(trueanswer);
    }
    else
    {
        MooseSays(falseanswer);
    }
}

void MooseSays(string messagage)
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
                       |   / \   |    {messagage}
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



