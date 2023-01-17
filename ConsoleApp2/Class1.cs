using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Intrinsics.Arm;
using System.Text;
using System.Threading.Tasks;
using System.Timers;

internal class class1 // print 1-10 number using for loop
{
    static void Main(string[] args)
    {
        
        int i;
        for (i = 1; i <= 10; i++)
        {
            Console.WriteLine($" {i} ");

        }
     
    }
}
internal class Even
{                                 // print Even number using for loop
    static void Main(string[] args)
    {
        int j;
        for (j = 1; j <= 50; j++)
        {
            if (j % 2 == 0)
            {
                Console.Write("Even number is");
                Console.WriteLine($" {j} ");

            }
        }
    }
}






internal class class10
{                                 //reverse print number using for loop
    static void Main(string[] args)
    {
        int y;
        for (y = 100; y >= 50; y--)
        {
            Console.WriteLine($"{y}");

        }
    }
}

internal class odd
{                            // odd numbber  print using for loop 
    static void Main(string[] args)
    {
        int k;
        for (k = 1; k <= 50; k++)
        {
            if (k % 2 != 0)
            {
                Console.Write("odd number is ");
                Console.WriteLine($"{k}");

            }
        }

    }
}
internal class table   // Even number using while
{
    static void Main(string[] args)
    {
        int i = 1;
        while(i<=50 ) 
        {
          if( i % 2 == 0)
           Console.WriteLine($"{i}");
            i++;
            
        }
    }
}

internal class table1  // odd number using while
{
    static void Main(string[] args)
    {
        int i = 1;
        while (i <= 50)
        {
            if (i % 2 != 0)
                Console.WriteLine($"{i}");
            i++;
        }
    }
}

internal class table2  //Reverse number print using while
{
    static void Main(string[] args)
    {
        int j=100;
        while(j>=50)
        {
            Console.WriteLine($" {j}");
            j--;
        }
    }
}

internal class table3
{                                 // print any number of table using for loop
    static void Main(string[] args)
    {
        int i, num;
        Console.WriteLine("Enter number");
        num=Convert.ToInt32(Console.ReadLine());
        for(i=1;i<=10;i++)
        {
            Console.WriteLine($"{num}*{i} = {num*i}");
        }
    }
}

internal class table5
{                         // print table using while loop
    static void Main(string[] args)
    {
        int i, num;
        Console.WriteLine("Enter number");
        num=Convert.ToInt32(Console.ReadLine());
        i=1;
         while(i<=10)
        {
            Console.WriteLine($"{num}*{i} = {num * i}");
            i++;
        }
    }
}
internal class Digit
{
    static void Main(string[] args)
    {             //                         sum of digit
        int n,sum=0,m;
        Console.WriteLine("Enter number+");
        n=Convert.ToInt32(Console.ReadLine());
        //1234
        while (n > 0)
        {
            m = n % 10;
            sum = sum + m;
            n = n / 10;
        }


        Console.WriteLine($"  sum of digit  = {sum}");
    }
}

internal class Digit1
{             
    static void Main(string[] args)
    {                                        // sum of 1st and last digit or multiply 2nd and 3rd digit
        int n;
        Console.WriteLine("Enter number+");
        n = Convert.ToInt32(Console.ReadLine());
        //1234

        int frist = n % 10;  // 4
        int second = n / 10; // 123
        int third = second % 10; // 3
        int fourth = second / 10; // 12
        int fifth = fourth % 10; // 2
        int sixth = fourth / 10; //1

        int multiplication = third * fifth;
        Console.WriteLine($" multiplication of 2nd and 3rd digit of  {n} is =  {multiplication}");

        int sum = sixth + frist;
        Console.WriteLine($" sum of  frist and last digit of {n} is = {sum}");
    }
}

internal class table8
{                        // print 1
    static void Main(string[] args)
    {
        int i,sum=0;
        
        for (i = 1; i <= 10; i++)
        {
            Console.WriteLine($" {i}");
            sum = sum + i;
        }   
        Console.WriteLine($" the sum of number is = {sum}");
       


    }
}


