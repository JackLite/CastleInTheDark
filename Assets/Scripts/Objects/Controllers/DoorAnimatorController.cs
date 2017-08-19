using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DoorAnimatorController : StateMachineBehaviour {

    // OnStateEnter is called when a transition starts and the state machine starts to evaluate this state
    override public void OnStateEnter(Animator animator, AnimatorStateInfo stateInfo, int layerIndex)
    {
        if(stateInfo.IsName("default"))
        {
            animator.SetBool("isAnimate", false);
        } else
        {
            animator.SetBool("open", false);
            animator.SetBool("close", false);
            animator.SetBool("isAnimate", true);
        }
    }
}
