using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class spawn : MonoBehaviour {

	public GameObject ruby;
	public GameObject[] places;
    public int segundos = 5;
    public bool canInstantiate = true;
	void Start () 
	{
		StartCoroutine(Example());
	}
	IEnumerator Example()
	{
		while (true) {
                yield return new WaitForSeconds(segundos);
                Instantiate(ruby, places[Random.Range(0, places.Length)].transform.position, Quaternion.identity);
        }
	}
}