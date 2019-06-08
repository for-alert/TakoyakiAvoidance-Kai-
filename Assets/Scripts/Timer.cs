using System.Collections;
using System.Collections.Generic;
using SeneController;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class Timer : MonoBehaviour
{
    private float second = 60;

    private Text timerText;

    SceneController sc;

    // Use this for initialization
    void Start()
    {
        timerText = GetComponent<Text>();
        sc = new SceneController();
    }

    // Update is called once per frame
    void Update()
    {
        second -= Time.deltaTime;
        timerText.text = "残り" + ((int) second).ToString("00") + "秒";
        if ((int) second == 0)
        {
            sc.ChangeScene("GameClear");
        }
    }
}