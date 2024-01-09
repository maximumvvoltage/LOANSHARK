using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class HIDECountdown : MonoBehaviour
{

    float currentTime = 0f;
    public float startingTime;
    public GameObject darkness;
    public Text countdownText;
    public SEEKCountdown sCountdown;
    public Canvas HideCanvas;
    public Canvas SeekCanvas;
    void Start()
    {
        currentTime = startingTime;
        darkness.SetActive(false);
        //GetComponent<AudioSource>(Hiding).Play();
        SeekCanvas.GetComponent<Canvas>().enabled = false;
    }

    void Update()
    {
        HideTime();
    }

    IEnumerator Wait()
    {
        yield return new WaitForSeconds(5);
        sCountdown.SeekTime();
    }

    void HideTime()
    {
        currentTime -= 1 * Time.deltaTime;
        print(currentTime);
        countdownText.text = currentTime.ToString("0");

        if (currentTime <= 5)
        {
            countdownText.color = Color.red;
        }

        if (currentTime <= 0)
        {
            currentTime = 0;
            darkness.SetActive(true);
            Wait();
            SeekCanvas.GetComponent<Canvas>().enabled = true;
            HideCanvas.GetComponent<Canvas>().enabled = false;
        }
        else
        {
            //   GetComponent<AudioSource>(Spotlight).Play();
        }
    }
}