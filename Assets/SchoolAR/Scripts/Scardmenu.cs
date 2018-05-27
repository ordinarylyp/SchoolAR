using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using EasyAR;

public class Scardmenu : MonoBehaviour {

    public Canvas cardCanvas;
    public ImageTargetBehaviour imageTarget;
	// Use this for initialization
	void Start () {
        cardCanvas.enabled = false;
        if(imageTarget.tag!=null)
        {
            cardCanvas.enabled = true;
        }
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}
}
