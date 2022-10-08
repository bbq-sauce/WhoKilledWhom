using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using StarterAssets;

public class LookHorror : MonoBehaviour
{   
    public GameObject player;
    public AudioSource audioSource;
    public AudioClip violinScare;
    public AudioClip ultimateClip;
    public bool isPlayed = false;
    public GameObject ghost;
    public GameObject playerTracker;
    float desiredDuration = 5;
    float elapsedTime;  
    public float waitTime = 2; 
    bool hasSeen = false;
    public Animator deadAnim;
    public GameObject moveCanvas;
    public GameObject mobileCanvas;
    public GameObject buttons;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        GhostDetect();
    }

    void GhostDetect()
    {
        if(Physics.Raycast(transform.position, transform.forward, out var hit, Mathf.Infinity))
        {
            if(hit.collider.gameObject.tag == "Ghost" && !isPlayed)
            {
                if(!isPlayed)
                {
                    audioSource.PlayOneShot(violinScare);
                    StartCoroutine("UltimateScare");
                    isPlayed = !isPlayed;
                    hasSeen = true;
                }
                
            }
            if(hasSeen)
            {
                if(waitTime >= 0)
                waitTime = waitTime - Time.deltaTime;
                if(waitTime <= 0)
                {
                    elapsedTime += Time.deltaTime;
                    float percentageCompleted = elapsedTime/desiredDuration;
                    ghost.transform.position = Vector3.Lerp(ghost.transform.position,playerTracker.transform.position,percentageCompleted);
                    player.GetComponent<FirstPersonController>().enabled = false;
                    moveCanvas.SetActive(false);
                    mobileCanvas.SetActive(false);
                    deadAnim.SetTrigger("DeadAnim");
                    buttons.SetActive(true);
                }
                
            }
            
        }

    }

    IEnumerator UltimateScare()
    {
        yield return new WaitForSeconds(2);
        audioSource.PlayOneShot(ultimateClip);
    }

    IEnumerator JumpScare()
    {
        yield return new WaitForSeconds(2);
        if(Vector3.Distance(ghost.transform.position,transform.position) < 15)
        {
            ghost.transform.Translate(Vector3.forward);
            
        }
    }
}
