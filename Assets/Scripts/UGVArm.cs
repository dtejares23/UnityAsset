using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class UGVArm : MonoBehaviour
{
    public GameObject MechanicalArm;
    public GameObject Armpivot;
    public float mechanicalarmrotation;
    public float Armpivotrotation;

    void Update()
    {
        if (Input.GetKey(KeyCode.RightArrow)) 
        {
            MechanicalArm.transform.Rotate(0, mechanicalarmrotation, 0);
        }


        if (Input.GetKey(KeyCode.LeftArrow))
        {
            MechanicalArm.transform.Rotate(0, -mechanicalarmrotation, 0);
        }


        if (Input.GetKey(KeyCode.UpArrow))
        {
            Armpivot.transform.Rotate(-Armpivotrotation, 0, 0);
        }

        if (Input.GetKey(KeyCode.DownArrow))
        {
            Armpivot.transform.Rotate(Armpivotrotation, 0, 0);
        }
    }
}
