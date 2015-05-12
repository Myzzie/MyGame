using UnityEngine;
using System.Collections;

public class AllPopUpManager : MonoBehaviour {

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () 
	{
	
		if  (Input.GetKey(KeyCode.Escape))
		{
			ClassPurchaseManager.hide ();
			MarketManager.hide ();
			PetStashManager.hide ();
			StatsManager.hide ();
		}

	}
}
