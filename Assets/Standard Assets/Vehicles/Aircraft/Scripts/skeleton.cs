using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class skeleton : MonoBehaviour {
	public GameObject hatr;
	public GameObject vHelmet;
	public GameObject katana;
	public GameObject sword;

	public bool hatrActive;
	public bool vHelmetActive;
	public bool katanaActive;
	public bool swordActive;

	// Use this for initialization
	void Start () {
		hatr = GameObject.Find("hatr");
		vHelmet = GameObject.Find("vHelmet");
		katana = GameObject.Find("katana");
		sword = GameObject.Find("sword");
		hatrActive = false;
		vHelmetActive = true;
		katanaActive = false;
		Debug.Log (hatr);
	}
	
	// Update is called once per frame
	void Update () {
		hatr.SetActive (hatrActive);
		vHelmet.SetActive (vHelmetActive);
		katana.SetActive (katanaActive);
		sword.SetActive (swordActive);
	}
}
