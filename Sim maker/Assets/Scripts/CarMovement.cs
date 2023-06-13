using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CarMovement : MonoBehaviour
{
    public float CarSpeed = 1;
    public float RotateSpeed = 1;
    public bool moveing = false;
    public Camera Cam1;
    public Camera Cam2;
    public Camera Cam3;
    public Camera OverallCam;


    void Update()
    {
        if (Input.GetKeyDown(KeyCode.F1))
        {
            Cam1.gameObject.SetActive(true);
            Cam2.gameObject.SetActive(false);
            Cam3.gameObject.SetActive(false);
            OverallCam.gameObject.SetActive(false);
        }

        if (Input.GetKeyDown(KeyCode.F2))
        {
            Cam1.gameObject.SetActive(false);
            Cam2.gameObject.SetActive(true);
            Cam3.gameObject.SetActive(false);
            OverallCam.gameObject.SetActive(false);
        }

        if (Input.GetKeyDown(KeyCode.F3))
        {
            Cam1.gameObject.SetActive(false);
            Cam2.gameObject.SetActive(false);
            Cam3.gameObject.SetActive(true);
            OverallCam.gameObject.SetActive(false);
        }


        if (Input.GetKeyDown(KeyCode.F4))
        {
            Cam1.gameObject.SetActive(false);
            Cam2.gameObject.SetActive(false);
            Cam3.gameObject.SetActive(false);
            OverallCam.gameObject.SetActive(true);
        }

        OverallCam.transform.LookAt(transform);




        //if (Input.GetKey(KeyCode.W))
        if (Input.GetButton("Forward"))
        {
            transform.Translate(0,0, CarSpeed);
            moveing = true;
            print("Go forward");
        }

        if (Input.GetKey(KeyCode.S))
        {
            transform.Translate(0, 0, -CarSpeed);
            moveing = true;
            print("Go backward");
        }

        if (Input.GetKeyUp(KeyCode.W) || Input.GetKeyUp(KeyCode.S)) 
        {
            moveing = false;
            print("Stop !");
        }


        if (Input.GetKey(KeyCode.A) && moveing == true)
        {
            transform.Rotate(0, -RotateSpeed,0);
            print("Go left");
        }

        if (Input.GetKey(KeyCode.D))
        {
            if (moveing == true)
            {
                transform.Rotate(0, RotateSpeed, 0);
                print("Go right");
            } 
        }
    }
}
