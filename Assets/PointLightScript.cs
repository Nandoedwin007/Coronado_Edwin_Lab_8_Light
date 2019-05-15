using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PointLightScript : MonoBehaviour
{
    private Light pointLight;
    // Start is called before the first frame update
    void Start()
    {
        pointLight = GetComponent<Light>();
    }

    // Update is called once per frame
    void Update()
    {
        //Este script es el que cambia la intensidad de la luz, lo hace siempre pero 
        //pero solo se obsrva cuando la luz está habilitada
        pointLight.intensity = Mathf.Sin(Time.time*5)*5;
    }
}
