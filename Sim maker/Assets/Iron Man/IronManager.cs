using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class IronManager : MonoBehaviour
{
    public Animator anim;
    public string IdleName;
    public string AttackName;


    void Update()
    {
        if (Input.GetKeyDown(KeyCode.A))
        {
            anim.SetBool("Fight",true);
            anim.Play(AttackName);
        }
        if (Input.GetKeyDown(KeyCode.I))
        {
            anim.SetBool("Fight", false);
            anim.Play(IdleName);
        }

    }
}
