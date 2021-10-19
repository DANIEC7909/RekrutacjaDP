using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraTouch : MonoBehaviour
{
    Camera camera;
    [SerializeField]AgentGeneral selectedAgent;
                AgentGeneral agentGeneral;

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
                if (hit.transform.CompareTag("agent"))
                {
                    DeselectObj();

                    agentGeneral = hit.transform.GetComponent<AgentGeneral>();
                    agentGeneral.isCurrentlySelected = true;
                    agentGeneral.mr.material = agentGeneral.materials[1];
                    selectedAgent = agentGeneral;

                }else if (hit.transform.tag!="agent") {
                    DeselectObj();
                }
            }
        }
    }
    /// <summary>
    /// This function deselects all of selected agents both in this script and in agent
    /// </summary>
    void DeselectObj()
    {
        selectedAgent = null;
        if (agentGeneral != null)
        {
            agentGeneral.mr.material = agentGeneral.materials[0];
            agentGeneral.isCurrentlySelected = false;
            agentGeneral = null;
        }
    }
}
