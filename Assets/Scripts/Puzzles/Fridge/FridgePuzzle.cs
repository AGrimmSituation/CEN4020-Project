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
    
    public void AddLetter(string s)
    {
        //Check combinations given by user for the right answer.
        //If yes, freeze the puzzle to show it was correct.

        if (!isSolved)
        {
            input += s;
            if (input == answer)
            {
                SolveAndLock();
            }
            else if (input.Length >= 7)
            {
                //the correct answer is only 7 chars long.
                //if the user's answer is >= 7 chars,
                //reset and clear it so they can try again
                input = "";
            }

            if (text)
            {
                text.text = input;
            }
        }
    }

    public void SolveAndLock()
    {
        //once solved: freeze and hide the puzzle,
        //and replace the fridge sprite to the 
        //corrected one in the scene
        isSolved = true;
        fridge.sprite = solvedFridge;
        text.text = answer;
        gameObject.SetActive(false);
    }
}

