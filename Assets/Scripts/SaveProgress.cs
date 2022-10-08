using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SaveProgress : MonoBehaviour
{
    public static SaveProgress instance;
    public GameObject audioManager;
    public GameObject inventoryManager;
    public GameObject child;
    public GameObject parentDontDestroy;
    
    void Start()
    {
        DontDestroyOnLoad(parentDontDestroy);
        // DontDestroyOnLoad(gameObject);
        // DontDestroyOnLoad(audioManager);
        // DontDestroyOnLoad(inventoryManager);
    }

    void Update()
    {
        
    }
}
