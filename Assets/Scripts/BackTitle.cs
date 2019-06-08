using System.Collections;
using System.Collections.Generic;
using SeneController;
using UnityEngine;
using UnityEngine.Experimental.UIElements;

public class BackTitle : MonoBehaviour
{
    private SceneController sc;

    // Use this for initialization
    void Start()
    {
        sc = new SceneController();
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKey(KeyCode.Return))
        {
            sc.ChangeScene("Title");
        }
    }
}