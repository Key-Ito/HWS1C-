Console.Write ("Введите число N: ");
string userInput1 = Console.ReadLine() ?? "";
int userNumber1 = int.Parse(userInput1);

int a = 1;

Console.Write (userNumber1 + " -> ");

while (a <= userNumber1)
{
    if (a % 2 == 0)
    {
    Console.Write (a);
    }
    a++;
    if ((a-1) % 2 == 0)
    {   
        if (a < userNumber1)
        {Console.Write (", ");}
    }
}


 
//Console.WriteLine(userNumber + " -> " + userNumber * userNumber);
