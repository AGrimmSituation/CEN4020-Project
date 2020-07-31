//Container class for tracking game save data.

using UnityEngine;

public static class SavedState
{
    public static bool livingRoomPadlockSolved = false;
    public static bool clockSolved = false;
    public static bool fridgeSolved = false;
    public static bool tvSolved = false;
    public static bool bedroomPadlockSolved = false;
    public static bool bathroomLockSolved = false;
    public static string lastScene = "Living Room";
}
