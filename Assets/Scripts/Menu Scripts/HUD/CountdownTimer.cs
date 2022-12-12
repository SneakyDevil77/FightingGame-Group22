using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class CountdownTimer : MonoBehaviour
{
    [SerializeField] private TMP_Text countdownText;

    private float elapsedTime = 0f;
    private float startedTime = 0f;
    private float startCountdown = 5;
    private float remainingTime = 0;
    private bool isPaused;
    public static bool isroundStarted = false;

    // Start is called before the first frame update
    void Start()
    {
        startedTime = Time.realtimeSinceStartup;
    }

    // Update is called once per frame
    void Update()
    {
        isPaused = PauseMenu.isPaused;  
        roundStartTimer();
    }

    void roundStartTimer()
    {
        if (remainingTime >= 0 && isPaused == false)
        {
            Time.timeScale = 0;
            elapsedTime = Time.realtimeSinceStartup - startedTime;
            remainingTime = startCountdown - elapsedTime;
            remainingTime = Mathf.RoundToInt(remainingTime);
            countdownText.enabled = true;
            countdownText.text = "" + remainingTime;
        }
        else if (remainingTime <= 0 && isPaused == false)
        {
        Time.timeScale = 1;
        countdownText.enabled = false;
        isroundStarted = true;
        }
  
    }
}
