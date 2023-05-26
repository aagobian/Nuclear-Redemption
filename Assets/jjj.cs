using UnityEngine;
using UnityEngine.UI;

public class jjj : MonoBehaviour
{
    public GameObject nextScreen;
    public Animator animator;

    public void TransitionToNextScreen()
    {
        
    }

    private void EnableNextScreen()
    {
        gameObject.SetActive(false);
        nextScreen.SetActive(true);
    }
}
