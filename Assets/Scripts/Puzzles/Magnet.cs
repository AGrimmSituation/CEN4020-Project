using UnityEngine;
using UnityEngine.UI;

public class Magnet : MonoBehaviour
{
    [Header("Scene References")]
    [SerializeField] Text text = null;
    [SerializeField] GameObject puzzle = null;

    [Header("Attributes")]
    [SerializeField] string answer = "FIREMAN";
    string input = "";

    void Start()
    {
        text.text = "";
    }
    
    public void AddLetter(string s)
    {
        //check combinations given by user for the right answer
        //if yes, freeze the puzzle to show it was correct

        input += s;
        if (input == answer)
        {
            puzzle.SetActive(false);
        }
        else if (input.Length >= 7)
        {
            input = "";
        }

        if (text)
        {
            text.text = input;
        }
    }
}

