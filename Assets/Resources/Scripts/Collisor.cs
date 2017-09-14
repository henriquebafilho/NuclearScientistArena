using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Collisor : MonoBehaviour {

	void Start()
	{
		Debug.Log ("oi");
	}
	void OnTriggerStay2D(Collider2D coll)
	{
		if (coll.gameObject.tag == "Player")
		{
			transform.parent.GetComponent<Tiro> ().canshot1 = true;
			Debug.Log ("ola");
		}if (coll.gameObject.tag == "Monstro")
		{
			transform.parent.GetComponent<Tiro> ().canshot2 = true;
			Debug.Log ("ola");
		}

	}
	void OnTriggerExit2D(Collider2D coll)
	{
		if (coll.gameObject.tag == "Player")
		{
			transform.parent.GetComponent<Tiro> ().canshot1 = false;
		}
		if (coll.gameObject.tag == "Monstro")
		{
			transform.parent.GetComponent<Tiro> ().canshot2 = true;
			Debug.Log ("ola");
		}
	}
}
