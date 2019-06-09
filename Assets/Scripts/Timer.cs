using SeneController;
using UnityEngine;
using UnityEngine.UI;

public class Timer : MonoBehaviour
{
    private float second = 60;

    private Text timerText;

    private SceneController sc;

    private void Start()
    {
        timerText = GetComponent<Text>();
        sc = new SceneController();
    }

    private void Update()
    {
        second -= Time.deltaTime;
        timerText.text = "残り" + ((int) second).ToString("00") + "秒";
        if ((int) second == 0)
        {
            sc.ChangeScene("GameClear");
        }
    }
}