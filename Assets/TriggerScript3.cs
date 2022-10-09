using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TriggerScript3 : MonoBehaviour
{
    public DeathScript2 deathScript2;
    public AudioSource audioSource;
    public GameObject martha;
    public AudioClip audioClip;
    public GameObject playerCanvas;
    public GameObject questionPanel;
    public Camera mainCamera;

    public Camera cam2;
    public Camera cam1;
    public Animator horrorEndAnim;
    public GameObject thankuPanel;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    IEnumerator TiedUp()
    {
        yield return new WaitForSeconds(2);
        mainCamera.enabled = false;
        cam2.enabled = true;
    }

    public void HorrorEnd()
    {
        StartCoroutine(End());
        horrorEndAnim.enabled = true;
        martha.GetComponent<Animator>().enabled = false;
        martha.SetActive(true);
        
    }

    IEnumerator End()
    {
        yield return new WaitForSeconds(8);
        cam2.enabled = false;
        cam1.enabled = true;
        horrorEndAnim.SetTrigger("HorrorEnd");
        yield return new WaitForSeconds(2);
        audioSource.PlayOneShot(audioClip);
        yield return new WaitForSeconds(6);
        thankuPanel.SetActive(true);
        yield return new WaitForSeconds(5);
        deathScript2.TitleScreen();
    }

    void OnTriggerEnter(Collider other)
    {
        if(other.gameObject.tag == "Player")
        {
            StartCoroutine(TiedUp());
            questionPanel.SetActive(true);
            playerCanvas.SetActive(false);
        }
    }
}
