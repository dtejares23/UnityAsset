using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;
using UnityEngine.UI;

public class Automovement : MonoBehaviour
{
    public NavMeshAgent navmeshagent;
    public Transform[] Target;
    public int counter;
    public bool arrive = false;
    public float dist;
    public float Range = 3.5f;
    public float speedmovement = 8;
    public Slider Speedvolume;
    public Text Slidertitle;
    public Text Distancetext;

    private void Start()
    {
        navmeshagent.speed = speedmovement;
        Slidertitle.text = "Speed = " + Speedvolume.value;
    }

    void Update()
    {
        if (arrive == false)
        {
            navmeshagent.destination = Target[counter].position;
        }

        dist = Vector3.Distance(transform.position, Target[counter].position);
        Distancetext.text = "Distance = " + dist;

        if (dist < Range)
        {
            arrive = true;
            navmeshagent.speed = 0;
            if (counter != Target.Length-1)
            { 
                counter++;
            } 
        }

        if (dist > Range)
        {
            arrive = false;
            navmeshagent.speed = speedmovement;
        }
    }


    public void Speedchanges() 
    {
        speedmovement = Speedvolume.value;
        Slidertitle.text = "Speed = " + Speedvolume.value;
    }
}
