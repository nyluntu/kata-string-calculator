# String calculator kata.

This kata is modified from original source. Link to original kata: <http://osherove.com/tdd-kata-1/>

# Instructions
1. Create a simple String calculator with a method int Add(string input)
2. The method can take 2 numbers, and will return their sum 
  * for an empty string it will return "operator not supported"
  * program look for supported operator from string.
  * for example "1+2" should return 3
3. Allow the Add method to handle an unknown amount of numbers
  * for example "1+2+5+6+8" should return 22
4. Catch all errors and print "operation failed", if operator fails to calculate result.
  * for example "1+n" should print "operation failed"


