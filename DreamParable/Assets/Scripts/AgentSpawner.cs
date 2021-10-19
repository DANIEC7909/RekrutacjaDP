using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AgentSpawner : MonoBehaviour
{
    [SerializeField] [Range(0, 10)] float minTime;
    [SerializeField] [Range(0, 10)] float maxTime;
    [SerializeField] int maxAgentCountOnScene;
    [SerializeField] GameObject Agent;
    public List<GameObject> spawnedAgent;

    //flags
    bool canSpawn = true;
    private void Update()
    {
        if (canSpawn == true)
        {
            if (spawnedAgent.Count < maxAgentCountOnScene)
            {
                StartCoroutine(Spawn(Random.Range(minTime, maxTime)));
                canSpawn = false;
            }
        }
    }
    IEnumerator Spawn(float time)
    {
        yield return new WaitForSeconds(time);
        canSpawn = true;
        GameObject go = Instantiate(Agent, new Vector3(0, 1, 0), Quaternion.identity);
        //spawn obj^^
        spawnedAgent.Add(go);
        //add this obj to spawnedA list 
    }
}
