using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Cube1script : MonoBehaviour
{
    Camera mainCam;
    public static float userPosX;
    public static float userPosZ;


    // Start is called before the first frame update
    void Start()
    {
       
        mainCam = Camera.main;

    }

    // Update is called once per frame
    void FixedUpdate()
    {
        userPosX = mainCam.transform.position.x;
        userPosZ = mainCam.transform.position.z;
        //transform.position = new Vector3(mainCam.transform.position.x, 0, mainCam.transform.position.z);  // Movement behaviour of the cube. 
        transform.position = new Vector3(userPosX, 0, userPosZ);  // Movement behaviour of the cube. 

    }
}