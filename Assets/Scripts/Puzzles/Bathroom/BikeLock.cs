using UnityEngine;
using UnityEngine.UI;

public class BikeLock : MonoBehaviour
{
    [Header("Scene References")]
    [SerializeField] GameObject cabinet = null;
    [SerializeField] GameObject bikelock = null;
    [SerializeField] Text text = null;

    [Header ("Attributes")]
    [SerializeField] string answer = "5 3 1";

    int leftDigit = 0;
    int middleDigit = 0;
    int rightDigit = 0;

    public string CurState { get => leftDigit + " " + middleDigit + " " + rightDigit; }

    bool isUnlocked = false;
    public bool IsUnlocked { get => isUnlocked; }

    void Start()
    {
        //text will show the different numbers
        //on the bikelock
        text.text = "0 0 0";
    }

    public enum Digit { Left, Middle, Right };
    public void IncrementDigit(Digit digit)
    {
        if (!isUnlocked)
        {
            // increment the digit
            switch (digit)
            {
                case Digit.Left:
                    leftDigit = (leftDigit + 1) % 10;
                    break;
                case Digit.Middle:
                    middleDigit = (middleDigit + 1) % 10;
                    break;
                case Digit.Right:
                    rightDigit = (rightDigit + 1) % 10;
                    break;
            }

            text.text = leftDigit + " " + middleDigit + " " + rightDigit;

            // check for solution
            if (CurState == answer)
            {
                SolveAndOpen();
            }
        }
    }

    public void SolveAndOpen()
    {
        //once solved, unlock the bikelock
        //and allow the cabinet to be opened
        isUnlocked = true;
        bikelock.SetActive(false);
        cabinet.GetComponent<BoxCollider2D>().enabled = true;
        gameObject.SetActive(false);
        SavedState.bathroomLockSolved = true;
    }
}
