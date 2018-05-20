using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Harmer : MonoBehaviour {

	// Use this for initialization
	void OnTriggerEnter(Collider col){
		if(col.tag.Equals("Player")){
			if(InventoryColor.goldCount>0){
				InventoryColor.NoGold();
			}else{
				col.gameObject.GetComponent<Reseter>().ResetPlayer();
			}
		}
		
	}
}
