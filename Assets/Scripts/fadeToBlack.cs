﻿using UnityEngine;
using System.Collections;

public class fadeToBlack : MonoBehaviour {



	void OnGUI () {
		if (Mathf.Round (TimeManager.Instance.time) <= 0f){
			// Make a background box
		GUI.Box (new Rect ((Screen.width / 2 - ((Screen.width / 2) / 2)), Screen.height / 2 - ((Screen.height / 2) /2),Screen.width / 2, Screen.height /2), "FlyING Lions !");
//		GUI.Box(new Rect(10,10,100,90), "Loader Menu");
			// Make the first button. If it is pressed, Application.Loadlevel (1) will be executed

		GUI.Label (new Rect (Screen.width / 3 + 50, Screen.height /3, 200, 20), "Coins");
		GUI.Label (new Rect (Screen.width / 3 + 50, Screen.height /3 + 40, 200, 20), "Rentepunten");

		GUI.Label (new Rect (Screen.width / 3 + 200, Screen.height /3, 200, 20), "" + CoinManager.Instance.creditCount);
		GUI.Label (new Rect (Screen.width / 3 + 200, Screen.height /3 + 40, 200, 20), "xxx");

		if (GUI.Button (new Rect (Screen.width / 2 - 100, Screen.height /2, 200, 40), "Start")) {
			Application.LoadLevel (1);
		}

		// Make the second button.
		if (GUI.Button (new Rect (Screen.width / 2 - 100, Screen.height /2 + 60, 200, 40), "Stop")) {
			Application.Quit ();
		}
		}
	}
}
