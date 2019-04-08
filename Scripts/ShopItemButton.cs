using System.Collections;

using System.Collections.Generic;

using UnityEngine;


using UnityEngine.UI;



public class ShopItemButton : MonoBehaviour {


	public int currentStarcoin;
	public static int itemValueInt;

	public GameObject fakeButton;
	public GameObject trueButton;
	public GameObject completButton;

	public GameObject itemName;
	public GameObject itemEffect;
	public GameObject itemValue;
	public GameObject itemFakeValue;
	public GameObject itemCompletValue;

	public void FeedItem01() {
		itemValueInt = GlobalItem.FeedItemValue01;
		ShopItemBuying.itemName = GlobalItem.FeedItemName01;
		itemName.GetComponent<Text>().text = GlobalItem.FeedItemName01;
		itemEffect.GetComponent<Text>().text = GlobalItem.FeedItemEffect01;	
		itemValue.GetComponent<Text>().text = " $ " + itemValueInt;
		itemFakeValue.GetComponent<Text>().text = " $ " + itemValueInt;
		itemCompletValue.GetComponent<Text>().text = " $ " + itemValueInt;
		currentStarcoin = GlobalStarcoin.Starcoin;
		if (currentStarcoin >= itemValueInt) {
			fakeButton.SetActive(false);
			trueButton.SetActive(true);
			completButton.SetActive(false);
		} else {
			fakeButton.SetActive(true);
			trueButton.SetActive(false);
			completButton.SetActive(false);
		}
	}

	public void FeedItem02() {
		itemValueInt = GlobalItem.FeedItemValue02;
		ShopItemBuying.itemName = GlobalItem.FeedItemName02;
		itemName.GetComponent<Text>().text = GlobalItem.FeedItemName02;
		itemEffect.GetComponent<Text>().text = GlobalItem.FeedItemEffect02;	
		itemValue.GetComponent<Text>().text = " $ " + itemValueInt;
		itemFakeValue.GetComponent<Text>().text = " $ " + itemValueInt;
		itemCompletValue.GetComponent<Text>().text = " $ " + itemValueInt;
		currentStarcoin = GlobalStarcoin.Starcoin;
		if (currentStarcoin >= itemValueInt) {
			fakeButton.SetActive(false);
			trueButton.SetActive(true);
			completButton.SetActive(false);
		} else {
			fakeButton.SetActive(true);
			trueButton.SetActive(false);
			completButton.SetActive(false);
		}
	}

	public void PlayItem01() {
		itemValueInt = GlobalItem.PlayItemValue01;
		ShopItemBuying.itemName = GlobalItem.PlayItemName01;
		itemName.GetComponent<Text>().text = GlobalItem.PlayItemName01;
		itemEffect.GetComponent<Text>().text = GlobalItem.PlayItemEffect01;	
		itemValue.GetComponent<Text>().text = " $ " + itemValueInt;
		itemFakeValue.GetComponent<Text>().text = " $ " + itemValueInt;
		itemCompletValue.GetComponent<Text>().text = " $ " + itemValueInt;
		currentStarcoin = GlobalStarcoin.Starcoin;
		if (currentStarcoin >= itemValueInt) {
			fakeButton.SetActive(false);
			trueButton.SetActive(true);
			completButton.SetActive(false);
		} else {
			fakeButton.SetActive(true);
			trueButton.SetActive(false);
			completButton.SetActive(false);
		}
	}

	public void PlayItem02() {
		itemValueInt = GlobalItem.PlayItemValue02;
		ShopItemBuying.itemName = GlobalItem.PlayItemName02;
		itemName.GetComponent<Text>().text = GlobalItem.PlayItemName02;
		itemEffect.GetComponent<Text>().text = GlobalItem.PlayItemEffect02;	
		itemValue.GetComponent<Text>().text = " $ " + itemValueInt;
		itemFakeValue.GetComponent<Text>().text = " $ " + itemValueInt;
		itemCompletValue.GetComponent<Text>().text = " $ " + itemValueInt;
		currentStarcoin = GlobalStarcoin.Starcoin;
		if (currentStarcoin >= itemValueInt) {
			fakeButton.SetActive(false);
			trueButton.SetActive(true);
			completButton.SetActive(false);
		} else {
			fakeButton.SetActive(true);
			trueButton.SetActive(false);
			completButton.SetActive(false);
		}
	}

	public void SuppItem01() {
		itemValueInt = GlobalItem.SuppItemValue01;
		ShopItemBuying.itemName = GlobalItem.SuppItemName01;
		itemName.GetComponent<Text>().text = GlobalItem.SuppItemName01;
		itemEffect.GetComponent<Text>().text = GlobalItem.SuppItemEffect01;	
		itemValue.GetComponent<Text>().text = " $ " + itemValueInt;
		itemFakeValue.GetComponent<Text>().text = " $ " + itemValueInt;
		itemCompletValue.GetComponent<Text>().text = " $ " + itemValueInt;
		currentStarcoin = GlobalStarcoin.Starcoin;
		if (currentStarcoin >= itemValueInt) {
			fakeButton.SetActive(false);
			trueButton.SetActive(true);
			completButton.SetActive(false);
		} else {
			fakeButton.SetActive(true);
			trueButton.SetActive(false);
			completButton.SetActive(false);
		}
	}

	public void SuppItem02() {
		itemValueInt = GlobalItem.SuppItemValue02;
		ShopItemBuying.itemName = GlobalItem.SuppItemName02;
		itemName.GetComponent<Text>().text = GlobalItem.SuppItemName02;
		itemEffect.GetComponent<Text>().text = GlobalItem.SuppItemEffect02;	
		itemValue.GetComponent<Text>().text = " $ " + itemValueInt;
		itemFakeValue.GetComponent<Text>().text = " $ " + itemValueInt;
		itemCompletValue.GetComponent<Text>().text = " $ " + itemValueInt;
		currentStarcoin = GlobalStarcoin.Starcoin;
		if (currentStarcoin >= itemValueInt) {
			fakeButton.SetActive(false);
			trueButton.SetActive(true);
			completButton.SetActive(false);
		} else {
			fakeButton.SetActive(true);
			trueButton.SetActive(false);
			completButton.SetActive(false);
		}
	}
}
