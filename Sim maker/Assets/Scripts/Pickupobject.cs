using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Pickupobject : MonoBehaviour
{
    public bool Readyforpickup = false;
    public GameObject nose;
    public Rigidbody rigid;

    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag == "Arm nose")
        {
            Readyforpickup = true;
            nose = other.gameObject;
        }
    }

    private void OnTriggerExit(Collider other)
    {
        if (other.gameObject.tag == "Arm nose")
        {
            nose = null;
            Readyforpickup = false;
        }
    }


    private void Update()
    {
        if (Readyforpickup == true) 
        {
            if (Input.GetKeyDown(KeyCode.Space)) 
            {
                transform.parent = nose.transform;
                rigid.isKinematic = true;
            }

            if (Input.GetKeyDown(KeyCode.H))
            {
                transform.parent = null;
                rigid.isKinematic = false;
                print("Mission is done !");
            }
        }
    }
}
