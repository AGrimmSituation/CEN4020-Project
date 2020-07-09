using UnityEngine;

public class CardPadlockButton : MonoBehaviour
{
    //Code used from previous padlock button implementation

    [SerializeField] CardPadlock padlock = null;
    [SerializeField] string letter = "1";

    //each time the user clicks on a letter,
    //the letter will be sent to the "Padlock2"
    //script to compare to the correct answer

    void OnMouseDown()
    {
        if(padlock)
        {
            padlock.AddLetter(letter);
        }
    }
}
