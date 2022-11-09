////using System;
////public class Kata
////{
////    public static string NumberToString(int num)
////    {
////        return num.ToString();
////    }
////}


////powers of 2
////using System.Numerics;

////public static BigInteger[] PowersOfTwo(int n)
////{

////}

////johns class one
//using System.Numerics;
//using System;
//public class Kata
//{
//	public static BigInteger[] PowersOfTwo(int n)
//	{
//		var result = new BigInteger[n + 1];
//		for (int i = 0; i <= n; i++)
//		{
//			result[i] = (BigInteger)Math.Pow(i, 2);
//		}
//		return result;
//	}
//}


// new kata
//my previous start
//using System.Linq;

//class AverageSolution
//{
//    public static double FindAverage(double[] array)

//    {
//        var avg = array.Average();
//        return (avg > 0) ? avg : 0;
//    }
//}
//using System;
//using System.Globalization;

//class AverageSolution
//{
//    public static double FindAverage(double[] array)
//    {
//        //if array is empty, return 0
//        //calculate the average of the numbers in a given list
//        // numbers.sum / numbers.count = average. 

//        //var arraySum = (array, 1);
//        //if Sum(array) == 0
//        //{

//        //}
//        // my trials 

//        //foreach (var double in array)
//        //{

//        //}
//        //var arrayToAvg = new List<int>();

//        //for (int i = 0; i < array.Length; i++)

//        //{
//        //    arrayToAvg.Add(i);
//        //}
//        //numbers.Count(arrayToAvg);






//        //else
//        //        {
//        //            return 0;
//        //        }


//        //foreach (var item in collection)
//        //{

//        //}
//        //return 0;
//    }
//}

//calculate average kata

//    short answer
//    using System.Linq;

//class AverageSolution
//{
//    public static double FindAverage(double[] array)
//    {
//        return array.Length == 0 ? 0 : array.Average();
//    }
//}

//

//    using System;

//public class Kata
//{
//    public static string NumberToString(int num)
//    {
//        return num.ToString();
//    }
//}

//using System;

//public static class Game
//{
//    public static float Combat(float health, float damage) => (health - damage) >= 0 ? (health - damage) : 0;

//}

// trip to the market  
//not certain what the desired output is... true/ false? yes, t or f. 
//this worked. 
//public static class Kata
//{
//    public static bool IsLockNessMonster(string sentence)
//    {
//        var lowered = sentence.ToLower();

//        if (sentence.Contains("3.50"))
//        {
//            return true;
//        }
//        else if (lowered.Contains("three fifty"))
//        {
//            return true;
//        }
//        else if (lowered.Contains("tree fiddy"))
//        {
//            return true;
//        }       
//        else
//        {
//            return false;
//        }
//    }

//}

//linq shorter solution
//using System.Linq;

//public static class Kata
//{
//    public static bool IsLockNessMonster(string sentence)
//    {
//        return sentence.ToUpper().Contains("TREE FIDDY") || sentence.Contains("3.50");
//    }
//}

//organized or statements
//    using System;

//public static class Kata
//{
//    public static bool IsLockNessMonster(string sentence)
//    {
//        return sentence.Contains("tree fiddy", StringComparison.OrdinalIgnoreCase) ||
//               sentence.Contains("three fifty") ||
//               sentence.Contains("3.50");
//    }
//}


//the one I think is cleanest
//public static class Kata
//{
//    public static bool IsLockNessMonster(string sentence)
//    {
//        return sentence.Contains("3.50") || sentence.ToLower().Contains("tree fiddy");
//    }
//}

//using System;

//namespace Solution
//{
//    public class SolutionClass
//    {
//        public static string EvenOrOdd(int number) => (number % 2 == 0) ? "Even" : "Odd";
//    }
//}
//using System;

//public static class Game
//{
//    public static float Combat(float health, float damage) => (health - damage) >= 0 ? (health - damage) : 0;

//}

//remove the string spaces

//namespace Solution
//{
//    public static class SpacesRemover
//    {
//        public static string NoSpace(string input)
//        {
//           return input.Replace(" ", "");

