using UnityEngine;
using System.Collections;

public class GetOre : MonoBehaviour {

	public static float baseOreAmount = 1;
	public static float oreAmount;


	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	
	}




	public static float MineOre()
	{

		DoubleOre.DoubleOreChance ();
		if (DoubleOre.doubleChance1) {
			return oreAmount = baseOreAmount * DoubleOre.GetDoubleOre ();
		} else
			return baseOreAmount;



	}
}
