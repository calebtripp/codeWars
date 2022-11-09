
////////public static class Kata
////////{
////////    public static int SquareSum(int[] numbers)
////////    {

////////        Math.Pow(int[], 2);
////////    }
////////}


//////using System;
//////using System.Diagnostics.CodeAnalysis;

//////public static class Clock
//////{
//////    public static int Past(int h, int m, int s)
//////    {
//////        //#Happy Coding! ^_^
//////       // var seconds = 

//////        1hr
//////            60
//////            60




//////        int h * 60 * 60) / 1000
//////        int m * 60 / 1000
//////        int s / 1000

//////        (secondsSum / 1000)


//////    }
//////}


//////You ask a small girl,"How old are you?" She always says, "x years old", where x is a random number between 0 and 9.

//////Write a program that returns the girl's age (0-9) as an integer.

//////Assume the test input string is always a valid string. For example, the test input may be "1 year old" or "5 years old". 
//////The first character in the string is always a number.

//////Parse.Int;


//////doesnt work, not all code paths return a value
//////using System;

//////public class Kata
//////{
//////    public static int GetAge(string inputString)
//////    {
//////        foreach (var num in inputString)
//////        {
//////            return Convert.ToInt32(num);
//////        }
//////    }
//////}

//////doesnt work, cannot convert from int to char??


////// no worky worky....what am i missing here???
//////using System;

//////public class Kata
//////{
//////    public static int GetAge(string inputString)
//////    {
//////        foreach (int correctAge in inputString)
//////        {
//////            return ("{0}", Convert.ToInt32(correctAge));
//////        }
//////    }
//////}


////// doesnt work, doesnt provide a return

//////using System;

//////public class Kata
//////{
//////        public static int GetAge(string inputString)
//////    {
//////        try 
//////        {
//////            int m = Int32.Parse("abc");// return int.Parse(inputString);
//////        }
//////        catch (FormatException e)
//////        {
//////            Console.WriteLine("not correct format");
//////        }
//////    }
//////}

//////iteration statement??



//////THIS DOESNT WORK BECAUSE OF LOGIC FAILURE TO CONVERT TO INT AND RETURN...What??
//////using System;

//////public class Kata
//////{
//////    public static int GetAge(string inputString)
//////    {
//////        int int.Parse(correctAge);
//////        if (correctAge < 10 && correctAge > 0)
//////        {
//////            return correctAge;
//////        }
//////        else
//////        {
//////            // Uncomment the following line to resolve.
//////            return "0";  
//////        }
//////    }
//////}


//////not sure how to do the check??
//////using System;

//////public class Kata
//////{
//////    public static int GetAge(string inputString)
//////    {
//////        if (Int32.Parse(inputString = 0,1,2,3,4,5,6,7,8,9,))
//////        {
//////            return int;
//////        }
//////        {
//////            int m = Int32.Parse("abc");// return int.Parse(inputString);
//////        }
//////    }

//////using System;
//////using System.ComponentModel;
//////using System.ComponentModel.Design;

//////public class Kata
//////{
//////    public static int GetAge(string inputString)
//////    {
//////        foreach (int 1 in inputString)
//////        {
//////            return inputString;
//////        }
//////    }
//////}


////////template
//////using System;

//////public class Kata
//////{
//////    public static int GetAge(string inputString)
//////    {

//////    }
//////}

//////short solution
//////using System;


//////public class Kata
//////{
//////    public static int GetAge(string age)
//////    {

//////        return age[0] - '0';
//////    }
//////}

//////long solution

//////using System;

