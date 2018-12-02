using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlacesManager : MonoBehaviour {
	public List<Place> PlacesPool;
	public List<Place> PlacesThisTurn;

	public int MaxRandomPlaces;
	public int MinRandomPlaces;
	int RandomPlacesCount;

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}

	public void GeneratePlaces(){
		RandomPlacesCount = Random.Range(MinRandomPlaces, MaxRandomPlaces);
		foreach(Place p in PlacesThisTurn){
			p.Hide();
		}
		PlacesThisTurn.Clear();

		for(int i = 0; i < RandomPlacesCount; i++){
			Place ChosenPlace = PlacesPool[Random.Range(0, PlacesPool.Count)];
			print(ChosenPlace.name);
			if(!PlacesThisTurn.Contains(ChosenPlace)){
				PlacesThisTurn.Add(ChosenPlace);
				ChosenPlace.Show();
			}
		}	
	}

	public void ClearPlaces(){
		foreach(Place p in PlacesThisTurn){
			p.Hide();
		}
		PlacesThisTurn.Clear();
	}
}
