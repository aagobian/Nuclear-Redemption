using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class kkk1 : MonoBehaviour
{
    public Animator transitionAnimator;
    public string targetScene;

    public void PlaySceneTransition()
    {
        StartCoroutine(LoadSceneWithTransition());
    }

    IEnumerator LoadSceneWithTransition()
    {
        transitionAnimator.SetTrigger("Animations");
        yield return new WaitForSeconds(1.5f);
        SceneManager.LoadScene(targetScene);
    }
}

