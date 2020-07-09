using UnityEngine;

public class FridgeMagnet : MonoBehaviour
{
    [SerializeField] FridgePuzzle puzzle = null;
    [SerializeField] string letter = "1";

    //adds each letter to the answer string when a letter is clicked
    //in order to compare it to the correct answer, which occurs in the
    //FridgePuzzle script
    void OnMouseDown()
    {
        if(puzzle)
        {
            puzzle.AddLetter(letter);
        }
    }
}
