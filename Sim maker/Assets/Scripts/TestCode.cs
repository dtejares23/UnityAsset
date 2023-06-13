using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TestCode : MonoBehaviour
{
    public int intVariable; // -3 -2 -1 0 1 2 3
    public float floatVariable; // 0.25 114.75633
    public string TXT; // !!$@ name any texts
    public GameObject obj; // any objects in our scene (camera 3d model light particle systems terrain or something else)
    public Camera cam; // only objects which have camera components 
    public Light lightobj; // only objects which have camera components 


    void Start()
    {
        // this function will work at the first moment of scene launch and it works only one time !
        print("Start function");
        print("Abolfazl age = "+ intVariable + TXT+ " = " + floatVariable);
    }

    void Update()
    {
        intVariable = intVariable + 2;
        AbolfazlAga();
    }

    void AbolfazlAga()
    {
        print("Abolfazl Age = " + intVariable);
    }
}
