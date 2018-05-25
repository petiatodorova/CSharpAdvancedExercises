# CSharpGeneral
Exercises with C# DataTypes | Strings | Regex | Dictionary | Class | Arrays | Lists

# Strings:

===================

## CharToAsciiToChar

===================

Convert character to ASCII code and convert ASCII code to character



## StringBuilderTest

===================

Reverse input string and change it with some key number.



## PrintRepeatingCharacter

=========================

Prints repeating symbol, which comes from the console.



## Print Part of the ASCII Table

================================

Find online more information about ASCII (American Standard Code for Information Interchange) and write a program that prints part of the ASCII table of characters at the console.  On the first line of input you will receive the char index you should start with and on the second line - the index of the last character you should print.

### Tests:

*** Input

60

65

*** Output

&lt; = &gt; ? @ A

*** Input

69

79

*** Output

E F G H I J K L M N O

*** Input

97

104

*** Output

a b c d e f g h

*** Input

40

55

*** Output

( ) * + , - . / 0 1 2 3 4 5 6 7



## Character Multiplier

================================

Create a method that takes two strings as arguments and returns the sum of their character codes multiplied (multiply str1.charAt (0) with str2.charAt (0) and add to the total sum). Then continue with the next two characters. If one of the strings is longer than the other, add the remaining character codes to the total sum without multiplication.

### Tests:

*** Input

Gosho Pesho

*** Output

53253

*** Input

123 522

*** Output

7647

*** Input

a aaaa

*** Output

9700



# Data Types:

bool  --&gt; Boolean value  --&gt;  True or False  --&gt;  Default: False

byte  --&gt; 8-bit unsigned integer  --&gt; Default: 0 to 255

char  --&gt; 16-bit Unicode character  --&gt; U +0000 to U +ffff  --&gt; Default: '\0'

decimal  --&gt; 128-bit precise decimal values with 28-29 significant digits  --&gt; (-7.9 x 1028 to 7.9 x 1028) / 100 to 28  --&gt; Default: 0.0M

double  --&gt; 64-bit double-precision floating point type  --&gt; (+/-)5.0 x 10-324 to (+/-)1.7 x 10308  --&gt; Default: 0.0D

float  --&gt; 32-bit single-precision floating point type  --&gt; -3.4 x 1038 to + 3.4 x 1038  --&gt; Default: 0.0F

int  --&gt; 32-bit signed integer type  --&gt; -2,147,483,648 to 2,147,483,647  --&gt; Default: 0

long  --&gt; 64-bit signed integer type  --&gt; -9,223,372,036,854,775,808 to 9,223,372,036,854,775,807  --&gt; Default: 0L

sbyte  --&gt; 8-bit signed integer type  --&gt; -128 to 127  --&gt; Default: 0

short  --&gt; 16-bit signed integer type  --&gt; -32,768 to 32,767  --&gt; Default: 0

uint  --&gt; 32-bit unsigned integer type  --&gt; 0 to 4,294,967,295  --&gt; Default: 0

ulong  --&gt; 64-bit unsigned integer type  --&gt; 0 to 18,446,744,073,709,551,615  --&gt; Default: 0

ushort  --&gt; 16-bit unsigned integer type  --&gt; 0 to 65,535  --&gt; Default: 0

# Max Sequence of Equal Elements

================================

Write a program that finds the longest sequence of equal elements in an array of integers. If several longest sequences exist, print the leftmost one.

## Tests:

*** Input

2 1 1 2 3 3 2 2 2 1

*** Output

2 2 2

*** Input

1 1 1 2 3 1 3 3

*** Output

1 1 1

*** Input

4 4 4 4

*** Output

4 4 4 4

*** Input

0 1 1 5 2 2 6 3 3

*** Output

1 1

# Variable in Hexadecimal Format

================================

