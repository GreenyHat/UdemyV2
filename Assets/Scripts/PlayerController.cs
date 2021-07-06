using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    [SerializeField]
    float speed;

    void Start()
    {

        speed = 20;
    }

    void Update()
    {
        //S = s0 + V * t* (dirección)
        transform.Translate(Vector3.forward * speed * Time.deltaTime);
    }
}
