using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Event_TerroristAttack : BaseEvent {
	public int Dead = 6;
	public int Injured = 10;
	public int Cost = 15;

	public Event_TerroristAttack(){
		Name = "Horrific blast at the kindergarten";
		Description = "Your assistant tells you horrific news. A terrorist attack at the kindergarten leaves " + Dead + " children dead and " + Injured + " injured. Infamous group \"Terrorists Against Children\" claims responsibility for this truly despicable act";
		//Picture = ;
		Choice1Text = "\"Fucking sweet! And injured must be worth at least half a Soul, right?\" (+" + (Dead + Injured/2 - 1).ToString() +" Souls)";
		Choice2Text = "Offer condolences and donate to charity (+" + (Dead + Injured/2).ToString() +" Souls; -" + Cost + " Money)";
	}

	//Add MPT, detract money
	public override void Choice1(){
		GameObject.Find("GameController").GetComponent<GameController>().SoulsCollected += (Dead + Injured/2 - 1);
	}

	//
	public override void Choice2(){
		GameObject.Find("GameController").GetComponent<GameController>().SoulsCollected += (Dead + Injured/2);
		GameObject.Find("GameController").GetComponent<GameController>().AddMoney(-Cost);
	}
}
