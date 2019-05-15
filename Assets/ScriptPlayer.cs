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
        //Cargamos el primer texto al Texto del UI
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

        //Raycast con un laro máximo de 3Mts
        if (Physics.Raycast(myRay, out hitInfo, 3.0f))
        {
            //Solo detecta los objetos que tiene el Tag, en caso de no tenerlo mostraría nombre de cualquier objeto (Paredes)
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
            //If que en caso de no encontrar ningún objeto deshabilita el texto del UI y lo limpia
            objetoActual.enabled = false;
            objetoActual.text = "";
        }

        //Aquí es donde se prende y se apaga la flashlight

        if (Input.GetMouseButtonDown(0))
        {

            linternaSpot.enabled = lightOn;
            lightOn = !lightOn;
        }




    }
}
