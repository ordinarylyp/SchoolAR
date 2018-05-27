using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using EasyAR;

public class Sdoormenu : MonoBehaviour {

    public Canvas doorCanvas;
    public ImageTargetBehaviour DtargetBehaviour;

	// Use this for initialization
	void Start () {
        doorCanvas.enabled = false;
        if(DtargetBehaviour.tag!=null)
        {
            doorCanvas.enabled = true;
        }
        
	}
	
	// Update is called once per frame
	void Update () {
		
	}
}
