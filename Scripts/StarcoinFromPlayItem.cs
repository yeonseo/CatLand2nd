using System.Collections;

using System.Collections.Generic;

using UnityEngine;
using UnityEngine.UI;




public class StarcoinFromPlayItem : MonoBehaviour {
	public GameObject statusBox;
	public static int StarcoinIncrease;
	public int InternalIncrease;
	public int generatePlayTime;
	//public AudioSource starcoinSound;

	public void ClickTheBottun () {
		generatePlayTime = Random.Range(1,10);
		StarcoinIncrease = 300 * 3 * generatePlayTime;
		InternalIncrease = StarcoinIncrease;
		//starcoinSound.Play();
		GlobalStarcoin.Starcoin += InternalIncrease;
		statusBox.GetComponent<Text>().text = "+" + InternalIncrease;
		statusBox.GetComponent<Animation>().Play("Starcoin");
	}
}
