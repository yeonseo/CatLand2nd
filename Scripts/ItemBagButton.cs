using System.Collections;

using System.Collections.Generic;

using UnityEngine;


using UnityEngine.UI;



public class ItemBagButton : MonoBehaviour {
	public static int itemNum;
	public GameObject fakeButton;
	public GameObject trueButton;

	public GameObject itemName;
	public GameObject itemEffect;
	public GameObject itemTrueNum;
	public GameObject itemFakeNum;

	public void FeedItem01() {
		itemNum = GlobalItemLog.FeedItemNum01;
		ShopItemBuying.itemName = GlobalItem.FeedItemName01;
		itemName.GetComponent<Text>().text = GlobalItem.FeedItemName01;
		itemEffect.GetComponent<Text>().text = GlobalItem.FeedItemEffect01;	
		itemTrueNum.GetComponent<Text>().text = "보유수량 " + itemNum + "개";
		itemFakeNum.GetComponent<Text>().text = "보유수량 " + itemNum + "개";
		if (itemNum > 0) {
			fakeButton.SetActive(false);
			trueButton.SetActive(true);
		} else {
			fakeButton.SetActive(true);
			trueButton.SetActive(false);
		}
	}
}
