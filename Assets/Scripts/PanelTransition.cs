using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PanelTransition : MonoBehaviour {

    public Animator view1Animation;
    public Animator view2Animation;


    public void Transition()
    {
        StartCoroutine(PlayTransitions());

    }

    IEnumerator PlayTransitions()
    {
        view1Animation.SetBool("slideout", true);

        yield return new WaitForSeconds(0.2f);

        view2Animation.SetBool("slidein", true);

    }
	
}
