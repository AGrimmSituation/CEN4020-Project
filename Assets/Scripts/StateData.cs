using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[System.Serializable]
public class StateData 
{
	public bool lrPadlock;
	public bool clock;
	public bool fridge; 
	public bool tv;
	public bool brPadlock;
	public string lastScene;

	public StateData()
	{
	lrPadlock = SavedState.livingRoomPadlockSolved;
	clock = SavedState.clockSolved;
	fridge = SavedState.fridgeSolved; 
	tv = SavedState.tvSolved;
	brPadlock = SavedState.bedroomPadlockSolved;
	lastScene = SavedState.lastScene;
	}







}
