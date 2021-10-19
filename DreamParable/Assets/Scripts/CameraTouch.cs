using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
public class CameraTouch : MonoBehaviour
{
    Camera camera;
    [SerializeField]AgentGeneral selectedAgent;
                AgentGeneral agentGeneral;
   [SerializeField] TextMeshProUGUI agentName;
   [SerializeField] TextMeshProUGUI agenthealth;
    private void Start()
    {
        #region Initialization
        camera = Camera.main;
        Cursor.lockState = CursorLockMode.None;
        Cursor.visible = true;
        #endregion
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
                    #region SelectObj
                    agentGeneral = hit.transform.GetComponent<AgentGeneral>();
                    agentGeneral.isCurrentlySelected = true;
                    agentGeneral.mr.material = agentGeneral.materials[1];
                    selectedAgent = agentGeneral;
                    #endregion
                }
                else if (hit.transform.tag!="agent") {
                    DeselectObj();
                }
            }
        }
        #region Pass all data to the overlay
        if (agentGeneral != null)
        {
            agentName.text = agentGeneral.name;
            agenthealth.text = agentGeneral.health.ToString();
        }
        else
        {
            agentName.text = "None";
            agenthealth.text = "0";
        }
            #endregion
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
