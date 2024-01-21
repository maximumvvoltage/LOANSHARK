using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class HIDECountdown : MonoBehaviour
{
    float currentTime = 0f;
    public float startingTime;
    public GameObject darkness;
    public Text HideText;
    public Text SeekText;
    //public SEEKCountdown sCountdown;
    public GameObject startDialogue;
    //public Canvas HideCanvas;
    //public Canvas SeekCanvas;
    void Start()
    {
        currentTime = startingTime;
        darkness.SetActive(false);
        //GetComponent<AudioSource>(Hiding).Play();
        //SeekCanvas.GetComponent<Canvas>().enabled = false;
    }

    void Update()
    {
        HideTime();
    }

    void HideTime()
    {
        currentTime -= 1 * Time.deltaTime;
        print(currentTime);
        HideText.text = currentTime.ToString("0");

        if (currentTime <= 5)
        {
            countdownText.color = Color.red;
        }

        if (currentTime <= 0)
        {
            HideText.SetActive(false);
            darkness.SetActive(true);
        }
        if (currentTime <= -2)
        {
            startDialogue.SetActive(true);
        }
        if (currentTime <= -5)
        {
            startDialogue.SetActive(false);
            SeekText.SetActive(true);
        }
    }
}