using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Place : MonoBehaviour {
	PlacesManager manager;
	public GameObject AquireButton;
	public GameObject KidnapButton;
	public GameObject ExtortButton;
	public GameObject Owner;

	void Start(){
		Hide();
	}

	public void Hide(){
		if(AquireButton != null) AquireButton.SetActive(false); 
		if(KidnapButton != null) KidnapButton.SetActive(false);
		if(ExtortButton != null) ExtortButton.SetActive(false);
		if(Owner != null) Owner.SetActive(false);
	}

	public void Show(){
		if(AquireButton != null) AquireButton.SetActive(true); 
		if(KidnapButton != null) KidnapButton.SetActive(true);
		if(ExtortButton != null) ExtortButton.SetActive(true);
		if(Owner != null) Owner.SetActive(true);
	}
}
