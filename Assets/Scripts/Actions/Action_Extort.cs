using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Action_Extort : MonoBehaviour {
	public int OwnerIndex;
	public int Money;
	public int AttitudeChange;

	public void Extort(){
		GameController gc = GameObject.Find("GameController").GetComponent<GameController>();
		gc.ChangeAttitide(OwnerIndex, AttitudeChange);
		gc.AddMoney(Money);

		gc.GetComponent<PlacesManager>().ClearPlaces();
	}
}
