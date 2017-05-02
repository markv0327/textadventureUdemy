using UnityEngine;
using UnityEngine.UI;
using System.Collections;

public class TextController : MonoBehaviour {

	public Text text;
	private enum States {cell, sheet_0, mirror, lock_0, cell_mirror, sheet_1, lock_1, corridor_0, 
						stairs_0, stairs_1, stairs_2, corridor_1, corridor_2, corridor_3, in_closet_1, in_closet, 
						closet_door, floor, floor_nothing_1, floor_nothing_2, courtyard};
	private States myState;
	
	// Use this for initialization
	void Start () {
		myState = States.cell;
	}
	
	// Update is called once per frame
	void Update () {
		print (myState);
		if (myState == States.cell) {
			cell();
		} else if (myState == States.sheet_0) {
			sheet_0();
		} else if (myState == States.lock_0) {
			lock_0();
		} else if (myState == States.mirror) {
			mirror();
		} else if (myState == States.lock_1) {
			lock_1();
		} else if (myState == States.sheet_1) {
			sheet_1();
		} else if (myState == States.cell_mirror) {
			cell_mirror();
		} else if (myState == States.corridor_0) {
			corridor_0();
		} else if (myState == States.stairs_0) {
			stairs_0();
		} else if (myState == States.closet_door) {
			closet_door();
		} else if (myState == States.floor) {
			floor();
		} else if (myState == States.floor_nothing_1) {
			floor_nothing_1();
		} else if (myState == States.floor_nothing_2) {
			floor_nothing_2();
		} else if (myState == States.corridor_1) {
			corridor_1();
		} else if (myState == States.stairs_1) {
			stairs_1();
		} else if (myState == States.in_closet) {
			in_closet();
		} else if (myState == States.in_closet_1) {
			in_closet_1();
		} else if (myState == States.corridor_2) {
			corridor_2();
		//} else if (myState == States.stairs_2) {
			//stairs_2();
		} else if (myState == States.corridor_3) {
			corridor_3();
		} else if (myState == States.courtyard) {
			courtyard();
		}
	}
	
	
	void cell () {
		text.text ="On a long and lonesome highway, east of Omaha. " +
					"You can listen to the engine moanin' out its one-note song " +
					"You can think about the woman, or the girl you knew the night before.\n\n" +
					"Press M for Mirror, S for Sheet, or L for Lock";
		if (Input.GetKeyDown(KeyCode.S)) {
			myState = States.sheet_0;
		} else if (Input.GetKeyDown(KeyCode.M)) {
			myState = States.mirror;
		} else if (Input.GetKeyDown(KeyCode.L)) {
			myState = States.lock_0;
		} 
	}
	
	void sheet_0 () {
		text.text ="These are some really dirty sheets.\n\n" +
					"Press R to Return to the Cell";
		if (Input.GetKeyDown(KeyCode.R)) {
			myState = States.cell;
		}
	}
	
	void lock_0 () {
		text.text ="Yep, locked tight.\n\n" +
			"Press R to Return to the Cell";
		if (Input.GetKeyDown(KeyCode.R)) {
			myState = States.cell;
		}
	}
	
	void mirror () {
		text.text ="What an ugly picture. Oh wait that's me!. You smashed the mirror and realize you can do the same to the lock.\n\n" +
			"Press L to Go to the Lock";
		if (Input.GetKeyDown(KeyCode.L)) {
			myState = States.lock_1;
		}
	}
	
	void cell_mirror () {
		text.text ="This is where the mirror use to be.\n\n" +
			"Press R to Return to the Lock";
		if (Input.GetKeyDown(KeyCode.R)) {
			myState = States.lock_1;
		}
	}
	
	void sheet_1 () {
		text.text ="You can use these digusting sheets to lower yourself to a safe distance or you can look at the broken mirror.\n\n" +
			"Press M to look at the Mirror or T to tie the sheets together";
		if (Input.GetKeyDown(KeyCode.M)) {
			myState = States.cell_mirror;
		} else if (Input.GetKeyDown(KeyCode.T)) {
			myState = States.corridor_0;
		}
	}
	
	void lock_1 () {
		text.text ="With your retard strength you smash the lock. Freedom! Oh wait, there's a long drop down.\n\n" +
			"Press S to look at your sheets, M to look at the Mirror";
		if (Input.GetKeyDown(KeyCode.S)) {
			myState = States.sheet_1;
		} else if (Input.GetKeyDown (KeyCode.M)) {
			myState = States.cell_mirror;
		}
	}
	
