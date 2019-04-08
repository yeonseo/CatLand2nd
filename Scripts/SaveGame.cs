using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;


public class SaveGame : MonoBehaviour {

	public int saveStarcoin;

	void Update () {
		saveStarcoin = GlobalStarcoin.Starcoin;

		PlayerPrefs.SetInt("SavedStarcoin",GlobalStarcoin.Starcoin);
		PlayerPrefs.SetInt("SavedFeedItemNum01",GlobalItemLog.FeedItemNum01);
		PlayerPrefs.SetInt("SavedFeedItemNum02",GlobalItemLog.FeedItemNum02);
	}
}