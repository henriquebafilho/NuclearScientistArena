using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class fade : MonoBehaviour {

	public Texture2D fadeoutTexture;
	public float fadespeed;

	private int DrawDepth = -1000;
	private float alpha = 1.0f;
	private int fadeDir = -1;

	void OnGUI(){
		alpha += fadeDir * fadespeed * Time.deltaTime;
		alpha = Mathf.Clamp01 (alpha);

		GUI.color = new Color (GUI.color.r, GUI.color.g, GUI.color.b, alpha);
		GUI.depth = DrawDepth;
		GUI.DrawTexture (new Rect (0, 0, Screen.width, Screen.height), fadeoutTexture);
	}
	public float BeginFade(int direction){
		fadeDir = direction;
		return(fadespeed);
	}

	public void OnLevelWasLoaded(){
		BeginFade (-1);
	}

	public void OnLevelWillLoad(){
		BeginFade (1);
	}
}
