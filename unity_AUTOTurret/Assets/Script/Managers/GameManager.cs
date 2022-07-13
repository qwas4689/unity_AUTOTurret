using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using System;

public class GameManager : MonoBehaviour
{
    public TimerText Timer;
    public GameOverUI GameOverUI;

    private bool _isOver;

    public void Update()
    {
        if (_isOver && Input.GetKeyDown(KeyCode.R))
        {
            SceneManager.LoadScene(0);
        }
    }

    public void End()
    {
        // 타이머 종료
        Timer.IsOn = false;


        // 데이터 저장
        int savedBestTime = PlayerPrefs.GetInt("BestTime", 0);
        int bestTime = Math.Max(Timer.SurvivalTime, savedBestTime);
        PlayerPrefs.SetInt("BestTime", bestTime);

        GameOverUI.Activate(bestTime);
        

        // GameOverUI에다가 갱신

        _isOver = true;
    }
}
