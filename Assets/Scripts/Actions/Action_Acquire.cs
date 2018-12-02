using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Action_Acquire : MonoBehaviour {
	public float Cost;
	public float MPTBonus;
	public int AttitudeCost;

	public void Acquire(){
		GameObject gc = GameObject.Find("GameController");
		gc.GetComponent<PlacesManager>().PlacesPool.Remove(GetComponent<Place>());
		gc.GetComponent<GameController>().AddMoney(-Cost);
		gc.GetComponent<GameController>().MoneyPerTurn += MPTBonus;
		gc.GetComponent<GameController>().Factions[GetComponent<Action_Kidnap>().OwnerIndex].ChangeAttitude(AttitudeCost);

		gc.GetComponent<PlacesManager>().ClearPlaces();
	}
}
