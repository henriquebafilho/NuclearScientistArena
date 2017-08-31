using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public  class Tiro : MonoBehaviour {
    public  GameObject player;
    public static float forceFactor = 2000;
    public bool canshot = false;
	// Use this for initialization
	void Start () {
        player = GameObject.Find("PLayer");
    }
    //se o jogador encostar no tiro, nada acontece, mas se ele apertar espaço o tiro vai até a ele

    void OnTriggerEnter2D(Collider2D coll)
    {
            if (coll.gameObject.tag == "player")
            {
                //Destroy(gameObject);
                player.GetComponent<Player>().canshot = false;
            }
     }
    // Update is called once per frame
    void Update () {
        if (player.GetComponent<Player>().canshot)
        {
            if (Input.GetKey(KeyCode.Space))
            {
                transform.position = Vector3.MoveTowards(transform.position, player.transform.position, 5 * Time.deltaTime);
            }
        }
        else { canshot = false; }
    }
    
}
