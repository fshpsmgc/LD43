using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class GameController : MonoBehaviour {
	public Faction[] Factions;
	public float PlayerMoney;
	public float MoneyPerTurn;
	public int SoulsCollected;
	public int SoulsTarget;


	public Slider[] FactionAttitideSlider;
	public Text MoneyText;
	public Text SoulsText;
	
	public Canvas VictoryCanvas;
	public Canvas DefeatCanvas;

	void Victory(){

	}

	void Defeat(){

	}

	public void Restart(){
		SceneManager.LoadScene("SampleScene");
	}

	public void AddMoney(float i){
		PlayerMoney += i;
		if(PlayerMoney <= 0){
			Defeat();
		}
	}

	public void AddSouls(int i){
		SoulsCollected += i;

		if(SoulsCollected >= SoulsTarget){
			Victory();
		}
	}

	public void UpdateUI(){
		if(MoneyPerTurn >= 0){
			MoneyText.text = PlayerMoney + " +"  + MoneyPerTurn + " per turn"; 
		}else{
			MoneyText.text = PlayerMoney + " -"  + Mathf.Abs(MoneyPerTurn) + " per turn"; 
		}

		SoulsText.text = SoulsCollected + "/" + SoulsTarget;

		for(int i = 0; i < Factions.Length; i++){
			FactionAttitideSlider[i].value = Factions[i].attitude.Current;
		}
	}

	public void ChangeAttitide(int faction, int i){
		if(!Factions[faction].ChangeAttitude(i)) Defeat();
	}

}
