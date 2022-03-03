# Testing.Katas.Example
Tdd Katas Examples in c#
Examples in [Nunit](https://es.wikipedia.org/wiki/NUnit)

# Create a Password verifications class called “PasswordVerifier”.

1. Add the following verifications to a master function called “Verify()”

   1. - password should be larger than 8 charsCancel changes
   2. - password should not be null
   3. - password should have one uppercase letter at least
   4. - password should have one lowercase letter at least
   5. - password should have one number at least

 Each one of these should throw an exception with a different message of your choosing

2. Add feature: Password is OK if at least three of the previous conditions is true
3. Add feature: password is never OK if item 1.4 is not true.
4. Assume Each verification takes 1 second to complete. How would you solve  items 2 and 3  so tests can run faster?


# FizzBuzz Kata
Print the numbers from 1 to 100. But for multiples of three, print "Fizz” instead of the number and for the multiples of five, print "Buzz". 
For numbers which are multiples of both three and five, print "FizzBuzz".

# String Calculator Kata”.

Before you start: 
Try not to read ahead.

Do one task at a time. The trick is to learn to work incrementally.

Make sure you only test for correct inputs. there is no need to test for invalid inputs for this kata

String Calculator

Create a simple String calculator with a method signature => int Add(string numbers)

The method can take up to two numbers, separated by commas, and will return their sum. 
for example “” or “1” or “1,2” as inputs.
(for an empty string it will return 0) 
Hints:

 - Start with the simplest test case of an empty string and move to one and two numbers
 - Remember to solve things as simply as possible so that you force yourself to write tests you did not think about
 - Remember to refactor after each passing test

Allow the Add method to handle an unknown amount of numbers

Allow the Add method to handle new lines between numbers (instead of commas).
the following input is ok: “1\n2,3” (will equal 6)
the following input is NOT ok: “1,\n” (not need to prove it - just clarifying)

Support different delimiters
to change a delimiter, the beginning of the string will contain a separate line that looks like this: “//[delimiter]\n[numbers…]” for example “//;\n1;2” should return three where the default delimiter is ‘;’ .
the first line is optional. all existing scenarios should still be supported

Calling Add with a negative number will throw an exception “negatives not allowed” - and the negative that was passed. 
if there are multiple negatives, show all of them in the exception message.

STOP HERE if you are a beginner. Continue if you can finish the steps so far in less than 30 minutes.

Numbers bigger than 1000 should be ignored, so adding 2 + 1001 = 2

Delimiters can be of any length with the following format: “//[delimiter]\n” for example: “//[***]\n1***2***3” should return 6
—Allow multiple delimiters like this: “//[delim1][delim2]\n” for example “//[*][%]\n1*2%3” should return 6.

make sure you can also handle multiple delimiters with length longer than one char
