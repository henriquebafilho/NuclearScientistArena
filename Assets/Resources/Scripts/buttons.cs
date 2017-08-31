using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class buttons : MonoBehaviour {

    public GameObject sound;

    void Update()
    {
        DontDestroyOnLoad(sound);
    }

    public void OnClickPlay(){
		SceneManager.LoadScene ("Game1_1");
	}
	public void OnClickCredits(){
		SceneManager.LoadScene ("Credits");
	}
	public void OnClickMenu(){
		SceneManager.LoadScene ("Menu");
	}
    public void OnClickHistory() {
        SceneManager.LoadScene("History");
    }
	public void OnClickExit(){
		Application.Quit ();
	}
    public void goToscene()
    {
        SceneManager.LoadScene("Game1_1");
    }
    public void OnClickTips() {
        SceneManager.LoadScene("Tips");

    }
}
