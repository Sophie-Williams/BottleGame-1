using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class GameController : MonoBehaviour {

	public GameObject Bottle;

	public void RotateBottle ()
	{
		Bottle.GetComponent<Animation> ().Play ("+315");
	}


	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}
}
