using System;
using System.Collections;
using System.Collections.Generic;
using Scrips;
using UnityEngine;

[RequireComponent(typeof(SphereCollider))]
public class BasePickupObject : MonoBehaviour
{
    // Start is called before the first frame update
    public Item itemToPickUp;
    private SphereCollider colider;
    private bool isTriggered;


    private Collider other;
    void Start()
    {
        colider = GetComponent<SphereCollider>();
        colider.isTrigger = true;
        colider.radius = 1;
        Debug.Log(itemToPickUp==null);
    }

    private void Update()
    {
        
        if (Input.GetKeyDown(KeyCode.E) && itemToPickUp != null&& isTriggered)
        {
            other.gameObject.GetComponent<Character>()
                .AddItem(itemToPickUp);
        }
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.CompareTag("Player"))
        {
            isTriggered = true;
            this.other = other;
        }
    }


    private void OnTriggerExit(Collider other)
    {
        if (other.gameObject.CompareTag("Player"))
        {
            isTriggered = false;
            this.other = null;
        }
    }


}
