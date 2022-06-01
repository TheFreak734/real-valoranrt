using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TutorialManager : MonoBehaviour
{
    [SerializeField] private Animator myDoor = null;

    public GameObject[] popUps;
    public int popUpIndex;
    public float waitTime = 15f;
    public float waitTime2 = 1f;

    public GameObject[] RobotVoices;
    public GameObject beep;

    public GameObject isTriggered;

    // Update is called once per frame
    void Update()
    {
        if (popUpIndex == 0)
        {
            RobotVoices[0].SetActive(true);
            beep.SetActive(false);
            if (waitTime <= 0)
            {
                RobotVoices[1].SetActive(true);
                popUps[0].SetActive(true);
                if (Input.GetKeyDown(KeyCode.W) || Input.GetKeyDown(KeyCode.S))
                {
                    popUpIndex++;
                    waitTime = 2;
                    beep.SetActive(true);
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
                beep.SetActive(false);
                RobotVoices[2].SetActive(true);
                popUps[0].SetActive(false);
                popUps[1].SetActive(true);
                if (Input.GetKeyDown(KeyCode.A) || Input.GetKeyDown(KeyCode.D))
                {
                    popUpIndex++;
                    waitTime = 2;
                    beep.SetActive(true);
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
                beep.SetActive(false);
                RobotVoices[3].SetActive(true);
                popUps[1].SetActive(false);
                popUps[2].SetActive(true);
                if (Input.GetKeyDown(KeyCode.Space))
                {
                    popUpIndex++;
                    waitTime = 2;
                    beep.SetActive(true);
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
                beep.SetActive(false);
                RobotVoices[4].SetActive(true);
                popUps[2].SetActive(false);
                popUps[3].SetActive(true);
                if (Input.GetKeyDown(KeyCode.E))
                {
                    beep.SetActive(true);
                    popUpIndex++;
                    popUps[3].SetActive(false);
                    waitTime = 2;
                }
            }
            else
            {
                waitTime -= Time.deltaTime;
            }
        }
        else if (popUpIndex == 4)
        {
            myDoor.Play("doorOpen", 0, 0.0f);
            if (waitTime <= 0)
            {
                beep.SetActive(false);
                RobotVoices[5].SetActive(true);
                popUps[3].SetActive(false);
                popUps[4].SetActive(true);
                if (isTriggered.activeInHierarchy)
                {
                    popUps[4].SetActive(false);
                    beep.SetActive(true);
                    popUpIndex++;
                    waitTime = 2;
                }
            }
            else
            {
                waitTime -= Time.deltaTime;
            }
        }
        else if (popUpIndex == 5)
        {
            beep.SetActive(false);
            RobotVoices[6].SetActive(true);
        }
    }
}
