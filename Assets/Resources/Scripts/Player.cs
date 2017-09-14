using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour {
    //static public int Lifes, SubLifes, PlayerCheckPoint;
	//static public bool Running;
	//public AudioClip RunSound;
	public Animator Anim;
	public  float Speed;
	private Rigidbody2D rb;
    private float DeathTime, CurrentDeathTime;
    private bool faceRight, idle;
    private Vector2 move;
    public bool canshot;
    bool controlidleFlip;

	void Start()
	{
        controlidleFlip = false;
        canshot = false;
		//PlayerCheckPoint = -1;
		rb = GetComponent<Rigidbody2D> ();
		//Lifes = 3;
		//SubLifes = 3;
		Speed = 4;
		DeathTime = 2f;
		faceRight = true;
		idle = true;

		//Running = false;
	}

	public void FixedUpdate()
	{
		move = new Vector2 (Input.GetAxis ("Horizontal"), Input.GetAxis ("Vertical"));
		rb.velocity = move*Speed;

		Anim.SetFloat("Move", Mathf.Abs(move.x));
		Anim.SetFloat ("MoveY", move.y);
		Anim.SetBool("Idle", idle);

		if (move.x > 0 && !faceRight) Flip();
		else if (move.x < 0 && faceRight) Flip();

		if (move.x != 0) {
			idle = false;
            controlidleFlip = false;
		}
		else if (move.x == 0) {
			idle = true;
		}
        if (idle&&!controlidleFlip)
        {
            controlidleFlip = true;
        }
        
    }

    void Update () 
	{
		CurrentDeathTime += Time.deltaTime;

        /*if (walking){
			//SoundManager.PlaySingle(RunSound);
			//SoundManager.Instance.MakeRunClip();
		}*/
        
    }
    //detectando área de colisão com o tiro
    
    //---------------------------------
    void OnDisable()
	{
		move.x = 0;
		Anim.SetFloat ("Move", Mathf.Abs (move.x));

		/*if(Lifes == 0 && DeathTime <= CurrentDeathTime){
			Application.LoadLevel(5);
		}*/
	}

	private void Flip()
	{
		faceRight = !faceRight;
		Vector3 theScale = transform.localScale;
		theScale.x *= -1;
		transform.localScale = theScale;
	}
    public void check()
    {
        Vector3 thescale = transform.localScale;

        if (faceRight) {
            thescale = new Vector3(Mathf.Abs(thescale.x), thescale.y, thescale.z);
            faceRight = !faceRight;
    }
        else
        {
            if (thescale.x < 0) { }
            else thescale = new Vector3(-thescale.x, thescale.y, thescale.z);
            faceRight = !faceRight;
        }
        transform.localScale = thescale;
        Debug.Log("IDLE");

    }
}
