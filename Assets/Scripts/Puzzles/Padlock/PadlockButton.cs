using UnityEngine;

public class PadlockButton : MonoBehaviour
{
    [SerializeField] Padlock padlock = null;
    [SerializeField] string digit = "1";

    //each time the user clicks on a certain digit, 
    //it will send the digit to the "Padlock" script
    //to compare to the correct answer
    void OnMouseDown()
    {
        if(padlock)
        {
            padlock.AddDigit(digit);
        }
    }
}
