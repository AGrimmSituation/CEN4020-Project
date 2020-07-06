using UnityEngine;

public class FridgeMagnet : MonoBehaviour
{
    [SerializeField] FridgePuzzle puzzle = null;
    [SerializeField] string letter = "1";

    //hopefully adds each letter to the answer
    //string to compare to the correct answer
    void OnMouseDown()
    {
        if(puzzle)
        {
            puzzle.AddLetter(letter);
        }
    }
}
