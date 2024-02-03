STRING SUM
1. **MyBigNumber Class:**
   - Represents a large number as a string.
   - Has a constructor to initialize the object with a string.

2. **StringSum Method:**
   - A static method for adding two large numbers represented as strings.
   - Takes two string parameters, iterates through digits, and calculates the sum with carry.
   - Returns the result as a string.

3. **Add Method in MyBigNumber Class:**
   - A static method within the class.
   - Uses the `StringSum` method to add two `MyBigNumber` objects, creating a new object with the result.

4. **Main Method in Program Class:**
   - Handles user input in a loop.
   - Prompts for two numbers, creates `MyBigNumber` objects.
   - Calls the `Add` method to add the numbers and displays the result.
   - Asks the user if they want to try again.


The core addition logic is in the `StringSum` method, which is used by the `Add` method within the `MyBigNumber` class. The program loop allows users to input numbers repeatedly.

UNITTEST

The provided code is a unit test using Microsoft's Visual Studio testing framework. It includes two test cases for the `String_Sum` method:

1. **Test Case 1:**
   - Adds "9482394" and "4782394".
   - Expects the result "14264788".

2. **Test Case 2:**
   - Adds "9482394" and "0".
   - Expects the result "9482394".
   - 
3. **Test Case 3:**
   - Adds "124" and "".
   - Expects the result "0".
  


The `Assert.AreEqual` method is used to verify that the actual result matches the expected result for each test case. Running this unit test ensures the correct behavior of the `String_Sum` method.
