using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Event_MoneyFound : BaseEvent {

	public Event_MoneyFound(){
		Name = "A penny";
		Description = "As you walk down the street, you see something shiny lying on a sidewalk. A penny? What a nice surprise! It's not much, but you pick it up regardless and go on with your day with renewed energy.";
		//Picture = ;
		Choice1Text = "Sweet!";
		Choice2Text = "";
	}

	//Add MPT, detract money
	public override void Choice1(){
		GameObject.Find("GameController").GetComponent<GameController>().AddMoney(1);
	}

	//
	public override void Choice2(){

	}
}
