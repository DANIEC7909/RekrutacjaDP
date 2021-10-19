using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AgentMovement : MonoBehaviour
{
    #region Fields
    Rigidbody rb;
    [Header("This value represents speed of agent movement")]
    [SerializeField] float speed = 1;
    [Header("This value represents how far agent can walk")]
    [SerializeField] float length = 5;
    [Header("This value represents distance to new position generation")]
    [SerializeField] float distanceToChange=1;
  
    [SerializeField]Vector3 pos;
    #endregion
    void Start()
    {
        //get all references 
        rb = GetComponent<Rigidbody>();
       
    } 


    


    void FixedUpdate()
    {
       
        if (Vector3.Distance(transform.position, pos) < distanceToChange)
        {
            pos =CalculateNewPosition(length);
            
        }
        //simply movement 
        transform.position = Vector3.Lerp(transform.position, pos,Time.deltaTime*speed);
    }
    /// <summary>
    /// This func generate random position based on vector length
    /// </summary>
    /// <param name="length">length of vector</param>
    /// <returns></returns>
    Vector3 CalculateNewPosition(float length)
    {
        Vector3 pos = new Vector3(Random.Range(-length, length), 0, Random.Range(-length, length));
        return pos;
    }
}
