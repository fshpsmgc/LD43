using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Event_FreezeAttitude_Void : BaseEvent {
	float MPTCost = 1;
	float MoneyCost = 20;

	public Event_FreezeAttitude_Void(){
		Name = "";
		Description = "As you wake up, you feel strange emptiness inside. The feeling that can be overcome by telling your assistant to start throwing money into a huge hole that will appear near you office shortly after you arrive every Monday morning. What a strange and very specific feeling!";
		//Picture = ;
		Choice1Text = "Embrace the void (-" + MPTCost + " Money per Turn; " + "freeze attitude of The Other One for this turn)";
		Choice2Text = "Resist (-" + MoneyCost +" Money)";
	}

	//Add MPT, detract money
	public override void Choice1(){
		GameObject.Find("GameController").GetComponent<GameController>().Factions[3].isFrozen = true;
		GameObject.Find("GameController").GetComponent<GameController>().MoneyPerTurn -= MPTCost;
	}

	//
	public override void Choice2(){
		GameObject.Find("GameController").GetComponent<GameController>().AddMoney(-MoneyCost);
	}
}
