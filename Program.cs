using Microsoft.VisualBasic.CompilerServices;
using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.Design.Serialization;
using System.Globalization;
using System.Linq;
using System.Numerics;
using System.Reflection.Metadata.Ecma335;
using System.Runtime.CompilerServices;
using System.Threading;

namespace UpdatedTechQuestionsPractice
{
    class Program
    {
        static void Main(string[] args)
        {
           // string strToReverse = "reverse me";
           // ReverseString(strToReverse);

           // int[] singleNumber = { 2, 2, 1 };
           // FindSingleNumInArray(singleNumber);

           // int num = 2;
           // FizzBuzz(num);

           // int[] intArr1 = { 1, 2, 3, 4, 5, 6, 7, 8, 2, 2, 2 };
           // int x = 2;
           // ReturnElementThatOccursTheMost(intArr1, x);

           // int[] nums2 = { 0, 1, 0, 3, 12 };
           // MoveZerosToEndPreservingArrayOrder(nums2);

           // MaxDepthBinaryTree();

           // CreateLinkedList();

           // reverse linked list
           //LinkedList list = new LinkedList();
           // ReverseLinkedList(list);

           // string str = "rt";
           // string str1 = "atr";
           // ValidAnagram(str, str1);

           // int[] iA1 = { 1, 2, 3, 4, 5 };
           // int[] iA2 = { 1, 2, 3, 4, 5, 5 };

        }
        public static string ReverseString(string str)
        {
            // take string and reverse it, we can do this by converting string to charArray
            char[] charArr = str.ToCharArray();

            // reverse array
            Array.Reverse(charArr);

            // print array in reverse
            Console.WriteLine(charArr);
            return str;

        }
        public static int FindSingleNumInArray(int[] nums)
        {
            // given a non-empty array of ints, every element appears twice except for one.
            // find the element that only appears once

            // variable to hold value of first nums element
            int singleNum = nums[0];
            // checks to see if length of nums[] is greater than one, if its not, we already know the single value
            if (nums.Length > 1)
            {
                // iterates through loop
                for (int i = 0; i <= nums.Length - 2; i++)
                {
                    singleNum = singleNum ^ nums[i + 1];
                }
            }
            Console.WriteLine(singleNum);


            return nums[0];
        }
        public static int FizzBuzz(int num)
        {
            // calculate if num is divisible by 5 AND 3, just 5, or just 3
            if (num % 5 == 0 && num % 3 == 0)
            {
                Console.WriteLine("Divisible by 5 and 3");
            }
            else if (num % 5 == 0 && num % 3 != 0)
            {
                Console.WriteLine("Divisible by 5 and NOT 3");
            }
            else if (num % 5 != 0 && num % 3 == 0)
            {
                Console.WriteLine("Divisible by 3 and NOT 5");
            }
            else if (num % 5 != 0 && num % 3 != 0)
            {
                Console.WriteLine("Not divisible by 3 or 5");
            }
            return num;
        }
        public static int ReturnElementThatOccursTheMost(int[] intArr1, int x)
        {
            // should return num 2
            // need to count the occurance of matching elements
            // we can do this by iterating over each element in the array and counting them
            int count = 0;

            for (int i = 0; i < intArr1.Length; i++)
            {
                if (x == intArr1[i])
                {
                    count++;

                }
                Console.WriteLine(count);

            }


            return intArr1[0];
        }
        public static int MoveZerosToEndPreservingArrayOrder(int[] nums)
        {
            // maybe do this by iterating through and counting number of 0s
            // removing zeros from array
            // create new array and append number of zeros to the end


            // iterate through array and count number of zeros
            int NumZeros = 0;
            for (int i = 0; i < nums.Length; i++)
            {
                if (nums[i] == 0)
                {
                    NumZeros++;
                }
            }

            for (int i = 0; i < nums.Length; i++)
            {
                if (nums[i] != 0)
                {

                }
            }
            Console.WriteLine("Number of zeros is: " + (NumZeros));

            // create array and remove zeros







            return nums[0];
        }
        public static void CreateLinkedList()
        {
            // create linked list
            string[] words = { "the", "fox", "jumps", "over" };
            LinkedList<string> sentence = new LinkedList<string>(words);

            // display elements in linkedList
            foreach (string word in words)
            {
                Console.WriteLine(word + " ");
            }

            Console.WriteLine(sentence.Count);
        }
        public static void ReverseLinkedList(LinkedList list)
        {
            list.AddNode(new LinkedList.Node(1));
            list.AddNode(new LinkedList.Node(3));
            list.AddNode(new LinkedList.Node(2));
            list.AddNode(new LinkedList.Node(7));
            list.AddNode(new LinkedList.Node(5));
            list.AddNode(new LinkedList.Node(9));

            list.PrintList();
            list.ReverseList();
            list.PrintList();
        }
        public static void DeleteNodeInLinkedList(LinkedList list)
        {
            list.DeleteNode();
        }
        public static void ValidAnagram(string s, string t)
        {
            // conv to charArray to sort
            char[] str1 = s.ToCharArray();
            char[] str2 = t.ToCharArray();
            // sort charArrays
            Array.Sort(str1);
            Array.Sort(str2);
            // conv back to string to check for equality
            string s1 = new string(str1);
            string t1 = new string(str2);

            if (s.Length != t.Length)
            {
                Console.WriteLine("No");
            }
            else if (s1 == t1)
            {
                Console.WriteLine("yes");
            }
            else
            {
                Console.WriteLine("NO");
            }    
        }
        public static void ReturnTotalNumberOfEvenElementsInArray(int[] numbers)
        {
            int totalEven = 0;
            // iterate through array and add if number is even
            for (int i = 0; i < numbers.Length; i++)
            {
                if (numbers[i] % 2 == 0)
                {
                    totalEven++;
                }
            }
            Console.WriteLine(totalEven);

        }
        public static void ReturnFirstIndexOfCharInString(string str)
        {
            Console.WriteLine("Enter a letter to find the first index of: ");
            int index = str.IndexOf(Console.ReadLine());
            Console.WriteLine(index);

        }
        public static void SingleNumber(int[] number) // returns the number that occurs the most
        {
            var dict = new Dictionary<int, int>();

            foreach (int n in number)
            {
                if (!dict.ContainsKey(n))
                {
                    dict[n] = 0;
                }
                else
                {
                    dict[n]++;
                }
            }

            foreach (var pair in dict)
            {
                if (pair.Value > 1)
                {
                    Console.WriteLine(pair.Key);
                }

            }
        }
        public static bool IsPermutation(string str1, string str2)
        {
            // Convert string to charArray and sort by character
            char[] char1 = str1.ToCharArray();
            char[] char2 = str2.ToCharArray();
            Array.Sort(char1);
            Array.Sort(char2);

            if (char1.Length != char2.Length)
            {
                Console.WriteLine("Not Permutation");
            }
            else if (char1.Length == char2.Length)
            {
                for (int i = 0; i < char1.Length; i++)
                {
                    // compare sorted char[] to see if they have same elements
                    if (char1[i] == char2[i])
                    {
                    }
                }
                Console.WriteLine("Permutation");
            }
            return true;
        }
        public static string CompressBad(string str) // returns a compressed string so aabcccccaaa would be a2b1c5a2
        {
            string compressedString = "";
            int countConsecutive = 0;

            for (int i = 0; i < str.Length; i++)
            {
                countConsecutive++;

                if (i + 1 >= str.Length || str[i] != str[i + 1])
                {
                    compressedString += "" + str[i] + countConsecutive;
                    countConsecutive = 0;
                }
            }
            Console.WriteLine(compressedString);
            return compressedString.Length < str.Length ? compressedString : str;
        }
        public static void PrintSumIntArray()
        {
            int[] nums = { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };
            int sum = 0;

            for (int i = 0; i < nums.Length; i++)
            {
                // Add value of num element i to sum variable
                sum += nums[i];
            }
            Console.WriteLine(sum);

        }
        public static void CharIndex() // pidk what this does
        {
            string searchString = "980";
            string s1 = "1234567890";

            Console.WriteLine(s1.IndexOf(searchString, 2));

        }
        public static string RemoveSpecialCharacter(string str)
        {
            // create string array named chars to hold all special characters we want to remove
            string[] chars = new string[] { ",", ".", "/", "!", "@", "#", "$", "%", "^", "&", "*", "'", "\"", ";", "_", "(", ")", ":", "|", "[", "]" };
            // for each string t in char array
            foreach (string t in chars)
            {
                //if str contains string t
                if (str.Contains(t))
                {
                    // str = str replace string with empty string
                    str = str.Replace(t, "");
                }
            }
            return str;
        }
        public static void NumberOccurancesOfEachCharacter()
        {
            string input = "joshstaraitisnumberofuccurances";
            // while input length is greater than 0
            while (input.Length > 0)
            {
                // write input[char object at specified position in string object]
                Console.Write(input[0] + " : ");
                // counter for loop
                int count = 0;
                // foreach var t (char) in input
                foreach (var t in input)
                {
                    // if input[char object location] is equal to t
                    if (input[0] == t)
                    {
                        //increment counter
                        count++;
                    }
                }
                Console.WriteLine(count);
                // input = input replace old input[char object location] with new empty string
                input = input.Replace(input[0].ToString(), string.Empty);
            }

        }
        public static char FirstNonRepeatedChar(string input)
        {
            bool isDuplicate;
            for (int i = 0; i < input.Length; i++)
            {
                isDuplicate = false;
                for (int j = 0; j < input.Length; j++)
                {
                    if ((input[i] == input[j]) && i != j)
                    {
                        isDuplicate = true;
                        break;
                    }
                }
                if (!isDuplicate)
                {
                    return input[i];
                }
            }
            return default(char);
        }
        public static void ExtractAllSubstring()
        {
            Console.WriteLine("Enter a name");
            string value = Console.ReadLine();
            //string value = "enter a name";
            for (int length = 1; length < value.Length; length++)
            {
                for (int start = 0; start <= value.Length - length; start++)
                {
                    string substring = value.Substring(start, length);
                    Console.WriteLine(substring);
                }
            }
        }
        public static string Replace(string x)
        {
            x = x.Trim();
            x = x.Replace(" ", "*");
            return x;
        }
        public static bool IsUnique(string s) // checks to see if dictionary is all unique characters?
        {
            // using dictionary
            Dictionary<char, int> d = new Dictionary<char, int>();

            foreach (char c in s)
            {
                if (d.ContainsKey(c))
                    return false;
                else
                    d.Add(c, 1);
            }
            return true;
        }
        public static bool IsUnique1(string s)
        {
            string temp1 = "";
            string temp2 = "";

            for (int i = 0; i < s.Length; i++)
            {
                temp1 = s.Substring(i, 1);
                for (int k = 0; k < s.Length; k++)
                {
                    temp2 = s.Substring(k, 1);
                    if ((temp1 == temp2) && (i != k))
                        return false;
                }
            }
            return true;
        }
        public static char MostOccurringCharInString(string charString)
        {
            int totalOccurance = -1;
            char mostOccurringChar = ' ';
            foreach (char currentChar in charString)
            {
                int totalFoundOccurance = 0;
                foreach (char charToBeMatch in charString)
                {
                    if (currentChar == charToBeMatch)
                        totalFoundOccurance++;
                }
                if (totalOccurance < totalFoundOccurance)
                {
                    totalOccurance = totalFoundOccurance;
                    mostOccurringChar = currentChar;
                }
            }
            return mostOccurringChar;
        }
        public static void StringPalindrome()
        {
            Console.WriteLine("enter word");
            string word = Console.ReadLine();

            // convert word to charArray
            var array = word.ToCharArray();
            // reverse charArray
            Array.Reverse(array);
            // if word = reversed array
            if (word.Equals(new string(array)))
            {
                Console.WriteLine("yes");
            }
            else
            {
                Console.WriteLine("no");
            }
        }
        public static int Count(string x)
        {
            int result = 0;

            //trim whitespace from beginning and end of string.
            x = x.Trim();
            // foreach will execute once with empty string returning 1
            if (x == "")
            {
                return 0;
            }

            while (x.Contains(" "))
            {
                x = x.Replace("  ", " ");
            }

            //count words
            foreach (string y in x.Split(' '))
            {
                result++;
            }
            return result;
        }
        public static void Anagram()
        {
            // Get user input
            Console.WriteLine("Enter first word: ");
            string word1 = Console.ReadLine();
            Console.WriteLine("Enter second word: ");
            string word2 = Console.ReadLine();

            //Convert both strings to charArray
            char[] char1 = word1.ToLower().ToCharArray();
            char[] char2 = word2.ToLower().ToCharArray();

            // Sort charArray
            Array.Sort(char1);
            Array.Sort(char2);

            // create new strings from sorted charArrays
            string NewWord1 = new string(char1);
            string NewWord2 = new string(char2);

            //compare two strings
            if (NewWord1 == NewWord2)
            {
                Console.WriteLine("Word1 and Word2 are anagrams", word1, word2);
            }
            else
            {
                Console.WriteLine("Word1 and Word2 are NOT anagrams", word1, word2);
            }



        }
        public static string RemoveDuplicates(string textString)
        {

            string table = "";
            string result = "";
            foreach (char value in textString)
            {
                if (table.IndexOf(value) == -1)
                {
                    table += value;
                    result += value;
                }
            }
            return result;
        }
    }
}
