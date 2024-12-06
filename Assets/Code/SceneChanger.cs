using UnityEngine;
using UnityEngine.SceneManagement;

public class SceneChanger : MonoBehaviour
{
    // Scene name or build index you want to load
    public string sceneToLoad; // e.g., "MainMenu", "Level1"

    // This can be triggered by various events like a click, collision, etc.
    void OnMouseDown()
    {
        // Check if sceneToLoad is not empty or null
        if (!string.IsNullOrEmpty(sceneToLoad))
        {
            // Load the scene specified by the sceneToLoad string
            SceneManager.LoadScene(sceneToLoad);
        }
        else
        {
            Debug.LogError("Scene name not set. Please specify a scene to load.");
        }
    }
}
