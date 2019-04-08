using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class GlobalItem : MonoBehaviour {
	public static int FeedItemValue01;
	public static string FeedItemName01;
	public static string FeedItemEffect01;

	public static int FeedItemValue02;
	public static string FeedItemName02;
	public static string FeedItemEffect02;

	public static int PlayItemValue01;
	public static string PlayItemName01;
	public static string PlayItemEffect01;

	public static int PlayItemValue02;
	public static string PlayItemName02;
	public static string PlayItemEffect02;

	public static int SuppItemValue01;
	public static string SuppItemName01;
	public static string SuppItemEffect01;

	public static int SuppItemValue02;
	public static string SuppItemName02;
	public static string SuppItemEffect02;

	void Start() {

		FeedItemValue01 = 10;
		FeedItemName01 = "일반사료";
		FeedItemEffect01 = "허기를 채웁니다";

		FeedItemValue02 = 20;
		FeedItemName02 = "냠냠사료";
		FeedItemEffect02 = "치킨향이 납니다";

		PlayItemValue01 = 30;
		PlayItemName01 = "오뎅꼬치";
		PlayItemEffect01 = "흔들어주자!";

		PlayItemValue02 = 50;
		PlayItemName02 = "쥐돌이";
		PlayItemEffect02 = "사냥본능을 흔들!";

		SuppItemValue01 = 15;
		SuppItemName01 = "플라스틱 밥그릇";
		SuppItemEffect01 = "땅바닥보단 낫다";

		SuppItemValue02 = 20;
		SuppItemName02 = "방석";
		SuppItemEffect02 = "고양이들이 앉아줄지는..";

	}

}