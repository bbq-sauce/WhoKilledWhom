using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FlashLightLogic : MonoBehaviour
{
    public AudioSource audioSource;
    public AudioClip iCanSeeU;
    public bool isHorrorEventPlayed = false;
    public Light flashLight;
    public GameObject ghost;
    public Light horrorLight;
    // Start is called before the first frame update
    void Start()
    {
        
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
        audioSource.PlayOneShot(iCanSeeU);
        ghost.transform.Rotate(new Vector3(0,0,0));
    }
}
