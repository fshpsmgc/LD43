using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Event_FreezeAttitude_Snail : BaseEvent {
	float Cost = 10;

	public Event_FreezeAttitude_Snail(){
		Name = "Assassination Attempt";
		Description = "Snail mafia decided to contact you. They offer to cover your deeds for a while in exchange for the head of someone, who crossed their path.";
		//Picture = ;
		Choice1Text = "Accept (-" + Cost + " Money; " + "freeze attitude of Snail Mafia for this turn)";
		Choice2Text = "Refuse";
	}

	//Add MPT, detract money
	public override void Choice1(){
		GameObject.Find("GameController").GetComponent<GameController>().Factions[1].isFrozen = true;
		GameObject.Find("GameController").GetComponent<GameController>().AddMoney(-Cost);
	}

	//
	public override void Choice2(){

	}
}
