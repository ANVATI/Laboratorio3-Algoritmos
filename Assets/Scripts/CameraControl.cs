using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraControl : MonoBehaviour
{
    public GameObject steve;
    private Vector3 targetplayer;
    public float direccion;
    public float smoothed;

    void Update()
    {
        targetplayer = new Vector3(steve.transform.position.x,steve.transform.position.y,-10);
        transform.position = Vector3.Lerp(transform.position,targetplayer,smoothed * Time.deltaTime);
    }
    
}
