using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class StaticHandler : MonoBehaviour
{
    [SerializeField]AudioSource sound = null;
    [SerializeField]SpriteRenderer solvedChannel = null;
    // Start is called before the first frame update
    void Start()
    {
        sound = GetComponent<AudioSource>();
        sound.playOnAwake = true;
    }

    // Update is called once per frame
    void Update()
    {
        if(solvedChannel.gameObject.activeSelf == true)
        {
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
