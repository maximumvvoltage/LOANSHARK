using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class HIDECountdown : MonoBehaviour
{
    //float seekingStartTime;
    public float hidingStartTime = 30f;
    public float seekingStartTime = 190.1f;

    [Header("GameObjects")]
    public GameObject HideObject;
    public GameObject SeekObject;
    public GameObject darkness;

    [Header("Dialogue Boxes")]
    public GameObject startDialogue;
    public GameObject halfTime;
    public GameObject loseDialogue;
    public GameObject winDialogue;

    [Header("Text Objects")]
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

        if (seekingStartTime <= 117)
        {
            startDialogue.SetActive(true);
            if (seekingStartTime <= 115)
            {
                startDialogue.SetActive(false);
            }    
        }
        if (seekingStartTime <= 30)
        {
            halfTime.SetActive(true);
            if (seekingStartTime <= 27)
            {
                halfTime.SetActive(false);
            }
        }
        
        if (seekingStartTime <= 0)
        {
            seekingStartTime = 0;
            winDialogue.SetActive(true);
        }
    }
}