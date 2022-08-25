using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
public class DoorScript : MonoBehaviour
{
    public void Load_Next_Scene(Collider other)
    {
        SceneManager.LoadScene(2);
    }
}


