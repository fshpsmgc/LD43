using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Event_FreezeAttitude_Human : BaseEvent {
	float Cost = 5;

	public Event_FreezeAttitude_Human(){
		Name = "Bribe";
		Description = "Just as you walk into your office, you hear your phone ringing. On the other end is the chief of The Board Police with a lucrative offer. You \"help\" with \"renovation\" of their \"department\", and in return he will maybe sort of look the other-ish way tou your whole soul-gathering buisness";
		//Picture = ;
		Choice1Text = "Accept (-" + Cost + " Money; " + "freeze attitude of Humans for this turn)";
		Choice2Text = "Refuse";
	}

	//Add MPT, detract money
	public override void Choice1(){
		GameObject.Find("GameController").GetComponent<GameController>().Factions[0].isFrozen = true;
		GameObject.Find("GameController").GetComponent<GameController>().AddMoney(-Cost);
	}

	//
	public override void Choice2(){

	}
}
