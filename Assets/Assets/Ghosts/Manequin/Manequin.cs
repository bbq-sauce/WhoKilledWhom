using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Manequin : MonoBehaviour
{
    [SerializeField] private Animator Controlmanequin;
    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Player"))
        {
            Controlmanequin.SetBool("New Bool", true);
        }
    }

    private void OnTriggerExit(Collider other)
    {
        if (other.CompareTag("Player"))
        {
            Controlmanequin.SetBool("New Bool", false);
        }
    }
}
