using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class kkk : MonoBehaviour
{
    public Animator transitionAnimator;
    public string targetScene;

    public void PlaySceneTransition()
    {
        StartCoroutine(LoadSceneWithTransition());
    }

    IEnumerator LoadSceneWithTransition()
    {
        transitionAnimator.SetTrigger("Transition");
        yield return new WaitForSeconds(4f);
        SceneManager.LoadScene(targetScene);
    }
}
