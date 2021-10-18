using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AgentSpawner : MonoBehaviour
{
    [SerializeField] [Range(0, 10)] float minTime;
    [SerializeField] [Range(0, 10)] float maxTime;
    [SerializeField] List<GameObject> spawnedAgent;
    [SerializeField] int maxAgentCountOnScene;

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
        Debug.Log("spawn");
        //spawn obj^^
        //add this obj to spawnedA list 
    }
}
