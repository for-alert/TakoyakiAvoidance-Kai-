using System.Collections;
using System.Collections.Generic;
using SeneController;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameStart : MonoBehaviour
{
    SceneController sc;

    private void Start()
    {
        sc = new SceneController();
    }

// Update is called once per frame
    void Update()
    {
        if (Input.GetKey(KeyCode.Return))
        {
            sc.ChangeScene("Game");
        }
    }
}