using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.RegularExpressions;

namespace CodeWars
{
   public class Program
   {
      public static void Main(string[] args)
      {
         int[] vs = {-2, -1, 0, 1, 2, 3, 4, 5, 6, 7, 8 };
         string[] array = { "first", "second", "third", "forth" };

         Console.WriteLine(Greet("Dan", "Dan"));

         Console.WriteLine(DoubleChar("Hello"));
         Console.WriteLine(Max(vs));
         Console.WriteLine(Min(vs));
         Console.WriteLine(ReverseWords("Testing Words"));
         Console.WriteLine(Reverse("Testing Words"));
         Console.WriteLine(SumArray(vs));
         Console.WriteLine(CountPositivesSumNegatives(vs).ToString());

         Console.WriteLine(IsPangram("The quick brown fox jumps over the lazy dog"));
         Console.WriteLine(IsIsogram("aba"));
         Console.WriteLine(Problem("1"));
         Console.WriteLine(Between(1, 4));
         Console.WriteLine(SortByLength(array));
         Console.WriteLine(GetDrinkByProfession("programmer"));
         Console.WriteLine(Shortcut("codewars"));
         Console.WriteLine(IsEven(4));
         Console.WriteLine(IsSortedAndHow(vs));
         ChristmasTree();
         Console.WriteLine(ValidPhoneNumber("+48 592-045-990"));
         Console.WriteLine(Capitalized("Use Of Technology"));
         Console.WriteLine(Capitalized("Rocket science"));
         Console.WriteLine(NumbersMultipication(1, 5));
         Console.WriteLine(HowManyOccurrences("do it now do", "do"));
      }
      public static string DoubleChar(string s)
      {
         // your code here
         return string.Join("", s.Select(x => "" + x + x));
      }

      public static string MouthSize(string animal)
      {
         return (animal.ToLower() == "alligator") ? "small" : "wide";
      }

      /*determine if the number passed in is even or not, returning true or false*/
      public static bool IsEven(double n)
      {
         return (n % 2 == 0) ? true : false;
      }

      public static int Max(int[] list)
      {
         return list.Max();
      }
      public static int Min(int[] list) => list.Min();

      public static string Greet(string name, string owner)
      {
         if (name == owner)
         {
            return "Hello boss";
         }
         return "Hello guest";

      }

      /*Complete the function that accepts a string parameter, and reverses each word in the string. All spaces in the string should be retained.*/
      public static string ReverseWords(string str)
      {
         return string.Join(" ", str.Split(' ').Select(i => new string(i.Reverse().ToArray())));
      }

      /*You need to write a function that reverses the words in a given string. A word can also fit an empty string.*/
      public static string Reverse(string text)
      {
         return string.Join(" ", text.Split(' ').Reverse().ToArray());
      }

      /*Write a function that takes an array of numbers and returns the sum of the numbers.*/
      public static int SumArray(int[] array)
      {
         return array.Sum();
      }


      /*Return an array, where the first element is the count of positives numbers and the second element is sum of negative numbers.
         0 is neither positive nor negative.
         If the input array is empty or null, return an empty array.*/
      public static int[] CountPositivesSumNegatives(int[] input)
      {
         if (input == null || !input.Any())
         {
            return new int[] { };
         }

         int countPositives = input.Count(n => n > 0);
         int sumNegatives = input.Where(n => n < 0).Sum();

         return new int[] { countPositives, sumNegatives };
      }

      /*A pangram is a sentence that contains every single letter of the alphabet at least once.For example, 
         the sentence "The quick brown fox jumps over the lazy dog" is a pangram, because it uses the letters
         A-Z at least once(case is irrelevant).*/
      public static bool IsPangram(string str)
      {
         str = str.ToLower();

         for (char letter = 'a'; letter <= 'z'; letter++)
         {
            if (str.IndexOf(letter) == -1) return false;
         }
         return true;
      }

      /*An isogram is a word that has no repeating letters, consecutive or non-consecutive. Implement a function that
       determines whether a string that contains only letters is an isogram. Assume the empty string is an isogram. Ignore letter case.*/
      public static bool IsIsogram(string str)
      {
         return str.ToUpper().Distinct().Count() == str.Length;
      }

