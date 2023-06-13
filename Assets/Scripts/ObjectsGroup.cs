using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ObjectsGroup : MonoBehaviour
{
    public float SizeX;
    public float PosZ;

    void Update()
    {
        transform.localScale = new Vector3(SizeX,1,1);
        transform.Translate(0,0,PosZ);
    }
}