	void corridor_0 () {
		text.text ="You fall into a long corridor. To your left are some stairs, to your right is a closet door, and beneath you is, of course, the floor \n\n"+
		 "Press S for Stairs, C for Closet, or F for the Floor";
		if (Input.GetKeyDown(KeyCode.S)) {
			myState = States.stairs_0;
		} else if (Input.GetKeyDown(KeyCode.C)) {
			myState = States.closet_door;
		} else if (Input.GetKeyDown(KeyCode.F)) {
			myState = States.floor;
		}
	}
	
	void corridor_1 () {
		text.text ="Now that you have the hairclip what do you want to do? \n\n Press S for Stairs, C for Closet, or F to look at the Floor.";
		if (Input.GetKeyDown(KeyCode.S)) {
			myState = States.stairs_0;
		} else if (Input.GetKeyDown(KeyCode.C)) {
			myState = States.in_closet;
		} else if (Input.GetKeyDown(KeyCode.F)) {
			myState = States.floor_nothing_1;
		}
	}
	
	void corridor_2 () {
		text.text ="You are back in the corridor wearing that horrible duck costume. \n\n Press S for Stairs, C for Closet, or F to look at the Floor.";
		if (Input.GetKeyDown(KeyCode.S)) {
			myState = States.stairs_1;
		} else if (Input.GetKeyDown(KeyCode.C)) {
			myState = States.in_closet_1;
		} else if (Input.GetKeyDown(KeyCode.F)) {
			myState = States.floor_nothing_2;
		}
	}
	
	void corridor_3 () {
		text.text ="Ahead of you there is a courtyard. \n\n Press Space to enter it";
		if (Input.GetKeyDown(KeyCode.Space)) {
			myState = States.courtyard;
		}
	}
	
	void stairs_0 () {
		text.text ="You go to down the stairs but as you do a slab of concrete juts out of the wall blocking your path. \n\n Press R to go back down the Stairs";
		if (Input.GetKeyDown(KeyCode.R)) {
			myState = States.corridor_0;
		}
	}
	
	void stairs_1 () {
		text.text ="You walk down the stairs only tripping once on your giant duck feet. \n\n Press Space to look around";
		if (Input.GetKeyDown(KeyCode.Space)) {
			myState = States.corridor_3;
		}
	}
	
	/*void stairs_2 () {
		text.text ="You are in a corridor! \n\n Press Space to play again";
		if (Input.GetKeyDown(KeyCode.Space)) {
			Start ();
		}
	}*/
	
	void floor () {
		text.text ="You see a hairclip, Press Space to use this to open the closet door";
		if (Input.GetKeyDown(KeyCode.Space)) {
				myState = States.corridor_1;
		}
	}
	
	void floor_nothing_1 () {
		text.text ="You're staring at a dirty floor. \n\nPress Space to go back.";
		if (Input.GetKeyDown(KeyCode.Space)) {
			myState = States.corridor_1;
		}
	}
	
	void floor_nothing_2 () {
		text.text ="You're staring at a dirty floor";
		if (Input.GetKeyDown(KeyCode.Space)) {
			myState = States.corridor_2;
		}
	}
	
	void closet_door () {
		text.text ="The door is locked tight! \n\n Press R to go back.";
		if (Input.GetKeyDown(KeyCode.R)) {
			myState = States.corridor_0;
		}
	}
	
	void in_closet () {
		text.text ="You open the closet to reveal a tacky duck costume. Do you put the costume on? \n\n" +
					"Press Y to put the custome on, or N not to";
		if (Input.GetKeyDown(KeyCode.Y)) {
			myState = States.corridor_2;
		} else if (Input.GetKeyDown(KeyCode.N)) {
			myState = States.corridor_1;
		}
	}
	
	void in_closet_1 () {
		text.text ="You have the duck costume on. Do you want to take it off? \n\n" +
			"Press Y to put the custome on, or N not to";
		if (Input.GetKeyDown(KeyCode.Y)) {
			myState = States.corridor_1;
		} else if (Input.GetKeyDown(KeyCode.N)) {
			myState = States.corridor_2;
		}
	}
	
	void courtyard () {
		text.text ="In the courtyard you can see the way out at last. An alarm sounds behind you and guards start stirring"+ 
					"but you are already on your way out in your tacky duck custome! \n\n Press Space to play again";
		if (Input.GetKeyDown(KeyCode.Space)) {
			Start ();
		}
	}
}
