using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BedroomLoader : MonoBehaviour
{
    [SerializeField] TvPuzzle tvPuzzle = null;
    [SerializeField] CardPadlock cardPadlockPuzzle = null;

    void Start()
    {
        if (SavedState.tvSolved)
        {
            tvPuzzle.SolveAndLock();
        }

        if (SavedState.bedroomPadlockSolved)
        {
            cardPadlockPuzzle.SolveAndLock();
        }
    }
}