internal class Reverse
{                          //   Reverse number print
    static void Main(string[] args)
    {
        int n, reverse = 0, r;
        Console.WriteLine("Enter number");
        n = Convert.ToInt32(Console.ReadLine());
        //1234
        while (n != 0) // 123, 12,1
        {
            r = n % 10; // 4, 3, 2,1
            reverse = reverse *10 + r; //4,3,2
            n = n/10; // 1234  , 123 , 12 
        }
        Console.WriteLine($" the reverse number {reverse}");
    }
}

internal class New
{                                      // print 1-10 number using do-while
    static void Main(string[] args)
    {
        int i = 1;
        do
        {
            Console.WriteLine($"{i}");
            i++;
        }while(i<=10);
    }
}

internal class Number6
{                           //  print Even number using Do_while loop
    static void Main(string[] args)
    {
        int i = 1;
        do
        {
            if (i % 2 == 0)
            
                Console.WriteLine($"{i}");
                i++;
            
        } while (i <= 50);
    }
}

internal class Number7
{                          // print odd number using DO_While loop
    static void Main(string[] args)
    {
        int i = 1;
        do
        {
            if (i % 2 != 0)

                Console.WriteLine(i);
            i++;
        }while(i <= 50);    
    }
}

internal class Number8
{                            //  print reverse number usnig Do_While loop
    static void Main(string[] args)
    {
        int i = 100;
        do
        {
            Console.WriteLine(i);
            i--;
        } while (i >= 50);
    }
}

internal class Number9
{
    static void Main(string[] args)
    {
        int i = 1, n;
        Console.WriteLine("Enter number");
        n= Convert.ToInt32 (Console.ReadLine());
        do
        {
            Console.WriteLine("{0}*{1}={2}", n, i, n * i);
            i++;
        } while (i <= 10);
    }
}

internal class Number10
{
    static void Main(string[] args)
    {
        int i = 1, sum = 0;
        do
        {
            Console.WriteLine(i);
            sum = sum + i;
            i++;
           
        } while (i <= 10);

       
        Console.WriteLine($"sum of number is = {sum}");
    }
    
}

internal class reverse
{                                 
    static void Main(string[] args)
    {
        int reverse=0,n,remaindar; 
        Console.WriteLine("Enter number is");
        n=Convert.ToInt32 (Console.ReadLine()); //123
        while(n!=0)
        {  //123
            remaindar = n % 10; // 3 2 1
           reverse= reverse *10 + remaindar; // 0+3=3 // 30+2= 32//320+1=321
            n = n / 10; // 123  //12

        }
        Console.WriteLine($"the reverse number is = {reverse}");
    }
   

    
}

internal class Armstrong
{                                 // check weather number is Armstorng number or not
    static void Main(string[] args)
    {
        int n,r,sum=0,temp;
        Console.WriteLine("Enter number");
        n= Convert.ToInt32(Console.ReadLine());
        
        temp = n;
        while (n!=0) //153
        {
           
            r=n%10; // 3 5 1
            sum=sum+(r*r*r); // sum=27 // sum= 27+125=152 // 153+1=153
            n=n/10; //153  // 15 
          
        }
        Console.WriteLine($"sum is = {sum}");
        
        if(temp==sum)
        {
            Console.WriteLine("Number is Armstrong number");
        }
        else
        {
            Console.WriteLine("Number is Not  Armstrong number");
        }
    }
}

internal class Primenumber
{              //             check number is prime number or not
    static void Main(string[] args)
    {
        int num,count=0;
        Console.WriteLine("Enter number");
        num=Convert.ToInt32(Console.ReadLine());

        for(int i=2; i<=num/2; i++) 
        { 
            if(num%i==0) 
            {
                count = 1;
                    break;
               
            }
            
        }

        if (count == 0)
        {
            Console.WriteLine(" it is Prime number");
        }
        else
        {
            Console.WriteLine(" it is not  Prime number");
        }
    }
}

