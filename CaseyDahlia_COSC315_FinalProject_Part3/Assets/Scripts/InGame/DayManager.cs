using System.Collections;
using System.Collections.Generic;
using UnityEngine.UI;
using UnityEngine;

public class DayManager : MonoBehaviour
{
    // Start is called before the first frame update

    public const int TIMESCALE = 360;

    private Text timeText;
    private Text dateText;

    private int day;
    private double hour, minute, second;
    void Start()
    {
        day = 1;
        minute = 0;
        hour = 20;

        timeText = GameObject.Find("Time").GetComponent<Text>();
        dateText = GameObject.Find("Date").GetComponent<Text>();

        
    }

    // Update is called once per frame
    void Update()
    {
        CalculateTime();
        CalculateDate();
    }

    void DateTextCallFunction()
    {
        dateText.text = day.ToString();
    }

    void TimeTextCallFunction()
    {
        if(hour <= 12)
        {
            timeText.text = string.Format("{0:00}:{1:00} am", hour, minute);
        }
        else
        {
            timeText.text = string.Format("{0:00}:{1:00} pm", hour, minute);
        }
        
    }

    void CalculateTime()
    {
        second += (Time.deltaTime * TIMESCALE);

        if(second >= 60)
        {
            minute++;
            second = 0;
            TimeTextCallFunction();
            DateTextCallFunction();
        }

        else if(minute >= 60)
        {
            hour++;
            minute = 10;
            TimeTextCallFunction();
            DateTextCallFunction();
        }
        else if(hour >= 24)
        {
            day++;
            hour = 5;

            Debug.Log("Day ends");
            TimeTextCallFunction();
            DateTextCallFunction();

        }
        else if(day > 1)
        {
            Time.timeScale = 0f;
            //TIMESCALE = 0;
            Debug.Log("Game Ends!");
            DateTextCallFunction();
        }

    }

    void CalculateDate()
    {

    }
}