//////public class Kata
//////{
//////    public static int GetAge(string inputString)
//////    {
//////        if (inputString == "0 year old")
//////        {
//////            return 0;
//////        }
//////        else if (inputString == "1 year old")
//////        {
//////            return 1;
//////        }
//////        else if (inputString == "2 years old")
//////        {
//////            return 2;
//////        }
//////        else if (inputString == "3 years old")
//////        {
//////            return 3;
//////        }
//////        else if (inputString == "4 years old")
//////        {
//////            return 4;
//////        }
//////        else if (inputString == "5 years old")
//////        {
//////            return 5;
//////        }
//////        else if (inputString == "6 years old")
//////        {
//////            return 6;
//////        }
//////        else if (inputString == "7 years old")
//////        {
//////            return 7;
//////        }
//////        else if (inputString == "8 years old")
//////        {
//////            return 8;
//////        }
//////        else if (inputString == "9 years old")
//////        {
//////            return 9;
//////        }
//////        else
//////        {
//////            return 9999999;
//////        }

//////    }
//////}

//////another solution
//////using System;

//////public class Kata
//////{
//////    public static int GetAge(string inputString)
//////    {
//////        return (int)Char.GetNumericValue(inputString[0]);
//////    }
//////}


//////another
//////using System;

//////public class Kata
//////{
//////    public static int GetAge(string inputString) => inputString[0] - '0';
//////}

//////functions and methods are the same in c#

////// new kata

//////Write a function named setAlarm which receives two parameters. The first parameter, employed, is true whenever you are employed 
//////    and the second parameter, vacation is true whenever you are on vacation.

//////The function should return true if you are employed and not on vacation 
//////    (because these are the circumstances under which you need to set an alarm). 
//////    It should return false otherwise. Examples:

//////public class Kata
//////{
//////    public static bool SetAlarm(bool employed, bool vacation)
//////    {
//////        // your code here
//////    }
//////}
//////public class Kata  ** my first successful code wars**
//////{
//////    public static bool SetAlarm(bool employed, bool vacation)
//////    {
//////        if (employed && !vacation)

//////        {
//////            return true;
//////        }
//////        else
//////        {
//////            return false;
//////        }
//////    }
//////}

//////ternary solution example
//////public class Kata
//////{
//////public static bool SetAlarm(bool employed, bool vacation)
//////{
//////    return (employed && !vacation) ? true : false;
//////}
////////}


//////shortest example... 
//////not sure how it satisfies the false - is it because the default of bool is false 
//////so if you only address what's true you're good?

//////public class Kata
//////{
//////public static bool SetAlarm(bool employed, bool vacation)
//////{
//////    return employed & !vacation;
//////}
////////}

//////public class Kata
//////{
//////    public static bool SetAlarm(bool employed, bool vacation) => employed && !vacation;
//////}

//////The Database
//////public static class Kata
//////{
//////    public static string Greet(string language)
//////    {
//////        // Happy Codding :)
//////    }
//////}

//////cant get to work, cant impli
//////public static class Kata
//////{
//////    public static void Greet(string language) => language[0] - '0';

//////}
////// lamda doesnt work, can't implicitly convert an int to a string
//////public static int GetAge(string inputString) => inputString[0] - '0';

//////public static class Kata
//////{
//////    public static void Greet(string language)
//////    {
//////        Convert.ToString(language[0] - '0');

//////        List<string> list = new List<string>()
//////        {
//////            "Red",
//////            "Blue",
//////            "Green"
//////        };
//////    }
//////}

//////public class Kata
//////{
//////    public static int SumMix(object[] x)
//////    {
//////        int sum = 0;
//////        Array.ForEach(x, delegate (int i) { sum += i; });
//////        Console.WriteLine(sum);
//////    }
//////}

////// new kata

//////Write function bmi that calculates body mass index (bmi = weight / height2).

//////if bmi <= 18.5 return "Underweight"

//////if bmi <= 25.0 return "Normal"

//////if bmi <= 30.0 return "Overweight"

//////if bmi > 30 return "Obese"
////using System.Reflection.Metadata.Ecma335;

////public class Kata
////{
////    public static string Bmi(double weight, double height)
////    {
////        var result = (weight / Math.Pow(height, 2));

////        // result <= 18.5 ? return "Underweight" : result <= 25? return "overweight";

