using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[System.Serializable]
public class Faction{
	[System.Serializable]
	public struct Attitude{
		public int Max;
		public int Current;
	}

	public Attitude attitude;
	public string Name;
	public string Description;
	public Sprite Icon;
	public bool isFrozen;

	//If player lost return true, else false
	public bool ChangeAttitude(int i){
		if(!isFrozen){
			attitude.Current -= i;
			if(attitude.Current < 0) return true;
			else 					 return false;
		}else{
			return false;
		}
	} 
}
