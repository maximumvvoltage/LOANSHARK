using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class SEEKCountdown : MonoBehaviour
{

    float currentTime = 0f;
    public float startingTime = 190.1f;
    public GameObject Canvas;
    public Text countdownText;
    public HIDECountdown hCountdown;
    void Start()
    {
        currentTime = startingTime;
        //GetComponent<AudioSource>(Hiding).Play();
    }

    void Update()
    {
        SeekTime();
    }

    public void SeekTime()
    {
        currentTime -= 1 * Time.deltaTime;
        print(currentTime);
        countdownText.text = currentTime.ToString("0");
        countdownText.color = Color.red;

        if (currentTime <= 15)
        {
            countdownText.color = Color.green;
        }

        if (currentTime <= 0)
        {
            currentTime = 0;
        }
    }
}