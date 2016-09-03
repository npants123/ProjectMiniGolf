using System.Collections;
using UnityEngine;

/// <summary>
/// Water trigger.
/// </summary>
public class WaterTrigger : MonoBehaviour
{
    #region variables

    //a ref to the player object
    private GameObject m_playerObj;
    //a ref to the ballscript
    private BallScript m_ballScript;

    #endregion

    public  void OnEnable()
    {
        GolfManager.onStartHole += onShowStart;
    }

    public  void OnDisable()
    {
        GolfManager.onStartHole -= onShowStart;
    }

    public void onShowStart()
    {
        //get the player object
        GameObject go = GameObject.FindWithTag("Player");
        if (go)
        {
            //save a ref of the players gameobject
            m_playerObj = go;

            //get the players ballscript
            m_ballScript = m_playerObj.GetComponent<BallScript>();
        }
    }

    public void Start()
    {
        onShowStart();
    }

    public void OnTriggerEnter(Collider col)
    {
        if (col.gameObject == m_playerObj)
        {
            //ensure there is a ballscript object and then call its fallout funciton.
            if (m_ballScript)
            {

                m_ballScript.fallout();
            }
        }
    }
}
