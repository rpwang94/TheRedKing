using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GameController : MonoBehaviour {

	public Text questionText;
	public Text playerStatsText;

	public Button choice1;
	public Button choice2;
	public Button choice3;
	public Button choice4;

	[HideInInspector] public CardChoiceHandler cardChoiceHandler;
	[HideInInspector] public PlayerHandler playerHandler;

	[HideInInspector] public List<string> cardDescriptions;
	[HideInInspector] public string playerStats;

	void Awake() {
		cardChoiceHandler = GetComponent<CardChoiceHandler> ();
		playerHandler = GetComponent<PlayerHandler> ();
	}

	void Start() {
		DisplayCardText ();
	}
		
	public void DisplayCardText(){
		UnpackChoices ();

		string[] descriptions = cardDescriptions.ToArray ();
		choice1.GetComponentInChildren<Text>().text = descriptions [0];
		choice2.GetComponentInChildren<Text>().text = descriptions [1];
		choice3.GetComponentInChildren<Text>().text = descriptions [2];
		choice4.GetComponentInChildren<Text>().text = descriptions [3];

		questionText.text = cardChoiceHandler.currentCard.cardText;

		playerHandler.CreatePlayerStatsString ();
		playerStatsText.text = playerStats;
	}
		
	void UnpackChoices(){
		cardChoiceHandler.UnpackChoiceDescriptions ();
	}

	void Update (){
	
	}
}