////        { result > 18.5 ? "Underweight" : "overweight"; }

////        return result


////            t0;
////        var youzie < 20.0 ? "Cold." : "Perfect!";

////        //    var readout2 = (result <= 78) ? "obese";

////        //    return readout;  


////minw that worked - wouldn't let me do math.pow
////public class Kata
////{
////    public static string Bmi(double weight, double height)
////    {
////        var result = (weight / (height*height));

////        if (result <= 18.5)
////        {
////            return "Underweight";
////        }
////        else if (result <= 25)
////        {
////            return "Normal";
////        }
////        else if (result <= 30)
////        {
////            return "Overweight";
////        }
////        else
////        {
////            return "Obese";
////        }

////    }
////}


////another way
////public class Kata {
////public static string Bmi(double w, double h)
////  => (w = w / h / h) > 30 ? "Obese" : w > 25 ? "Overweight" : w > 18.5 ? "Normal" : "Underweight";
////}

////another way. 
////public class Kata
////{
////    public static string Bmi(double weight, double height)
////    {
////        var bmi = weight / (height * height);

////        if (bmi <= 18.5) return "Underweight";
////        if (bmi <= 25) return "Normal";
////        if (bmi <= 30) return "Overweight";
////        return "Obese";
////    }
////}

////another - interesting

////using System;
////public class Kata
////{
////    public static string Bmi(double weight, double height)
////    {
////        var bmi = Math.Round(weight / (height * height), 1);
////        return
////          bmi <= 18.5 ? "Underweight" :
////          bmi <= 25 ? "Normal" :
////          bmi <= 30 ? "Overweight" : "Obese";
////    }
////}


////new kata third angle of a triangle

////You are given two interior angles (in degrees) of a triangle.

////Write a function to return the 3rd.

////Note: only positive integers will be tested.

////throw new NotImplementedException(); ?? just to throw me off??

////this was mine

//////https://en.wikipedia.org/wiki/Triangle

////using System;

////public static class Kata
////{
////    public static int OtherAngle(int a, int b)
////    {
////       var thirdAngle = (180 - (a + b));   
////        return thirdAngle;  
////    }
////}

////another solution
////using System;

////public static class Kata
////{
////    public static int OtherAngle(int a, int b)
////    {
////        return 180 - a - b;
////    }
////}

////ternary solution? 
////using System;

////public static class Kata
////{
////    public static int OtherAngle(int a, int b) => 180 - a - b > 0 ? 180 - a - b : 0;
////}

//// THIS IS WHAT I WAS TRYING TO DO
////public class Kata
////{
////    public static string Bmi(double weight, double height)
////    {
////        var bmi = weight / (height * height);
////        return bmi <= 18.5 ? "Underweight" : bmi <= 25.0 ? "Normal" : bmi <= 30.0 ? "Overweight" : "Obese";
////    }
////}

////interesting
////using System;

////public class Kata
////{
////    public static string Bmi(double weight, double height)
////      => (weight / Math.Pow(height, 2)) switch
////      {
////          var x when x <= 18.5 => "Underweight",
////          var x when x <= 25.0 => "Normal",
////          var x when x <= 30.0 => "Overweight",
////          _ => "Obese"
////      };
////}

//// new kata

////Timmy & Sarah think they are in love, but around where they live, 
////    they will only know once they pick a flower each. 
////    If one of the flowers has an even number of petals and the other 
////    has an odd number of petals it means they are in love.

////Write a function that will take the number of petals
////    of each flower 
////    and return true if they are in love 
////    and false if they aren't.

////using System;

////public class LoveDetector
////{
////    public static bool lovefunc(int flower1, int flower2) => flower1 == flower2 ? false : true;

////}
////OR

////
////using System;

////public class LoveDetector
////{
////    public static bool lovefunc(int flower1, int flower2)
////    {
////       var loveCheck = flower1 % flower2 == 1 ? true : false;
////       return loveCheck;
////    }

////}

