using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class LoadGame : MonoBehaviour {

	public int savedStarcoin;
	public int savedFeedItemNum01;
	public int savedFeedItemNum02;
	public int savedPlayItemNum01;
	public int savedPlayItemNum02;
	public int savedSuppItemNum01;
	public int savedSuppItemNum02;

	void Start() {
		savedStarcoin = PlayerPrefs.GetInt("SavedStarcoin");
		GlobalStarcoin.Starcoin = savedStarcoin;

		savedFeedItemNum01 = PlayerPrefs.GetInt("SavedFeedItemNum01");
		GlobalItemLog.FeedItemNum01 = savedFeedItemNum01;
		savedFeedItemNum02 = PlayerPrefs.GetInt("SavedFeedItemNum02");
		GlobalItemLog.FeedItemNum02 = savedFeedItemNum02;
	}
}