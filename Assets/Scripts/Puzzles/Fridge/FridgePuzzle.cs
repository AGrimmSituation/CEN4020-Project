using UnityEngine;
using UnityEngine.UI;

public class FridgePuzzle : MonoBehaviour
{
    [Header("Scene References")]
    [SerializeField] Text text = null;
    [SerializeField] Sprite solvedFridge = null;
    [SerializeField] SpriteRenderer fridge = null;

    [Header("Attributes")]
    [SerializeField] string answer = "FIREMAN";
    string input = "";

    bool isSolved = false;
    public bool IsSolved { get => isSolved; }

    void Start()
    {
        text.text = "";
    }
    
    public void AddLetter(string s)
    {
        //Check combinations given by user for the right answer.
        //If yes, freeze the puzzle to show it was correct.

        if (!isSolved)
        {
            input += s;
            if (input == answer)
            {
                isSolved = true;
                //hides puzzle
                gameObject.SetActive(false);
                fridge.sprite = solvedFridge;
            }
            else if (input.Length >= 7)
            {
                input = "";
            }
        }

        if (text)
        {
            text.text = input;
        }
    }
}