//        }
//    }
//}

//next kata string repeat

//Write a function that accepts an integer n and a string s as parameters, and returns a string of s repeated exactly n times.
// 6, "I"     -> "IIIIII"
// 5, "Hello"-> "HelloHelloHelloHelloHello"

//namespace Solution
//{
//public static class
//    {
//using System;
//namespace Solution;
//public static class Methods

//{
//    public static string RepeatStr(int n, string s)
//    {

//        //for (int i = 0; i < length; i++)
//        //{
//        //    string c = s[i];
//        //    return c;
//        //}
//        //{
//        //    return s.Repeat(n); 
//        //}
//        foreach (var item in collection)
//        {

//        }
//        foreach (var item in s)

//        {
//            return item * n;        //return $"{item} * {n}";
//        }

//    }
//}

//}
//}

// // Repeat string s  int n times. 
//string sRepeated = s * n


// count odd numbers below n
//using System;

//public static class Kata
//{
//    public static ulong OddCount(ulong n) //cs0161
//    {

//        while (n > 0 && n%2 !=0)
//        {
//            return --n;
//        }
//        //else
//        //{
//        //    return 0;
//        //}
//        //var listOfNumbers = new List<ulong>();
//        //for (ulong i = 0; i < n; i -= 3);
//        //{
//        //    listOfNumbers.Add(n);                   //this doesnt seem right
//        //                                           // return i;
//        //}
//        // n < 0  %2 !=0                               // given n, return the number of positive odd numbers below n
//    }
////}

//using System.Linq;

//namespace Solution
//{
//    public static class Program
//    {

//        public static string RepeatStr(int n, string s)
//        {
//           for (int index = 0; index < (index *n); (index * n))
//            {
//              string copiedArray =  String.Copy(s, n);
//                return copiedArray;
//            }//  return $"{s}*{n}";
//        }
//    }
//}


//using System.Collections.Generic;
//using System.Linq;

//public static class Kata
//{
//    public static List<int> Odds(List<int> values) =>
//      // arrow it
//      values.Where( => )
//            .ToList();
//}

//using System;
//public static class Kata
//{

//    public static int[] ReverseSeq(int n)
//    {
//        var listOfNumbers = new List<int>();
//        for (int i = n; i > 0 ; i--)
//        {
//            listOfNumbers.Add(i);
//            return (listOfNumbers);
//        }                                   //returns an array of integers from n to 1 where n>0
//    }
//}


// new Kata
//using System.Collections.Generic;
//using System.Linq;

//public static class Kata
//{
//    public static List<int> Odds(List<int> values) =>
//    // arrow it
//    while (values <= 0 &&!= % 0)
//	{
// //       values.Add()
//	//}

// //   values.Where(values => 1)  // && != %0
//            .ToList();
//}
//using System;

//namespace Solution
//{
//    public class TwiceAsOldSolution
//    {
//        public static int TwiceAsOld(int dadYears, int sonYears)
//        {
//            var twiceOlder = sonYears * 2;
//            var solution = Math.Abs(dadYears - twiceOlder);
//            return solution;
//        }
//    }
//}

//using System;

//public static class Kata
//{
//    public static string greet()
//    {
//        string greetingsEarthling = "hello world!";
//        return greetingsEarthling;                       
//    }
//}

//// new kata Complementary DNA   /////////////////////////////
//using System;
//public class DnaStrand
//{
//    public static string MakeComplement(string dna)
//    {
//      //  var listOfNumbers = new List<char>();
//        for (int i = 0; i < 0; i++)
//        {
//            return
//            dna.Replace("A", "T");
//            dna.Replace("T", "A");
//            dna.Replace("C", "G");
//            dna.Replace("G", "C");
//        }
//       // return Convert.ToString(listOfNumbers);
//    }
//}                         ///////////////////////////////

// is there a way to have these run in sequence? I think they may overwrite each other.
//also, how to keep the ones already changed from being overwritten. for loop??

//using System;

