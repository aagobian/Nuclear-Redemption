using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class SceneTransition222 : MonoBehaviour
{
    public RectTransform animationImage;
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
        Vector3 initialScale = animationImage.localScale;
        Vector3 targetScale = initialScale * 2f;

        while (timer < expandDuration)
        {
            timer += Time.deltaTime;
            float t = timer / expandDuration;
            animationImage.localScale = Vector3.Lerp(initialScale, targetScale, t);
            yield return null;
        }

        animationImage.localScale = targetScale;

        yield return new WaitForSeconds(stallDuration);

        // Shrink animation
        timer = 0f;
        initialScale = animationImage.localScale; // Update initial scale to the current scale
        targetScale = Vector3.zero; // Shrink to 0

        while (timer < expandDuration + stallDuration)
        {
            timer += Time.deltaTime;
            float t = timer / (expandDuration + stallDuration);
            animationImage.localScale = Vector3.Lerp(initialScale, targetScale, t);
            yield return null;
        }

        animationImage.localScale = targetScale;
        animationImage.gameObject.SetActive(false);
        isAnimating = false;

        StartGame();
    }
} 