      /*Make a function that returns the value multiplied by 50 and increased by 6. If the value entered is a string it should return "Error".*/
      public static string Problem(string a)
      {
         try
         {
            return (Double.Parse(a) * 50 + 6).ToString();
         }
         catch
         {
            return "Error";
         }
      }

      /*Complete the function that takes two integers (a, b, where a < b) and return an array of all integers between the input parameters, 
       * including them.*/
      public static int[] Between(int a, int b)
      {
         // your code here
         List<int> result = new List<int>();
         for(int i = a; i <= b; i++)
         {
            result.Add(i); 
         }
         return result.ToArray();
      }

      /*Write a function that takes an array of strings as an argument and returns a sorted array containing the same strings,
       * ordered from shortest to longest.*/
      public static string[] SortByLength(string[] array)
      {
         return array.OrderBy(x => x.Length).ToArray();
      }

      /*Complete the function that receives as input a string, and produces outputs according to the following table:*/
      public static string GetDrinkByProfession(string p)
      {
         switch (p.ToLower())
         {
            case "jabroni": return "Patron Tequila";
            case "school counselor": return "Anything with Alcohol";
            case "programmer": return "Hipster Craft Beer";
            case "bike gang member": return "Moonshine";
            case "politician": return "Your tax dollars";
            case "rapper": return "Cristal";
            default: return "Beer";
         }
      }

      /*Create a function called shortcut to remove the lowercase vowels(a, e, i, o, u ) in a given string.*/
      public static string Shortcut(string input)
      {
         return Regex.Replace(input, "[aeiou]", "");
      }

      /*Take a list of ages when each of your great-grandparent died.
         Multiply each number by itself.
         Add them all together.
         Take the square root of the result.
         Divide by two.*/
      public static int PredictAge(params int[] ages)
      {
         return (int)Math.Sqrt(ages.Sum(x => x * x)) / 2;
      }

      /*You are given an array with positive numbers and a non-negative number N.You should find the N-th power of the element 
         in the array with the index N.If N is outside of the array, then return -1. Don't forget that the first element has the index 0.*/
      public static double Index(int[] array, int n)
      {
         return (n >= array.Length) ? -1 : Math.Pow(array[n], n);
      }

      /*Complete the method which accepts an array of integers, and returns one of the following:*/
      public static string IsSortedAndHow(int[] array)
      {
         if (array.SequenceEqual(array.OrderBy(x => x)))
            return "yes, ascending";
         if (array.SequenceEqual(array.OrderByDescending(x => x)))
            return "yes, descending";
         return "no";
      }

      /*public static string[] SortByAlphabetical(string[] array)
      {
         string[] a = new string[]
         {
            "Egyptian",
            "Indian",
            "American"
         };
         return Array.Sort(array).ToArray();
      }*/

      // // create a function that takes a list of non-negative integers and strings and returns a new list with the strings filtered out.
      public static int[] FilterArray(object[] array)
      {
         return array.OfType<int>().ToArray();
      }
      //Find the length of the longest substring in the given string s that is the same in reverse.
      public static int GetLongestPalindrome(string s)
      {
         if (s.Length == 0)
         {
            return 0;
         }
         int longest = 0;
         for (int i = 0; i < s.Length; i++)
         {
            for (int j = i + 1; j <= s.Length; j++)
            {
               string sub = s.Substring(i, j - i);
               if (sub == new string(sub.Reverse().ToArray()))
               {
                  if (sub.Length > longest)
                  {
                     longest = sub.Length;
                  }
               }
            }
         }
         return longest;
      }



