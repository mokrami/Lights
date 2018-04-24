using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Lights : MonoBehaviour {
	public GameObject prefabLight;
	// Use this for initialization
	void Start () {
		Instantiate (prefabLight);
	}
	
	// Update is called once per frame
	void Update () {
		
	}
}
