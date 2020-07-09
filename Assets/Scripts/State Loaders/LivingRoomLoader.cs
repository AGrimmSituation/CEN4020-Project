using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LivingRoomLoader : MonoBehaviour
{
    [SerializeField] Clock clockPuzzle = null;
    [SerializeField] Padlock padlockPuzzle = null;

    void Start()
    {
        if (SavedState.clockSolved)
        {
            clockPuzzle.SolveAndLock();
        }

        if (SavedState.livingRoomPadlockSolved)
        {
            padlockPuzzle.SolveAndLock();
        }
    }
}
