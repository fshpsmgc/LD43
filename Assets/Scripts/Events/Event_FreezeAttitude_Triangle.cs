using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Event_FreezeAttitude_Triangle : BaseEvent {
	public Event_FreezeAttitude_Triangle(){
		Name = "Encouragement";
		Description = "As you go to your office, you (and, it seems, you alone) notice Rainbow Triangle sobbing in the lobby.";
		Choice1Text = "Say some nice words (freeze attitude of Rainbow Triangle for this turn)";
		Choice2Text = "Walk past";
	}

	//Add MPT, detract money
	public override void Choice1(){
		GameObject.Find("GameController").GetComponent<GameController>().Factions[2].isFrozen = true;
	}

	//
	public override void Choice2(){

	}
}
