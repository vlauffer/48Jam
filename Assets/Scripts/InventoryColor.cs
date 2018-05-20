using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class InventoryColor : MonoBehaviour {
    public static int blueCount = 50;
    public static int redCount;
    public static int goldCount;
    public Text blueText;
    public Text redText;
    public Text goldText;
    
	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
        blueText.text = blueCount.ToString();
        redText.text = redCount.ToString();
        goldText.text = goldCount.ToString();
	}

    public static void addCount(string color, int number)
    {
        if(color == "blue")
        {
            blueCount += number;
        } else if(color == "red")
        {
            redCount += number;
        } else
        {
            goldCount += number;
        }
    }

    public static void NoGold(){
        goldCount-=10;
        if(goldCount<0){
            goldCount=0;
        }
    }
}
