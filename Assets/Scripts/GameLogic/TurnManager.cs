using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class TurnManager : MonoBehaviour {
	RandomEventsManager Events;
	GameController GC;
	PlacesManager placesManager;
	// Use this for initialization
	void Start () {
		Events = GetComponent<RandomEventsManager>();
		GC = GetComponent<GameController>();	
		placesManager = GetComponent<PlacesManager>();
	}
	
	// Update is called once per frame
	void Update () {
		GC.UpdateUI();
	}

	public void Turn(){
		GC.AddMoney(GC.MoneyPerTurn);
		SetupEvent();
		placesManager.GeneratePlaces();
	}

	void SetupEvent(){
		BaseEvent e = Events.PickRandomEvent();
		print(e.GetType());

		Events.UIName.text = e.Name;
		Events.UIDescription.text = e.Description;

		Events.Choice1.onClick.RemoveAllListeners();
		Events.Choice1.GetComponentInChildren<Text>().text = e.Choice1Text;
		Events.Choice1.onClick.AddListener(e.Choice1);
		Events.Choice1.onClick.AddListener(Events.HideCanvas);

		Events.Choice2.onClick.RemoveAllListeners();
		Events.Choice2.GetComponentInChildren<Text>().text = e.Choice2Text;
		Events.Choice2.onClick.AddListener(e.Choice2);
		Events.Choice2.onClick.AddListener(Events.HideCanvas);

		Events.EventCanvas.enabled = true;
	}

}
