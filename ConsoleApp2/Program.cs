// See https://aka.ms/new-console-template for more information

using System;
/*
Console.WriteLine("Enter number");
int n = Convert.ToInt32(Console.ReadLine());
if (n >= 1000 && n <= 9999)
{
    Console.WriteLine("number is 3 digit");
   int frsitdigit = n / 1000;
    int lastdigit = n%10;
    int seconddigit = n / 1000;
    int thirddigit =n%10;
    int sum = frsitdigit + lastdigit;
    int mul = seconddigit * thirddigit;
    Console.WriteLine("sum is =" + sum);
    Console.WriteLine("mul is =" + mul);
}
else
{
    Console.WriteLine("number is not 3 digit");
}
{

/*
    int a, b;
    Console.WriteLine("Enter a is=");
    a = Convert.ToInt32(Console.ReadLine());
    Console.WriteLine("Enter b is=");
    b = Convert.ToInt32(Console.ReadLine());
    Console.WriteLine("1. add");
    Console.WriteLine("2. sub");
    Console.WriteLine("3. mul");
    Console.WriteLine("4. div");
    Console.WriteLine("5. mod");
    Console.WriteLine("Select any option form above");
    int option = Convert.ToInt32(Console.ReadLine());
    switch (option)
    {
        case 1:
            int add = a + b;
            Console.WriteLine("addition is=" + add);
            break;
        case 2:
            int sub = a - b;
            Console.WriteLine("substration is=" + sub);
            break;
        case 3:
            int mul = a * b;
            Console.WriteLine("multiply is=" + mul);
            break;
        case 4:
            int div = a / b;
            Console.WriteLine("division is=" + div);
            break;
        case 5:
            int mod = a % b;
            Console.WriteLine("mod is=" + mod);
            break;
        default:
            Console.WriteLine("error");
            break;
    }*/
internal class Program
{
    private static void Main(string[] args)
    {
        {/*
    Console.WriteLine("enter number form 1-5");
    int n =Convert.ToInt32(Console.ReadLine());
    if(n==1)
    {
        Console.WriteLine("one");
    }
    else if(n==2)
    {
        Console.WriteLine("two");
    }
    else if(n==3)
    {
        Console.WriteLine("three");
    }
    else if(n==4)
    {
        Console.WriteLine("four");
    }
    else if(n==5) 
    {
        Console.WriteLine("Five");
    }
    else
    {
        Console.WriteLine("you enter wrong number");
    }*/

        }
        {  /*     //                             Divisible number by 5 and  11
    Console.WriteLine("enter number");
    int n = Convert.ToInt32(Console.ReadLine());
    if(n%5==0 && n%11==0)
    {
        Console.WriteLine("the number is divisible by 5 and 11");
    }
    else
    {
        Console.WriteLine("the number is not divisible by 5 and 11");
    }*/
        }
        {/*
    char ch;
    Console.WriteLine("Enter alphabet");
    ch=Convert.ToChar(Console.Read());
    if(ch== 'a'|| ch=='e' || ch=='i'|| ch=='o'|| ch=='u')
        {
        Console.WriteLine("it is vowel");
    }
    else
    {
        Console.WriteLine("it is consonant");
    }*/


            Console.WriteLine("enter number,digit,special charcter");
            char ch = Convert.ToChar(Console.Read());
            if (ch == '@' || ch == '$' || ch == '#')
            {
                Console.WriteLine("it is special charcter");
            }
            else if (ch >= '0' && ch <= '9')
            {
                Console.WriteLine("it is digit");
            }
            else if (ch >= 'a' && ch <= 'z' || ch >= 'A' && ch <= 'Z')
            {
                Console.WriteLine("alphabet");
            }
        }
    }
}


internal class Example
{    //      sum of Digit
    static void Main(string[] args)
    {
        {
            int num, r, sum = 0;
            Console.WriteLine("Enter number1");
            num = Convert.ToInt32(Console.ReadLine());
           while(num>0) // 123,12,1
            {
                r = num % 10; //3,2,1
                sum = sum  + r;  // 3 // 3+2=5// 5+1=6
                num = num / 10; // 123 // 12
            }

            Console.WriteLine($"sum of Digit is ={sum}");

        }


    }
    
     
    
}
internal class Problem
{                             // star pattern
    static void Main(string[] args)
    {
        int i, j,c;
        for (i=1; i<=5;i++)
        {
            for (j = 1; j <= i; j++)
            {
                
              Console.Write($"*");
                
            }
            Console.WriteLine();

        }
    }
}
internal class Problem1
{
    static void Main(string[] args)
    {

        int i, j;
        for (i = 1; i <=5; i++)
        {
            for (j = 1; j <= i; j++)
            {

                Console.Write($"{j}");

            }
            Console.WriteLine();

        }
    }
}

internal class Problem2
{
    static void Main(string[] args)
    {
        int i, j;
        for (i = 5; i >=1; i--)
        {
            for (j = 1; j <= i; j++)
            {

                Console.Write($"{j}");

            }
            Console.WriteLine();
        }



    } 
    
}
internal class Problem3
{
    static void Main(string[] args)
    {
        int i, j;
        for (i = 1; i <= 5; i++)
        {
            for (j = 5; j >= i; j--)
            {

                Console.Write($"{j}");

            }
            Console.WriteLine();
        }
    }
}

internal class Problem4
{
    static void Main(string[] args)
    {
        int i, j,c;
        for (i = 1; i <= 4; i++)
        {
            for (j = 1; j <=4-i; j++)
            {
                Console.Write(" ");
            }
            for (c = 1; c <=i; c++)
            { 

                Console.Write("*");
             
            }
            Console.WriteLine();
        }
    }
}