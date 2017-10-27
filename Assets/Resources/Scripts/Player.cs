using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour {

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
		rb = GetComponent<Rigidbody2D>();
		DeathTime = 2f;
		faceRight = true;
		idle = true;
	}

	public void FixedUpdate()
	{
        move = new Vector2(Input.GetAxis("Horizontal2"), Input.GetAxis("Vertical2"));
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
    }
    //detectando área de colisão com o tiro
    //---------------------------------
    void OnDisable()
	{
		move.x = 0;
		Anim.SetFloat ("Move", Mathf.Abs (move.x));
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
    }
}
