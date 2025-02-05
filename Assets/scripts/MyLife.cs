using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MyLife : MonoBehaviour {

	public int numlife = 9;
	public GameObject[] obj;

	// Use this for initialization
	void Start () {
		obj = GetComponentsInChildren<GameObject> (true); 
		obj[0].SetActive (true);
		obj[1].SetActive (false);
		obj[2].SetActive (false);
		obj[3].SetActive (false);
		obj[4].SetActive (false);
		obj[5].SetActive (false);
		obj[6].SetActive (false);
		obj[7].SetActive (false);
		obj[8].SetActive (false);
	}
	
	// Update is called once per frame
	void Update () {
		ClearLife ();
		if (numlife == 1) 
		{
			obj[0].SetActive (true);
		}
		if (numlife == 2) 
		{
			obj[0].SetActive (true);
			obj[1].SetActive (true);
		}
		if (numlife == 3) 
		{
			obj[0].SetActive (true);
			obj[1].SetActive (true);
			obj[2].SetActive (true);
		}
		if (numlife == 4) 
		{
			obj[0].SetActive (true);
			obj[1].SetActive (true);
			obj[2].SetActive (true);
			obj[3].SetActive (true);
		}
		if (numlife == 5) 
		{
			obj[0].SetActive (true);
			obj[1].SetActive (true);
			obj[2].SetActive (true);
			obj[3].SetActive (true);
			obj[4].SetActive (true);
		}
		if (numlife == 6) 
		{
			obj[0].SetActive (true);
			obj[1].SetActive (true);
			obj[2].SetActive (true);
			obj[3].SetActive (true);
			obj[4].SetActive (true);
			obj[5].SetActive (true);
		}
		if (numlife == 7) 
		{
			obj[0].SetActive (true);
			obj[1].SetActive (true);
			obj[2].SetActive (true);
			obj[3].SetActive (true);
			obj[4].SetActive (true);
			obj[5].SetActive (true);
			obj[6].SetActive (true);
		}
		if (numlife == 8) 
		{
			obj[0].SetActive (true);
			obj[1].SetActive (true);
			obj[2].SetActive (true);
			obj[3].SetActive (true);
			obj[4].SetActive (true);
			obj[5].SetActive (true);
			obj[6].SetActive (true);
			obj[7].SetActive (true);
		}
		if (numlife == 9) 
		{
			obj[0].SetActive (true);
			obj[1].SetActive (true);
			obj[2].SetActive (true);
			obj[3].SetActive (true);
			obj[4].SetActive (true);
			obj[5].SetActive (true);
			obj[6].SetActive (true);
			obj[7].SetActive (true);
			obj[8].SetActive (true);
		}
	}

	void ClearLife() {
		obj[0].SetActive (false);
		obj[1].SetActive (false);
		obj[2].SetActive (false);
		obj[3].SetActive (false);
		obj[4].SetActive (false);
		obj[5].SetActive (false);
		obj[6].SetActive (false);
		obj[7].SetActive (false);
		obj[8].SetActive (false);
	}
}