      // Given an array (arr) as an argument complete the function countSmileys that should return the total number of smiling faces.
      // Rules for a smiling face: Each smiley face must contain a valid pair of eyes. Eyes can be marked as : or ;
      /*A smiley face can have a nose but it does not have to.Valid characters for a nose are - or ~
     Every smiling face must have a smiling mouth that should be marked with either ) or D
   No additional characters are allowed except for those mentioned.*/
      public static int CountSmileys(string[] arr)
      {
         int count = 0;
         for (int i = 0; i < arr.Length; i++)
         {
            if (arr[i].Length == 2)
            {
               if (arr[i][0] == ':' || arr[i][0] == ';')
               {
                  if (arr[i][1] == ')' || arr[i][1] == 'D')
                  {
                     count++;
                  }
               }
            }
            else if (arr[i].Length == 3)
            {
               if (arr[i][0] == ':' || arr[i][0] == ';')
               {
                  if (arr[i][1] == '-' || arr[i][1] == '~')
                  {
                     if (arr[i][2] == ')' || arr[i][2] == 'D')
                     {
                        count++;
                     }
                  }
               }
            }
         }
         return count;
      }


      // Create a function to multiply all of the values in an array by the amount of values in the given array.
      public static int[] MultiplyAll(int[] arr, int[] arr2)
      {
         int[] newArr = new int[arr.Length];
         for (int i = 0; i < arr.Length; i++)
         {
            newArr[i] = arr[i] * arr2[i];
         }
         return newArr;
      }

      // Create a function that accepts a string (of a person's first and last name) and returns a string with the first and last name swapped.
      public static string SwapName(string name)
      {
         string[] splitName = name.Split(' ');
         string firstName = splitName[1];
         string lastName = splitName[0];
         return lastName + " " + firstName;
      }

      // Complete the function which converts hex number (given as a string) to a decimal number.
      public static int HexToDec(string hex)
      {
         int dec = 0;
         for (int i = 0; i < hex.Length; i++)
         {
            if (hex[i] == 'A')
            {
               dec += 10 * (int)Math.Pow(16, hex.Length - i - 1);
            }
            else if (hex[i] == 'B')
            {
               dec += 11 * (int)Math.Pow(16, hex.Length - i - 1);
            }
            else if (hex[i] == 'C')
            {
               dec += 12 * (int)Math.Pow(16, hex.Length - i - 1);
            }
            else if (hex[i] == 'D')
            {
               dec += 13 * (int)Math.Pow(16, hex.Length - i - 1);
            }
            else if (hex[i] == 'E')
            {
               dec += 14 * (int)Math.Pow(16, hex.Length - i - 1);
            }
            else if (hex[i] == 'F')
            {
               dec += 15 * (int)Math.Pow(16, hex.Length - i - 1);
            }
            else
            {
               dec += (int)hex[i] * (int)Math.Pow(16, hex.Length - i - 1);
            }
         }
         return dec;
      }

      //Implement a function that adds two numbers together and returns their sum in binary. The conversion can be done before, or after the addition.
      public static string AddBinary(int a, int b)
      {
         string binary = "";
         int sum = a + b;
         while (sum > 0)
         {
            binary = (sum % 2).ToString() + binary;
            sum /= 2;
         }
         return binary;
      }

      // Given an array of ones and zeroes, convert the equivalent binary value to an integer.
      public static int BinaryArrayToNumber(int[] arr)
      {
         int sum = 0;
         for (int i = 0; i < arr.Length; i++)
         {
            sum += arr[i] * (int)Math.Pow(2, arr.Length - i - 1);
         }
         return sum;
      }

      // Remove all exclamation marks from the end of sentence.
      public static string Remove(string s)
      {
         while (s[s.Length - 1] == '!')
         {
            s = s.Remove(s.Length - 1);
         }
         return s;
      }
      // another way to do it
      //return s.TrimEnd('!');

      //Count the number of divisors of a positive integer n.
      public static int CountDiv(int n)
      {
         int count = 0;
         for (int i = 1; i <= n; i++)
         {
            if (n % i == 0)
            {
               count++;
            }
         }
         return count;
      }


      // Return a new array consisting of elements which are multiple of their own index in input array (length > 1).
      public static List<int> MultipleOfIndex(List<int> xs)
      {
         List<int> newList = new List<int>();
         for (int i = 0; i < xs.Count; i++)
         {
            if (xs[i] % i == 0)
            {
               newList.Add(xs[i]);
            }
         }
         return newList;
      }

      // Given a year, return the century it is in.
      public static int GetCentury(int year)
      {
         return year / 100 + 1;
      }

