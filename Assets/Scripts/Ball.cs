using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ball : MonoBehaviour {
    public string color;
    public int ballnum=1;

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}

    private void OnTriggerEnter(Collider other)
    {
        if(other.gameObject.tag == "Player")
        {
            Destroy(gameObject);
            if(color.Equals("blue")){
                InventoryColor.addCount(color,ballnum+2);
            }
            if(color.Equals("gold")){
                InventoryColor.addCount(color,ballnum+6);
            }
            InventoryColor.addCount(color, ballnum);
        }
        
    }
}
