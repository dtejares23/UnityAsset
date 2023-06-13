using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TriggerTest : MonoBehaviour
{
    public float currentspeed;
    public GameObject[] Targets;


    private void Start()
    {
        gameObject.GetComponent<Renderer>().material.color = Color.white;
    }


    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag == "UGV")
        {
            gameObject.GetComponent<Renderer>().material.color = Color.red;
            for (int i = 0; i < Targets.Length; i++)
            {
                Targets[i].SetActive(true);
            }
            //currentspeed = other.gameObject.GetComponent<UGVMovement>().UGVSpeed;
            //other.gameObject.GetComponent<UGVMovement>().UGVSpeed = 0.1f;
        } 
    }

    private void OnTriggerExit(Collider other)
    {
        if (other.gameObject.tag == "UGV")
        {
            gameObject.GetComponent<Renderer>().material.color = Color.white;
            //other.gameObject.GetComponent<UGVMovement>().UGVSpeed = currentspeed;
        }
    }

}
