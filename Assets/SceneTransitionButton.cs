using UnityEngine;
using UnityEngine.SceneManagement;

public class SceneTransitionButton : MonoBehaviour
{
    public string Scene1; // The name of the scene to transition to

    public void TransitionToScene()
    {
        SceneManager.LoadScene(Scene1);
    }
}
