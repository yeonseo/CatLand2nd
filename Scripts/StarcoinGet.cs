using System.Collections;

using System.Collections.Generic;

using UnityEngine;
using UnityEngine.UI;




public class StarcoinGet : MonoBehaviour {
	public GameObject statusBox;
	public static int StarcoinIncrease = 1;
	public int InternalIncrease;
	//public AudioSource starcoinSound;

	public void ClickTheBottun () {
		InternalIncrease = StarcoinIncrease;
		//starcoinSound.Play();
		GlobalStarcoin.Starcoin += InternalIncrease;
		statusBox.GetComponent<Text>().text = "+" + InternalIncrease;
		statusBox.GetComponent<Animation>().Play("Starcoin");
	}
}
