using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GameController : MonoBehaviour {

	public Text displayText;
	public Button choice1;
	public Button choice2;
	public Button choice3;
	public Button choice4;

	[HideInInspector] public CardChoiceHandler cardChoiceHandler;
	[HideInInspector] public List<string> cardDescriptions;

	List<string> questionLog = new List<string> ();

	void Awake() {
		cardChoiceHandler = GetComponent<CardChoiceHandler> ();
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

		displayText.text = cardChoiceHandler.currentCard.cardText;

//		string joinedText = cardChoiceHandler.currentCard.cardText + "\n" + string.Join ("\n", cardDescriptions.ToArray());
//		questionLog.Add (joinedText + "\n");
//	
//		displayText.text = string.Join("\n", questionLog.ToArray());
	}
		
	void UnpackChoices(){
		cardChoiceHandler.UnpackChoiceDescriptions ();
	}

	void Update (){
	
	}
}
