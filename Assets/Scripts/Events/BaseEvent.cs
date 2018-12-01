using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

[System.Serializable]
public class BaseEvent {
	public string Name;
	public string Description;
	public Sprite Picture;
	public string Choice1Text;
	public string Choice2Text;

	public virtual void Choice1(){
		GameObject.Find("TestText").GetComponent<Text>().text = "Choice1";
	}

	public virtual void Choice2(){
		GameObject.Find("TestText").GetComponent<Text>().text = "Choice2";
	}
}
