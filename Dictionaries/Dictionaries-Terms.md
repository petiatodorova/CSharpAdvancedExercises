# Fruits Shop - General Skeleton for work with SortedDictionary and Class
=========================================================================

## Test Dictionary of string and Class for different functionality (created by me)
-----------------------------------------------------------------------

### Variant 1: 

Write a program that receives on every row (untill is received "End") some data about person and fruits:

Name Fruit Color Quantity Price

The data are received as is shown in the test.

On the console print for every color (ordered alphabetically) 
the persons (ordered by names in descending order alphabetically) how much money did they spend.
If there is one and the same name in the input rows, the persons must be printed in increasing order by the money they have spent.
The Output must be as in the Output:


### Tests:

#### Input
Ivan apple red / 32 14.4
Ivan; kiwi blue 17 33.10
Ivan grape blue 18 , 12.4
Mimi orange blue  \ 19 18.8
Mihail orange yellow 33   18.20
Sonya; kiwi blue 22.5 13.10
Kotyo apple green , 14 15.4
Asen apple red / 18 24.4
Asen kiwi red / 11.5 20.4
End

#### Output
The Color: --> blue
Name: Sonya --> Total Money: 294.750
Name: Mimi --> Total Money: 357.2
Name: Ivan --> Total Money: 223.2
Name: Ivan --> Total Money: 562.70
The Color: --> green
Name: Kotyo --> Total Money: 215.6
The Color: --> red
Name: Ivan --> Total Money: 460.8
Name: Asen --> Total Money: 234.60
Name: Asen --> Total Money: 439.2
The Color: --> yellow
Name: Mihail --> Total Money: 600.60



### Variant 2: 

On the console print for every person (ordered alphabetically) by name,
the fruits (ordered by names in descending order alphabetically) and how much money did he spend.
If there is one and the same name in the input rows, the fruits must be printed in increasing order by the money they have spent.
The Output must be as in the Output:

### Tests:

#### Input
Ivan apple red / 32 14.4
Ivan; kiwi blue 17 33.10
Ivan grape blue 18 , 12.4
Mimi orange blue  \ 19 18.8
Mihail orange yellow 33   18.20
Sonya; kiwi blue 22.5 13.10
Kotyo apple green , 14 15.4
Asen apple red / 18 24.4
Asen kiwi red / 11.5 20.4
End

#### Output