using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LinternaSound : MonoBehaviour
{

    public AudioClip SoundToPlayClick;
    private AudioSource audioSrc;
    public Light luzHabitacion;
    // Start is called before the first frame update
    void Start()
    {
        audioSrc = GetComponent<AudioSource>();
    }

    // Update is called once per frame
    void Update()
    {
        //Al presionarl eel clcik hacemos el sonido pero reaalmente no prendemos, solo se reproduce el sonido 
        if (Input.GetMouseButtonDown(0))
        {
            audioSrc.PlayOneShot(SoundToPlayClick, 1f);
        }


    }
    private void OnTriggerEnter(Collider other)
    {
        
        //Si entra en la habitación se prende la luz
        if (other.gameObject.tag == "Habitacion2")
        {
            luzHabitacion.enabled = true;
            Debug.Log("Se ha entrado a la habitacion");
        }
        else
        {
            luzHabitacion.enabled = false;
            Debug.Log("Se ha salido a la habitacion");
        }
    }
    private void OnTriggerExit(Collider other)
    {
        //Al salir de la habitacion se apaga la luz
        if (other.gameObject.tag == "Habitacion2")
        {
            luzHabitacion.enabled = false;
            Debug.Log("Se ha salido a la habitacion");
        }
    }
}
