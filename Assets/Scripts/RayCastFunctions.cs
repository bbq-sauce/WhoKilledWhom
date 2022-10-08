using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RayCastFunctions : MonoBehaviour
{
    public GameObject trigger;
    public AudioSource audioSource;
    public AudioClip scaryClip;
    private bool isPlayed = false;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        ScaryEvent();
    }

    void ScaryEvent()
    {
        if(Physics.Raycast(transform.position,transform.forward,out var hit,50))
        {
            if(hit.collider == trigger.GetComponent<Collider>() && !isPlayed)
            {
                StartCoroutine(Scare());
                isPlayed = !isPlayed;
            }
        }
    }

    IEnumerator Scare()
    {
        yield return new WaitForSeconds(2);
        audioSource.PlayOneShot(scaryClip);
    }
}
