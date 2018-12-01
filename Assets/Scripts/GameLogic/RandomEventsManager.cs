using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class RandomEventsManager : MonoBehaviour {
	BaseEvent[] Events = new BaseEvent[1];
	public Canvas EventCanvas;
	public Text UIName;
	public Text UIDescription;
	public Text UIPicture;
	public Button Choice1;
	public Button Choice2;
	// Use this for initialization
	void Start () {
		Events[0] = new Event_MoneyToMPT();
	}
	
	// Update is called once per frame
	void Update () {
		
	}

	public BaseEvent PickRandomEvent(){
		return Events[Random.Range(0, Events.Length)];
	}

	public void HideCanvas(){
		EventCanvas.enabled = false;
	}
}
