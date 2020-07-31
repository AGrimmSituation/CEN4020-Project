using System.Collections;
using System.Collections.Generic;
using UnityEngine;

//A non-static version of the game data so an object can be created
//in order to write the data to a file, and retrieve it. The data in this
//object will then be copied to the static instance of the game data
[System.Serializable]
public class StateData 
{
	public bool lrPadlock;
	public bool clock;
	public bool fridge; 
	public bool tv;
	public bool brPadlock;
	public bool bathLock;
	public bool loftSolved;
	public string lastScene;

	public StateData()
	{
	lrPadlock = SavedState.livingRoomPadlockSolved;
	clock = SavedState.clockSolved;
	fridge = SavedState.fridgeSolved; 
	tv = SavedState.tvSolved;
	brPadlock = SavedState.bedroomPadlockSolved;
	bathLock = SavedState.bathroomLockSolved;
	loftSolved = SavedState.bookcaseSolved;
	lastScene = SavedState.lastScene;
	}







}
