using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Hat : MonoBehaviour {
	public bool active;
	public static float r;
	public static float g;
	public static float b;
	public static float a;
	public Color color;
	// Use this for initialization
	void Start () {
		r = 0.5F;
		g = 0.1F;
		b = 0.1F;
		a = 1.0F;
		color = new Color(r, g, b, a);
		active = true;
		//gameObject.SetActive (false);
	}
	
	// Update is called once per frame
	void Update () {
		gameObject.SetActive (active);
		//r = Random.Range (0.0F, 1.0F);
		//g = Random.Range (0.0F, 1.0F);
		//b = Random.Range (0.0F, 1.0F);
		color = new Color(r, g, b, a);
		//Debug.Log (gameObject.activeSelf);
		GetComponent<Renderer>().material.color = color;
	}
}
