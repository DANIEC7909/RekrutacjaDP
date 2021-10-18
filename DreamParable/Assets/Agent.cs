using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Agent : MonoBehaviour
{
    Rigidbody rb;
    [SerializeField] float speed=1, multiplayer=5;
    bool xy;
    void Start()
    {
      
    }

    
    void FixedUpdate()
    {
        Vector3 pos = Vector3.zero;
        if (xy)
        {
            pos = new Vector3(Mathf.Sin(Time.time) * multiplayer, 0, 0);
        }
        else
        {
            pos = new Vector3(0, 0, Mathf.Sin(Time.time) * multiplayer);
        }


        transform.position = Vector3.Lerp(transform.position, pos,Time.deltaTime*speed);
    }
}
