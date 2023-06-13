using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class UGVMovement : MonoBehaviour
{
    public float UGVSpeed = 1;
    public float RotateSpeed = 1;
    public Camera Cam1;
    public Camera Cam2;
    public Camera NoseCam;
    public Camera OverallCam;
    public bool Automove = false;
    public Automovement automovementscript;
    public NavMeshAgent navmesh;
    public GameObject StartPoint;
    public string Username;
    public GameObject PressF3;
    public GameObject PressF1;

    private void Start()
    {
        Username = PlayerPrefs.GetString("UserName");
        navmesh = gameObject.GetComponent<NavMeshAgent>();
        StartPoint = GameObject.Find("Start point");
    }

    void Update()
    {
        if (Input.GetKeyDown(KeyCode.F1))
        {
            Cam1.gameObject.SetActive(true);
            Cam2.gameObject.SetActive(false);
            OverallCam.gameObject.SetActive(false);
            NoseCam.gameObject.SetActive(false);
            automovementscript.enabled = false;
            navmesh.enabled = false;
            Automove = false;
            PressF1.SetActive(false);
        }

        if (Input.GetKeyDown(KeyCode.F2))
        {
            Cam1.gameObject.SetActive(false);
            Cam2.gameObject.SetActive(true);
            OverallCam.gameObject.SetActive(false);
            NoseCam.gameObject.SetActive(false);
            automovementscript.enabled = false;
            navmesh.enabled = false;
            Automove = false;
        }

        if (Input.GetKeyDown(KeyCode.F3))
        {
            Cam1.gameObject.SetActive(false);
            Cam2.gameObject.SetActive(false);
            OverallCam.gameObject.SetActive(true);
            NoseCam.gameObject.SetActive(false);
            automovementscript.enabled = true;
            navmesh.enabled = true;
            Automove = true;
            PressF3.SetActive(false);
        }


        if (Input.GetKeyDown(KeyCode.F4))
        {
            NoseCam.gameObject.SetActive(true);
            Cam1.gameObject.SetActive(false);
            Cam2.gameObject.SetActive(false);
            OverallCam.gameObject.SetActive(false);
            automovementscript.enabled = false;
            navmesh.enabled = false;
            Automove = false;
        }


        OverallCam.transform.LookAt(transform);

        if (Automove == false)
        {
            if (Input.GetKey(KeyCode.W))
            {
                transform.Translate(0, 0, UGVSpeed);
                print("Go forward");
            }

            if (Input.GetKey(KeyCode.S))
            {
                transform.Translate(0, 0, -UGVSpeed);
                print("Go backward");
            }

            if (Input.GetKeyUp(KeyCode.W) || Input.GetKeyUp(KeyCode.S))
            {
                print("Stop !");
            }

            if (Input.GetKey(KeyCode.A))
            {
                transform.Rotate(0, -RotateSpeed, 0);
                print("Go left");
            }

            if (Input.GetKey(KeyCode.D))
            {
                transform.Rotate(0, RotateSpeed, 0);
                print("Go right");
            }

            if (Input.GetKey(KeyCode.R)) 
            {
                transform.localEulerAngles = new Vector3(0,0,0);
                transform.position = StartPoint.transform.position;
            }
        }
    }
}
