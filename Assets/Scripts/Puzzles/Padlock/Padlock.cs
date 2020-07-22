using UnityEngine;
using UnityEngine.UI;

public class Padlock : MonoBehaviour
{
    [Header("Scene References")]
    [SerializeField] GameObject door = null;
    [SerializeField] GameObject padlock = null;
    [SerializeField] Text text = null;

    [Header("Attributes")]
    [SerializeField] string answer = "2973";
    string input = "";

    bool isUnlocked = false;
    public bool IsUnlocked { get => isUnlocked; }

    void Start()
    {
        text.text = "";
    }

    public void AddDigit(string s)
    {
        //while the padlock is locked, take in the answer combination
        //the user is given and check if it is correct. if so, unlock
        //the padlock and hide it from view. this will allow the user
        //to go through the door with the padlock now open
        if (isUnlocked == false)
        {
            input += s;
            if (input == answer)
            {
                SolveAndLock();
            }
            else if (input.Length >= 4)
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
        isUnlocked = true;
        door.GetComponent<BoxCollider2D>().enabled = true;
        padlock.SetActive(false);
        gameObject.SetActive(false);
    }
}