      // Given a string, return the character that is most common in the string.
      public static char GetMostCommonCharacter(string s)
      {
         Dictionary<char, int> charCount = new Dictionary<char, int>();
         foreach (char c in s)
         {
            if (charCount.ContainsKey(c))
            {
               charCount[c]++;
            }
            else
            {
               charCount.Add(c, 1);
            }
         }
         int max = 0;
         char mostCommon = ' ';
         foreach (KeyValuePair<char, int> kvp in charCount)
         {
            if (kvp.Value > max)
            {
               max = kvp.Value;
               mostCommon = kvp.Key;
            }
         }
         return mostCommon;
      }

      // Given a string, return a string in which each character is repeated once.
      public static string DoubleChar2(string str)
      {
         string newStr = "";
         foreach (char c in str)
         {
            newStr += c + c;
         }
         return newStr;
      }

      // Given an integer as input, can you round it to the next (meaning, "higher") multiple of 5?
      public static int RoundToNext5(int n)
      {
         if (n % 5 == 0)
         {
            return n;
         }
         else
         {
            return n + 5 - n % 5;
         }
      }

      // Given a non-negative integer n, write a function to_binary/ToBinary which returns that number in a binary format.
      public static string ToBinary(int n)
      {
         string binary = "";
         while (n > 0)
         {
            binary = (n % 2).ToString() + binary;
            n /= 2;
         }
         return binary;
      }

      // Write a function that takes a single string (word) as argument. The function must return an ordered list containing the indexes of all capital letters in the string.
      public static List<int> Capitals(string word)
      {
         List<int> capitals = new List<int>();
         for (int i = 0; i < word.Length; i++)
         {
            if (char.IsUpper(word[i]))
            {
               capitals.Add(i);
            }
         }
         return capitals;
      }

      // Given an array of integers, find the one that appears an odd number of times.
      public static int find_it(int[] seq)
      {
         int count = 0;
         for (int i = 0; i < seq.Length; i++)
         {
            for (int j = 0; j < seq.Length; j++)
            {
               if (seq[i] == seq[j])
               {
                  count++;
               }
            }
            if (count % 2 != 0)
            {
               return seq[i];
            }
            count = 0;
         }
         return 0;
      }

      // What if we need the length of the words separated by a space to be added at the end of that same word and have it returned as an array?
      public static string[] AddLength(string str)
      {
         string[] words = str.Split(' ');
         for (int i = 0; i < words.Length; i++)
         {
            words[i] = words[i] + " " + words[i].Length;
         }
         return words;
      }

      // Define a function that removes duplicates from an array of numbers and returns it as a result.
      public static int[] RemoveDuplicates(int[] arr)
      {
         List<int> newList = new List<int>();
         for (int i = 0; i < arr.Length; i++)
         {
            if (!newList.Contains(arr[i]))
            {
               newList.Add(arr[i]);
            }
         }
         return newList.ToArray();
         // another way to do it
         //return arr.Distinct().ToArray();
      }

      // Given an array of integers, return the difference between the largest and smallest integers in the array.
      public static int LargestSmallest(int[] arr)
      {
         int min = arr[0];
         int max = arr[0];
         for (int i = 1; i < arr.Length; i++)
         {
            if (arr[i] < min)
            {
               min = arr[i];
            }
            if (arr[i] > max)
            {
               max = arr[i];
            }
         }
         return max - min;
      }

      // Create a function which translates a given DNA string into RNA.
      public static string DNAtoRNA(string dna)
      {
         return dna.Replace("T", "U");
      }

      // Each number should be formatted that it is rounded to two decimal places.
      public static double TwoDecimalPlaces(double number)
      {
         return Math.Round(number, 2);
      }

      // Find the total sum of internal angles (in degrees) in an n-sided simple polygon. N will be greater than 2.
      public static int PolygonAngles(int n)
      {
         return (n - 2) * 180;
      }

