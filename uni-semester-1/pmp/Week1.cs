namespace uni_semester_1.pmp;

public class Week1
{
    public static void Main(string[] args)
    {
        
    }

    public static void Task_1()
    {
        Console.WriteLine("Hello World!");
        string line = Console.ReadLine();
        if (line == "enter")
        {
            System.Environment.Exit(0);
        }
    }

    public static void Task_2()
    {
        Console.Clear();
        Console.BackgroundColor = ConsoleColor.White;
        Console.ForegroundColor = ConsoleColor.Black;
        Console.CursorVisible = false;
        Console.WriteLine("Hello World!");
        string line = Console.ReadLine();
        if (line == "enter")
        {
            System.Environment.Exit(0);
        }
    }

    public static void Task_3()
    {
        Console.WriteLine("Please tell me your name!");
        string name = Console.ReadLine();
        Console.WriteLine("Hello " + name + "!");
    }

    public static void Task_4()
    {
        Console.WriteLine("Please tell me your birth year!");
        int currentYear = DateTime.Today.Year; //or just 2024
        string answer = Console.ReadLine();
        int birthYear = int.Parse(answer);
        int currentAge = currentYear - birthYear;
        Console.WriteLine("Your current age is: " + currentAge);
        Console.WriteLine("Next year you will be: " + (currentAge + 1));
    }

    public static void Task_5()
    {
        Console.WriteLine("Please tell me your height! (in meter)");
        string answer = Console.ReadLine();
        double height = double.Parse(answer);

        Console.WriteLine("Please tell me your weight! (in kg)");
        string answer2 = Console.ReadLine();
        double weight = double.Parse(answer2);

        double bmi = weight / (height * height);
        Console.WriteLine("Your current BMI is: " + bmi);
    }

    public static void Task_6()
    {
        Console.WriteLine("Adj meg egy időintervallumot másodpercben!");
        string answer = Console.ReadLine();
        int timeInSeconds = int.Parse(answer);
        int remainderMinutes = timeInSeconds % 60;
        int hours = timeInSeconds / 60;

        string minutes;
        if (remainderMinutes < 10)
        {
            minutes = "0" + remainderMinutes;
        }
        else
        {
            minutes = remainderMinutes.ToString();
        }

        Console.WriteLine("Az időtartam másodpercben: " + timeInSeconds);
        Console.WriteLine("Az időtartam formázva: " + hours + ":" + minutes);
    }

    public static void Task_7()
    {
        Console.WriteLine("Give me a password!");
        string firstPassword = Console.ReadLine();

        Console.WriteLine("Confirm the password!");
        string secondPassword = Console.ReadLine();

        if (firstPassword == secondPassword)
        {
            Console.BackgroundColor = ConsoleColor.Green;
            Console.ForegroundColor = ConsoleColor.Black;
            Console.WriteLine("Passwords are equal!");
        }
        else
        {
            Console.BackgroundColor = ConsoleColor.Red;
            Console.ForegroundColor = ConsoleColor.Black;
            Console.WriteLine("Passwords are not equal!");
        }
    }

    public static void Task_9()
    {
        Console.WriteLine("Add meg az első számot:");
        string firstAnswer = Console.ReadLine();
        double firstNumber = double.Parse(firstAnswer);

        Console.WriteLine("Add meg a második számot:");
        string secondAnswer = Console.ReadLine();
        double secondNumber = double.Parse(secondAnswer);

        Console.WriteLine("Add meg a műveletet:");
        string operation = Console.ReadLine();

        double result = 0;
        if (operation == "+")
        {
            result = firstNumber + secondNumber;
        }
        else if (operation == "-")
        {
            result = firstNumber - secondNumber;
        }
        else if (operation == "*")
        {
            result = firstNumber * secondNumber;
        }
        else if (operation == "/")
        {
            result = firstNumber / secondNumber;
        }

        Console.WriteLine($"{firstAnswer} {operation} {secondAnswer} = {result}");
    }

    public static void Task_11()
    {
        Console.WriteLine("Adj meg egy számot:");
        string firstAnswer = Console.ReadLine();
        int number = int.Parse(firstAnswer);

        if (number == 1)
        {
            Console.WriteLine("egy");
        }
        else if (number == 2)
        {
            Console.WriteLine("kettő");
        }
        else if (number == 3)
        {
            Console.WriteLine("három");
        }
        else if (number == 4)
        {
            Console.WriteLine("négy");
        }
        else if (number == 5)
        {
            Console.WriteLine("öt");
        }
        else if (number == 6)
        {
            Console.WriteLine("hat");
        }
        else if (number == 7)
        {
            Console.WriteLine("hét");
        }
        else if (number == 8)
        {
            Console.WriteLine("nyolc");
        }
        else if (number == 9)
        {
            Console.WriteLine("kilenc");
        }
        else
        {
            Console.WriteLine("Tájékoztatás hibaüzenettel.");
        }
    }

    public static void Task_12()
    {
        string[] magánhangzok = { "a", "á", "e", "é", "i", "í", "o", "ó", "ö", "ő", "u", "ú", "ü", "ű" };
        string[] mássalhangzók =
        {
            "b", "c", "cs", "d", "dz", "dzs", "f", "g", "gy", "h", "j", "k", "l", "m", "n", "ny", "p", "r", "s", "sz",
            "t", "ty", "v", "z", "zs"
        };

        Console.WriteLine("Adj meg egy betűt:");
        string betű = Console.ReadLine();

        if (magánhangzok.Contains(betű))
        {
            Console.WriteLine("Magánhangzó");
        }
        else if (mássalhangzók.Contains(betű))
        {
            Console.WriteLine("Mássalhangzó");
        }
    }
    
    public static void Task_13()
    {
        Console.WriteLine("Adja meg a tartály térfogatáramát (m3/h): ");
        double V = Convert.ToDouble(Console.ReadLine());
        
        Console.WriteLine("Adja meg az első cső térfogatáramát (m3/h): ");
        double R1 = Convert.ToDouble(Console.ReadLine());
        
        Console.WriteLine("Adja meg a második cső térfogatáramát (m3/h): ");
        double R2 = Convert.ToDouble(Console.ReadLine());
        
        Console.WriteLine("Adja meg az időtartamot (óra): ");
        double T = Convert.ToDouble(Console.ReadLine());
        
        double totalFilled = T * (R1 + R2);
        
        if (totalFilled < V)
        {
            double percentageFilled = (totalFilled / V) * 100;
            Console.WriteLine($"A tartály {percentageFilled}%-ban lesz tele.");
        }
        else
        {
            double overflow = totalFilled - V;
            Console.WriteLine($"A tartály {overflow} m3-rel lesz túltöltve.");
        }
    }
}