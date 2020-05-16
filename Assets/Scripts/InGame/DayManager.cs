using System.Collections;
using System.Collections.Generic;
using UnityEngine.UI;
using UnityEngine;

public class DayManager : MonoBehaviour
{
    //The speed of the clock
    public const int TIMESCALE = 360;

    //Text displaying on canvas
    private Text timeText;
    private Text dateText;

    //Number for day
    private int day;

    //Numbers for time
    private double hour, minute, second;
    
    void Start()
    {
        //First time displays on canvas
        day = 1;
        minute = 0;
        hour = 5;

        //Gets from Hierarcy
        timeText = GameObject.Find("Time").GetComponent<Text>();
        dateText = GameObject.Find("Date").GetComponent<Text>();

        
    }

    // Update is called once per frame
    void Update()
    {
        //Calls time change
        CalculateTime();

        //Calls date change
        CalculateDate();
    }

    //Calls to change the date after when the hour reaches a goal point in the display
    void DateTextCallFunction()
    {
        //dateText.text = day.ToString();
        dateText.text = "Day: "+ day.ToString();
    }

    //Calls to change the time in the display
    void TimeTextCallFunction()
    {
        if(hour <= 12)
        {
            timeText.text = string.Format("Time: "+"{0:00}:{1:00} am", hour, minute);
        }
        else
        {
            timeText.text = string.Format("Time: "+"{0:00}:{1:00} pm", hour, minute);
        }
        
    }

    //Calculates time
    void CalculateTime()
    {
        //Timer times speed
        second += (Time.deltaTime * TIMESCALE);

        //Detects seconds
        if(second >= 60)
        {
            minute++;
            second = 0;
            TimeTextCallFunction();
            DateTextCallFunction();
        }

        //Detects mintues
        else if (minute >= 60)
        {
            hour++;
            minute = 10;
            TimeTextCallFunction();
            DateTextCallFunction();
        }
        //Detects hours
        else if (hour >= 24)
        {
            day++;
            hour = 5;

            Debug.Log("Day ends");
            TimeTextCallFunction();
            DateTextCallFunction();

        }

        //Detects days
        else if (day > 7)
        {
            Time.timeScale = 0f;
            //TIMESCALE = 0;
            Debug.Log("Game Ends!");
            DateTextCallFunction();
        }

    }

    //Calculates date???
    void CalculateDate()
    {

    }
}