//public static class Kata
//{
//    public static string Greet(string name)
//    {
//        throw new NotImplementedException("Greet is not implemented.");
//    }
//}

//new kata disemvowel trolls

//using System;

//public static class Kata
//{
//    public static string Disemvowel(string str)
//    {
//        string disemvoweled = String.Join("", str.Split('a', 'e', 'i', 'o', 'u'));  
//        return disemvoweled;
//    }
//}
////needs to remove To.Lower??

//public class Triangle
//{

//    public static bool IsTriangle(int a, int b, int c)
//    {
//        if ((a > 0 && b > 0 && c > 0) && (a + b > c) && (b + c > a) && (c + a > b))
//        {
//            return true;
//        }

//        else
//        {
//            return false;
//        }
//    }
//}
//public class RentalCar
//{

//    public static int RentalCarCost(int d)
//    {   
//       var totalAmount = (d * 40);

//        if (d < 3 && d > 0)
//        {
//            return totalAmount;
//        }
//        else if (d >= 3 && d < 7)
//        {
//           return totalAmount - 20;
//        }
//        else if (d >= 7)
//        {
//            return totalAmount - 50;     
//        }
//        else
//        {
//            return 0;
//        }
//    }
//}

//another shorter solution with if statments
//public class RentalCar
//{

//    public static int RentalCarCost(int d)
//    {
//        int total = d * 40;
//        if (d >= 7)
//            return total - 50;
//        if (d >= 3)
//            return total - 20;
//        return total;
//    }
//}

// new kata List Filtering

//using System.Collections;
//using System.Collections.Generic;

//public class ListFilterer
//{
//    public static IEnumerable<int> GetIntegersFromList(List<object> listOfItems)
//    {
//       var sorted = new int[listOfItems.Count];

//        for (int i = 0; i < listOfItems.Count; i++)
//        {
//            if (listOfItems == char)
//            {

//            }
//        }
//        {
//            sorted.Add();
//                listOfItems.Remove(""));
//            return listOfItems.Remove("");
//        }

//        return listOfItems.Remove("");


//        //    {
//        string disemvoweled = String.Join("", str.Split('a', 'e', 'i', 'o', 'u'));  
////        //        return disemvoweled;
////        //    }
////    }
////}


//// new kata difference of volumes of cuboids

//public class Kata
//{
//    public static int FindDifference(int[] a, int[] b)
//    {
//        //need to pull out ints from list. 
//       var arrayA = new int[3];

//        foreach (var item in a)
//        {
//            item*item
//        }  for (int i = 0; i < a.Length; i++)
//        {
//            arrayA[i] = a[i];
//        }
//        if (a-b >0)
//        {
//            return a-b
//        }
//        else
//        {
//            return b-a
//        }
//    }
//}

//public class Kata
//{
//    public static int[] Between(int a, int b)
//    {

//        var arr = new int[(b-a+1)];
//        for (int i = a; i <= b; i++)
//        {
//            arr[i] = i;
//        }
//        return arr;
//    }
//}

//public class Kata
//{
//    public static int GetGoals(int laLigaGoals, int copaDelReyGoals, int championsLeagueGoals)
//    {
//        var goalSum = laLigaGoals + copaDelReyGoals + championsLeagueGoals;
//        return goalSum;
//    }
//}

//using System;

//public class Kata
//{
//    public static string Remove_char(string s)
//    {

//        string result = s.Substring(0, s.Length - 1);
//        return result;
//    }
//}

//using System;

//public class Kata
//{
//    public static int Litres(double time)
//    {
//        var roundskies = Math.Floor(time * .5);

//        return Convert.ToInt32(roundskies);      
//    }
//}

//using System;

//public class Kata
//{
//    public static string AreYouPlayingBanjo(string name)
//    {       
//        var rCheck = name.ToLower();

//        if (rCheck.StartsWith("r"))
//        {
//            return $"{name} plays banjo";
//        }
//        else
//        {
//            return $"{name} does not play banjo";
//        }
//    }
//}

