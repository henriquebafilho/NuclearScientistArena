using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class destroyPlus : MonoBehaviour {

	// Use this for initialization
	void Start () {
        StartCoroutine(destroyer());
	}
	IEnumerator destroyer()
    {
        yield return new WaitForSeconds(1);
        Destroy(gameObject);
    }
}
