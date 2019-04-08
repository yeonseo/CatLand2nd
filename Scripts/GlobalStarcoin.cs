using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GlobalStarcoin : MonoBehaviour {

	public static int Starcoin;
	public GameObject StarcoinDisplay;
	public int InternalStarcoin;

	void Update () {
		InternalStarcoin = Starcoin;
		StarcoinDisplay.GetComponent<Text>().text = "Star Coin = " + InternalStarcoin;
	}

}