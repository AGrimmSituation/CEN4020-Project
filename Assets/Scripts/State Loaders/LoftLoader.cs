using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LoftLoader : MonoBehaviour
{
    [SerializeField]BookcasePuzzle bookcasePuzzle = null;
    // Start is called before the first frame update
    void Start()
    {
        if(SavedState.bookcaseSolved)
        {
            bookcasePuzzle.SolveAndLock();
        }
    }
}