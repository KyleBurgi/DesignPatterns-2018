Name: Kyle Burgi
Assignment 1 - Guitar Hero

Assignment Text - 

"The upcoming Guitar Hero VIII: Legends of Rock needs a player configuration system. Guitar Hero VIII lets you play three different characters (Slash, Jimi Hendrix, and Angus Young). Each character can use one of three different guitars (Gibson SG, Fender Telecaster or Gibson Flying V) as well as perform a unique solo act (Put the Guitar on Fire, Jump off the Stage, Smash the Guitar).  Implement a player configuration system in Java or C# using the Strategy design pattern.  You should have separate classes to represent each of the components specified.  
 

Include a UML class diagram (as a .pdf) that represents your class relationships as part of your submission.  You are free to use any editing tools you wish.  Eclipse has a nice UML class diagram tool that will even generate the UML based on existing code.  Note however that it does not always build the class diagram correctly -- you should stay away from this tool until you have a good understanding of the components of a UML class diagram.  A reasonably good UML drawing program is Draw.IO (There will be a demo of this in class).  TinyUML is also pretty good.  You are welcome to use whatever you like *as long as it supports the basic UML symbols required for class diagrams -- we will go over these in class*."

Source File Structure:
- GuitarHero.cs (File Contains Main)
- GameCharacter.cs (Contains class for GameCharacter)
- Guitar.cs (IGuitar Interface and Classes that use IGuitar)
- Solo.cs (ISolo Interface and Classes that use ISolo)
- Menu.cs (IMenu Interface and Classes that use IMenu)

Main Folder Contains:
- GuitarHero Folder with everything
	- Source Files (GuitarHero)
		- bin
			- Debug
				- Where .exe lives.
	- Visual Studio Solution
- ReadMe
- UML.pdf
- UML.XML (For my future personal use)
- GuitarHero.exe (Normally in ./bin/debug/ but brought up front for ease of use)

My rendition of this assignment uses a menu system and a while loop to run.
There will always be two players and both players can choose everything to be the same.
- (While this is terrible design, I didn't deem it necessary for this specific assignment to forbide that)

Each player is presented with the option to:
- Choose a character (Which is just a field in GameCharacter)
- Choose a guitars
- Choose a solo

The user is then present with a menu:
 - 1/2/3 Swaps the solo on either or both players
 - 4/5/6 Swaps the guitar on either or both players
 - 99 Exits the program
 - Entering any other string will print out both players solos and guitars.
	- First player one, then player two.
	
Shortcomings:
 - The obvious lack of direction in how UI or testing should take place hindered me slightly. I didn't know how to produce the switches so I just decided to use a menu system.
 - I struggled in the beginning by making GameCharacter's class an interface originally to go above and beyond. This however was an obvious mistake, especially with my use of C#. This influenced GameCharacter to be just one singular class that uses both IGuitar and ISolo.
 - I suppose I could have added a way to change characters as well, but I don't see a point in doing that at this point.
 - I could have made the characters themselves Interfaces and implemented them that way.

 Last Minute Ideas that may or may not be implemented:
 - (DONE-ish) Making my menus an interface to reduce code clutter in some objects. (THIS WON'T HAVE UML or Main IMPLEMENTATION)
 - Make Characters an interfaceable object.
 
 Questions I have for myself:
 - Can interfaces contain interfaces?
	-For instance, can a Character Interface implement Costumes for that specific character?