using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RandomLerper : MonoBehaviour {


	public float range;
	public float randomSpeed;


	public Transform startPos;
	public Transform endPos;
	float startTime;
	float d2D;
	// Use this for initialization
	
	void Start(){
		startTime=Time.time;
		d2D = Vector2.Distance(startPos.position,endPos.position);
	}
	void Update(){
		float currentDur=Time.time - startTime;
		float fraction = currentDur / d2D;
		transform.position = Vector2.Lerp(startPos.position,endPos.position,fraction);

		if(currentDur==d2D){
			Debug.Log("done");
		}
	}

	public void ChangeLocation(){
		
	}
}
