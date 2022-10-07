using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class TriggerScript2 : MonoBehaviour
{
    public GameObject creepyGhost;
    public GameObject AIGhost;
    public GameObject parentCreep;
    public GameObject tracker;
    public AudioSource creatureAudio;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void OnTriggerEnter(Collider other)
    {
        if(other.gameObject.tag == "Player")
        {
            creepyGhost.GetComponent<SkinnedMeshRenderer>().enabled = true;
            creepyGhost.GetComponent<Collider>().enabled = true;
            parentCreep.transform.position = tracker.transform.position;
            parentCreep.GetComponent<NavMeshAgent>().enabled = true;
            creatureAudio.minDistance = 29;
            AIGhost.SetActive(true);
        }
    }
}
