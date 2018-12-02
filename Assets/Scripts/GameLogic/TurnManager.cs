using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class TurnManager : MonoBehaviour {
	RandomEventsManager Events;
	GameController GC;
	PlacesManager placesManager;
	public int TurnCounter;
	public Text TurnText;
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
		TurnCounter++;
		TurnText.text = "Turn: " + TurnCounter;
		GC.AddMoney(GC.MoneyPerTurn);
		if(TurnCounter % 2 == 0){
			SetupEvent();
		}
		placesManager.GeneratePlaces();

		foreach(Faction f in GC.Factions){
			f.isFrozen = false;
		}
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

		if(e.Choice2Text == ""){
			Events.Choice2.gameObject.SetActive(false);
		}else{
			Events.Choice2.gameObject.SetActive(true);
			Events.Choice2.onClick.RemoveAllListeners();
			Events.Choice2.GetComponentInChildren<Text>().text = e.Choice2Text;
			Events.Choice2.onClick.AddListener(e.Choice2);
			Events.Choice2.onClick.AddListener(Events.HideCanvas);
		}

		Events.EventCanvas.enabled = true;
	}

}