Write a program that reads a number in hexadecimal format (0x##) convert it to decimal format and prints it.

## Tests:

*** Input

0xFE

*** Output

254

*** Input

0x37

*** Output

55

*** Input

0x10

*** Output

16

# Different Integers Size

================================

Given an input integer, you must determine which primitive data types are capable of properly storing that input.

Input

You receive N – integer which can be arbitrarily large or small

Output

You must determine if the given primitives are capable of storing it. If yes, then print:

{N} can fit in:

* dataType

If there is more than one appropriate data type, print each one on its own line and order them by size

(sbyte &lt; byte &lt; short &lt; ushort &lt; int &lt; uint &lt; long).

If the number cannot be stored in one of the four aforementioned primitives, print the line: 

{N} can't fit in any type

## Tests:

*** Input

-150

*** Output

-150 can fit in:

* short

* int

* long

*** Input

150000

*** Output

150000 can fit in:

* int

* uint

* long

*** Input

1500000000

*** Output

1500000000 can fit in:

* int

* uint

* long

*** Input

213333333333333333333333333333333333

*** Output

213333333333333333333333333333333333 can't fit in any type

# Thea the Photographer

================================

This problem is from the Programming Fundamentals Retake Exam (11 September 2016).

Thea is a photographer. She takes pictures of people on special events. She is a good friend and you want to help her.

She wants to inform her clients when their pictures will be ready. Since the number of pictures is big and it requires time for editing (#nofilter, #allnatural) every single picture - you decide to write a program in order to help her.

Thea follows this pattern: first she takes all pictures. Then she goes through every single picture to filter these pictures that are considered "good". Then she needs to upload every single filtered picture to her cloud. She is considered ready when all filtered pictures are uploaded in her picture storage.

You will receive the number of pictures she had taken. Then the approximate time in seconds for every picture to be filtered. Then a filter factor – a percentage (integer number) of the total photos (rounded to the nearest bigger integer value e.g. 5.01 -&gt; 6) that are good enough to be given to her clients (Photoshop may do miracles but Thea does not). Approximate time for every picture to be uploaded will be given again in seconds. Your task is: based on this input to display total time needed for her to be ready with the pictures in given below format.

Input

On the first line, you will receive an integer N – the number of pictures Thea had taken.

On the second line, you will receive an integer FT – the amount of time (filter time) in seconds that Thea will require to filter every single picture.

On the third line, you will receive an integer FF – the filter factor or the percentage of the total pictures that are considered “good” to be uploaded.

On the fourth line, you will receive an integer UT – the amount of time needed for every filtered picture to be uploaded to her storage.

The input will be in the described format, there is no need to check it explicitly.

Output

Print the amount of time Thea will need in order to have her pictures ready to be sent to her client in given format:

d:HH:mm:ss

d - days needed – starting from 0.

HH –  hours needed – from 00 to 24.

mm – minutes needed – from 00 to 59.

ss – minutes needed – from 00 to 59.

## Tests:

## Constraints

The number of total pictures Thea will have taken is range [0 … 1 000 000]

The seconds for both filtering and uploading will be in range [0 … 100 000]

The filter factor will be an integer number between [0 … 100].

## Tests:

*** Input

1000

1

50

1

*** Output

0:00:25:00

*** Comments

Total pictures = 1 000, 50% of them are useful -&gt; Filtered pictures = 500 

Total pictures * filter time = 1000 s

Filtered pictures * upload time = 500 s

Total time = 1500 s

*** Input

5342

2

82

3

*** Output

0:06:37:07

*** Comments

Total pictures = 5342 - 82% of them are useful -&gt; 4380.44-&gt; 4381 filtered.

# Integer to Hex and Binary

================================

Create a program to convert a decimal number to hexadecimal and binary number and print it.

## Tests:

*** Input

10

*** Output

A

1010

*** Input

420

*** Output

1A4

110100100

*** Input

256

*** Output

100

100000000

# Convert Speed Units

================================

NB: You cannot solve this Problem with JAVA without using additional logic for the rounding.

Create a program to ask the user for a distance (in meters) and the time taken (as three numbers: hours, minutes, seconds), and print the speed, in meters per second, kilometers per hour and miles per hour.

Assume 1 mile = 1609 meters.

Input

On first line, you receive – distance in meters

On second – hours

On third – minutes

On fourth – seconds

Output

Every number in the output should be precise up to 6 digits after the floating point

On first line – speed in meters per second (m/s)

On second line – speed in kilometers per hour (km/h)

On third line – speed in miles per hour (mp/h)

## Tests:

*** Input

1000

1

1

0

*** Output

0.2732241

0.9836066

0.6113155

*** Input

10000

0

20

30

*** Output

8.130081

29.26829

18.19036

*** Input

200000

2

5

0

*** Output

26.66667

96

59.66439


# Arrays and Lists

# Max Sequence of Equal Elements
================================

Write a program that finds the longest sequence of equal elements in an array of integers. If several longest sequences exist, print the leftmost one.

### Tests:

*** Input
2 1 1 2 3 3 2 2 2 1

*** Output
2 2 2

*** Input
1 1 1 2 3 1 3 3

*** Output
1 1 1

*** Input
4 4 4 4

*** Output
4 4 4 4

*** Input
0 1 1 5 2 2 6 3 3

*** Output
1 1


# Max Sequence of Increasing Elements
=====================================

Write a program that finds the longest increasing subsequence in an array of integers. The longest increasing subsequence is a portion of the array (subsequence) that is strongly increasing and has the longest possible length. If several such subsequences exist, find the left most of them.

### Tests:

*** Input
3 2 3 4 2 2 4

*** Output
2 3 4

*** Input
4 5 1 2 3 4 5

*** Output
1 2 3 4 5

*** Input
3 4 5 6

*** Output
3 4 5 6

*** Input
0 1 1 2 2 3 3

*** Output
0 1


# Most Frequent Number
=====================================

Write a program that finds the most frequent number in a given sequence of numbers. 
Numbers will be in the range [0…65535].
In case of multiple numbers with the same maximum frequency, print the left-most of them.

### Tests:

*** Input
4 1 1 4 2 3 4 4 1 2 4 9 3

*** Output
4
The number 4 is the most frequent (occurs 5 times)

*** Input
2 2 2 2 1 2 2 2

*** Output
2
The number 2 is the most frequent (occurs 7 times)

*** Input
7 7 7 0 2 2 2 0 10 10 10

*** Output
7
The numbers 2, 7 and 10 have the same maximal frequence (each occurs 3 times). The leftmost of them is 7.
13. 


# Sorting of Array with the method "Selection sort"
==================================================

Сортиране на масив означава да подредим елементите му в нарастващ
(намаляващ) ред. Напишете програма, която сортира масив. Да се
използва алгоритъма "Selection sort".


# CSharpAdvanced
C# Advanced exercises

## Exercises: Stacks and Queues

This document defines the **exercise
assignments** for the 

["CSharp
Advanced" course @ Software University](https://softuni.bg/trainings/1361/advanced-c-sharp-may-2016).
Please submit your solutions (source code) of all below described
problems in [Judge](https://judge.softuni.bg/).

1. **Reverse Numbers with a Stack** 

Write a program that reads **N integers** from the console and **reverses
them using a stack**. Use the **Stack&lt;int&gt;**
class. Just put the input numbers in the stack and pop them.
Examples:

**Examples**

 

**Input**

 

**Output**

 

1
			2 3 4 5

 

5
			4 3 2 1

 

1

 

1

1. **Basic
	Stack Operations** 

Play
around with a stack. You will be given an integer **N
**representing
the amount of elements to push onto the stack, an integer **S
**representing
the amount of elements to pop from the stack and finally an integer
**X**,
an element that you should check whether is present in the stack. If
it is print **true
**on
the console, if it’s not print the smallest element currently
present in the stack.

**Input
Format: **On
the first line you will be given **N**,
**S**
and **X
**separated
by a single space. On the next line you will be given **N**
amount of integers.

**Output
Format: **On
a single line print either **true
**if
**X
**is
present in the stack otherwise print **smallest
**element
in the stack. If the stack is empty print 0.

**Examples**

 

**Input**

 

**Output**

 

**Comments**

 

5
			2 13

1
			13 45 32 4

 

true

 

We
			have to **push
			5 **elements.
			Then we **pop
			2 **of
			them. Finally, we have to check whether 13 is present in the
			stack. Since it is we print **true**.

 

4
			1 666

420
			69 13 666

 

13

1. **Maximum
	Element** 

You
have an empty sequence, and you will be given N queries.
Each query is one of these three types:

1
x - Push the element x into the stack.

2
   - Delete the element present at the top of the stack.

3
   - Print the maximum element in the stack.

**Input
Format: **The
first line of input contains an integer, N. The next N
lines each contain an above mentioned query. _(It
is guaranteed that each query is valid.)_

**Output
Format: **For
each type 3 query, print the maximum element in the stack
on a new line.

**Constraints**:  
1
≤ N ≤ 10

5   
1
≤ x ≤ 10

9  
1
≤ type ≤ 3

**Examples**

 

**Input**

 

**Output**

 

9

1
			97

2

1
			20

2

1
			26

1
			20

3

1
			91

3

 

26

91

1. **Basic
	Queue Operations** 

Play
around with a queue. You will be given an integer **N
**representing
the amount of elements to enqueue (add), an integer **S
**representing
the amount of elements to dequeue (remove/poll) from the queue and
finally an integer **X**,
an element that you should check whether is present in the queue. If
it is print **true
**on
the console, if it’s not print the smallest element currently
present in the queue.

**Examples**

 

**Input**

 

**Output**

 

**Comments**

 

5
			2 32

1
			13 45 32 4

 

true
			

 

We
			have to **push
			5 **elements.
			Then we **pop
			2 **of
			them. Finally, we have to check whether 13 is present in the
			stack. Since it is we print **true**.

 

4
			1 666

666
			69 13 420

 

13

 

3
			3 90

90
			90 90

 

0

1. **Calculate
	Sequence with Queue** 

We
are given the following sequence of numbers:

- S

1
	= N 
- S

2
	= S

1
	+ 1 
- S

3
	= 2*S

1
	+ 1 
- S

4
	= S

1
	+ 2 
- S

5
	= S

2
	+ 1 
- S

6
	= 2*S

2
	+ 1 
- S

7
	= S

2
	+ 2 
- … 

Using
the **ArrayDeque&lt;E&gt;**
class, write a program to print its first 50 members for given N.

**Examples**

 

**Input**

 

**Output**

 

2

 

2
			3 5 4 4 7 5 6 11 7 5 9 6 …

 

-1

 

-1
			0 -1 1 1 1 2 …

 

1000

 

1000
			1001 2001 1002 1002 2003 1003 …

1. ***
	Truck Tour** 

Suppose
there is a circle. There are **N** petrol
pumps on that circle. Petrol pumps are numbered 0 to (N−1) (both
inclusive). You have **two
pieces of information**
corresponding to each of the petrol pump: (1) the **amount
of petrol**
that particular petrol pump will give, and (2) the **distance
from that petrol pump**
to the next petrol pump.

Initially,
you have a tank of infinite capacity carrying no petrol. You can
start the tour at **any**
of the petrol pumps. Calculate the **first
point**
from where the truck will be able to complete the circle. Consider
that the truck will stop at **each
of the petrol pumps**.
The truck will move one kilometer for each liter of the petrol.

**Input
Format: **The
first line will contain the value of **N**.  
The
next **N** lines
will contain a pair of integers each, i.e. the amount of petrol that
petrol pump will give and the distance between that petrol pump and
the next petrol pump.

**Output
Format: **An
integer which will be the smallest index of the petrol pump from
which we can start the tour.

**Constraints:
**  
1
≤ N ≤ 1000001  
1 ≤ Amount of petrol, Distance ≤ 1000000000

**Examples**

 

**Input**

 

**Output**

 

3

1
			5

10
			3

3
			4

 

1

1. **Balanced
	Parentheses** 

Given
a sequence consisting of parentheses, determine whether the
expression is balanced. A sequence of parentheses is balanced if
every open parenthesis can be paired uniquely with a closed
parenthesis that occurs after the former. Also, the interval between
them must be balanced. You will be given three types of
parentheses: (, {, and [.

{[()]}
- This is a balanced parenthesis.

{[(])}
- This is not a balanced parenthesis.

**Input
Format: **Each
input consists of a single line, S, the sequence of parentheses.

**Constraints:**   
1
≤ len

s
≤
1000, where len

s is
the length of the sequence.   
Each character of the sequence
will be one of {, }, (, ), [, ].

**Output
Format: **For
each test case, print on a new line "_YES_"
if the parentheses are balanced. Otherwise, print "_NO_".
Do not print the quotes.

**Examples**

 

**Input**

 

**Output**

 

{[()]}

 

YES

 

{[(])}

 

NO

 

{{[[(())]]}}

 

YES

1. **Recursive
	Fibonacci** 

The
Fibonacci sequence is quite a famous sequence of numbers. Each member
of the sequence is calculated from the sum of the two previous
elements. The first two elements are 1, 1. Therefore the sequence
goes as 1, 1, 2, 3, 5, 8, 13, 21, 34…   
The following sequence
can be generated with an array, but that’s easy, so your task is to
implement recursively.

So
if the function getFibonacci(n) returns the n’th Fibonacci number
we can express it using getFibonacci(n) = getFibonacci(n-1) +
getFibonacci(n-2)

However,
this will never end and in a few seconds a StackOverflow Exception is
thrown. In order for the recursion to stop it has to have a “bottom”.
The bottom of the recursion is getFibonacci(1) should return 1 and
getFibonacci(0) should return 1.

**Input
Format: **On
the only line in the input the user should enter the wanted Fibonacci
number.

**Output
Format: **The
output should be the n’th Fibonacci number counting from 0 

**Constraints:
**

1
≤ N ≤ 49

**Examples**

 

**Input**

 

**Output**

 

5

 

8

 

10

 

89

 

21

 

17711

For
the Nth Fibonacci number, we calculate the N-1th and the N-2th
number, but for the calculation of N-1th number we calculate the
N-1-1th(N-2th) and the N-1-2th number, so we have a lot of repeated
calculations.

If
you want to figure out how to skip those unnecessary calculations,
you can search for a technique called [

memoization](https://en.wikipedia.org/wiki/Memoization).

1. **Stack
	Fibonacci ** 

There
is another way of calculating the Fibonacci sequence using a stack.
It is non recursive, so it does not make any unnecessary
calculations. Try implementing it. First push 1 and 1 and them use
popping peeking and pushing to generate every consecutive number. 

**Examples**

 

**Input**

 

**Output**

 

7

 

21

 

15

 

987

 

33

 

5702887

1. ***Simple
	Text Editor** 

You
are given an empty text. Your task is to implement 4 commands related
to manipulating the text

- 1
	someString - **append**s
	someString to the end of the text 
- 2
	count - **erases**
	the last _count
	_elements
	from the text 
- 3
	index - **returns**
	the element at position _index
	_from
	the text 
- 4
	- **undoes**
	the last not undone command of type _1
	/ 2 _and
	returns the text to the state before that operation 

**Input
format: **The
first line contains _**n**_,
the number of operations. Each
of the following _**n**_
lines contains the name of the operation followed by the command
argument, if any, separated by space in the following format
_**CommandName
Argument**_.

For
example:

3

1
abc

2
2

4

**Output
Format: **For
each operation of type _**3
**_print
a single line with the returned character of that operation.

**Constraints:
**

1
≤ N ≤ 105

The
length of the text will not exceed 1000000 All
input characters are English letters. It
is guaranteed that the sequence of input operation is possible to
perform

**Examples**

 

**Input**

 

**Output**

 

8

1
			abc

3
			3

2
			3

1
			xy

3
			2

4

4
			

3
			1

 

c

y

a

**Explanation**

[]()There
are 8 operations. Initially, the text is
empty.   
In the first operation, we append **abc**
to the text.   
Then, we print its 3rd character,which
is **c** at
this point.   
Next, we erase its
last 3 characters, **abc**.   
After
that, we append **xy**
to the text.   
The text becomes **xy** after
these previous two modifications.   
Then, we are asked to
return the 2nd character of the text, which
is **y**.  
After
that, we have to undo the last update to the text, so it becomes
empty.  
The next operation asks us to undo the update before that,
so the text becomes **abc** again.   
Finally,
we are asked to print its 1st character, which is **a** at
this point.

1. ****Poisonous
	Plants** 

You
are given **N** plants
in a garden. Each of these plants has been added with some amount of
pesticide. After each day, if any plant has **more
pesticide**
than the plant at **its
left**,
being weaker(more GMO) than the left one, **it
dies**.
You are given the initial values of the pesticide and position of
each plant. Print the number of days **after**
which no plant dies, i.e. the time after which there are no plants
with more pesticide content than the plant to their left.

**Input
Format: **The
input consists of an integer **N**
representing the number of plants. The next **single
line**
consists of **N** integers
where every integer represents the position and amount of pesticides
of each plant.

**Constraints**:
1 ≤ N ≤ 100000  
Pesticides amount on a plant is between 0 and
1000000000

**Output
Format: **Output
a single value equal to the number of days after which no plants die

**Examples**

 

**Input**

 

**Output**

 

7

6
			5 8 4 7 10 9

 

2

**Explanation**

Initially
all plants are alive.   
Plants = {(6,1), (5,2), (8,3), (4,4),
(7,5), (10,6), (9,7)}   
Plants[k] = (i,j) =&gt; j

th plant
has pesticide amount = i.   
After the 1

st day,
4 plants remain as plants 3, 5, and 6 die.   
Plants = {(6,1),
(5,2), (4,4), (9,7)}   
After the 2

nd day,
3 plants survive as plant 7 dies. Plants = {(6,1), (5,2),
(4,4)}   
After the 3

rd day,
3 plants survive and no more plants die.   
Plants = {(6,1),
(5,2), (4,4)}   
After the 2

nd day
the plants stop dying.
