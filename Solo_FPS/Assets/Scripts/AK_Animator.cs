using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AK_Animator : MonoBehaviour
{
    public Animator anim;

    void Update()
    {
        anim.SetBool("Vertical", Input.GetButton("Vertical"));
        anim.SetBool("Horizontal", Input.GetButton("Horizontal"));
    }
}
