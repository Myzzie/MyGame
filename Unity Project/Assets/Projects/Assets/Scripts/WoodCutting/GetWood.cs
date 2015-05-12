using UnityEngine;
using System.Collections;

public class GetWood : MonoBehaviour {

	public static float woodAmount = 1;
	public static float baseWoodAmount;
	
	
	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}
	
	
	
	
	public static float CutWood()
	{

		
		DoubleWood.DoubleWoodChance ();
		if (DoubleWood.doubleChance1) {
			return woodAmount = baseWoodAmount * (float)DoubleWood.GetDoubleWood ();
		} else
			return baseWoodAmount;
		
		
		
	}
}
