using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{
    private Animator anim;
    // Use this for initialization
    void Start()
    {
        anim = GetComponent<Animator>();
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKey(KeyCode.LeftArrow) && Input.GetKey(KeyCode.RightArrow))
        {
            anim.SetBool("Left", false);
            anim.SetBool("Middle", true);
        }
        else
        {
            anim.SetBool("Middle", false);
        }

        if(Input.GetKey(KeyCode.LeftArrow) && !Input.GetKey(KeyCode.RightArrow))
        {
            anim.SetBool("Left", true);
        }

        else
        {
            anim.SetBool("Left", false);
        }

        if(Input.GetKey(KeyCode.RightArrow) && !Input.GetKey(KeyCode.LeftArrow))
        {
            anim.SetBool("Right", true);
        }

        else
        {
            anim.SetBool("Right", false);
        }
    }
}
