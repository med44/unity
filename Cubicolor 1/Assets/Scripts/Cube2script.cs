using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Cube2script : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    { 

    }

    // Update is called once per frame
    void FixedUpdate()
    {
        transform.position = new Vector3(Cube1script.userPosX * -1, 0, Cube1script.userPosZ);  // Movement behaviour of the cube.
    }
}
