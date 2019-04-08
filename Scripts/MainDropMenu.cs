using System.Collections;

using System.Collections.Generic;

using UnityEngine;


using UnityEngine.SceneManagement;

public class MainDropMenu : MonoBehaviour {

	public void CatInfoMenu() {
		SceneManager.LoadScene(2);
	}

	public void CheckMenu() {
		SceneManager.LoadScene(3);
	}

	public void ShopMenu() {
		SceneManager.LoadScene(4);
	}

}
