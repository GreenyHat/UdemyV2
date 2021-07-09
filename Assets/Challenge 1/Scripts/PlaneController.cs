using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlaneController : MonoBehaviour
{
   [SerializeField]
   GameObject propellerObject;

   float propellerInput, propellerSpeed;
  

    [SerializeField, Tooltip("Velocidad lineal del avión"), Range(0, 25)]
   float speed;

    [SerializeField, Tooltip("Velocidad de giro con respecto a los ejes Z (giro hacia der/izq) y X (arriba/abajo)"), Range(0,90)]    
   float zTurnSpeed, xTurnSpeed;

    [SerializeField, Tooltip("Ejes de dirección")]
   float horizontalInput, verticalInput, run;

    void Start()
    {
        speed = 10;
        propellerSpeed = 100000;
        zTurnSpeed = 50;
        xTurnSpeed = 50;
    }

    void Update()
    {
        propellerInput = Input.GetAxis("Fire2");
        run = Input.GetAxis("Fire1");
        verticalInput = Input.GetAxis("Vertical");
        horizontalInput = Input.GetAxis("Horizontal");
        
        transform.Translate(speed * Time.deltaTime * Vector3.forward * run);//S = s0 + V * t * (direcciónXYZ)
        transform.Rotate(zTurnSpeed * Time.deltaTime * Vector3.forward * horizontalInput);
        transform.Rotate(xTurnSpeed * Time.deltaTime * Vector3.right * verticalInput);     
        propellerObject.transform.Rotate(propellerSpeed * Time.deltaTime * Vector3.forward * propellerInput);     

    }
}
