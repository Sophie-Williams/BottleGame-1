using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class GameController : MonoBehaviour {

	public GameObject Bottle;
	public AnimationClip[] anim = new AnimationClip[16];
	//public List <string> wishString = new List <string> ();
	public Text wishTextComponent;
	public string[] wishString = new string[100];


	public void StartAnimation ()
	{
		int randAnim = Random.Range (0, 16);
		int randString = Random.Range (0, 3);
		Debug.Log (randAnim);
		Bottle.GetComponent<Animation> ().Play (anim[randAnim].name);
		wishTextComponent.text = wishString [randString];
	}

}
