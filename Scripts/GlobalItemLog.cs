using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;


public class GlobalItemLog : MonoBehaviour {

	public GameObject FeedItemNumText01;
	public static int FeedItemNum01 = 0;
	public GameObject FeedItemNumText02;
	public static int FeedItemNum02 = 0;

	public GameObject PlayItemNumText01;
	public static int PlayItemNum01 = 0;
	public GameObject PlayItemNumText02;
	public static int PlayItemNum02 = 0;

	public GameObject SuppItemNumText01;
	public static int SuppItemNum01 = 0;
	public GameObject SuppItemNumText02;
	public static int SuppItemNum02 = 0;

	void Update () {
		FeedItemNumText01.GetComponent<Text>().text = GlobalItem.FeedItemName01 + "\n" + FeedItemNum01 + " 개";
		FeedItemNumText02.GetComponent<Text>().text = GlobalItem.FeedItemName02 + "\n" + FeedItemNum02 + " 개";

		PlayItemNumText01.GetComponent<Text>().text = GlobalItem.PlayItemName01 + "\n" + PlayItemNum01 + " 개";
		PlayItemNumText02.GetComponent<Text>().text = GlobalItem.PlayItemName02 + "\n" + PlayItemNum02 + " 개";

		SuppItemNumText01.GetComponent<Text>().text = GlobalItem.SuppItemName01 + "\n" + SuppItemNum01 + " 개";
		SuppItemNumText02.GetComponent<Text>().text = GlobalItem.SuppItemName02 + "\n" + SuppItemNum02 + " 개";
	}
}