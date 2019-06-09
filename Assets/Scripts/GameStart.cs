using SeneController;
using UnityEngine;

public class GameStart : MonoBehaviour
{
    private SceneController sc;

    private void Start()
    {
        sc = new SceneController();
    }

// Update is called once per frame
    private void Update()
    {
        if (Input.GetKey(KeyCode.Return))
        {
            sc.ChangeScene("Game");
        }
    }
}