using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PressurePlate : MonoBehaviour
{
    public GameObject isTriggered;

    private void OnTriggerEnter(Collider target)
    {
        if(target.gameObject.layer == LayerMask.NameToLayer("Grabbable"))
        {
            Debug.Log("is cheese");
            isTriggered.SetActive(true);
        }
        else
        {
            Debug.Log("not cheese");
        }
    }
}