// not all code paths return a value. not sure why? both true and false are handled?
//public class Kata
//{
//    public static bool Check(object[] a, object x)
//    {
//        foreach (var item in a)
//        {
//            if (item == x)
//            {
//                return true;
//            }
//            else
//            {
//                return false;
//            }
//        }
//    }
//}

// while loop is a no. 
//public class Kata
//{
//    public static bool Check(object[] a, object x)
//    {
//        foreach (var item in a)
//        {
//            while (item == x)
//            {
//                return true;                                
//            }

//            return false;   

//        }
//    }
//}

// trying again

//public class Kata
//{
//    public static bool Check(object[] a, object x)
//    {
//        for (int i = 0; i < a.Length; i++)
//        {
//            {
//                while (a == x)
//                {
//                    return true;
//                }
//                return false;
//            }
//        }        

//    }
//}

//for with foreach and while. 
//public class Kata
//{
//    public static bool Check(object[] a, object x)
//    {
//        for (int i = 0; i < a.Length; i++)
//        {
//            foreach (var item in a)
//            {
//                while (item == x)
//                {
//                    return true;
//                }

//                return false;

//            }
//        }
//    }
//}
//foreach with while. 

//public class Kata
//{
//    public static bool Check(object[] a, object x)
//    {
//        for (int i = 0; i <= a.Length; i++)
//        {
//            foreach (var item in a)
//            {
//                while (item == x)
//                {
//                    return true;
//                }

//                return false;

//            }


//        }

//        return false;
//    }
//}

//for with if. 
//public class Kata
//{
//    public static bool Check(object[] a, object x)
//    {
//        for (int i = 0; i <= a.Length; i++)
//        {
//            if (a == x)
//            {
//                return true;
//            }           
//        }



//            return false;
//           }
//}
//using System.Collections.Generic;

//namespace System.Linq
//{
//    public class Kata
//    {

//        public static bool Check(object[] a, object x)
//        {
//            while (a.Contains(x))
//            {
//                return true;
//            }

//            return false;

//        }
//    }
//}

//using System.Collections.Generic;
//using System.Linq;

//    public class Kata
//{
//    public static bool Check(object[] a, object x) 
//        => a.Contains(x) ? true : false;

//}


//a good short solution

//using System.Linq;

//public class Kata
//{
//    public static bool Check(object[] a, object v) => a.Contains(v);
//}

//another good solution
//using System;
//using System.Linq;

//public class Kata
//{
//    public static bool Check(object[] a, object x)
//    {
//        return a.Contains(x);  ///how does this return t or f?
//    }
//}

////shortest 
//using System.Linq;

//public class Kata
//{
//    public static bool Check(object[] a, object x) => a.Contains(x);
//}
//using System.Linq;
//using System.Security.Cryptography;
//using static God.Human;
/////


//using System.Net;
// new kata basic subclasses, adam and eve

//public class God
//{
//    public static Human[] Create()
//    {
//        Man adam = new Man();
//        Woman eve = new Woman();
//        Human[] manArray = new Human[] { adam, eve };
//        return manArray;
//    }
//}
//public class Human
//{
//}

//public class Man : Human
//{
//}

//public class Woman : Human
//{
//}


//public class Kata
//{
//    public static int RoundToNext5(int n)
//    {

//        if (n % 5 == 0) return n;

//        else return 0;
//                //(n % 5 >= 1);



//    }


// Algorithm is
// 1. take an integer as an inputx
//2. round the input up to the next or equal to multiple of 5.
//Math.Rnd()
// 3. allow for pos or neg
//4. all inputs will be valid integers. 
// return the closest multiple of 5. 

// 

//    input: output:
//        0->   0
//2->   5
//3->   5
//12->   15
//21->   25
//30->   30
//- 2->   0
//- 5->   - 5


//    using System;



//public class Kata
//{ 

//    public static int CalculateYears(double principal, double interest, double tax, double desiredPrincipal)
//    {
//       // var years = principal * 2;
//        var accruedInterest = (principal * interest);
//        var taxableIncome = (interest * tax);   
//        var 
//        var netGain = accruedInterest - 

