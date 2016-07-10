using UnityEngine;
using System.Collections;
//need to add this include to get access to the UI text object
using UnityEngine.UI;

public class TextController : MonoBehaviour {
	
	//need to add this to get access to the text object in the UI.  Need the UnityEngine.UI include to have access to this
	//This actually publishes a public object from the script.  This object is then available to the Unity engine to link the text object
	//in the UI to.
	public Text UItext;
	private enum states
	{
		cell,
		mirror,
		sheets_0,
		lock_0,
		cell_mirror,
		sheets_1,
		lock_1,
		corridor_0
	};
	//create a variable of enum states
	private states currentState;
		
	// Use this for initialization
	void Start () {
		state_cell();
	}
	
	// Update is called once per frame
	void Update () {
		switch(currentState)
		{
			case states.cell: state_cell();	break;
			case states.sheets_0: state_sheets_0();	break;
			case states.cell_mirror: state_cell_mirror(); break;
			case states.lock_0: state_lock_0();	break;
			case states.corridor_0: state_corridor_0();	break;
		}
//		if (currentState == states.cell)
//		{
//			state_cell();
//		}
//		else if (currentState == states.sheets_0)
//		{
//			state_sheets_0();
//		}
//		else if (currentState == states.cell_mirror)
//		{
//			state_cell_mirror();
//		}
//		else if (currentState == states.lock_0)
//		{
//			state_lock_0();
//		}
		
	}
	
	void state_cell()
	{
		currentState = states.cell;
		//the '\n' character is the escape new line charater
		UItext.text = "You are in a prison cell and want to escape.  There are some dirty sheets on the bed and a mirror on " +
					  "the wall, and the door is locked from the outside.\n\n"+
					  "S to view Sheets \n" +
					  "M to view the Mirror \n" +
					  "L to view the Lock";
		if(Input.GetKeyDown(KeyCode.S))
		{
			currentState = states.sheets_0;
		}
		else if(Input.GetKeyDown(KeyCode.M))
		{
			currentState = states.cell_mirror;
		}
		else if(Input.GetKeyDown(KeyCode.L))
		{
			currentState = states.lock_0;
		}
	}
	
	void state_sheets_0()
	{
		//the '\n' character is the escape new line charater
		UItext.text = "You investigate the sheets and only find dried semen and some poo.  You lick them to confirm.\n\n" +
					  "M to view the Mirror \n" +
					  "L to view the Lock";
		
		if(Input.GetKeyDown(KeyCode.M))
		{
			currentState = states.cell_mirror;
		}
		else if(Input.GetKeyDown(KeyCode.L))
		{
			currentState = states.lock_0;
		}
			
	}
	
	void state_cell_mirror()
	{
		//the '\n' character is the escape new line charater
		UItext.text = "You look into the cell mirror.  You are one ugly SOB.  You are too dumb to look behind the mirror which contained " +
					  "a portal out of the jail.\n\n" +
					  "S to view Sheets \n" +
					  "L to view the Lock";
		
		if(Input.GetKeyDown(KeyCode.S))
		{
			currentState = states.sheets_0;
		}
		else if(Input.GetKeyDown(KeyCode.L))
		{
			currentState = states.lock_0;
		}
		
		
	}
	
	void state_lock_0()
	{
		//the '\n' character is the escape new line charater
		UItext.text = "You decide to try the cell lock.  To your utter amazement it is open.  You have been in this cell for 20 years! " +
					  "Your wife has remarried, your kids don't know their father and you have lost everything and all this time the " +
					  "cell door was unlocked :-(.\n\n" +
					  "Press Return to proceed" ;
		
		if(Input.GetKeyDown(KeyCode.Return))
		{
			currentState = states.corridor_0;
		}
	}
	
	void state_corridor_0()
	{
		//the '\n' character is the escape new line charater
		UItext.text = "You enter the corridor \n\n" +
					  "Press Return to proceed" ;
		
		if(Input.GetKeyDown(KeyCode.Return))
		{
			currentState = states.corridor_0;
			//this will hide an object
			UItext.enabled = false;
		}
	}
	
}
