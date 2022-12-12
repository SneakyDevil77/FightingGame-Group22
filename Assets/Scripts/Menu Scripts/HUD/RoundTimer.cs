using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class RoundTimer : MonoBehaviour
{
    [SerializeField] private TMP_Text rTimer;

    public static float startingTimer;
    public static float currentTime;




    // Start is called before the first frame update
    void Start()
    {
        startingTimer = PlayerPrefs.GetFloat("TimerValue"); //Gets the length the round set by the slider in options menu
        currentTime = startingTimer;

    }

    // Update is called once per frame
    void Update()
    {
        if (CountdownTimer.isroundStarted == true)
        {
            startTimer();
        }
    }

    private void startTimer()
    {
        currentTime -= 1 * Time.deltaTime;
        rTimer.text = "Time Left: " + Mathf.Round(currentTime);
    }
}
