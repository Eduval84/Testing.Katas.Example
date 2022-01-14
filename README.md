# Testing.Katas.Example
Tdd Katas Examples in c#
Examples in [Nunit]([here](myLib/README.md))

# Create a Password verifications class called “PasswordVerifier”.

1. Add the following verifications to a master function called “Verify()”

   1. - password should be larger than 8 chars
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
