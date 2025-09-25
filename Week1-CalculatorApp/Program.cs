// See https://aka.ms/new-console-template for more information
//first set of values
Console.WriteLine("Enter first value");
int val1 = Convert.ToInt32(Console.ReadLine());

//select operator
Console.WriteLine("Select operation (+, -, /, *)");
char op = Convert.ToChar(Console.ReadLine());
int answer = 0;

//second set of values
Console.WriteLine("Enter second value");
int val2 = Convert.ToInt32(Console.ReadLine());

switch (op)
{
    case '+': 
      answer = val1 + val2;
      break;
    case '-':
        answer = val1 - val2;
        break;
    case '*':
        answer = val1 * val2;
        break;
    case '/':
        answer = val1 / val2;
        break;
    default:
        answer = 0;
        break;

}

//print answer
Console.WriteLine("The answer is " + answer);