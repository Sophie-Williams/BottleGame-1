using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class GameController : MonoBehaviour {

	public GameObject Bottle;
	public AnimationClip[] anim = new AnimationClip[16];

	public Text wishTextComponent;
	public string[] wishString = new string[100];
	private int countOfPress;
	private int randString;

	public void StartAnimation ()
	{
		int randAnim = Random.Range (0, 16);
		randString = Random.Range (0, 55);
		Debug.Log (randString);
		countOfPress++;
		Bottle.GetComponent<Animation> ().Play (anim[randAnim].name);
		wishTextComponent.text = wishString [randString];
	}
		
}
