using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Collisor : MonoBehaviour {

	void Start()
	{
		
	}
	void OnTriggerStay2D(Collider2D coll)
	{
		if (coll.gameObject.tag == "Player")
		{
			transform.parent.GetComponent<Tiro> ().canshot1 = true;
		}if (coll.gameObject.tag == "Monstro")
		{
			transform.parent.GetComponent<Tiro> ().canshot2 = true;
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
		}
	}
}
