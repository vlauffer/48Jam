using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ShopScript : MonoBehaviour {
    GameObject[] shopItems;

	// Use this for initialization
	void Start () {
        shopItems = GameObject.FindGameObjectsWithTag("Shop");
        hide();
	}

    void hide()
    {
        foreach (GameObject item in shopItems) {
            item.SetActive(false);
        }
    }

    void show()
    {
        foreach (GameObject item in shopItems)
        {
            item.SetActive(true);
        }
    }

    private void OnTriggerEnter(Collider other)
    {
        if(other.tag == "Player")
        {
            show();
        }
    }

    private void OnTriggerExit(Collider other)
    {
        if(other.tag == "Player")
        {
            hide();
        }
    }
}
