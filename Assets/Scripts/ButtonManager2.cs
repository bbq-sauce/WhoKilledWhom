﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class ButtonManager2 : MonoBehaviour
{
    public GameObject destroyDontDestroy;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {

    }

    public void Restart()
    {
        Destroy(destroyDontDestroy);
        Dont1.disableIndex = 0;
        Dont2.completionIndex = 0;
        InventoryManager.itemCount = 0;
        SceneManager.LoadScene(1);
        
    }

    public void TitleScreen()
    {
        Destroy(destroyDontDestroy);
        Dont1.disableIndex = 0;
        Dont2.completionIndex = 0;
        InventoryManager.itemCount = 0;
        SceneManager.LoadScene(0);
    }
}
