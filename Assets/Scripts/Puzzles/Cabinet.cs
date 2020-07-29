using UnityEngine;
using UnityEngine.UI;

public class Cabinet : MonoBehaviour
{
    // Scene References
    [SerializeField] GameObject cabinet = null;
    [SerializeField] GameObject padlock = null;

    //when the user clicks on the Shampoo bottle
    //the padlock on the cabinet under the sink
    //will disappear and the user will be able to 
    //click on the cabinet

    void OnMouseDown()
    {
        padlock.SetActive(false);
        cabinet.GetComponent<BoxCollider2D>().enabled = true;
    }
}