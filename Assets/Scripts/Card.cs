using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(menuName = "RedKing/Card")]
public class Card : ScriptableObject {

	[TextArea]
	public string cardText;
	public Choice[] choices;

}
