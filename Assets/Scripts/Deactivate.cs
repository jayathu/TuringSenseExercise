using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Deactivate : MonoBehaviour {

	// Use this for initialization
	public void CallInvoke () {

        Invoke("DeactivateObject", 20);
		
	}

    void DeactivateObject()
    {
        if (gameObject.activeInHierarchy)
        {
            gameObject.SetActive(false);
        }
    }
   
}
