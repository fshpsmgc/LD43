using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class RandomEventsManager : MonoBehaviour {
	BaseEvent[] Events = new BaseEvent[8];
	public Canvas EventCanvas;
	public Text UIName;
	public Text UIDescription;
	public Image UIPicture;
	public Button Choice1;
	public Button Choice2;
	// Use this for initialization
	void Start () {
		Events[0] = new Event_FreezeAttitude_Human();
		Events[1] = new Event_FreezeAttitude_Snail();
		Events[2] = new Event_FreezeAttitude_Triangle();
		Events[3] = new Event_FreezeAttitude_Void();
		Events[4] = new Event_MoneyFound_Big();
		Events[5] = new Event_MoneyFound();
		Events[6] = new Event_MoneyToMPT();
		Events[7] = new Event_TerroristAttack();
	
	}
	

	public BaseEvent PickRandomEvent(){
		return Events[Random.Range(0, Events.Length)];
	}

	public void HideCanvas(){
		EventCanvas.enabled = false;
	}
}
