using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameMananger : MonoBehaviour {
	GameObject[] drains;
	public GameObject particule;
	// Use this for initialization
	void Start () {
		drains = GameObject.FindGameObjectsWithTag ("drain");

	}
	
	// Update is called once per frame
	void Update () {
		
	}
	public void spaw()
	{
		StartCoroutine (Spaws ());
	}
	public IEnumerator  Spaws()
	{
		yield return new WaitForSeconds (4);
		Instantiate (particule, drains [Random.Range (0, drains.Length)].transform.position, Quaternion.identity);
	}

}
