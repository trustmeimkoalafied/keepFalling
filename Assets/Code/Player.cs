using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;  // Import TextMeshPro namespace
using UnityEngine.SceneManagement;  // Import the SceneManager to handle scene transitions

public class Player : MonoBehaviour
{
    public int friendsFound = 0;  // Number of friends found
    public int totalFriendsToFind = 3;  // Total number of friends needed to open the exit door
    public GameObject exitdoor;  // The exit door GameObject

    // Use TextMeshProUGUI instead of the regular UI Text
    public TextMeshProUGUI friendsFoundText;

    void Start()
    {
        UpdateFriendsText();  // Update the UI text at the start
    }

    void Update()
    {
        // You can add any player movement or other logic here.
        // For example, the Spacebar will simulate finding a friend for testing.
        if (Input.GetKeyDown(KeyCode.Space))
        {
            FindFriend();  // Simulate finding a friend
        }
    }

    void OnTriggerEnter2D(Collider2D other)
    {
        if (other.CompareTag("Friend"))
        {
            FindFriend();  // Call the FindFriend method when a friend is collided with
            Destroy(other.gameObject);  // Optionally destroy the friend object after being found
        }

        // Check if the player collides with the exit door
        if (other.CompareTag("ExitDoor") && exitdoor.activeSelf)
        {
            GameOver();  // Call GameOver method if the exit door is active
        }
    }

    public void FindFriend()
    {
        Debug.Log("Friend Found!");  // Debug log to check if the method is called
        friendsFound++;  // Increment the friends found count
        UpdateFriendsText();  // Update the UI text showing the friends found

        // If the player has found all the friends, open the exit door
        if (friendsFound >= totalFriendsToFind)
        {
            OpenExitDoor();
        }
    }

    private void OpenExitDoor()
    {
        if (exitdoor != null)
        {
            exitdoor.SetActive(true);  // Activate the exit door, making it visible
        }
    }

    // Update the UI Text element showing the number of friends found
    private void UpdateFriendsText()
    {
        if (friendsFoundText != null)
        {
            friendsFoundText.text = "Friends Found: " + friendsFound + "/" + totalFriendsToFind;
        }
    }

    // Method to handle game over and transition to the Game Over scene
    private void GameOver()
    {
        Debug.Log("Game Over!");  // Debug log for the game over event

        // You can replace "GameOverScene" with the actual name of your Game Over scene
        SceneManager.LoadScene("GameOver");  // Load the Game Over scene
    }
}


