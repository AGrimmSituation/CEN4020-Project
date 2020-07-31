using UnityEngine;

public class BookcasePuzzle : MonoBehaviour
{
    [SerializeField]GameObject bookcase1 = null;    //Original bookcase hiding door
    [SerializeField]GameObject bookcase2 = null;    //Moved position of bookcase
    [SerializeField]GameObject hiddenDoor = null;   //Door behind bookcase leads outside
    [SerializeField]GameObject correctBook = null;  //bookcaseUI collider over Fahrenheit 451
    [SerializeField]AudioSource bookSound = null;
    // Start is called before the first frame update
    void Start()
    {
        bookSound = GetComponent<AudioSource>();
    }
    void OnMouseDown()
    {
        if(correctBook) //If the correct book is clicked, reveal the secret door
        {
            bookcase1.gameObject.SetActive(false);
            bookcase2.gameObject.SetActive(true);
            hiddenDoor.gameObject.SetActive(true);
            bookSound.PlayOneShot(bookSound.clip);
        }
    }
}
