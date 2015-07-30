# String calculator kata.

This kata is modified from original source. Link to original kata: <http://osherove.com/tdd-kata-1/>.
While doing kata, it have been modified a few times from original.

# Instructions
1. Create a simple String calculator with a method Add(string input)
2. The method can take multiple numbers, separated + char and will return sum as integer. 
  * for an empty string it will return "operator not supported".
  * valid input should return sum.
  * if only one number is given, return that number.
  * if last number is followed by operator, ignore that.
  * "" should return "operation not supported"
  * "1" should return "1"
  * "0+1" should return "1"
  * "1+2" should return "3"
  * "1+2+3" should return "6"
  * "1+2+3+4" should return "10"
  * "1+2+" should return "3" (last operator is ignored)
  
# View of learning
Read the whole instructions and implement it step by step. Use TDD approach. The kata is fine for training
TDD discipline. Remember green-red-refactoring phases. 

When doing multiple times, get familiar your tools like IDE. Try to figure out useful shortcuts... for example
how to generate test functions or how to use refactoring features. If you are set up test environment each time,
you will figure out how to do it effectively. It depends on lot of tools that you are using.


