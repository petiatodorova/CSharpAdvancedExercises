
### Когато искаме да ползваме променлива, записваме pattern-a s $ отпред:
string pattern = $@"[A-Z][^\.|\!|\?]*\b{word}\b[^\.|\!|\?]*";

string pattern2 = $@"{start}(.*?){end}";

#### First Match: 
Match matchLine = Regex.Match(input, pattern);

#### All Matches:
MatchCollection digitMatches = Regex.Matches(input, patternDigit);




-------------------------
Regexes:
https://msdn.microsoft.com/en-us/library/system.text.regularexpressions.regex(v=vs.110).aspx

-------------------------

#### Groups:

            string input = Console.ReadLine();

            string pattern = @"(\|<)(\w+)";
            Regex regex = new Regex(pattern);

            if (regex.IsMatch(input))
            {
                MatchCollection myMatches = regex.Matches(input);
                List<string> result = new List<string>();

                foreach (Match match in myMatches)
                {
                    string currentMatch = match.Groups[2].ToString();
                    string curResult = currentMatch.Substring(toSkip, Math.Min(toTake, currentMatch.Length - toSkip));
                    result.Add(curResult);
                }
                Console.WriteLine($"{string.Join(", ", result)}");



-------------------------
# Key Replacer
==============

You will be given a key string and a text string. The key string will contain a start key and an end key.
The start key starts at the beginning of the string and ends at the first occurrence of one of the symbols – “|”, “<” or “\”. The end key starts at the last occurrence of one of these symbols and ends when the string ends. Both keys can contain only Latin alphabet letters.
When you extract both keys search for them in the text string and extract every string, which is between them. Concatenate all collected strings and print the result. If the result string is empty print “Empty result”.
Input
The input will be read from the console. The first line will hold the keys string and the second line will hold the text to search.
Output
Print the concatenated message, if such exists or "Empty result", if it does not.

### Input
start<213asfaas|end
saaastarthelloendsdarstartFromTheOtherenddvsefdsfstartSideend

### Output
helloFromTheOtherSide

### Input
A|safafasfsadf|B
NoMEssageABhereYeyAB

### Output
Empty result


# Weather
=========

You have to make a weather forecast about the weather depending on strings, which you receive from the console. Every string consists of data about the city, average temperature and weather type. You will receive strings until you receive the command “end”. 
Every valid weather forecast consists of:
Two Latin capital letters, which represent the code of the city
Immediately followed by a floating-point number, which will represent the average temperature. Numbers without a floating point are not considered valid.
Followed by the type of weather, which will consist of uppercase and lowercase Latin letters, starts immediately after the temperature and ends at the first occurrence of the sign ‘|’
If you receive input, which does not follow the rules above – ignore it.
If you receive a new temperature and/or type of weather for a city, which already exists – rewrite the previous values.
At the end, print the temperature and weather type for every city. Order the cities by average temperature in ascending order.

## Tests

### Input
You will receive strings until you receive the command “end”.

### Output
Print all cities ordered by average temperature in ascending order. Use the following format: 
“{nameOfTheCity} => {averageTemperature} => {typeOfWeather}”
Format the temperature to the 2nd decimal place.

### Constraints
The average temperature will be in the interval [0.00…50.00]
The floating-point numbers will have at most 2 digits after the floating point.

## Tests

### Input
PB23.41Rainy|ASDASD
SDASCA20.21sUNNY|SDASD
asdaCA22.5rainy|sada
CA23.41cloydy
end

### Output
CA => 22.50 => rainy
PB => 23.41 => Rainy

### Input
invalidKA31.41|sunny|
validCA12.41Rainy|absad
gfASFasASPA31.21cloudy|asd
YA21.51sunny|
sadL21.41rainy|adas
end

### Output
CA => 12.41 => Rainy
YA => 21.51 => sunny
PA => 31.21 => cloudy
5. 



# Extract Sentences by Keyword
==============================

Write a program that extracts all sentences that contain a particular word from a string (case-sensitive).
Assume that the sentences are separated from each other by the character "." or "!" or "?".
The words are separated by a non-letter character.
Note that a substring is different than a word. The sentence “I am a fan of Motorhead” does not contain the word “to”. It contains the substring “to”, which is not what we need.
Print the result text without the separators between the sentences ("." or "!" or "?").
Examples

Input
to
Welcome to SoftUni! You will learn programming, algorithms, problem solving and software technologies. You need to allocate for study 20-30 hours weekly. Good luck! I am fan of Motorhead. To be or not to be - that is the question. TO DO OR NOT?

Output
Welcome to SoftUni
You need to allocate for study 20-30 hours weekly
To be or not to be - that is the question



----------------

using System;
using System.Text.RegularExpressions;

namespace ExtractSentences2
{
    class ExtractSentences2
    {
        static void Main(string[] args)
        {
            string word = Console.ReadLine();
            string input = Console.ReadLine();
            string pattern = $@"[A-Z][^\.|\!|\?]*\b{word}\b[^\.|\!|\?]*";
            if (Regex.IsMatch(input, pattern))
            {
                MatchCollection myMatches = Regex.Matches(input, pattern);
                foreach (Match match in myMatches)
                {
                    Console.WriteLine($"{match.Value}");
                }
            }
        }
    }
}

-------------




MatchCollection Count

----------------------------------------------------------------

using System;
using System.Text.RegularExpressions;

public class Example
{
   public static void Main()
   {
      string pattern = @"\d+";
      string[] inputs = { "This sentence contains no numbers.",
                          "123 What do I see?",
                          "2468 369 48 5" };
      foreach (var input in inputs) {
         MatchCollection matches = Regex.Matches(input, pattern);
         Console.WriteLine("Input: {0}", input);
         if (matches.Count == 0)
            Console.WriteLine("   No matches");
         else
            foreach (Match m in matches)
               Console.WriteLine("   {0} at index {1}", m.Value, m.Index);

         Console.WriteLine();
      }
   }
}

**********************************************************************************************************************

(.*?) - non greedy
 .+? - non greedy
(.*) - greedy

**********************************************************************************************************************

\+\d{1,3}([ -]*[0-9]){6,}- поне 6 пъти и повече

+1-800-555-2468 - matched
+359 2 834-2334 - matched
+359888123456 - matched
(052) 343-434 - not matched

**********************************************************************************************************************

^\+\d{1,3}([ -]*[0-9]){6,}$

+359 2 123-456 is a match
+359 (888) 123-456 is a NOT match

**********************************************************************************************************************

Simplified Email Extraction Pattern:
/[a-z0-9._%+-]+@[a-z0-9.-]+\.[a-z]{2,20}/gi

**********************************************************************************************************************



match 	cat. 	Success
match 	896. 	Success
match 	?=+. 	Success
skip 	abc1

[a-z0-9?|=|\+]\.
[a-z0-9?=\+]\.

**********************************************************************************************************************

capture 	Jan 1987 	Jan 1987 1987 	Success
capture 	May 1969 	May 1969 1969 	Success
capture 	Aug 2011 	Aug 2011 2011 	Success

((\w+) (\d+))

**********************************************************************************************************************

match 	I love cats 	Success
match 	I love dogs 	Success
skip 	I love logs 	To be completed
skip 	I love cogs

cats|([d]ogs)

**********************************************************************************************************************

match 	3.14529 	Success
match 	-255.34 	Success
match 	128 		Success
match 	1.9e10 		Success
match 	123,340.00 	Success
skip 	720p 	To be completed

(-)?\d+(\.|\,)?\d+(\.|\,)?\b

**********************************************************************************************************************

capture 	415-555-1234 	415 	Success
capture 	650-555-2345 	650 	Success
capture 	(416)555-3456 	416 	Success
capture 	202 555 4567 	202 	Success
capture 	4035555678 		403 	Success
capture 	1 416 555 9292 	416 	Success

(([0-9]){3})

**********************************************************************************************************************

capture 	tom@hogwarts.com 	tom 						Success
capture 	tom.riddle@hogwarts.com 	tom.riddle 			Success
capture 	tom.riddle+regexone@hogwarts.com 	tom.riddle 	Success
capture 	tom@hogwarts.eu.com 	tom 					Success
capture 	potter@hogwarts.com 	potter 					Success
capture 	harry@hogwarts.com 	harry 						Success
capture 	hermione+regexone@hogwarts.com 	hermione 		Success

((\w+)(\.)?(\w+)?)

**********************************************************************************************************************

capture 	<a>This is a link</a> 	a						Success
capture 	<a href='https://regexone.com'>Link</a> 	a 	Success
capture 	<div class='test_style'>Test</div> 	div 		Success
capture 	<div>Hello <span>world</span></div> 	div 	Success

\<\/?(\w+)\>

**********************************************************************************************************************

capture 				The quick brown fox... 	The quick brown fox... 	Success
capture 	   jumps over the lazy dog. 	jumps over the lazy dog. 	Success
^\s*(.*)\s*$

**********************************************************************************************************************

Task 	Text 	Capture Groups 	 
skip 	W/dalvikvm( 1553): threadid=1: uncaught exception 
skip 	E/( 1553): FATAL EXCEPTION: main 
skip 	E/( 1553): java.lang.StringIndexOutOfBoundsException 	
capture 	E/( 1553):   at widget.List.makeView(ListView.java:1727) 	makeView ListView.java 1727 	Success
capture 	E/( 1553):   at widget.List.fillDown(ListView.java:652) 	fillDown ListView.java 652 		Success
capture 	E/( 1553):   at widget.List.fillFrom(ListView.java:709) 	fillFrom ListView.java 709 		Success

(\w+)\(([\w\.]+):(\d+)\)

**********************************************************************************************************************

capture 	ftp://file_server.com:21/top_secret/life_changing_plans.pdf 	ftp file_server.com 21 	Success
capture 	https://regexone.com/lesson/introduction#section 	https regexone.com 	Success
capture 	file://localhost:4040/zip_file 	file localhost 4040 	Success
capture 	https://s3cur3-server.com:9999/ 	https s3cur3-server.com 9999 	Success
capture 	market://search/angry%20birds 	market search

(\w+)(\:\/\/)([\w+\.?\-?]+)(\:(\d+))?

**********************************************************************************************************************

yolo yololo

yolo(?=lo) връща второто(yolo)lo (непременно да има lo)
yolo(?!lo) връща първото(yolo) (непременно да няма lo)

(?<=yo)lol
lol yololo - връща първото(lol) (но непременно да има yo преди него)

(?<!yo)lo
lol yololo - връща всяко(lo) (което обаче няма yo преди него)

**********************************************************************************************************************

[A-Z]((?![.?!]\s[A-Z][^.?!]).)+ - хваща цели изречения









# Strong Password
=====================================

Louise joined a social networking site to stay in touch with her friends. The signup page required her to input a name and a password. However, the password must be strong. The website considers a password to be strong if it satisfies the following criteria:

Its length is at least .
It contains at least one digit.
It contains at least one lowercase English character.
It contains at least one uppercase English character.
It contains at least one special character. The special characters are: !@#$%^&*()-+
She typed a random string of length  in the password field but wasn't sure if it was strong. Given the string she typed, can you find the minimum number of characters she must add to make her password strong?

Note: Here's the set of types of characters in a form you can paste in your solution:

numbers = "0123456789"
lower_case = "abcdefghijklmnopqrstuvwxyz"
upper_case = "ABCDEFGHIJKLMNOPQRSTUVWXYZ"
special_characters = "!@#$%^&*()-+"
Input Format

The first line contains an integer  denoting the length of the string.

The second line contains a string consisting of  characters, the password typed by Louise. Each character is either a lowercase/uppercase English alphabet, a digit, or a special character.

Constraints

Output Format

Print a single line containing a single integer denoting the answer to the problem.

Sample Input 0

3
Ab1
Sample Output 0

3
Explanation 0

She can make the password strong by adding  characters, for example, $hk, turning the password into Ab1$hk which is strong.

characters aren't enough since the length must be at least .

Sample Input 1

11
#HackerRank
Sample Output 1

1
Explanation 1

The password isn't strong, but she can make it strong by adding a single digit.


# Camera View
=====================================

You are an amateur photographer and you want to calculate what will be seen in your pictures.
On the first line, you will receive an array of integers with exactly two elements:
First element – m will be the elements, which you have to skip. The second element – n will be the elements, which you have to take.
On the next line, you will receive a string, in which every camera will be marked with "|<". Skip the next m elements immediately after the camera and take the next n elements.
If you encounter new camera in the view  stop the current camera and start new view with the newly found.
Output
Print all the taken views separated with ", ".

### Tests:

*** Input
9 7
GreatBigSea|<uglyStuffHawaii|<boriiiingKilauea

*** Output
Hawaii, Kilauea

*** Input
0 5
|>invalid|<beach|noMoreCameras

*** Output
beach

