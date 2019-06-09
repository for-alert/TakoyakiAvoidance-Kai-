using SeneController;
using UnityEngine;

public class BackTitle : MonoBehaviour
{
    private SceneController sc;

    // Use this for initialization
    private void Start()
    {
        sc = new SceneController();
    }

    // Update is called once per frame
    private void Update()
    {
        if (Input.GetKey(KeyCode.Return))
        {
            sc.ChangeScene("Title");
        }
    }
}