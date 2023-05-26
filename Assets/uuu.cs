using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class TransitionButton : MonoBehaviour
{
    public string Scene1;

    private Button button;

    private void Start()
    {
        button = GetComponent<Button>();
        button.onClick.AddListener(TransitionToScene);
    }

    private void OnDestroy()
    {
        button.onClick.RemoveListener(TransitionToScene);
    }

    private void TransitionToScene()
    {
        SceneManager.LoadScene(Scene1);
    }
}
