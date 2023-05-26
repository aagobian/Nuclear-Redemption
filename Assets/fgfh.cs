using UnityEngine;

public class ButtonTransitionBehavior : StateMachineBehaviour
{
    public string transitionParameter = "Transition";
    public bool triggerOnEnter = true;

    private bool buttonClicked = false;

    override public void OnStateEnter(Animator animator, AnimatorStateInfo stateInfo, int layerIndex)
    {
        if (triggerOnEnter && buttonClicked)
        {
            animator.SetTrigger(transitionParameter);
        }
    }

    override public void OnStateUpdate(Animator animator, AnimatorStateInfo stateInfo, int layerIndex)
    {
        if (!triggerOnEnter && buttonClicked)
        {
            animator.SetTrigger(transitionParameter);
            buttonClicked = false;
        }
    }

    public void OnButtonClicked()
    {
        buttonClicked = true;
    }
}

