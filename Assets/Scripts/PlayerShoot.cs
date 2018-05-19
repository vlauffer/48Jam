using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerShoot : MonoBehaviour {

    public GameObject redShot;
    public GameObject blueShot;
    public Transform shotSpawn;
    public Transform cameraForward;

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
        if (Input.GetButtonDown("Fire1") && InventoryColor.redCount > 0)
        {
            fireRed();
            InventoryColor.redCount -= 1;
        } else if (Input.GetButton("Fire2") && InventoryColor.blueCount > 0)
        {
            fireBlue();
            InventoryColor.blueCount -= 1;
        }

	}

    void fireBlue()
    {
        var bullet = (GameObject)Instantiate(
            blueShot,
            shotSpawn.position,
            shotSpawn.rotation);
    }

    void fireRed()
    {
        // Create the Bullet from the Bullet Prefab
        var bullet = (GameObject)Instantiate(
            redShot,
            shotSpawn.position,
            shotSpawn.rotation);

        // Add velocity to the bullet
        bullet.GetComponent<Rigidbody>().AddForce(cameraForward.forward * 1000);
    }
}