////bottom done with John walkthrough
////using System;
////public class LoveDetector
////{
////    public static bool lovefunc(int flower1, int flower2)
////    {

////        if ((flower1 % 2 == 0 && flower2 % 2 != 0) || (flower2 % 2 == 0 && flower1 % 2 != 0))
////        {
////            return true;
////        }

////        else
////        {
////            return false;
////        }
////    }
////}

///// simpler solution 
////using System;

////public class LoveDetector
////{
////    public static bool lovefunc(int flower1, int flower2)
////    {
////        return flower1 % 2 != flower2 % 2;
////    }
////}




////So, niether of these worked, because they're looking for zero flowers. using an equals method we'll be good.
////



////new kata
////cap is the amount of people the bus can hold excluding the driver.
////on is the number of people on the bus excluding the driver.
////wait is the number of people waiting to get on to the bus excluding the driver.
////If there is enough space, return 0, and if there isn't, return the number of passengers he can't take.




////using System;

////    //public static class Kata
////    //{
////    //    public static int Enough(int cap, int on, int wait) => (cap - on) >= wait ? 0 : wait - (cap - on);

/////*}/*// cap - on = available capacity
//////waiting =  incoming volume. 
////// if waiting <= available capacity, return 0. 
//////if waiting > available capacity, return waiting - available capacity. 



////CW didn't like the first one, sai missing a using directive or an assembly reference. 


////using System.Runtime.CompilerServices;
////stopped here somewhere. 
////class AverageSolution
////{
////    public static double FindAverage(double[] array)

////    {
////            var avg = array.Average();
////            return (avg > 0) ? avg : 0;                            
////    }
////}


//////SO solution?
//////public int Sum(params int[] customerssalary)
//////{


////class AverageSolution
////{
////    public static double FindAverage(double[] array)

////    {
////        var avg = array.Average();
////        return (avg > 0) ? avg : 0;
////    }
////}

////int avg = 0;

////for (int i = 0; i < array.Length; i++)
////{
////    result += array[i];
////}

////return result;
////}


////picked up here 


////using System.Security.Cryptography.X509Certificates;

////public class Multiplier
////{
////    public static int Multiply(int x)
////    { var evenCheck = x % x; //why doesn't this show as variable? - was outside method scope. 

////       (evenCheck == 0) ? x * 8 : x * 9; //keep getting errors here. 
////    }
////}

//////ternary? left hand side??

////using System.Security.Cryptography.X509Certificates;

////public class Multiplier
////{
////    public static int Multiply(int x)

////    {
////        x % x = 0 ? x* 8 : x* 9;
////    }
////}

//////ternary lamda - nope (left hand side??)
////using System.Security.Cryptography.X509Certificates;

////public class Multiplier
////{
////    public static int Multiply(int x) => (x % x) = 0 ? x * 8 : x * 9;


////}


////public class Multiplier
////{
////    public static int Multiply(int x)
////    {
////     if ((x%2) == 0)
////        {
////            return Convert.ToInt32(Console.WriteLine(x * 8));
////        }
////        else
////        {
////            return x * 9;
////        }
////    }
////}


////long way??
////below mine had issues
////public class Multiplier
////{
////    public static int Multiply(int x) => x % 2 = 0 ? x * 8 : x * 9


////}


//////working solution shorter
////public class Multiplier
////{
////    public static int Multiply(int x)
////    {
////        return x % 2 == 0 ? x * 8 : x * 9;
////    }
////}

////another working soution shortest
////public class Multiplier
////{
////    public static int Multiply(int n) => n * (n % 2 == 0 ? 8 : 9);
////}

////clever
////using System;

////public class Multiplier
////{
////    public static int Multiply(int x)
////    {
////        return x * (8 + x % 2);
////    }
////}

//// next kata is he gonna survive

////each dragon takes 2 bullets. 
////for each dragon, 2 bullets are required. 
////if bullets = dragons*2, he lives