//        years *= interest;
//        algorithm




//        (principal + ) - taxableIncome = var netGain;
//        return netGain;





//       // return years;
//    }
//}

// returning strings complete
//using System;

//public static class Kata
//{
//    public static string Greet(string name)
//    {
//        return ($"Hello, {name} how are you doing today?");
//    }
//}
/////////find the first non consecutive number
//working solution - i had such a hard time because i thought it could be increased by any math function , any amount. 

//using System;
//public class Kata
//{
//    public static object FirstNonConsecutive(int[] arr)
//    {
//        for (int i = 1; i < arr.Length; i++)
//        {
//            if (arr[i] != arr[i - 1] + 1)
//            {
//                return arr[i];
//            }
//        }
//        return null;
//    }
//}
// another working solution
//using System;
//using System.Linq;

//public class Kata
//{
//    public static object FirstNonConsecutive(int[] arr)
//    {
//        var nonConsec = arr.Where((n, index) => index > 0 && n != arr[index - 1] + 1);
//        if (nonConsec.Count() > 0)
//            return nonConsec.First();
//            return null;
//    }
//}















//public class Kata
//{
//    public static object FirstNonConsecutive(int[] arr)
//    {
//        var iStart = Index.Start;

//        arr[0] = arr[iStart];
//        foreach (int checkedIndex in arr)
//        {
//            // if ( is arr.TrueForAll)
//            {
//                return "Nonsense";
//            }

//            //if (checkedIndex < arr.Length)  
//            //arr[checkedIndex]++;    
//        }

//        var convertedToString = arr.ToString(cTS);

//        convertedToString.TrueForAll((arr[1] - arr[0]))



//        array 1 - Array[2] = Array 3 - Array 2


//        if (iStart.CompareTo[2]) == [2].CompareTo[3])
//        {

//            return
//        }
//        else return null;
//    }
//}
//Math.

//  // if 1st ele is smaller than 2nd ele,emt

//// Checking the given index 
//// is the start index or not
//// Using Equals(index) method
//if (res.Equals(0) == true)
//{

//    Console.WriteLine("The given index is start index" +
//              " and the element is " + greetings[res]);
//}
//else
//{

//    Console.WriteLine("The given index is not the start index ");

//    // FIND THE FIRST ELEMENT OF AN ARRAY THAT IS NOT CONSECUTIVE

//    //if whole array is consecutive, return null
//    //array will always have at least 2 members
//    //the numbers will ascend
//    //the numbers could be pos or neg.

//    Regex??

//    possible solution?
// if difference between index 0 and 1 is different than difference between 1 and 2, than 2 is not consecutive.

//Solved
//using System.Numerics;
//public class Kata
//{
//    public static int SaleHotDogs(int n)
//    {
//        if (n < 5) return 100 * n;
//        if (n >= 5 && n < 10) return 95 * n;
//        if (n >= 10) return 90 * n;
//        else return 0;
//    }
//}
// also ternary statement (includes arguments (, . .= within statement, example  iuf ? if.=9dfgfd: .+sdfs


//Complete function saleHotdogs/SaleHotDogs/sale_hotdogs, function accept
//1 parameters:n, n is the number of customers to buy hotdogs, different numbers have different
//prices (refer to the following table), return a number that the customer need to pay how much money.

//number	price (cents)
//n < 5   100
//n >= 5 and n< 10	95
//n >= 10	90

// new kata sort array by string length

// algo
//sort array of strings from shortest to longest
//return sorted array. 

//using System;
//using System.Linq;
//using System.Collections;
//using System.Net.WebSockets;
//using System.Collections.ObjectModel;
//using System.Reflection;
//using System.Collections.Generic;
//public class Kata
//{
//    public static string[] SortByLength(string[] array)
//    {
//        Array.Sort(array, (x, y) => x.Length.CompareTo(y.Length));
//        return array;
//    }
//}
// new kata grasshopper summation
//algo
//

//using System;
//using System.Reflection.Metadata.Ecma335;

