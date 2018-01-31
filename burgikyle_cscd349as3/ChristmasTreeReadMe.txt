Name: Kyle Burgi
Assignment 3 - Decorator(ChristmasTree)

Assignment Text - 
"The winter holidays will be here (again) before you know it! Being the organized individual you are, you have a plan for next year's holiday tree.  Implement a software system that allows you to calculate the price of any tree plus any combination of decorations. The system must be easily extendable in the sense that whenever new decorations are added in the store you will have to at most add one class.	holiday tree
Here are two tables representing costs of trees and decorations, respectively


Name	Cost
Fraser Fir	35
Douglas Fir	30
Balsam Fir	25
Colorado Blue Spruce	50
 

Name	Cost
Star	4
Ruffles	1
Balls Red	1
Balls Silver	3
Balls Blue	2
Ribbons	2
Lights	5
LEDs	10

A very important requirement is that a tree can only have one star. When a user wants to decorate a tree containing a star with a new star, you must print a warning that the tree already has a star and not add the price of a star to tree. Users must be able to continue decorating their tree if they attempt to add another star to it.  The following code snippet illustrates the problem:

Tree mytree = new BlueSpruce();
mytree = new Star(mytree);
mytree = new Ruffles(mytree);
mytree = new Star(mytree); //this is problematic and should not be permitted
mytree = new Ruffles(mytree);
printtree(mytree);

should lead to something like:

Tree already has a star!
Blue spruce tree decorated with, a Star, Ruffles, Ruffles costs $56.00

You should design your solution such that adding an additional star is not allowed.  While stars are decorations, they are special.  Consider how you might avoid the problem in the sample above an implement.  An important consideration is what class should be responsible for enforcing a single star on a tree."

Source File Structure:
- OhChristmasTree.cs (Main)
- Tree.cs (Holds the Tree)
- TreeDecorations (Holds the ornament decorator)

Main Folder Contains:
- TrackTheRing with everything
	- Source Files (OhChristmasTree)
		- bin
			- Debug
				- Where .exe lives.
	- Visual Studio Solution
- ReadMe
- UML.pdf
- UML.XML (For my future personal use)
- OhChristmasTree.exe (Normally in ./bin/debug/ but brought up front for ease of use)

Instructions:
A simple menu system that starts with the choice of a single tree, then you choose ornaments through a new menu.
After pressing 0 to exit the program, it displays the string of GetDescription() which prints to the console the tree then all the decorations.
Done.

Shortcomings:
- I figured I could try to implement another layer of Decorator for tree-toppers specifically.
- I know there are specific bugs including a buffer problem within the menu system. Choosing numbers outside of the options crashes the program even though there shouldn't be an issue. I believe this has to do with a ReadLine and Int.Parse error. Will continue to look into it.
- I want to flesh out how the singleton is implemented. It isn't very expandable and I want to make it expandable.

