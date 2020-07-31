//Container class for tracking game save data.

using UnityEngine;

//A static instance of the games data that will hold the information
//while the user is playing the game
public static class SavedState
{
    public static bool livingRoomPadlockSolved = false;
    public static bool clockSolved = false;
    public static bool fridgeSolved = false;
    public static bool tvSolved = false;
    public static bool bedroomPadlockSolved = false;
    public static bool bathroomLockSolved = false;
    public static bool bookcaseSolved = false;
    public static string lastScene = "Living Room";
}
