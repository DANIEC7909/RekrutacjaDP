using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AgentMovement : MonoBehaviour
{
    Rigidbody rb;
    [SerializeField] float speed = 1, multiplayer = 5;
  
    float val;
    MeshRenderer mr;
    [SerializeField]Vector3 pos;
    void Start()
    {
        //get all references 
        rb = GetComponent<Rigidbody>();
        val = Random.Range(0, 10);
        mr = GetComponent<MeshRenderer>();
        
    } 


    


    void FixedUpdate()
    {
      
            if (val == 1 || val == 0 || val == 5 || val == 10)
            {
                pos = new Vector3(Mathf.Sin(Time.time) * multiplayer , 0, 0);
            }
            else if (val == 2 || val == 8 || val == 4||val==6)
            {
                pos = new Vector3(0, 0, Mathf.Sin(Time.time) * multiplayer );
            }
           else if (val == 9 || val == 7 || val == 3)
            {
                pos = new Vector3(Mathf.Sin(Time.time) * multiplayer , 0, Mathf.Sin(Time.time) * multiplayer );
            }
      
      
       

            //simply movement 
        transform.position = Vector3.Lerp(transform.position, pos,Time.deltaTime*speed);
    }
}
