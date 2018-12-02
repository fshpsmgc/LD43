using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Event_MoneyFound_Big : BaseEvent {
	public int Money = 30;

	public Event_MoneyFound_Big(){
		Name = "A big pile of money";
		Description = "It's a preffy slow day at the office, so you start looking around. While doing so, you find a bigh pile of money, that someone left behind the couch.";
		//Picture = ;
		Choice1Text = "Well, it's not my fault, that I'm that rich (+" + Money + " Money)";
		Choice2Text = "Eh, it's free money, might as well just burn it";
	}

	//Add MPT, detract money
	public override void Choice1(){
		GameObject.Find("GameController").GetComponent<GameController>().AddMoney(Money);
	}

	//
	public override void Choice2(){

	}
}
