using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Countdown : MonoBehaviour
{

    float currentTime = 0f;
    float startingTime = 10f;
    public GameObject darkness;

    [SerializeField] Text countdownText;
    void Start()
    {
        currentTime = startingTime;
        darkness.SetActive(false);
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
            darkness.SetActive(true);
            newTimerWait();
        }
        else
        {
        //   GetComponent<AudioSource>(Spotlight).Play();
        }

        IEnumerator newTimerWait()
        {
            yield return new WaitForSeconds(3);
            NewTimer();
        }
        
        void NewTimer()
        {
            startingTime == 120f;
            currentTime -= 1 * Time.deltaTime;
            print(currentTime);
            countdownText.text = currentTime.ToString("0");

            if (currentTime <= 10)
            {
                countdownText.color = Color.green;
            }
        }
    }
}
