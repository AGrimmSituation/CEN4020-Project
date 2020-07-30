using System.Collections;
using UnityEngine;

public class PlaySoundOnClick : MonoBehaviour
{
    [SerializeField]AudioSource sound;

    // Start is called before the first frame update
    void Start()
    {
        sound = GetComponent<AudioSource>();
    }

    void OnMouseDown()
    {
	    if(PauseMenu.paused == false)
	    {
        	sound.PlayOneShot(sound.clip);
	    }
    }
}
