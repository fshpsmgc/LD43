using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Event_MoneyToMPT : BaseEvent {
	float MPT = 1;
	float Money = 10;

	public Event_MoneyToMPT(){
		Name = "Investment Opportunity";
		Description = "Description";
		//Picture = ;
		Choice1Text = "Accept (+" + MPT + " Money per Turn; -" + Money + " Money)";
		Choice2Text = "Refuse";
	}

	//Add MPT, detract money
	public override void Choice1(){
		GameController gc = GameObject.Find("GameController").GetComponent<GameController>();
		gc.AddMoney(-Money);
		gc.MoneyPerTurn += MPT;
	}

	//
	public override void Choice2(){

	}
}
