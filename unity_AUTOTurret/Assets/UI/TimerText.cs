using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class TimerText : MonoBehaviour
{
    private TextMeshProUGUI _ui;
    private float _timeSave;

    public int SurvivalTime { get; private set; }
    public bool IsOn { get; set; }

    void Start()
    {
        _ui = GetComponent<TextMeshProUGUI>();
        _ui.text = $"�ð� : 0��";
        IsOn = true;
    }

    void Update()
    {
        // 1�ʿ� �ѹ����� ������Ʈ �ǵ���
        _timeSave += Time.deltaTime;
        if (IsOn)
        {
            if (_timeSave > 1.0f)
            {
                SurvivalTime += (int)_timeSave;
                _timeSave = 0;
                _ui.text = $"�ð� : {SurvivalTime}��";
            }
        }
    }
}
