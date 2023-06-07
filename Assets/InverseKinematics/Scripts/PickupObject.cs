using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PickupObject : MonoBehaviour
{


    public bool ReadyForPickup = false;
    public GameObject nose;
    public Rigidbody rigid;
    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag == "Arm nose")
        {
            nose = other.gameObject;
            ReadyForPickup = true;
        }
    }

    private void OnTriggerExit(Collider other)
    {
        if (other.gameObject.tag == "Arm nose")
        {
            nose = null;
            ReadyForPickup = false;
        }
    }

    private void Update()
    {
        if (ReadyForPickup == true)
        {
            if (Input.GetKeyDown(KeyCode.E))
            {
                transform.parent = nose.transform;
                gameObject.GetComponent<Renderer>().material.color = Color.blue;
                rigid.isKinematic = true;
            }

            if (Input.GetKeyDown(KeyCode.G))
            {
                transform.parent = null;
                gameObject.GetComponent<Renderer>().material.color = Color.yellow;
                rigid.isKinematic = false;
            }
        }
    }
}
