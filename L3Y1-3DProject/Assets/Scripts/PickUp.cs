using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PickUp : MonoBehaviour
{
    public GameObject pickupPoint;
    public GameObject lastPickup;

    bool inRange;

    // Start is called before the first frame update
    void Start()
    {
        inRange = false;
    }

    // Update is called once per frame
    void Update()
    {
        if (inRange && pickupPoint.transform.childCount == 0)
        {
            if (Input.GetKeyDown(KeyCode.Space))
            {
                lastPickup.transform.position = pickupPoint.transform.position;
                lastPickup.transform.parent = pickupPoint.transform;
                lastPickup.transform.GetComponent<Rigidbody>().isKinematic = true;
            }
        }
        else
        {
            if (pickupPoint.transform.childCount == 1)
            {
                if (Input.GetKeyDown(KeyCode.Space))
                {
                    lastPickup.transform.parent = null;
                    lastPickup.transform.GetComponent<Rigidbody>().isKinematic = false;
                    lastPickup.transform.GetComponent<Rigidbody>().AddForce(pickupPoint.transform.forward * 50f, ForceMode.Impulse);
                    lastPickup = null;
                }
            }
        }
    }

    void OnTriggerEnter(Collider other) 
    {
        if (other.gameObject.CompareTag("PickUp"))
        {
            inRange = true;
            lastPickup = other.gameObject;
        }
    }

    void OnTriggerExit(Collider other) 
    {
        if (other.gameObject.CompareTag("PickUp"))
        {
            inRange = false;
        }
    }
}
