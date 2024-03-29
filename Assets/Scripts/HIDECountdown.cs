using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class HIDECountdown : MonoBehaviour
{
    //float seekingStartTime;
    public float hidingStartTime = 30f;
    public float seekingStartTime = 160.1f;

    [Header("GameObjects")]
    public GameObject HideObject;
    public GameObject SeekObject;
    public GameObject darkness;
    public GameObject Triad1;
    public GameObject Triad2;
    public GameObject Triad3;

    [Header("Dialogue Boxes")]
    public GameObject DieDialogue;
    public GameObject FindDialogue;
    public GameObject startDialogue;
    public GameObject sixtySeconds; 
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

        if (hidingStartTime <= 30)
        {
            DieDialogue.SetActive(true);
            if (hidingStartTime <= 27)
            {
                DieDialogue.SetActive(false);
            }    
        }

        if (hidingStartTime <= 27)
        {
            FindDialogue.SetActive(true);
            if (hidingStartTime <= 24)
            {
                FindDialogue.SetActive(false);
            }    
        }
        if (hidingStartTime <= 0)
        {
            HideObject.SetActive(false);
            darkness.SetActive(true);
            SeekObject.SetActive(true);
            hidingStartTime = 0;
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

        if (seekingStartTime <= 129)
        {
            startDialogue.SetActive(true);
            Triad1.SetActive(true);
            Triad2.SetActive(true);
            Triad3.SetActive(true);
            if (seekingStartTime <= 124)
            {
                startDialogue.SetActive(false);
            }    
        }
        if (seekingStartTime <= 60)
        {
            sixtySeconds.SetActive(true);
            if (seekingStartTime <= 53)
            {
                sixtySeconds.SetActive(false);
            }
        }
        if (seekingStartTime <= 30)
        {
            halfTime.SetActive(true);
            if (seekingStartTime <= 23)
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