//// long way
////class Kata
////{
////    public static bool Hero(int bullets, int dragons)
////    {
////        if (bullets >= (dragons*2))
////            return true;
////        else
////        {
////            return false;
////        }
////    }
////}

////ternary WORKING TERNARY (submitted)
////class Kata
////{
////    public static bool Hero(int bullets, int dragons) => bullets >= (dragons * 2) ? true : false;

////}

//////another option  with division
////class Kata
////{
////    public static bool Hero(int bullets, int dragons)
////    {
////        return bullets / 2 >= dragons;
////    }
////}

//// new kata grasshopper debug say hello
////public class Kata
////{
////    public static string SayHello(string name)
////    {
////        return $"Hello, {name}";
////    }
////}

//// always return 5 without using 5  https://www.codewars.com/kata/59441520102eaa25260000bf/csharp  numbers.count??
////public class Kata
////{
////    public static int SayHello(int five)
////    {
////        return Int32.Parse(five) ;
////    }
////}

////public class Dinglemouse
////{

////    public static int[] humanYearsCatYearsDogYears(int humanYears)
////    {
////        new int = (humanYears, humanYears+15
////        return new int[] { 0, 0, 0 };
////    }

////}

////using System;
////using System.Linq;

////namespace Solution
////{
////    public class Kata
////    {
////        public static int FinalGrade(int exam, int projects)
////        {
////            if (exam > 90 || projects > 10)
////            {
////                return 100;
////            }
////            else if (exam > 75 && projects >= 5)
////            {
////                return 90;
////            }
////            else if (exam > 50 && projects >= 2)
////            {
////                return 75;
////            }
////            else 
////            {
////                return 0;
////            }

////        }
////    }
////}



////using System; // must have this in order to use Math.Pow function
////public class Kata
////{
////    public static double Square(double a)
////    {
////        return Math.Pow(a, 2);
////    }

////}

//// convert number to string kata

//using System;
//public class Kata
//{
//    public static string NumberToString(int num)
//    {
//        return num.ToString();
//    }
//}
//Methods.NumberToString();

//using System.Numerics;

//var answer = Kata.PowersOfTwo(1);
//foreach (var item in answer)
//{
//    Console.WriteLine(item);
//}

//Methods.RepeatStr(3, *);   //covert array to string?

//using System;

//public class kata
//{
//    public static string boolean_to_string(bool b)
//    {
//        if (b == true)
//        {
//            return "True";
//        }
//        else
//            return "False";
//    }
//}

//public class Triangle
//{
//    public static bool IsTriangle(int a, int b, int c)
//    {
//        if ((a>0 && b>0 && c>0) && (a+b > c) && (b+c > a) && (c+a > b))
//        {
//            return true;
//        }

//        else
//        {
//            return false;
//        }        
//    }
//}

//opposite number solved
//using System;

//public class Kata
//{
//    public static int Opposite(int number)
//    {
//        return (number * -1);
//    }
//}

//sum of positive
//passes 3 of 5. 
//using System;
//using System.Linq;

//public class Kata
//{
//    public static int PositiveSum(int[] arr)
//    {
//        foreach (var item in arr)
//        {
//            if (item > 0)
//            {
//               return arr.Sum();

//            }

//        }

//            return 0;//if arr[] == 0, return 0;
//    }
//}
//??



///////////////////////////////////////
//using System;
//using System.Linq;
//using System.Collections;
//using System.Net.WebSockets;
//using System.Collections.ObjectModel;
//using System.Reflection;
//using System.Collections.Generic;

//public class Kata
//{

//    public static int PositiveSum(int[] arr)

//    {
//        foreach (var item in arr)
//        {
//            List<int> negList = new List<int>();

//            int negSum;
//            if (item > 0 && item! < 0)
//            {
//                return arr.Sum();

//            }
//            //else if (item < 0)
//            //{
//            //    negList.Add(item);
//            //    negSum = (negList.Sum() * -1);
//            //    return (arr.Sum() + negSum);             // Q for John, will a foreach allow you to iterate through like a for and add indexed value (i) 
//            //}
//        }

