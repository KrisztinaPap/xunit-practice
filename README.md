# C# Review/OOP Practice - xUnit Cumulative
​
## Author: Krisztina Pap

## Date due: 10-28-2020

## Last Edited: 10-27-2020

## Instructions

### Introduction
- This practice is designed to help you familiarize yourself with the fundamentals of XUnit in an object-oriented implementation.
​
### Requirements
- Create a new C# Console solution called “XUnitCumulativePractice”.
- Add a new xUnit Test Project (.NET Core) to the solution called “XUnitCumulativePractice_Tests”.
- Add an assembly reference from “XUnitCumulativePractice_Test”  to “XUnitCumulativePractice”.
    - Do this by r-clicking on “XUnitCumulativePractice_Test” dependencies, then Add Project Reference to “XUnitCumulativePractice”
- Rename the default file “UnitTest1.cs” in the XUnit project to “Program_Tests.cs”.
- Ensure your “Program” class is public in the XUnitCumulativePractice project.
- Create a method in XUnitCumulativePractice.Program.cs called ValidateOneToOneHundredEven() that will accept a string (“1” or “20” etc.)  as a parameter.
    - Validate that the string:
        - Is an integer (numeric, will safely parse to int).
        - Is between 1 and 100.
        - Is even.
    - If it is, return true. Otherwise return false.
- Create test cases in Program_Tests.cs that will test each of the requirements of ValidateOneToOneHundredEven().
    - This is to say, we should be testing (Theories) (png in root project folder)
    - Don’t forget to include edge cases (right on the border of acceptable, example if we wanted between 1 and 5, we would test at least -1, 0, 1, 5 and 6).
    - Please include at least 3 sets of test data per row.   
- Create a class called “Item” with the following properties:
    - “Name” (string).
    - A default and greedy constructor.
 - Create a class called “Storage” with the following properties and methods:
    - “Contents” (list of Items).
    - AddItem() will accept an item and add it to the “Contents” list.
    - RemoveItem() will remove the most recent addition to the “Contents” list.
    - A default constructor.
- Add a tests file to the XUnit project called Storage_Tests.cs.
    - Test the addition of items (Fact):
        - (Arrange) Create an Item named “TestItem” and an empty Storage. 
        - (Act) Add the Item to the Storage using the AddItem() method.
        - (Assert) Assert that the list has a count of 1
        - (Assert) Assert that the item in Storage.Contents is “TestItem”.
    - Test the removal of items (Fact):	
        - (Arrange) Create a Storage prepopulated with 5 Items. 
        - (Arrange) Create an object reference variable to the last item in the Contents list.
        - (Act) Run RemoveItem() on the Storage. 
        - (Assert) Assert that the count of the Contents has dropped by 1 (is 4)
        - (Assert) Assert that the object reference is no longer in the list.
​
### Challenges
- Convert the Facts for testing the object into Theories, and test multiple runs of each for expected behaviour.
- Make the “Contents” property a polymorphic list of “Items”, derive some classes from “Item” and test for expected behaviour of your choosing.

## Trello Project Board
https://trello.com/b/BgOGUH9r/c-review-oop-practice-xunit-cumulative

## References/Citations
