using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PriceUpdater : MonoBehaviour {

	public GameObject marker;
	public Text priceDisplay;
	// Use this for initialization
	void Start () {
		priceDisplay = GetComponent<Text>();
	}
	
	// Update is called once per frame
	void Update () {
		priceDisplay.text = marker.transform.position.y.ToString();
	}
}
