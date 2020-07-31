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

    bool isUnlocked = false;
    public bool IsUnlocked { get => isUnlocked;}

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

	if(isUnlocked == false)
	{
	    input += str;

	    if(input == answer)
	    {
		    SolveAndOpen();
	    }
	    else if (input.Length >= 3)
	    {
	    	input = "";
	    }
	}
        if(text)
        {
            text.text = input;
        }
    }

    public void SolveAndOpen()
    {
        //once solved, unlock the bikelock
        //and allow the cabinet to be opened
        isUnlocked = true;
        bikelock.SetActive(false);
        cabinet.GetComponent<BoxCollider2D>().enabled = true;
        SavedState.bathroomLockSolved = true;
    }
}
