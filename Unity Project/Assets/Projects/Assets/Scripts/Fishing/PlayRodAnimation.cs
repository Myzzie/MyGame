using UnityEngine;
using System.Collections;

public class PlayRodAnimation : MonoBehaviour {

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () 
	{
		if (Fish1.Delay == true) {

			animation.Play ("FishingRod");
		} else 
		{
			animation.Stop ("FishingRod");
		}
	}
}
