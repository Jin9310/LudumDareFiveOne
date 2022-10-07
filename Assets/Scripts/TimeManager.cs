using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class TimeManager : MonoBehaviour
{
    public float timer;
    private float _startTimer = 10.1f;
    public int timerToInt;

    public static bool gameIsPaused;

    public TMP_Text tenSecondsText;

    private void Start()
    {
        timer = _startTimer;
    }

    private void Update()
    {
        //not working with TimeDeltaTime
        if (Input.GetKeyDown(KeyCode.Tab))
        {
            PauseGame();
            timer = _startTimer;
        }

        timerToInt = Mathf.RoundToInt(timer);
        tenSecondsText.text = timerToInt.ToString();

        if(timer >= 0)
        {
            timer -= Time.deltaTime;
            if(timer <= 0)
            {
                PauseGame();
                timer = 0;
            }
            
        }

        switch (timerToInt)
        {
            case > 4:
                tenSecondsText.color = Color.white;
                tenSecondsText.fontSize = 36;
                break;
            case 3:
                tenSecondsText.color = Color.red;
                tenSecondsText.fontSize = 50;
                break;
            case 2:
                tenSecondsText.color = Color.red;
                tenSecondsText.fontSize = 60;
                break;
            case 1:
                tenSecondsText.color = Color.red;
                tenSecondsText.fontSize = 70;
                break;
            case 0:
                tenSecondsText.color = Color.red;
                tenSecondsText.fontSize = 80;
                break;
        }

    }

    public IEnumerator PauseForSecond()
    {
        yield return new WaitForSeconds(1);
    }

    void PauseGame()
    {
        if (gameIsPaused)
        {
            Time.timeScale = 0f;
        }
        else
        {
            Time.timeScale = 1;
        }
    }
}
