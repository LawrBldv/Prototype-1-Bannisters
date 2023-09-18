using UnityEngine;

public class RemoveObject : MonoBehaviour
{
    public GameObject playerObject;

    void OnTriggerEnter(Collider other)
    {
        if (other.gameObject == playerObject)
        {
            playerObject.SetActive(false);
            Debug.Log("Player disappeared");
        }
    }
}

