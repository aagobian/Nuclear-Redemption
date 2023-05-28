using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class SceneTransition222 : MonoBehaviour
{
    public Image animationImage;
    public Button startButton;
    public float expandDuration = 1.0f;
    public float stallDuration = 1.0f;
    public float shrinkDuration = 1.0f;
    public string gameLevelSceneName = "Scene1";

    private bool isAnimating = false;

    private void Start()
    {
        animationImage.gameObject.SetActive(false);
        startButton.onClick.AddListener(PlayAnimation);
    }

    private void StartGame()
    {
        SceneManager.LoadScene(gameLevelSceneName);
    }

    public void PlayAnimation()
    {
        if (isAnimating) return;

        isAnimating = true;
        animationImage.gameObject.SetActive(true);
        StartCoroutine(Animate());
    }

    private System.Collections.IEnumerator Animate()
    {
        // Expand animation
        float timer = 0f;
        Vector3 initialScale = animationImage.transform.localScale;
        Vector3 targetScale = new Vector3(2f, 2f, 1f);

        while (timer < expandDuration)
        {
            timer += Time.deltaTime;
            float t = timer / expandDuration;
            animationImage.transform.localScale = Vector3.Lerp(initialScale, targetScale, t);
            yield return null;
        }

        yield return new WaitForSeconds(stallDuration);

        // Shrink animation
        timer = 0f;
        Vector3 currentScale = animationImage.transform.localScale;

        while (timer < shrinkDuration)
        {
            timer += Time.deltaTime;
            float t = timer / shrinkDuration;
            animationImage.transform.localScale = Vector3.Lerp(currentScale, initialScale, t);
            yield return null;
        }

        animationImage.transform.localScale = initialScale; // Set scale back to initial value
        animationImage.gameObject.SetActive(false);
        isAnimating = false;

        StartGame();
    }
}
