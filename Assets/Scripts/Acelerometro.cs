using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class Acelerometro : MonoBehaviour
{

    public GameObject robot;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    float spped = 10.0f;
    // Update is called once per frame
    void Update()
    {
        Vector3 dir = Vector3.zero;

        dir.x = -Input.acceleration.y;        
        dir.z = -Input.acceleration.x;

        if(dir.sqrMagnitude > 1)
            dir.Normalize();

        dir *= Time.deltaTime;

        robot.transform.Translate(dir * spped);        
    }
}
