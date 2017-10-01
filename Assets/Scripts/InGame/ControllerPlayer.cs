using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ControllerPlayer : MonoBehaviour {

	Vector3 mausePosition;
	Vector3 directionMove;
	GameObject orb;
	float aceleration;
	float points;
	bool pauseGame;
	float aumento;

	// Use this for initialization
	void Start () {
		pauseGame = false;
		aumento = 0.5f;
		orb = GameObject.Find ("Orb");
		aceleration = 5;
		directionMove = Vector3.forward;
	}
	
	// Update is called once per frame
	void Update () {
		mausePosition = Camera.main.ScreenToWorldPoint (new Vector3(Input.mousePosition.x,Input.mousePosition.y, 10));
//		lookMausePosition = Camera.main.ScreenToWorldPoint (new Vector3(Input.GetTouch(0).position.x,Input.GetTouch(0).position.y));

		transform.LookAt(mausePosition);

		CalcularVelocidade ();
		CalcularPontuacao();
		directionMove = aceleration * Time.deltaTime * Vector3.forward;

		gameObject.transform.Translate (directionMove);
	}
	public void CalcularVelocidade(){
		aceleration = (float)Mathf.Log (points, 2) ;
	}
	void  CalcularPontuacao(){
		if (!pauseGame) { 
			points = aumento + points;
		}
	}
}
