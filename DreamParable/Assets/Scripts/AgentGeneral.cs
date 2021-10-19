using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AgentGeneral : MonoBehaviour
{
    #region Fields
    public int          maxHealth = 3;
    public int          health;
           AgentSpawner agentSpawner;
    public Material[]   materials;
    public MeshRenderer mr;
    //Flags
    public bool         isCurrentlySelected;
    #endregion
    private void Start()
    {
        //initialize health
        health = maxHealth;
        //get all references
        agentSpawner = FindObjectOfType<AgentSpawner>();
        mr = GetComponent<MeshRenderer>();
    }

    private void Update()
    {
        if (health <= 0)
        {
            agentSpawner.spawnedAgent.Remove(this.gameObject);//when agent dies remove em from agent spawner list
            Destroy(gameObject);
        }
    }

    private void OnCollisionEnter(Collision collision)
    {
        if (collision.transform.CompareTag("agent"))
        {
            health--;
        }
    }

}
