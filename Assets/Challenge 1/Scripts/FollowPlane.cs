using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FollowPlane : MonoBehaviour
{
    [SerializeField]
    GameObject plane;

    private Vector3 offset = new Vector3(0f, 6.7f, -16f);
    
    void Start()
    {
         
    }

    void Update()
    {
        transform.position = plane.transform.position + offset;
       // transform.rotation = plane.transform.rotation;
    }
}
