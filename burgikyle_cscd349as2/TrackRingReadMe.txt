Name: Kyle Burgi
Assignment 2 - Observer(TrackTheRing)

Assignment Text - 
"As with assignment 1, develop a simple set of Java/C# classes using the Observer pattern to represent the following scenario:

In the land of Middle Earth battle wages between good and bad.  On the side of 'good' are Hobbits, Elves, Dwarves, and Men.  On the side of 'bad' are the wizard Saruman and the Witch King of Angmar (leader of the Nazgul).  The ever watching Eye of Sauron is always on the lookout for the agents of 'good'.  Saruman and the Witch King would like to be notified any time the Eye of Sauron spots one of the good guys.

Use the Observer pattern to model the above.  Utilize Java's Observer interface and Observable class as part of your implementation.  If you use C#, utilize the .NET counterparts (IObservable and IObserver).  Use the tester class given below as a starting point for your design (you may add more to the tester as necessary based on your solution to this problem).  Follow the Weather Data example from HFDP to aid you in your task.  Turn in a zip that contains your source files and a UML representation (.pdf required) of the classes and interfaces in your design.

<Code Snippet>
public class TestSauronEye {
    public static void main(String[] args) {

        EyeOfSauron eye = new EyeOfSauron();
        BadGuy saruman = new BadGuy(eye, "Saruman");
        BadGuy witchKing= new BadGuy(eye, "Witch King");
        eye.setEnemies(1, 1, 2, 0); //hobbits, elves, dwarves, men -- BTW, this is HORRIBLE coding style and a bad code smell
        //message should be displayed from Saruman and Angmar that they know about 1 hobbit, 1 elf, 2 dwarves
        
        saruman.defeated(); //Saruman is no longer registered with the Eye
        eye.setEnemies(4, 2, 2, 100);
        //only the Witch King reports on the enemies

    }//end main
}//end class
"
Source File Structure:
- Armies.cs (Armies Class, Holds army data)
- IObservable.cs (IObservable Interface)
- IObserver.cs (Observer Interface)
- TrackRingMain.cs (Main)

Main Folder Contains:
- TrackTheRing with everything
	- Source Files (TrackTheRing)
		- bin
			- Debug
				- Where .exe lives.
	- Visual Studio Solution
- ReadMe
- UML.pdf
- UML.XML (For my future personal use)
- TrackTheRing.exe (Normally in ./bin/debug/ but brought up front for ease of use)

Instruction:
When opening the program you are presented with the menu to select an army to show.
This will iterate through 7 turns, one for each army plus one more.
If no army is selected then a default army(Frodo and Same, 2 Hobbits) will be presented.
The Obervers will act as follows
	- Saruman dies after 3 turns.
	- The Witch King dies after all 7 turns.
The user may also choose to exit by entering 7 on any turn.

This program starts with both observers watching the EyeOfSauron, Then I kill them off one by one.

Shortcomings:
I was sick during this assignment so I didn't really go as in depth as I wanted to.

I was short sighted with my army menu system and didn't take into account options.
This meant the lack of support for on the fly Registering/Removing of Observers in this pattern.
	- Clearly, these are still workable in the code as that is how they are implemented.(Please don't dock me points for that <3).

I could have made an easily accesible army object for the user to make.
	- I would have made it a subclass that builds the Armies object through a method and passes in the variables.

Notes for grader:
If you see this, can you leave a comment on Canvas for me? I'd really like to know if you look through these.
Kyle.