      // Given an array of integers , Find the maximum product obtained from multiplying 2 adjacent numbers in the array.
      public static int MaxProduct(int[] numbers)
      {
         int max = numbers[0] * numbers[1];
         for (int i = 0; i < numbers.Length - 1; i++)
         {
            if (numbers[i] * numbers[i + 1] > max)
            {
               max = numbers[i] * numbers[i + 1];
            }
         }
         return max;
      }


      // Write a program that finds the summation of every number from 1 to num. The number will always be a positive integer greater than 0.
      public static int Summation(int num)
      {
         int sum = 0;
         for (int i = 1; i <= num; i++)
         {
            sum += i;
         }
         return sum;
      }

      // Write a simple regex to validate a username. Allowed characters are:
      // all lowercase letters,
      //numbers,
      //underscore
      //Length should be between 4 and 16 characters(both included).
      public static bool ValidUsername(string username)
      {
         return Regex.IsMatch(username, @"^[a-z0-9_]{4,16}$");
      }


      // Write a regex to count the number of lowercase letters in a string
      public static int CountLowercase(string str)
      {
         return Regex.Matches(str, @"[a-z]").Count;
      }

      // Basic regex tasks. Write a function that takes in a numeric code of any length. The function should check if the code begins with 1, 2, or 3 and return true if so. Return false otherwise.
      public static bool ValidCode(string code)
      {
         return Regex.IsMatch(code, @"^[1-3]");
      }

      // create a function that takes a list of non-negative integers and strings and returns a new list with the strings filtered out.
      public static List<int> FilterList(List<object> list)
      {
         List<int> newList = new List<int>();
         for (int i = 0; i < list.Count; i++)
         {
            if (list[i] is int)
            {
               newList.Add((int)list[i]);
            }
         }
         return newList;
      }

      //Find the mean (average) of a list of numbers in an array.
      public static double Mean(int[] numbers)
      {
         int sum = 0;
         for (int i = 0; i < numbers.Length; i++)
         {
            sum += numbers[i];
         }
         return sum / numbers.Length;
      }

      // Your car is old, it breaks easily. The shock absorbers are gone and you think it can handle about 15 more bumps before it dies totally.
      // Unfortunately for you, your drive is very bumpy! Given a string showing either flat road("_") or bumps("n"),
      // work out if you make it home safely. 15 bumps or under, return "Woohoo!", over 15 bumps return "Car Dead".
      public static string Bumps(string bumps)
      {
         int bumpCount = 0;
         for (int i = 0; i < bumps.Length; i++)
         {
            if (bumps[i] == 'n')
            {
               bumpCount++;
            }
         }
         if (bumpCount <= 15)
         {
            return "Woohoo!";
         }
         else
         {
            return "Car Dead";
         }
      }

      // Your task is to write function findSum.
      // Upto and including n, this function will return the sum of all multiples of 3 and 5. 
      // For example: findSum(5) should return 8 (3 + 5)
      public static int FindSum(int n)
      {
         int sum = 0;
         for (int i = 0; i <= n; i++)
         {
            if (i % 3 == 0 || i % 5 == 0)
            {
               sum += i;
            }
         }
         return sum;
      }

      // Write a function which takes a list of strings and returns each line prepended by the correct number.
      // The numbering starts at 1. The format is n: string. Notice the colon and space in between.
      public static List<string> Number(List<string> strings)
      {
         List<string> newList = new List<string>();
         for (int i = 0; i < strings.Count; i++)
         {
            newList.Add((i + 1) + ": " + strings[i]);
         }
         return newList;
      }

      // Write a function named sumDigits which takes a number as input and returns the sum of the absolute value of each of the number's decimal digits.
      public static int SumDigits(int number)
      {
         int sum = 0;
         while (number != 0)
         {
            sum += Math.Abs(number % 10);
            number /= 10;
         }
         return sum;
      }

      // Given an array of positive digits, write a method that returns number of times that two 7's are next to each other in an array.
      public static int Sevens(int[] numbers)
      {
         int count = 0;
         for (int i = 0; i < numbers.Length - 1; i++)
         {
            if (numbers[i] == 7 && numbers[i + 1] == 7)
            {
               count++;
            }
         }
         return count;
      }

      // Write a method that draws Christmas tree shape with * characters. 

