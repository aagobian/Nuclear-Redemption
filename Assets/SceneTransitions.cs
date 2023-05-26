using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class SceneTransitions : MonoBehaviour
{
    public Animator TransitionAnim;
    public string Scene1;

    public void StartSceneTransition()
    {
        StartCoroutine(LoadSceneWithTransition());
    }

    IEnumerator LoadSceneWithTransition()
    {
        TransitionAnim.SetTrigger("end");
        yield return new WaitForSeconds(1.5f);
        SceneManager.LoadScene(Scene1);
    }
}
