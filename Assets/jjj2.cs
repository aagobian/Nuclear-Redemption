using UnityEngine;
using UnityEngine.UI;

public class jjj2 : MonoBehaviour
{
    public GameObject nextScreen;
    public Animator animator;

    public void TransitionToNextScreen()
    {
        animator.SetTrigger("EndTransition");
        // You can add any other code here to perform additional actions during the transition if needed

        // Example code to disable the current screen and enable the next screen after a delay
        float transitionDuration = animator.GetCurrentAnimatorStateInfo(0).length;
        Invoke("EnableNextScreen", transitionDuration);
    }

    private void EnableNextScreen()
    {
        gameObject.SetActive(false);
        nextScreen.SetActive(true);
    }
}

