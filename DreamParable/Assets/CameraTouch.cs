using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraTouch : MonoBehaviour
{
    Camera camera;
    AgentGeneral selectedAgent;
    private void Start()
    {
        camera = Camera.main;
        Cursor.lockState = CursorLockMode.None;
        Cursor.visible = true;
    }
    void Update()
    {
        RaycastHit hit;
        Ray ray = camera.ScreenPointToRay(Input.mousePosition);

        if (Physics.Raycast(ray, out hit))
        {
            if (Input.GetButtonDown("Fire1"))
            {
                AgentGeneral agentGeneral= null;
                if (hit.transform.CompareTag("agent"))
                {
                    selectedAgent = null;
                     agentGeneral = hit.transform.GetComponent<AgentGeneral>();
                    agentGeneral.isCurrentlySelected = true;

                }else if (hit.transform.tag!="agent") {
                    selectedAgent = null;
                    if (agentGeneral != null)
                    {
                        agentGeneral.isCurrentlySelected = false;
                    }
                }
            }
        }
    }
}
