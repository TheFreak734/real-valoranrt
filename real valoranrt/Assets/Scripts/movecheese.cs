using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class movecheese : MonoBehaviour
{
    [SerializeField] float speed;
    [SerializeField] Vector3 desiredPosition1;
    [SerializeField] Vector3 desiredPosition2;
    public GameObject cheese;

    public Animator animator;

    private IEnumerator wait;

    public GameObject fake;

    public GameObject firstLift;

    public GameObject holdArea;

    public PickupController pickup;

    public bool isLeft;

    private void OnTriggerStay(Collider target)
    {
        if (target.gameObject.layer == LayerMask.NameToLayer("Grabbable"))
        {
            if(target.name == "Fake")
            {
            
            }
            else
            {
                Destroy(target.gameObject);
            }
            animator.Play("Down1");
            animator.Play("Down2");
            wait = Wait(4f);
            if (holdArea.transform.childCount > 0)
            {
                pickup.DropObject();
                fake.SetActive(true);
            }
            Debug.Log("cheeesee");
            if (firstLift.activeInHierarchy == false)
            {
                StartCoroutine(wait);
            }
            else
            {
                cheese.transform.position = Vector3.Lerp(cheese.transform.position, desiredPosition2, speed * Time.deltaTime);
            }
        }
        else
        {
            Debug.Log("not cheese ??????");
        }
    }

    private IEnumerator Wait(float waitTime)
    {
        while (true)
        {
            Debug.Log("IEnumerator Started");
            cheese.transform.position = Vector3.Lerp(cheese.transform.position, desiredPosition1, speed * Time.deltaTime);
            yield return new WaitForSeconds(waitTime);
            fake.SetActive(false);
            firstLift.SetActive(true);
            Debug.Log("IEnumerator Ended");
        }
    }
}
