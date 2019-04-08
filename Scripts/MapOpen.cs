using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class MapOpen : MonoBehaviour {
	public Vector3 MapPosition;
	public static int MapRising = 0;
	public int InternalMapRising = 0;
	public GameObject ValueDisplay;

	void Update () {
		if (MapRising > 0) {
			MapPosition = transform.position;
			InternalMapRising += MapRising;
			MapPosition.y += InternalMapRising;
			transform.position = MapPosition;
		}
		MapRising = 0;
		ValueDisplay.GetComponent<Text>().text = "$ " + MapOpenButton.MapRisingValue;
	}
}