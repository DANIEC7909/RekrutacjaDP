using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Agent : MonoBehaviour
{
    Rigidbody rb;
    void Start()
    {
        rb = GetComponent<Rigidbody>();
    }

    
    void FixedUpdate()
    {

        rb.MovePosition(new Vector3(Mathf.PingPong(Time.deltaTime, 5), 0, 0));
    }
}
