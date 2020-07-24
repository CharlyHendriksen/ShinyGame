using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Timer : MonoBehaviour
{
    public float TimeRemaining = 10;
    public bool TimerIsRunning = false;
    public Text timeText;
     public GameObject LoseMenuUI;

    
    // Start is called before the first frame update
    void Start()
    {
        //Start timer automatically
        TimerIsRunning = true;
    }

    // Update is called once per frame
    void Update()
    {
       if (TimerIsRunning)
       {
           if (TimeRemaining > 0)
           {
               TimeRemaining -= Time.deltaTime;
               DisplayTime(TimeRemaining);
           }
           else
           {
                Debug.Log("Time has run out.");
                LoseMenuUI.SetActive(true);
                TimeRemaining = 0;
                TimerIsRunning = false; 
                Cursor.lockState = CursorLockMode.None;
                Cursor.visible = true; 
                Time.timeScale = 0f;


           }
       }
    }

    void DisplayTime(float TimeToDisplay)
    {
        TimeToDisplay +=1;

        float minutes = Mathf.FloorToInt(TimeToDisplay / 60); 
        float seconds = Mathf.FloorToInt(TimeToDisplay % 60);

        timeText.text = string.Format("{0:00}:{1:00}", minutes, seconds);
    }


}