      public static void ChristmasTree()
      {
         for (int i = 0; i < 3; i++)
         {
            for (int j = 0; j < 7 - i; j++)
            {
               Console.Write(" ");
            }
            for (int k = 0; k < i * 2 + 1; k++)
            {
               Console.Write("*");
            }
            Console.WriteLine();
         }
      }

      // Given a phone number as a string, write a method that checks if it is in the format +XX YYY-YYY-YYY.
      public static bool ValidPhoneNumber(string phoneNumber)
      {
         return Regex.IsMatch(phoneNumber, @"^\+\d{2}\s(\d{3}\-){2}(\d{3})");
      }

      // Given a string, write a  Regex method that checks if every word begins with capital letter.
      public static bool Capitalized(string str)
      {
         return Regex.IsMatch(str, @"^([A-Z]\w*\s*)+\W*$");
      }

      // Given two integers a and b (a <= b) as range, write a method that returns multiplication of numbers from given range.
      public static int NumbersMultipication(int from, int to)
      {
         while (from == to)
         {
            return from;
         }
         return from * NumbersMultipication(from + 1, to);
      }

      // Given a string and substring, write a method that returns number of occurrences of substring in the string.
      // Assume that both are case-sensitive.
      public static int HowManyOccurrences(string str, string subStr)
      {
         int found;
         int total = 0;
         for (int i = 0; i < str.Length; i++)
         {
            found = str.IndexOf(subStr, i);

            if (found > -1)
            {
               total++;
               i = found;
            }
         }

         return total;
      }

      //A single line to be taken as input and save it into a variable of your choice.
      // Print 'Hello Techgig' and then content of the variable on another line. 
      public static void HelloTechgig()
      {
         string str = Console.ReadLine();
         Console.WriteLine("Hello Techgig");
         Console.WriteLine(str);
      }

      // Given a sequence of numbers, find the largest pair sum in the sequence.
      public static int LargestPairSum(int[] numbers)
      {
         return numbers
            .OrderByDescending(n => n)
            .Take(2)
            .Sum();
      }

      // Time to test your basic knowledge in functions! Return the odds from a list:
      public static List<int> Odds(List<int> values) =>
         values.Where(n => n % 2 == 1).ToList();

      // Your task is to make function, which returns the sum of a sequence of integers.
      // The sequence is defined by 3 non-negative values: begin, end, step(inclusive).
      // If begin value is greater than the end, function should returns 0
      public static int Sum(int begin, int end, int step)
      {
         if (begin > end)
         {
            return 0;
         }
         else
         {
            return begin + Sum(begin + step, end, step);
         }
      }

      // Your function receives one side of the DNA (string, except for Haskell); you need to return the other complementary side
      // (string).
      // DNA strand is a string containing only C, G, A and T.
      // Complementary strand is a string containing only G, C, T and A.
      // Both strands must be of equal length.
      public static string ComplementaryStrand(string dna)
      {
         string complementary = "";
         for (int i = 0; i < dna.Length; i++)
         {
            if (dna[i] == 'A')
            {
               complementary += "T";
            }
            else if (dna[i] == 'T')
            {
               complementary += "A";
            }
            else if (dna[i] == 'G')
            {
               complementary += "C";
            }
            else if (dna[i] == 'C')
            {
               complementary += "G";
            }
         }
         return complementary;
      }


      // Given a string, return a new string made of every other char starting with the first, so "Hello" yields "Hlo".
      public static string EveryOther(string str)
      {
         string everyOther = "";
         for (int i = 0; i < str.Length; i += 2)
         {
            everyOther += str[i];
         }
         return everyOther;
      }

      // Two red beads are placed between every two blue beads. There are N blue beads. After looking at the arrangement below work out the number of red beads.
      public static int RedBeads(int n)
      {
         if (n < 2)
         {
            return 0;
         }
         return (n - 1) * 2;
      }

      // Write a function which removes from string all non-digit characters and parse the remaining to number. E.g: "hell5o wor6ld" -> 56
      public static int NonDigitsToNumber(string str)
      {
         return int.Parse(Regex.Replace(str, @"[^\d]", ""));
      }




   }
}
