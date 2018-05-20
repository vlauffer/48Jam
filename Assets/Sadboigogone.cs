using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Sadboigogone : MonoBehaviour {

	// Use this for initialization
	void OnCollisionEnter(Collision col){
		if(col.gameObject.tag.Equals("red")){
			Destroy(gameObject);
		}
	}
}
