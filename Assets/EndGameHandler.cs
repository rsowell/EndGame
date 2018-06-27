using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EndGameHandler : MonoBehaviour {
	private bool gotStrawberries;
	private bool gotSugar;
	private bool gotFlour;
	private bool gotButter;

	// Use this for initialization
	void Start () {
		gotStrawberries = false;
		gotSugar = false;
		gotFlour = false;
		gotButter = false;
	}

	// Update is called once per frame
	void Update () {

	}

	void OnTriggerEnter (Collider col)
	{
		//Debug.Log(col.gameObject.name);
		if(col.gameObject.name == "Sphere")
		{
			gotStrawberries = true;
			//col.gameObject.SetActive(false);
		}
		if(col.gameObject.name == "Cylinder")
		{
			gotSugar = true;
			//col.gameObject.SetActive(false);
		}
		if(col.gameObject.name == "Capsule")
		{
			gotFlour = true;
			//col.gameObject.SetActive(false);
		}
		if(col.gameObject.name == "Quad")
		{
			gotButter = true;
			//col.gameObject.SetActive(false);
		}
		if(gotStrawberries && gotSugar && gotFlour && gotButter) {
			GameObject.Find("Sphere").SetActive(false);
			GameObject.Find("Cylinder").SetActive(false);
			GameObject.Find("Capsule").SetActive(false);
			GameObject.Find("Quad").SetActive(false);
			GameObject.Find("Cake").GetComponent<MeshRenderer>().enabled = true;
		}
	}
}
