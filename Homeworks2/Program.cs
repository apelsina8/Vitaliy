Console.WriteLine("Input namber 1");  
int num1 = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Input namber 2");  
int num2 = Convert.ToInt32(Console.ReadLine());

int a = num1;
int b = num2;

int max = a;
int min = b;
    
if ( a > max) max = a;
{  
     Console.WriteLine($"{num1} > {num2}");  
} 