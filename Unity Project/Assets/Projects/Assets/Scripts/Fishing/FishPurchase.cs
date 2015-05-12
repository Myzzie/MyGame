using UnityEngine;
using System.Collections;

public class FishPurchase : MonoBehaviour {


	public UnityEngine.UI.Text fish;



	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () 
	{
		fish.text = "" + Materials.materials.fish1;
	
	}
}
