using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    [SerializeField, Range(0,20), Tooltip("Velocidad lineal máxima del Game Object")]
    float speed;

    [SerializeField, Range(0, 90), Tooltip("Velocidad máxima de giro del GO")]
    float turnSpeed;

    [SerializeField, Tooltip("Ejes de dirección del GO")]
    private float horizontalInput, verticalInput;
  

    void Start()
    {
        speed = 20;
        turnSpeed = 50;

    }

    void Update()
    {
        horizontalInput = Input.GetAxis("Horizontal");
        verticalInput = Input.GetAxis("Vertical");
        //S = s0 + V * t* (dirección)
        transform.Translate(speed * Time.deltaTime * Vector3.forward * verticalInput);
        transform.Rotate(turnSpeed * Time.deltaTime * Vector3.up * horizontalInput);/*OJO CON ESTO,
                                                            DEBE GIRAR EN EL EJE Y PARA QUE PAREZCA QUE GIRA
                                                            POR ESO PONGO VECTOR3.UP,PIENSA EN ESTOS EJES COMO CARNE DE KEBAB*/
    }
}
