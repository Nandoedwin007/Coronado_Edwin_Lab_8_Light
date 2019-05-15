using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LinternaSound : MonoBehaviour
{

    public AudioClip SoundToPlayClick;
    private AudioSource audioSrc;
    // Start is called before the first frame update
    void Start()
    {
        audioSrc = GetComponent<AudioSource>();
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetMouseButtonDown(0))
        {
            audioSrc.PlayOneShot(SoundToPlayClick, 1f);
        }
    }
}
