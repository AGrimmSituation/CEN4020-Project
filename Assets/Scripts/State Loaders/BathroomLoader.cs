using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BathroomLoader : MonoBehaviour
{
    [SerializeField] BikeLock bikeLock = null;

    void Start()
    {
        if (SavedState.bathroomLockSolved)
        {
            bikeLock.SolveAndOpen();
        }
    }
}
