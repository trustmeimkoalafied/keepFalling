using UnityEngine;
using UnityEngine.UI;
using System.Collections;

public class GameController : MonoBehaviour
{
    public GameOverScreen GameOverScreen;
    int maxPlatform = 0;

    public void GameOver() {
        GameOverScreen.Setup(maxPlatform);
    }

    private void Awake() { /* ... */ }
    void Start() { /* ... */ }
    void SpawnPlatforms() { /* ... */ }
    void Spawn10More() { /* ... */ }
    public void TouchedPlatform(string name) { /* ... */ }
}
