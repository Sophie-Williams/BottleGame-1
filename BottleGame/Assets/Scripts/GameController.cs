using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class GameController : MonoBehaviour {

	public GameObject Bottle;
	public List <AnimationClip> anim =new List <AnimationClip>();

	public void StartAnimation ()
	{
		int rand = Random.Range (0, anim.Count);
		Debug.Log (rand);
		Bottle.GetComponent<Animation> ().Play (anim[rand].name);
	}

}
