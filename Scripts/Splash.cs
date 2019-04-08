using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;


public class Splash : MonoBehaviour {

	public static bool isLoading = false;

	void Start() {
		isLoading = true;
		StartCoroutine(LoadGame());
	}

	IEnumerator LoadGame() {
		yield return new WaitForSeconds(2);
		SceneManager.LoadScene(1);
	}


}