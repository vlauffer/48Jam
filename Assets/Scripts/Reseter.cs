using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Reseter : MonoBehaviour {

	public Transform reset;
	public GameObject player;

	public void ResetPlayer(){
		player.transform.position= reset.position;
	}
}
