using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ArmColor : MonoBehaviour {
    public Material normal;
    public Material setGold;
    public static bool golden;
    public MeshRenderer meshRenderer;
    // Use this for initialization
    void Start () {
        MeshRenderer meshRenderer = gameObject.GetComponent<MeshRenderer>();
        meshRenderer.material = normal;
        golden = false;
	}

    private void Update()
    {
        if (golden)
        {
            meshRenderer.material = setGold;
        }
    }

    public static void goldenGun()
    {
        golden = true;
    }
}
