using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public  class Tiro : MonoBehaviour {
	public static Vector3 offset;
    public GameObject player,  monster;
    public static float forceFactor = 2000;
    public bool canshot1 = false;
	public bool canshot2 = false;
    public bool isGuardado = false;
	// Use this for initialization
	void Start () {
        player = GameObject.Find("PLayer");
		offset = new Vector3 (0.8f, 0.3f, 0f);
		monster = GameObject.Find ("Monstro");
        StartCoroutine(willBeDestroyed());
    }
    //se o jogador encostar no tiro, nada acontece, mas se ele apertar espaço o tiro vai até a ele
    void OnTriggerEnter2D(Collider2D coll)
    {
            if (coll.gameObject.tag == "player")
            {
                player.GetComponent<Player>().canshot = false;
                GameMananger.touchable = 1;
            }
            if(coll.gameObject.tag == "Monstro")
            {
                GameMananger.touchable = 2;
            }
            //adiciona pontos ao encostar na reserva com o cientista
            if(coll.gameObject.tag == "reserva" )
            {  
                isGuardado = true;
                GameMananger.score1 += 50;
                Destroy(gameObject);
        }
     }
    void OnTriggerExit2D(Collider2D coll)
    {
        GameMananger.touchable = 0;
    }
    // Update is called once per frame
    void Update()
    {
        if (canshot1)
        {
            if (Input.GetKey(KeyCode.P))
            {
                transform.position = Vector3.MoveTowards(transform.position, player.transform.position - offset, 0.2f);
                //detecta colisão da flor com o cientista
                if (transform.position == player.transform.position)
                { GameMananger.touchable = 1; }
            }
            if (Input.GetAxis("Horizontal2") > 0)
            {
                offset.x = -0.8f;
            }
            if (Input.GetAxis("Horizontal2") < 0)
            {
                offset.x = 0.8f;
            }
        }
        if(canshot2)
        {
            if(Input.GetKey(KeyCode.Space))
            {
                GameMananger.score2 += 50;
                Destroy(gameObject);
            }
        }
    }
    IEnumerator willBeDestroyed()
    {
        yield return new WaitForSeconds(4);
        Destroy(gameObject);
    }
}