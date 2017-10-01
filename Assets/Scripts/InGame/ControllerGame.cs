using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ControllerGame : MonoBehaviour {

	GameObject obs;
	int orbToGet;

	void Start(){
		orbToGet = 0;
		obs = GameObject.Find ("Orbs");
	}
	void Update(){
		
		if (obs.transform.childCount != orbToGet){
			if (obs.transform.GetChild (orbToGet).GetComponent<Orb> ().colidio) {	
				Debug.Log (orbToGet);
				obs.transform.GetChild (orbToGet).gameObject.SetActive(false);
				orbToGet += 1;
				obs.transform.GetChild (orbToGet).gameObject.SetActive(true);
				}
		}

	}
}
