using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class buttons : MonoBehaviour {

    public GameObject sound;
    void Update()
    {
        
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
    public void onClickHTPMonster()
    { SceneManager.LoadScene("HTPMonster"); }
    public void onClickHTPDrFletch()
    { SceneManager.LoadScene("HTPDrFletch"); }
    public void increaseSize()
    {
        transform.localScale *= 1.2f;
    }
    public void decreaseSize()
    {
        transform.localScale /= 1.2f;
    }
}
