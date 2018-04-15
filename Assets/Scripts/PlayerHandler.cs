using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerHandler : MonoBehaviour {

	public Player currentPlayer;

	GameController controller;

	void Awake () {
		controller = GetComponent<GameController> ();
	}
	
	public void CreatePlayerStatsString(){
		controller.playerStats = "Resources: " + currentPlayer.resourceScore.ToString () +
		" Access: " + currentPlayer.accessScore.ToString () +
		" Unity: " + currentPlayer.unityScore.ToString () +
		" Luck: " + currentPlayer.luckScore.ToString ();
	}
}
