using UnityEngine;
using UnityEngine.SceneManagement;

public class RulesMenu : MonoBehaviour
{
    public void GoToScene(string sceneName)
    {
        SceneManager.LoadScene(sceneName);
    }

    public void QuitApp()
    {
        Application.Quit();
        Debug.Log("Application Quit");
    }
}
