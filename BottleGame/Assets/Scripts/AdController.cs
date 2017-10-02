using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Advertisements;
public class AdController : MonoBehaviour {

	private float currenttime;
	void Awake ()
	{
		Advertisement.Initialize("1561920",false);
		currenttime = 60f;
	}

	void Update ()
	{
		currenttime -= Time.deltaTime;
		float roundCurrentTime = Mathf.Round (currenttime);
		if (roundCurrentTime == 0f) {
			if (Advertisement.isSupported) {
				if (Advertisement.IsReady("rewardedVideo")) {
					Advertisement.Show ("rewardedVideo");
				}
			}
			currenttime = 900f;
		}

	}

}
