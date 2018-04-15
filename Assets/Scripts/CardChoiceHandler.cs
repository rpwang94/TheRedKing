using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CardChoiceHandler : MonoBehaviour {

	public Card currentCard;

	GameController controller;

	void Awake () {
		controller = GetComponent<GameController> ();
	}

	public void UnpackChoiceDescriptions(){
		for (int i = 0; i < currentCard.choices.Length; i++) {
			controller.cardDescriptions.Add (currentCard.choices[i].choiceText);
		}
	}
}
