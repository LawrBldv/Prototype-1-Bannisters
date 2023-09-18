using System.Collections;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GoalScript : MonoBehaviour
{
    public bool isEntered;
    public GameObject personObject;
    public BoxCollider collide;

    private void Start()
    {
        isEntered = false; // Initialize to false
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject == personObject && !isEntered) // Check if it's the player and not already entered
        {
            isEntered = true;
            StartCoroutine(DelaySecond());
        }
    }

    IEnumerator DelaySecond()
    {
        Debug.Log("Finish Crossed!!");
        yield return new WaitForSeconds(1f);
        SceneManager.LoadScene("New Scene");
    }
}
