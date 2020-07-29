using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[RequireComponent(typeof(AudioSource))]
public class StaticHandler : MonoBehaviour
{
    [SerializeField]AudioSource sound = null;
    [SerializeField]SpriteRenderer solvedChannel = null;
    public AudioClip noise1;
    public AudioClip noise2;

    // Start is called before the first frame update
    void Start()
    {
        sound = GetComponent<AudioSource>();
	sound.clip = noise1;
        sound.playOnAwake = true;
	sound.clip = noise2;
    	sound.loop = true;
    	sound.Play();
    }


    // Update is called once per frame
    void Update()
    {

        if(solvedChannel.gameObject.activeSelf == true)
        {
	    sound.loop = false;
            sound.Stop();
        }
    }

    void OnMouseDown()
    {
        if(solvedChannel.gameObject.activeSelf == false)
        {
            sound.PlayOneShot(sound.clip);
        }
    }
}