//        //  negList.Contains();  - is there a simple way to identify it there are negative numbers?


//        for (int i = 0; i < arr.Length; i++)
//        {
//            List<int> posList = new List<int>();

//            if (i > 0)
//            {
//                posList.Add(arr[i]);
//            }
//            return posList.Sum();

//            List<int> negList2 = new List<int>();
//            var negList2Sum = negList2.Sum();
//            if (i < 0)
//            {
//                negList2.Add(arr[i]);
//            }
//            return ((negList2Sum * -1) + arr.Sum());
//        }

//        return 0;//if arr[] == 0, return 0;
//    }
//}
//solution... if statement... if array.sum is less than zero, return zero.
//else if use the string sum with negs removed or turned into positives and readded. 

// Solution working sum of positive numbers
//using System;
//using System.Linq;
//using System.Collections;
//using System.Collections.Generic;

//public class Kata
//{
//    public static int PositiveSum(int[] arr)
//    {
//        var posList = new List<int>();

//        for (int i = 0; i < arr.Length; i++)
//        {
//            if (arr[i] > 0)
//                posList.Add(arr[i]);
//        }
//        return posList.Sum();
//        if (arr.Sum() <= 0)
//            return 0;
//    }
//}

//using System;
//using System.Linq;

//public class Kata
//{
//    public static int PositiveSum(int[] arr)
//    {
//        return arr.Where(x => x > 0).Sum();
//    }
//}
// another linq solution
//using System;
//using System.Linq;

//public class Kata
//{
//    public static int PositiveSum(int[] arr)
//    {
//        return arr.Where(a => a > 0).Sum();
//    }
//}

// NEW KATA Sum without highest and lowest number
//algo
//determine the highest number in an array
//determine the lowest number in an array
// factor out the highest and lowest numbers
//add the remaining numbers in the array (or separate them out to another list then sum?

//else return 0 

// could sort then add all index except 0 and array.Length?


/// LINQ Solution
/// 
//var anArray = new int[] { 1, 5, 7, 4, 2 };
//var (number, index) = anArray.Select((n, i) => (n, i)).Min();



//solved, works. main issue was ternary fail?? and order of code and array.Length == 0 for empty. FIRST
//using System;
//using System.Linq;
//using System.Reflection.Metadata.Ecma335;

//public static class Kata
//{
//    public static int Sum(int[] numbers)
//    {
//        if (numbers == null) return 0;
//        if (numbers.Length == 0) return 0;

//        var lowN = numbers.Min();
//        var highN = numbers.Max();
//        var answer = numbers.Sum() - lowN - highN;

//        if (numbers.Length > 1) return answer;
//        else return 0;        
//    }
//}

//  numbers.Length > 1 ? answer : 0  why oh why does this ternary not work?
//another solution with linq
//using System;
//using System.Linq;

//public static class Kata
//{
//    public static int Sum(int[] numbers)
//    {
//        return numbers == null || numbers.Length < 2
//            ? 0
//            : numbers.Sum() - numbers.Max() - numbers.Min();
//    }
//}

//another 
//    using System.Linq;

//public static class Kata
//{
//    public static int Sum(int[] n) => (n?.Length ?? 0) > 1 ? n.Sum() - n.Max() - n.Min() : 0;
//}

//CenturyFromYear(100);


/// LINQ Solution
/// 
///


//Complete the square sum function so that it squares each number passed into it and then sums the results together.

//For example, for [1, 2, 2] it should return 9 because 1^2 + 2^2 + 2^2 = 9

//using System.Numerics;
//public static class Kata
//{
//    public static int SquareSum(int[] numbers)
//    {
//        var sumList = new List<int>();
//        foreach (var number in numbers)
//        {

//            var squares = number * number;
//            sumList.Add(squares);
//        }
//        return sumList.Sum();
//    }
//}

//Shorter with Lamda

