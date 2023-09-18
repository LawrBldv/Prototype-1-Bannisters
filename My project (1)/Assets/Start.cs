using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class LoadSceneOnClick : MonoBehaviour
{
    public string sceneToLoad; // Name of the scene to load, set in the Inspector

    void Start()
    {
        Button button = GetComponent<Button>(); // Get the button component
        button.onClick.AddListener(LoadTargetScene); // Attach the click event listener
    }

    void LoadTargetScene()
    {
        SceneManager.LoadScene("SampleScene"); // Load the specified scene
    }
}
