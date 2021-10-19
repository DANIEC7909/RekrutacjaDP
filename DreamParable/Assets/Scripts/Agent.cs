using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Agent : MonoBehaviour
{
    Rigidbody rb;
    [SerializeField] float speed = 1, multiplayer = 5;
    [SerializeField] bool xy;
    [SerializeField] Material[] materials;
    [SerializeField]
    float val;
    void Start()
    {
        rb = GetComponent<Rigidbody>();
        val = Random.Range(0, 10);
        if (val == 1 || val == 0 || val == 5)
        {
            xy = true;
            GetComponent<MeshRenderer>().material = materials[0];
        }
        if (val == 2 || val == 8 || val == 4)
        {
            xy = false;
            GetComponent<MeshRenderer>().material = materials[1];
        }
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
