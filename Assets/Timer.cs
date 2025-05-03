using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using System;

public class Timer : MonoBehaviour
{
    [SerializeField] TextMeshProUGUI timerText;
    float elapsedTime = 0f;
    bool isTiming = false;

    [SerializeField] TextMeshProUGUI timerText2;
    float elapsedTime2 = 0f;
    bool isTiming2 = false;

    public float ElapsedTime
    {
        get => elapsedTime;
    }
    public float ElapsedTime2
    {
        get => elapsedTime2;
    }

    void Update()
    {
        if (isTiming)
        {
            elapsedTime += Time.deltaTime;
            int minutes = Mathf.FloorToInt(elapsedTime / 60);
            int seconds = Mathf.FloorToInt(elapsedTime % 60);
            timerText.text = string.Format("{0:00}:{1:00}", minutes, seconds);
        }
        
        if (isTiming2)
        {
            elapsedTime2 += Time.deltaTime;
            int minutes = Mathf.FloorToInt(elapsedTime2 / 60);
            int seconds = Mathf.FloorToInt(elapsedTime2 % 60);
            timerText2.text = string.Format("{0:00}:{1:00}", minutes, seconds);
        }
        
    }
    // first player timer
    public void StartTimer()
    {
        elapsedTime = 0f;
        isTiming = true;
        // Debug.Log("1 Working");
    }

    public void StopTimer()
    {
        isTiming = false;
    }

    // second player timer
    
    public void StartTimer2()
    {
        elapsedTime2 = 0f;
        isTiming2 = true;
        // Debug.Log("2 Working");
    }

    public void StopTimer2()
    {
        isTiming2 = false;
    }
    
}