//using System.Linq;
//using System.Collections;
//using System.Net.WebSockets;
//using System.Collections.ObjectModel;
//using System.Reflection;
//using System.Collections.Generic;
//public static class Kata
//{
//    public static int summation(int num)
//    {       
//        var numberList = new List<int>();

//        for (int i = 0; i <= num; i++)
//        {
//            numberList.Add(i);  
//        }
//        return numberList.Sum();
//    }
//}

// kata century from year. 
//given a year, return the century it's in.


// years by 100 = century solved


//public static class Kata
//{
//    public static int СenturyFromYear(int year)
//    {
//        if (year % 100 > 0) 
//            return (year / 100);
//        else return (year / 100) + 1;
//    }
//}
// another solution
//public static class Kata
//{
//    public static int СenturyFromYear(int year) => (year + 99) / 100;
//}
// new kata convert a number to a string solved
//
//using System;
//public class Kata
//{
//    public static int StringToNumber(String str)
//    {
//        return Convert.ToInt32(str);
//    }
//}

// new kata counting sheep

// Consider an array/list of sheep where some sheep may be missing from their place.
// We need a function that counts the number of sheep present in the array (true means present).
//Hint: Don't forget to check for bad values like null/undefined

//algo
//if null / undefined, handle... how??

//


//solved
//using System;

//public static class Kata
//{
//    public static int CountSheeps(bool[] sheeps)
//    {
//        int sheepCount = 0;
//        foreach (var sheep in sheeps)
//        {
//            if (sheep == true)
//            {
//                sheepCount ++;
//            }           
//        }
//        return sheepCount;
//    }
//}

// another solution - how does this work?
//using System;
//using System.Linq;

//public static class Kata
//{
//    public static int CountSheeps(bool[] sheeps)
//    {
//        return sheeps.Count(s => s);
//    }
//}
//another
//using System;
//using System.Linq;

//public static class Kata
//{
//    public static int CountSheeps(bool[] sheeps)
//    {
//        return (int)sheeps.Count(x => x == true);
//    }
//}

//new kata
// Convert number to reversed array of digits

//Convert number to reversed array of digits
//Given a random non-negative number, you have to return 
//    the digits of this number within an array in reverse order.

//using System;
//using System.Collections.Generic;

//namespace Solution
//{
//    class Digitizer
//    {
//        public static long[] Digitize(long n)
//        {

//            var nonsense = n.ToString();
//            long[] newList = n.ToString
//                .ToArray();
//                Array.Reverse(n);
//            foreach (var num in collection)
//            {

//            }
//           return n.ToArray();

//            .select
//                StringToArray();


//                }
//    }
//}

//string FizzBuzzChallenge(int fBChk)
//{
//    if (fBChk % 3 == 0) return "fizz";
//    if (fBChk % 5 == 0) return "buzz";
//    if (fBChk % 3 == 0 && fBChk % 5 == 0) return "fizzbuzz";
//    else return null;
//}

///working solution below
//using System.Linq;
//namespace Solution
//{
//    public static class ArraysInversion
//    {
//        public static int[] InvertValues(int[] input)
//        {            
//            for (int i = 0; i < input.Length; i++)
//            {
//             input[i] *= -1;
//            }
//            return input;            
//        }
//    }
//}

//using System.Linq;
//namespace Converter
//{
//    public class Converter
//    {
//        public string dnaToRna(string dna)
//        {
//            foreach (var c in dna)
//            {
//                if (c == 'U')
//                {
//                    dna.Replace('U', 'T');
//                }
//                else
//                {
//                    dna.Replace('T', 'U');
//                }
//                //    : 'U';
//                //if (c == 'U')
//                //{

//                //}

//            }
//            return dna;
//        }
//    }
//}
//public class Kata
//{
//    public static int Grow(int[] x)
//    {

//        foreach (var i in x)
//        {
//            i * [i]++;
//        }
//        return x.Sum();
//    }
//}
//using System.Linq;
//grasshopper personalized message
public class Kata
{
    public static string Greet(string name, string owner)
    {
        return name == owner ? "Hello boss" : "Hello guest";        
    }
}