using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MapOpenButton : MonoBehaviour {
	public static int MapRisingValue = 5000;

	public void MapOpenning () {
		if (GlobalStarcoin.Starcoin >= MapRisingValue) {
			MapOpen.MapRising += 10;
			GlobalStarcoin.Starcoin -= MapRisingValue;
			MapRisingValue = 2*MapRisingValue;
		}
	}
}