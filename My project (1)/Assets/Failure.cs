using System.Collections;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Failure : MonoBehaviour
{
    public bool isEntered1;
    public GameObject personObject1;
    public BoxCollider collide;

    private void Start()
    {
        isEntered1 = false; // Initialize to false
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject == personObject1 && !isEntered1) // Check if it's the player and not already entered
        {
            isEntered1 = true;
            StartCoroutine(DelaySecond1());
        }
    }

    IEnumerator DelaySecond1()
    {
        Debug.Log("Finish Crossed!!");
        yield return new WaitForSeconds(1f);
        SceneManager.LoadScene("FailScene");
    }
}