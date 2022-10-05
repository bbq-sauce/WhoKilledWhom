using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FlashLightLogic : MonoBehaviour
{
    public AudioSource audioSource;
    public GameObject player;
    private CharacterController playerCharacter;
    public AudioClip iCanSeeU;
    public bool isHorrorEventPlayed = false;
    public Light flashLight;
    public GameObject ghost;
    public Light horrorLight;
    public GameObject tracker;
    public GameObject scareTracker;
    public GameObject rotationTracker;
    private bool isRayCasted = false;
    // Start is called before the first frame update
    void Start()
    {
        playerCharacter = player.GetComponent<CharacterController>();
    }

    // Update is called once per frame
    void Update()
    {
        Dim();
        if(flashLight.intensity <= 0 && !isHorrorEventPlayed)
        {
            HorrorEvent();
            isHorrorEventPlayed = true;
        }
        if(!isRayCasted)
        {
            BackScare();
        }
    }

    void Dim()
    {
        if(flashLight.intensity > 0.02f)
        {
            flashLight.intensity = flashLight.intensity - Time.deltaTime/25;
        }
        else
        {
            flashLight.intensity = 0;
        }
    }

    void HorrorEvent()
    {
        horrorLight.enabled = true;
        ghost.transform.parent = null;
        // tracker.transform.parent = null;
        audioSource.PlayOneShot(iCanSeeU);
        tracker.transform.parent = null;
        scareTracker.transform.parent = null;
        ghost.transform.position = scareTracker.transform.position;
        rotationTracker.transform.parent = null;
        playerCharacter.enabled = false;
    }

    void BackScare()
    {
        if(Physics.Raycast(transform.position,transform.forward,out var hit,Mathf.Infinity))
        {
            if(hit.collider.gameObject.tag == "RotationTracker")
            {
                ghost.SetActive(true);
                isRayCasted = !isRayCasted;
            }
        }
    }
}
