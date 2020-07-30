using System.Collection;
using System.Collection.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Timer: Monobehaviour
{
    public float TimeRemaining = 150;
    public bool TimerIsRunning = false;

    void Start()
    {
        TimerIsRunning = true;
    }

 void Update()
 {
     if(TimerIsRunning)
     {
         if(TimeRemaining > 0)
         {
             TimeRemaining -= Time.deltaTime;
             DisplayTime(TimeRemaining)
         }
         else
     {
         Debug.Log("Game Over!");
         TimeRemaining = 0;
         TimerIsRunning = false;
     }
}

void DisplayTime(float timeToDisplay)
{
    timeToDisplay += 1
    
    float minutes = Mathf.FloorToInt(timeToDisplay / 60);
    float seconds = Mathf.FloorToInt(timeToDisplay % 60);

    timeText.text = string.Format("{0:00}:{1:00}", minutes, seconds);
}

 }   
}