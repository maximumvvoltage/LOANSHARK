using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Countdown : MonoBehaviour
{
    float currentTime = 0f;
    float startingTime = 30f;

    [SerializeField] Text countdownText;
    void Start()
    {
        currentTime = startingTime;
        //GetComponent<AudioSource>(Hiding).Play();
    }

    void Update()
    {
        currentTime -= 1 * Time.deltaTime;
        print(currentTime);
        countdownText.text = currentTime.ToString("0");

        if(currentTime <= 5)
        {
            countdownText.color = Color.red;
        }

        if(currentTime <= 0)
        {
            currentTime = 0;
        }
        else
        {
        //   GetComponent<AudioSource>(Spotlight).Play();
        }
    }
}
