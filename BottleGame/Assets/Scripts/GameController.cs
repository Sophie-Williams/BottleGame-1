using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class GameController : MonoBehaviour {

	public GameObject Bottle;
	public List <AnimationClip> anim =new List <AnimationClip>();
	public List <string> wishString = new List <string> ();
	public Text wishTextComponent;

	public void StartAnimation ()
	{
		int randAnim = Random.Range (0, anim.Count);
		int randString = Random.Range (0, wishString.Count);
		Debug.Log (randString);
		Bottle.GetComponent<Animation> ().Play (anim[randAnim].name);
		wishTextComponent.text = wishString [randString];
	}

}
