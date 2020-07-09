using UnityEngine;
using UnityEngine.UI;

public class CardPadlock : MonoBehaviour
{
    //Code from previous padlock implementation
    //edited to work with padlock for this scene

    [Header("Scene References")]
    [SerializeField] GameObject door = null;
    [SerializeField] GameObject padlock = null;
    [SerializeField] Text text = null;


    [Header("Attributes")]
    [SerializeField] string answer = "understand";
    string input = "";

    bool isUnlocked = false;
    public bool IsUnlocked { get => isUnlocked; }

    void Start()
    {
        text.text = "";
    }

    
    public void AddLetter(string s)
    {
        //while the padlock is locked, take in the answer combination
        //the user supplies and check against the correct answer.
        //if the answer is correct, unlock the padlock and hide it 
        //from view. this allows the user to go through the door
        //with the padlock now open

        if(isUnlocked == false)
        {
            input += s;
            if(input == answer)
            {
                SolveAndLock();
            }
            else if (input.Length >= 10)
            {
                input = "";
            }
        }

        if (text)
        {
            text.text = input;
        }
    }

    public void SolveAndLock()
    {
        input = answer;
        isUnlocked = true;
        door.GetComponent<BoxCollider2D>().enabled = true;
        padlock.SetActive(false);
        SavedState.bedroomPadlockSolved = true;
        gameObject.SetActive(false);
    }
}
