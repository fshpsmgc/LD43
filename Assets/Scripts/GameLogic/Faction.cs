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
	
	public bool ChangeAttitude(int i){
		attitude.Current -= i;
		if(attitude.Current < 0) return true;
		else 					 return false;
	} 
}
