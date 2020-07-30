using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class BikeLock : MonoBehaviour
{
    [Header("Scene References")]
    [SerializeField] GameObject cabinet = null;
    [SerializeField] GameObject bikelock = null;
    [SerializeField] Text text = null;

    [Header ("Attributes")]
    [SerializeField] string answer = "531";
    string input = "";

    void Start()
    {
        //text will show the different numbers
        //on the bikelock
        text.text = "";
    }

    public void AddDigit(string str)
    {
        //while unsolved, compile answers
        //and check if they're correct

        //if the input size > 3, reset it
        //if you want to change the length, feel free
    }

    public void SolveAndOpen()
    {
        //once solved, unlock the bikelock
        //and allow the cabinet to be opened
    }
}
