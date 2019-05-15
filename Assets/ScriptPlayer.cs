using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ScriptPlayer : MonoBehaviour
{

    public Text objetoActual;
    private string NombreObjeto = "";
    private bool lightOn = false;

    public Light linternaSpot;
    // Start is called before the first frame update
    void Start()
    {
        objetoActual.text = NombreObjeto;
    }

    // Update is called once per frame
    void Update()
    {
        ////Version 2
        ////Camera.main es la caamara que es est[a utilizando en este momento

        //El Raycast sale del centro de la cámara
        Ray myRay = Camera.main.ViewportPointToRay(new Vector3(0.5f, 0.5f, 0));
        RaycastHit hitInfo;

        if (Physics.Raycast(myRay, out hitInfo, 3.0f))
        {
            if (hitInfo.collider.gameObject.tag == "SceneObject")
            {
                Debug.DrawRay(transform.position, hitInfo.point, Color.green);

                Debug.Log(hitInfo.collider.gameObject.name);

                //Destroy(hitInfo.collider.gameObject);
                objetoActual.enabled = true;
                objetoActual.text = hitInfo.collider.gameObject.name;
            }
            else
            {
                objetoActual.enabled = false;
                objetoActual.text = "";
            }

        }
        else
        {
            objetoActual.enabled = false;
            objetoActual.text = "";
        }

        if (Input.GetMouseButtonDown(0))
        {
            linternaSpot.enabled = lightOn;
            lightOn = !lightOn;
        }




    }
}
