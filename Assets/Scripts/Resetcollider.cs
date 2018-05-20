using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Resetcollider : MonoBehaviour {

	void OnTriggerEnter(Collider col){
		if(col.gameObject.tag.Equals("Player")){
			col.gameObject.GetComponent<Reseter>().ResetPlayer();
		}
	}
}
