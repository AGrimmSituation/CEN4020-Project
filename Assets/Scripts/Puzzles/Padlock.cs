using UnityEngine;

public class Padlock : MonoBehaviour
{
    [Header("Scene References")]
    [SerializeField] GameObject door = null;
    [SerializeField] GameObject padlock = null;

    [Header("Attributes")]
    [SerializeField] string answer = "2973";
    string input = "";

    bool isUnlocked = false;
    public bool IsUnlocked { get => isUnlocked; }

    public void AddDigit(string s)
    {
        if (isUnlocked == false)
        {
            input += s;
            if (input == answer)
            {
                isUnlocked = true;
                door.GetComponent<BoxCollider2D>().enabled = true;
                padlock.SetActive(false);
                gameObject.SetActive(false);
            }
            else if (input.Length >= 4)
            {
                input = "";
            }
        }
    }
}
