using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TutorialManager : MonoBehaviour
{
    [SerializeField] private Animator myDoor = null;

    public GameObject[] popUps;
    public int popUpIndex;
    public float waitTime = 2f;
    public float waitTime2 = 1f;
    public GameObject checkMark;

    // Update is called once per frame
    void Update()
    {
        if (popUpIndex == 0)
        {
            checkMark.SetActive(false);
            if (waitTime <= 0)
            {
                popUps[0].SetActive(true);
                if (Input.GetKeyDown(KeyCode.A) || Input.GetKeyDown(KeyCode.D))
                {
                    popUpIndex++;
                    waitTime = 2;
                    checkMark.SetActive(true);
                }
            }
            else
            {
                waitTime -= Time.deltaTime;
            }
        }
        else if (popUpIndex == 1)
        {
            if (waitTime <= 0)
            {
                checkMark.SetActive(false);
                popUps[0].SetActive(false);
                popUps[1].SetActive(true);
                if (Input.GetKeyDown(KeyCode.W))
                {
                    popUpIndex++;
                    waitTime = 2;
                    checkMark.SetActive(true);
                }
            }
            else
            {
                waitTime -= Time.deltaTime;
            }

        }
        else if (popUpIndex == 2)
        {
            if (waitTime <= 0)
            {
                checkMark.SetActive(false);
                popUps[1].SetActive(false);
                popUps[2].SetActive(true);
                if (Input.GetKeyDown(KeyCode.S))
                {
                    popUpIndex++;
                    waitTime = 2;
                    checkMark.SetActive(true);
                }
            }
            else
            {
                waitTime -= Time.deltaTime;
            }

        }
        else if (popUpIndex == 3)
        {
            if (waitTime <= 0)
            {
                checkMark.SetActive(false);
                popUps[2].SetActive(false);
                popUps[3].SetActive(true);
                if (waitTime2 <= 0)
                {
                    popUpIndex++;
                    popUps[3].SetActive(false);
                    waitTime = 2;
                    myDoor.Play("doorOpen", 0, 0.0f);
                }
                else
                {
                    waitTime2 -= Time.deltaTime;
                }
            }
            else
            {
                waitTime -= Time.deltaTime;
            }

        }
    }
}
