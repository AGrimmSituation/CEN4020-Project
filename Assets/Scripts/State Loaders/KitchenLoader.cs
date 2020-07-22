using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class KitchenLoader : MonoBehaviour
{
    [SerializeField] FridgePuzzle fridgePuzzle = null;

    void Start()
    {
        if (SavedState.fridgeSolved)
        {
            fridgePuzzle.SolveAndLock();
        }
    }
}
