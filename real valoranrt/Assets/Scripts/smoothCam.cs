using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class smoothCam : MonoBehaviour
{
    public Animator animator;
    public float yes;

    private void OnTriggerExit(Collider other)
    {
        if(yes == 1)
        {
            animator.Play("cam1");
        }
        else if (yes == 2)
        {
            animator.Play("cam2");
        }
        else if (yes == 3)
        {
            animator.Play("cam3");
        }
    }
}
