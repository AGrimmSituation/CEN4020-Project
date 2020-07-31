using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LivingRoomLoader : MonoBehaviour
{
    [SerializeField] Clock clockPuzzle = null;
    [SerializeField] Padlock padlockPuzzle = null;
    [SerializeField] BoxCollider2D loftDoor = null;

    void Start()
    {
        if (SavedState.clockSolved)
        {
            if (clockPuzzle)
            {
                clockPuzzle.SolveAndLock();
            }
        }

        if (SavedState.livingRoomPadlockSolved)
        {
            if (padlockPuzzle)
            {
                padlockPuzzle.SolveAndLock();
            }
        }

        if (SavedState.tvSolved)
        {
            if (loftDoor)
            {
                loftDoor.GetComponent<BoxCollider2D>().enabled = true;
            }
        }
    }
}
