using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class buttons : MonoBehaviour {

	public void OnClickPlay(){
		SceneManager.LoadScene ("Game1_1");
	}
	public void OnClickCredits(){
		SceneManager.LoadScene ("Credits");
	}
	public void OnClickMenu(){
		SceneManager.LoadScene ("Menu");
	}
	public void OnClickExit(){
		Application.Quit ();
	}
}
