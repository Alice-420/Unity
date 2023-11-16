using UnityEngine;
using System.Collections;
using UnityEngine.UI; // Required when Using UI elements.

public class AnimationTriggers : MonoBehaviour
{
    public Animator buttonAnimator;
    public Button button;

    void SomeFunction()
    {
        //Sets the button to the highlighted state (Useful when making tutorials).
        buttonAnimator.SetTrigger(button.animationTriggers.highlightedTrigger);
    }
}
