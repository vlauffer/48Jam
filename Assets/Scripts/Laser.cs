using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Laser : MonoBehaviour {

	public GameObject laser;
	public IEnumerator co;
	public float waitTime;

	bool inco=false;

	void Start(){
		StartCoroutine("CallLaser");
	}

	

	IEnumerator CallLaser(){

		while(true){
			yield return new WaitForSeconds(waitTime);
			laser.SetActive(true);
			yield return new WaitForSeconds(waitTime);
			laser.SetActive(false);
		}

		
		
	}
}
