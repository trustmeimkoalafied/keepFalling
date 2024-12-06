using System.Collections;
using UnityEngine;
using UnityEngine.SceneManagement;  // For scene transitions (if you want to load a new scene)
using TMPro;  // TextMeshPro for displaying the respawn count

public class Respawn : MonoBehaviour
{
    Vector2 startPos;
    SpriteRenderer spriteRenderer;

    public int maxRespawns = 3;  // Maximum number of respawns allowed
    private int respawnsRemaining;

    // Reference to the TextMeshPro UI text element that will show respawn count
    public TMP_Text respawnText;

    private void Awake()
    {
        spriteRenderer = GetComponent<SpriteRenderer>();
    }

    private void Start()
    {
        startPos = transform.position;  // Store the initial position
        respawnsRemaining = maxRespawns; // Set respawn limit
        UpdateRespawnText();  // Update the text UI at the start
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.CompareTag("Obstacle"))
        {
            Die();
        }
    }

    void Die()
    {
        if (respawnsRemaining > 0)
        {
            respawnsRemaining--;  // Decrease the number of respawns left
            UpdateRespawnText();  // Update the UI text to show remaining respawns
            StartCoroutine(RespawnPlayer(0.5f));  // Respawn with a short delay
        }
        else
        {
            GameOver();  // If no respawns left, show game over screen
        }
    }

    IEnumerator RespawnPlayer(float duration)
    {
        spriteRenderer.enabled = false;  // Hide the player while respawning
        yield return new WaitForSeconds(duration);  // Wait for a short delay
        transform.position = startPos;  // Respawn at the original position
        spriteRenderer.enabled = true;  // Make the player visible again
    }

    void GameOver()
    {
        // Trigger Game Over logic here
        Debug.Log("Game Over! No respawns left.");

        // If you want to transition to a "Game Over" scene, you can do so like this:
        SceneManager.LoadScene("GameOver");  // Replace with the name of your Game Over scene
    }

    // Function to update the respawn count UI text
    void UpdateRespawnText()
    {
        if (respawnText != null)
        {
            respawnText.text = "Respawns Left: " + respawnsRemaining.ToString();
        }
    }
}


