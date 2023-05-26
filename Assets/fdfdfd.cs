using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AnimatorTransitionButton : MonoBehaviour
{
    public Animator transitionAnimator;

    public void PlayTransitionAnimation()
    {
        transitionAnimator.SetTrigger("EndTransition");
    }
}
