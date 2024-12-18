// See https://aka.ms/new-console-template for more information
#region Function
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.Design;
using System.Transactions;

string Name (string name) { return name; }
double Box(double height, double width, double length) {
    double vol = height * width * length;
    return vol ; }
 
double EvenOdd(double num1)
{
    if (num1 %2==0 ) { return num1 * 2; } else { return num1 * num1; } }

double Temp(double celsius) { return celsius * 9 / 5 + 32; }

string Charchters (char vowels) { if (vowels == 'a' || vowels == 'o' || vowels == 'e' || vowels == 'i' || vowels == 'u') { return "vowel"; }
    else { return "constant"; } }

double Currency(double usd) { return usd * 3.25; }

    #endregion

    #region Call Function
    Console.WriteLine("Enter Name");
    string name = Console.ReadLine();
    Console.WriteLine("Welcome " + Name(name));

  
Console.WriteLine("Enter Box Length");
    double length = Convert.ToDouble(Console.ReadLine());
    Console.WriteLine("Enter Box Height");
    double height = Convert.ToDouble(Console.ReadLine());
    Console.WriteLine("Enter Box Width");
    double width = Convert.ToDouble(Console.ReadLine());

Console.WriteLine("The Volume is: " + Box(height,width,length));


Console.WriteLine("---------------------");
Console.WriteLine("Enter any number");
double num1 = Convert.ToDouble(Console.ReadLine());
Console.WriteLine(EvenOdd(num1));


Console.WriteLine("-------------");
Console.WriteLine("Enter temprature in celsius to convert to F");
double celsius = Convert.ToDouble(Console.ReadLine());
Console.WriteLine(Temp(celsius));

Console.WriteLine("------------------");
Console.WriteLine("Enter Charecter to find out if it is a vowel or a constant");
char vowels=Convert.ToChar(Console.ReadLine());
Console.WriteLine(Charchters(vowels));

Console.WriteLine("-------------------");
Console.WriteLine("Enter USD amount to get in KWD");
double usd = Convert.ToDouble(Console.ReadLine());
Console.WriteLine(Currency(usd));




#endregion