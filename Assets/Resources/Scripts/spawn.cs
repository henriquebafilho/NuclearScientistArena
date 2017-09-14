using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class spawn : MonoBehaviour {

	public GameObject ruby;
	public GameObject[] places;
	void Start () 
	{
		StartCoroutine(Example());
	}
	IEnumerator Example()
	{
		while (true) {
			yield return new WaitForSeconds (5);
			Instantiate (ruby, places [Random.Range (0, places.Length)].transform.position, Quaternion.identity);
		}
	}
}
