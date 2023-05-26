using UnityEngine;
using UnityEngine.UI;

public class jjj : MonoBehaviour
{
    public GameObject nextScreen;
    public Animator animator;

    public void TransitionToNextScreen()
    {
        animator.SetTrigger("EndTransition");
        // You can add any other code here to perform additional actions during the transition if needed
    }

    private void EnableNextScreen()
    {
        gameObject.SetActive(false);
        nextScreen.SetActive(true);
    }
}
