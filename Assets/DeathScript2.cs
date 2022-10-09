using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using StarterAssets;

public class DeathScript2 : MonoBehaviour
{
    public GameObject deathPanel;
    public GameObject dontDestroyObjects;
    public FirstPersonController firstPersonController;
    // Start is called before the first frame update
    void Start()
    {
        dontDestroyObjects = GameObject.FindGameObjectWithTag("DontDestroy");
    }

    // Update is called once per frame
    void Update()
    {
        if(AIWalk.isGameOver == true)
        {
            deathPanel.SetActive(true);
            firstPersonController.enabled = false;
            AIWalk.isGameOver = !AIWalk.isGameOver;
        }
    }

    public void Restart()
    {
        Destroy(dontDestroyObjects);
        Dont1.disableIndex = 0;
        Dont2.completionIndex = 0;
        InventoryManager.itemCount = 0;
        SceneManager.LoadScene(1);
    }

    public void TitleScreen()
    {
        Destroy(dontDestroyObjects);
        Dont1.disableIndex = 0;
        Dont2.completionIndex = 0;
        InventoryManager.itemCount = 0;
        SceneManager.LoadScene(0);
    }
}
