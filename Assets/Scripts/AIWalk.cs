using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class AIWalk : MonoBehaviour
{
    public NavMeshAgent navMeshAgent;
    public GameObject player;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if(navMeshAgent.enabled)
        {
            navMeshAgent.SetDestination(player.transform.position);
        }
    }
}
