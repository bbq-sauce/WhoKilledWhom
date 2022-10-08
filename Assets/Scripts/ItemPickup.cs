using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class ItemPickup : MonoBehaviour
{
    public GameObject player;
    public Item item;
    public string tagName;
    public GameObject icon;
    public GameObject inference;
    void Start()
    {
        player = GameObject.FindGameObjectWithTag("Player");
    }
    void Pickup()
    {
        InventoryManager.instance.Add(item);
        icon.SetActive(true);
        try{
            inference.SetActive(true);
        }
        catch
        {
            
        }
        
        Destroy(gameObject);
    }

    void Update()
    {
        if(Input.touchCount > 0 && Input.touches[0].phase == TouchPhase.Began)
        {
            Ray ray = Camera.main.ScreenPointToRay(Input.touches[0].position);
            RaycastHit hit;

            if(Physics.Raycast(ray, out hit))
            {
                if((hit.collider != null) && hit.transform.gameObject.tag == tagName)
                {
                    // if(Vector3.Distance(player.transform.position,transform.position) < 5f)
                    {
                        Pickup();
                    }
                }
            }
        }
    }

#if UNITY_EDITOR
    void OnMouseDown()
    {
        // if(Vector3.Distance(player.transform.position,transform.position) < 3f)
        {
            Pickup();
        }
    }

#endif
}
