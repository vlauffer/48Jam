﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Done : MonoBehaviour {

	public string sceneToLoad;
	// Use this for initialization
	
	
	// Update is called once per frame
	void OnTriggerEnter(Collider col){
		SceneManager.LoadScene(1);
	}
}
