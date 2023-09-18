using UnityEngine;
using UnityEngine.SceneManagement;

public class LoadSceneOnCollision : MonoBehaviour
{
    public string sceneToLoadName; // Name of the scene to load
    public GameObject objectToCheck; // The object to check for collision

    private bool collisionOccurred = false; // Flag to track collision

    void Update()
    {
        if (collisionOccurred)
        {
            // Load the specified scene by name
            SceneManager.LoadScene("New Scene");
        }
    }

    void OnTriggerEnter(Collider other)
    {
        // Check if the collider belongs to the object we want to track
        if (other.gameObject == objectToCheck)
        {
            // Set the collision flag to true when the object collides
            collisionOccurred = true;

            // Optionally, display a message when the collision occurs
            Debug.Log("Collision occurred");

            // Disable the object that triggered the collision (optional)
            objectToCheck.SetActive(false);
        }
    }
}

