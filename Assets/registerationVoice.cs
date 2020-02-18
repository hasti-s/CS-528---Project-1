using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class registerationVoice : MonoBehaviour
{ 

    public AudioSource audio;
    public bool isPlaying;// = false;

    // Start is called before the first frame update
    void Start()
    {
        audio = GetComponent<AudioSource>();
        isPlaying = false;
    }

    // Update is called once per frame
    void Update()
    {
        if (closeEnough())
        {
            if (!isPlaying)
            {
                isPlaying = true;
                if (!audio.isPlaying)
                {

                    audio.Play();
                }
            }
        }
        else
        {

            isPlaying = false;
            audio.Stop();
        }


    }

    public bool closeEnough() {
        if (Vector3.Distance(GameObject.Find("CAVE2-PlayerController").GetComponent<Transform>().position, transform.position) < 4)
            return true;
        else
            return false;
    }
}