//    using System.Linq;
//public static class Kata
//{
//    public static int SquareSum(int[] n) => n.Sum(i => i * i);
//}

//using System;
//using System.Collections.Generic;

//static void Main()
//{

//    var fizzChal = new FizzBuzz
//    var fizzbuzziness = FizzBuzzChallenge(13); // does this work?
//    Console.WriteLine(fizzbuzziness);
//}
//using System.Collections.Generic;
//public class Kata
//{
//    public static int[] Maps(int[] x)
//    {
//        var x2 = new List <int> ();
//        foreach (var item in x)
//        {
//            x2.Add (item*2);
//        }
//        return x2.ToArray();
//    }
//}

////shorter solution, direct to array
//using System.Linq;

//public class Kata
//{
//    public static int[] Maps(int[] x)
//    {
//        return x.Select(e => e * 2).ToArray();
//    }
//}

////another converting array 
//    using System;
//public class Kata
//{
//    public static int[] Maps(int[] x)
//    {
//        return Array.ConvertAll(x, n => n * 2);
//    }
//}


//public class DivisibleNb
//{
//    public static bool isDivisible(long n, long x, long y)
//    {    
//        return (n % x == 0 && n % y == 0);
//    }
//}

////first attempt
//using System;
//public class Kata
//{
//    public static string FindNeedle(object[] haystack)
//    {
//        foreach (var item in haystack)
//        {
//            if (item == "needle")
//                return haystack.indexOf("needle");
//        }
//    }
//}


//using System;
//using System.Linq;
//public class Kata
//{
//    public static string FindNeedle(object[] haystack)
//    {
//        int index = Array.FindIndex(haystack, x => x.Contains("needle"));

//        return $"found the needle at position {index}";
//    }
//}

//var index = haystack.FindIndex(haystack, row => row.roar == "xyz");
//foreach (var a in haystack)
//{


// if (item == "needle")
//
//return   indexOf("needle");
//        haystack.FindIndex(haystack => haystack.Contains("needle");
//        int indexOfValue = haystack.FindIndex(item => haystack.Contains("insert value from list"))

//        int indexOfValue = myList.FindIndex(a => a.Contains("insert value from list"))
//  
//solution - missed array. and put actual array name in method. duh.
//using System;

//public class Kata
//{
//    public static string FindNeedle(object[] haystack)
//    {    
//        return $"found the needle at position {Array.FindIndex(haystack, a => a == "needle")}";
//    }
//}


//using System;
//using System.Collections.Generic;
//using System.Linq;
//public class Kata
//{
//    public static string FakeBin(string x)
//    {
//        foreach (char c in x)
//        {
//            Convert.ToInt32(c);
//        }
//        foreach (char c in x)
//          {
//            if (c < 5)
//                x.Replace(c, '0');
//            else if (c >= 5)
//                x.Replace(c, '1');
//        }
//        return x;
//    }
//}
//My Solution

//using System;
//using System.Text;
//using System.Text.RegularExpressions;

//public class Kata
//{
//    public static string FakeBin(string x)
//    {
//        string binString = x.Replace('1', '0')
//                            .Replace('2', '0')
//                            .Replace('3', '0')
//                            .Replace('4', '0')
//                            .Replace('5', '1')
//                            .Replace('6', '1')
//                            .Replace('7', '1')
//                            .Replace('8', '1')
//                            .Replace('9', '1');

//        return binString;
//    }
//}

////another solution
//using System.Linq;

//public class Kata
//{
//    public static string FakeBin(string x)
//    {
//        return string.Concat(x.Select(a => a < '5' ? "0" : "1"));
//    }
//}

////another solution builder
//using System.Text;
//public class Kata
//{
//    public static string FakeBin(string x)
//    {
//        StringBuilder builder = new StringBuilder();

//        foreach (char t in x)
//        {
//            builder.Append(t >= '5' ? '1' : '0');
//        }

//        return builder.ToString();
//    }
//}

