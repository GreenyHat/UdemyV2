using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FollowPlayer : MonoBehaviour
/*PONEMOS FOLLOW PLAYER PORQUE NOS PUEDE VALER PARA LA CÁMARA, UNA MASCOTA O CUALQUIER COSA QUE NOS SIGA
 * SEA CAMARA, HUMO, LO QUE SEA.
 */
{
    public GameObject gObject;
    private Vector3 offset = new Vector3(0, 4, -5);

    void Start()
    {
        
    }

    void Update()
    {
        transform.position = gObject.transform.position + offset;//posicion de la camara se iguala a la del coche --> gObject
    }
}
