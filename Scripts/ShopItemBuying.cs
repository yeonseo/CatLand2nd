using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ShopItemBuying : MonoBehaviour {
	public static string itemName;

	public void BuyToItem() {
		GlobalStarcoin.Starcoin -= ShopItemButton.itemValueInt;
		if (itemName == GlobalItem.FeedItemName01) {
		GlobalItemLog.FeedItemNum01 += 1; }
		if (itemName == GlobalItem.FeedItemName02) {
		GlobalItemLog.FeedItemNum02 += 1; }

		if (itemName == GlobalItem.PlayItemName01) {
		GlobalItemLog.PlayItemNum01 += 1; }
		if (itemName == GlobalItem.PlayItemName02) {
		GlobalItemLog.PlayItemNum02 += 1; }

		if (itemName == GlobalItem.SuppItemName01) {
		GlobalItemLog.SuppItemNum01 += 1; }
		if (itemName == GlobalItem.SuppItemName02) {
		GlobalItemLog.SuppItemNum02 += 1; }
	}
}