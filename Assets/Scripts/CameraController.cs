using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraController : MonoBehaviour {
	public Vector2 Min;
	public Vector2 Max;
	public float ScrollSpeed;

	public float EdgeSize;

	Vector2 Move;

	Vector3 mousePos;
	bool isScrolling;

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		/*mousePos = Input.mousePosition;
		
		isScrolling = (mousePos.x < EdgeSize || mousePos.x > Screen.width - EdgeSize) || (mousePos.y < EdgeSize || mousePos.y > Screen.height - EdgeSize); 

		if(isScrolling){
			Move.y = mousePos.x - Screen.width;
			Move.x = mousePos.y - Screen.height;
			transform.Translate(Move.normalized * ScrollSpeed);
		}*/

		Move.x = Input.GetAxis("Horizontal");
		Move.y = Input.GetAxis("Vertical");

		if((Move.x < 0 && transform.position.x <= Min.x) || ((Move.x > 0 && transform.position.x >= Max.x))){
			Move.x = 0;
		}

		if((Move.y < 0 && transform.position.y <= Min.y) || ((Move.y > 0 && transform.position.y >= Max.y))){
			Move.y = 0;
		}
		transform.Translate(Move.normalized * ScrollSpeed);
	}
}
