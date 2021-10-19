using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AgentGeneral : MonoBehaviour
{
    public int maxHealth = 3;
    public int health;
    public bool isCurrentlySelected;
     AgentSpawner agentSpawner;
   public Material[] materials;
    public MeshRenderer mr;
    private void Start()
    {
        health = maxHealth;
        agentSpawner = FindObjectOfType<AgentSpawner>();
        mr = GetComponent<MeshRenderer>();
    }

    private void Update()
    {
        if (health <= 0)
        {
            agentSpawner.spawnedAgent.Remove(this.gameObject);
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
