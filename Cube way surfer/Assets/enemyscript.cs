using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class enemyscript : MonoBehaviour
{

    Rigidbody rb;
    public float speed;
    public float delay;
    public int SpeedNumber;

    void incspeed()
    {
        speed -= SpeedNumber;
        InvokeRepeating("incspeed", 0f, delay);


    }
    
    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody>();

    }

    // Update is called once per frame
    void FixedUpdate()
    {
        rb.velocity = new Vector3(0f, 0f, speed);
    }
}
