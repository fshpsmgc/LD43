using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Action_Kidnap : MonoBehaviour {
	public int OwnerIndex;
	public int Souls;
	public int AttitudeChange;

	public void Kidnap(){
		GameController gc = GameObject.Find("GameController").GetComponent<GameController>();
		gc.ChangeAttitide(OwnerIndex, AttitudeChange);
		gc.AddSouls(Souls);

		GetComponent<Place>().Hide();
	}
}
