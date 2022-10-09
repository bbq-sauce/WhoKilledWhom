using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class LightLogic : MonoBehaviour
{
    public Light flashLight;
    public NavMeshAgent navMeshAgent;
    public GameObject screamer;
    public GameObject creature;
    public GameObject target;
    public bool isPlayed = false;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        DeathEvent();
    }

    void DeathEvent()
    {
        flashLight.intensity -= Time.deltaTime/5;
        if(flashLight.intensity <= 0.02f && !isPlayed)
        {
            screamer.transform.position = target.transform.position;
            navMeshAgent.enabled = true;
            creature.SetActive(true);
            isPlayed = !isPlayed;
        }
    }
}
