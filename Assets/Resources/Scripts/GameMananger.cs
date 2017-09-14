using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
public class GameMananger : MonoBehaviour {
	GameObject[] drains;
	public GameObject particule, history;
    public Text scoreText1;
    public Text scoreText2;
    public static int score1, score2;
    public static int touchable = 0;
	void Start () {
        score1 = 0;
        score2 = 0;
		drains = GameObject.FindGameObjectsWithTag ("drain");
        
	}
	
	// Update is called once per frame
	void Update () {
        UpdateScore();
        Spawns();
	}
   
	public void spawn()
	{
		StartCoroutine (Spawns ());
	}
	public IEnumerator  Spawns()
	{
		yield return new WaitForSeconds (4);
		Instantiate (particule, drains [Random.Range (0, drains.Length)].transform.position, Quaternion.identity);
	}
    public void AddScore(int newScoreValue)
    {
        score1 += newScoreValue;
        score2 += newScoreValue;
        UpdateScore();
    }
    void UpdateScore()
    {
        scoreText1.text = "Pontos: " + score1;
        scoreText2.text = "Pontos: " + score2;
        if (score1 == 100 || score2 == 100) { SceneManager.LoadScene("victory"); }
    }
}
