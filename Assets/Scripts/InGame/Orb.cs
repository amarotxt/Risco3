using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Orb : MonoBehaviour {
	public bool colidio;
	// Use this for initialization
	void Start () {
		colidio = false;
	}
	
	// Update is called once per frame
	void Update () {
		
	}
	void OnTriggerEnter(Collider col){
		if (col.gameObject.CompareTag("Player")){
			colidio = true;
		}
	}
}
