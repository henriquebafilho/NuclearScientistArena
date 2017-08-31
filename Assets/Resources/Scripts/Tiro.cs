using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public  class Tiro : MonoBehaviour {
    public GameObject player;
    public GameObject monster;
    public static float forceFactor = 2000;
    public bool canshot = false;
    bool isGuardado = false;
	// Use this for initialization
	void Start () {
        player = GameObject.Find("PLayer");
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
            if(coll.gameObject.tag == "reserva" && GameMananger.touchable == 1)
            {  
                isGuardado = true;
                GameMananger.score1 = 50;
                Destroy(gameObject);
            }
            if(coll.gameObject.tag == "reserva" && GameMananger.touchable == 2)
            {
                isGuardado = false;
                GameMananger.score2 = 50;
                Destroy(gameObject);
            }
     }
    void OnTriggerExit2D(Collider2D coll)
    {
        GameMananger.touchable = 0;
    }
    // Update is called once per frame
    void Update () {
        if (player.GetComponent<Player>().canshot)
        {
            if (Input.GetKey(KeyCode.Space))
            {
                transform.position = Vector3.MoveTowards(transform.position, player.transform.position, player.GetComponent<Player>().Speed * Time.deltaTime);
                //detecta colisão da flor com o cientista
                if (transform.position == player.transform.position)
                { GameMananger.touchable = 1; }
            }
        }
        if(monster.GetComponent<Monster>().canshot)
        {
            if (Input.GetKey(KeyCode.P))
            {
                transform.position = Vector3.MoveTowards(transform.position, monster.transform.position, monster.GetComponent<Monster>().Speed * Time.deltaTime);
                //detecta colisão com da flor com o monstro
                if(transform.position == monster.transform.position)
                { GameMananger.touchable = 2; GameMananger.score2 = 50; Destroy(gameObject); }
            }
        }
        else { canshot = false; }
    }
    
}
