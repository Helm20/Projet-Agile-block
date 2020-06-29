﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MainMenu : MonoBehaviour {

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}
    public void GotoThestart() {
        SceneManager.LoadScene(0);
    }
    public void GotoRegister() {
        SceneManager.LoadScene(1);
    }
    public void GotoLogin() {
        SceneManager.LoadScene(2);
    }
    public void GotoPlay()
    {
        SceneManager.LoadScene(3);
    }
}