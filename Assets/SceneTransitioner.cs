using UnityEngine;
using UnityEngine.SceneManagement;

public class SceneTransitioner : MonoBehaviour
{
    public string Scene1; // The name of the scene to transition to

    public void TransitionToNextScene()
    {
        SceneManager.LoadScene(Scene1);
    }
}
