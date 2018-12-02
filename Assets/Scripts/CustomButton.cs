using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

public class CustomButton : MonoBehaviour {
	public UnityEvent OnClick;
	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}

	void OnMouseOver(){
		if(Input.GetMouseButtonDown(0)){
			OnClick.Invoke();
			transform.localScale -= new Vector3(.1f, .1f, .1f);
		}
	}

	void OnMouseEnter(){
		transform.localScale += new Vector3(.1f, .1f, .1f);
	}

	void OnMouseExit(){
		transform.localScale -= new Vector3(.1f, .1f, .1f);
	}
}
