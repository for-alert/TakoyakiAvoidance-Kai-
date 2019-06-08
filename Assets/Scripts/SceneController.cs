using UnityEngine.SceneManagement;

namespace SeneController
{
    public class SceneController
    {
        public void ChangeScene(string scene)
        {
            SceneManager.LoadScene(scene);
        }
    }
}