////another regex
//using System.Text.RegularExpressions;
//public class Kata
//{
//    public static string FakeBin(string x)
//    {
//        x = Regex.Replace(x, "[4321]", "0");
//        x = Regex.Replace(x, "[56789]", "1");
//        return x;
//    }
//}
////another
//public class Kata
//{
//    public static string FakeBin(string x)
//    {
//        string result = "";

//        foreach (char c in x)
//            result += c < '5' ? "0" : "1";

//        return result;
//    }
//}

// new kata regex validate pin code

//using System;
//using System.Net.NetworkInformation;
//using System.Reflection;
//using System.Text.RegularExpressions;
//using System.Linq;////////////////////////////////////////////////regex one///////////////////////////////////////////////////////////////////////////////////////////

//public class Kata
//{


//    static bool ValidatePin(string pin)
//    {
//       // return pin.Regex(@"^\d{4}|\d{6}");
//       Regex r = new Regex(@"^[0-9]\d{4}\d{6}$");     
//       return r.IsMatch(pin);
        //   Regex r = new Regex(@"^\+?\d{0,2}\-?\d{4,5}\-?\d{5,6}");//.test(pin);
        //class Regex Repesents an immutable regular expression.    

        //  string[] str = { "+91-9678967101", "9678967101", "+91-9678-967101", "+91-96789-67101", "+919678967101" };
        //Input strings for Match valid mobile number.    

//    }

//}

        //  return (  );
        ////  int.TryParse(pin);
        //bool intQ = pin.Equals(int);
        // return Convert.ToInt32(pin); 
        // return (pin.Replace("[- ]", "").Trim().Count() == 4 || pin.Replace("-", "").Trim().Count() == 6) && int.TryParse(pin, out _);
        //var yikes = pin.Length;
        //pin.Replace("-", "a").Replace(" ", "a");
        //bool numberPass = yikes == 4 || yikes == 6;

        //return numberPass && int.TryParse(pin, out _);
        //return (pin.Count() == 4 || pin.Count() == 6) && int.TryParse(pin, out _);
        //Console.WriteLine(ValidatePin(pin));

        // bool intP  = Convert.ToInt32(pin);
        //   return (pin.Count() == 4 || pin.Count() == 6) && int.TryParse(pin, out _);

        //foreach (var item in pin)
        //{
        //pin.Replace("-", "").Replace("+", "").Replace(" ", "").Trim();
        //var yikes = pin.Count();
        //bool numberPass = yikes == 4 || yikes == 6;

        //return (numberPass && int.TryParse(pin, out _));
        ////}
       
        // last before gave up and switched to regex. apparently the test called for - to be removed and string.replace doesnt replace??
//        using System;
//            using System.Collections.Generic;
//            using System.Linq;

//public class Kata
//    {
//        public static bool ValidatePin(string pin)
//        {
//            //pin.Replace("-", " ").Replace("+", " ").Trim();
//            //var yikes = pin.Count();
//            //bool numberPass = (yikes == 4 || yikes == 6);

//            //return (numberPass && int.TryParse(pin, out _));
           

//        }
//    }


//}
//    }
//}

//public static void Main(string[] args)
//{
//    string str = "";
//    int intStr; bool intResultTryParse = int.TryParse(str, out intStr);
//    if (intResultTryParse == true)
//    {
//        Console.WriteLine(intStr);
//    }
//    else
//    {
//        Console.WriteLine("Input is not in integer format");
//    }
//    Console.ReadLine();
//}



// return (!Regex.Match(pin, @"^(?=[0-9]*$)(?:.{4}|.{6})$").Success);
//REGEX()
///// algo - check that response is all integer
///// check that response is 4 or 6 characters only
///// return true or false.
///// 
//if (!Regex.Match(pin, @"^\d{5}$").Success)
//{
//    if (!Regex.Match(phoneTextBox.Text, @"^[1-9]\d{2}-[1-9]\d{2}-\d{4}$").Success)  