using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using EasyAR;

public class Slibmenu : MonoBehaviour {

    public Canvas SlibCanvas;
    public ImageTargetBehaviour LibimageTarget;

	// Use this for initialization
	void Start () {
        SlibCanvas.enabled = false;
        if(LibimageTarget.tag!=null)
        {
            SlibCanvas.enabled = true;
        }
	}
	
	// Update is called once per frame
	void Update () {
		
	}
}
