﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class SartScene : MonoBehaviour {

	// Use this for initialization
	public void StarButton () {
        SceneManager.LoadScene(2);
	}
	
	// Update is called once per frame
	public void QuitButton () {
        Application.Quit();

	}
}
