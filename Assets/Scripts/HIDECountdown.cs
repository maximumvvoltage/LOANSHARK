using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class HIDECountdown : MonoBehaviour
{
    //float seekingStartTime;
    public float hidingStartTime = 30f;
    public float seekingStartTime = 190.1f;
    public GameObject HideObject;
    public GameObject SeekObject;
    
    public GameObject darkness;
    public Text HideText;
    public Text SeekText;

    void Start()
    {
        HideObject.SetActive(true);
        darkness.SetActive(false);
        SeekObject.SetActive(false);
    }

    void Update()
    {
        HideTime();
        SeekTime();
    }

    void HideTime()
    {
        hidingStartTime -= 1 * Time.deltaTime;
        print(hidingStartTime);
        HideText.text = hidingStartTime.ToString("0");

        if (hidingStartTime <= 5)
        {
            HideText.color = Color.red;
        }

        if (hidingStartTime <= 0)
        {
            HideObject.SetActive(false);
            darkness.SetActive(true);
            SeekObject.SetActive(true);
        }
        if (hidingStartTime <= -2)
        {
            //startDialogue.SetActive(true);
        }
        if (hidingStartTime <= -5)
        {
            //startDialogue.SetActive(false);
        }
    }

    public void SeekTime()
    {
        seekingStartTime -= 1 * Time.deltaTime;
        print(seekingStartTime);
        SeekText.text = seekingStartTime.ToString("0");
        SeekText.color = Color.red;

        if (seekingStartTime <= 15)
        {
            SeekText.color = Color.green;
        }

        if (seekingStartTime <= 0)
        {
            seekingStartTime = 0;
        }
    }
}