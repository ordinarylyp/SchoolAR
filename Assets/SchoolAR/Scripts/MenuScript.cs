using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MenuScript : MonoBehaviour {
    public Canvas quitCanvas;


	// Use this for initialization
	void Start () {
        quitCanvas.enabled = false;
		
	}
    public void ExitPress()
    {
        quitCanvas.enabled = true;
    }

    public void NoPress()
    {
        quitCanvas.enabled = false;
    }
    public void PlayPress(int SceneIndex)
    {
        SceneManager.LoadScene(SceneIndex);
        
    }
	public void YesPress()
    {
        Application.Quit();
    }
	// Update is called once per frame
	void Update () {
		
	}
}
