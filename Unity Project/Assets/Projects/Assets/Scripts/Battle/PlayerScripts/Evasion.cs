using UnityEngine;
using System.Collections;

public class Evasion : MonoBehaviour {


	public static float evadeChance;
	public static float baseEvadeChance = 5;
	public static float evadeEnhance = 1;



	void Start()
	{
	}


	public static bool EvadeChance ()
	{
		int randomTemp = Random.Range (0, 101);
		if (randomTemp <= (int)evadeChance) {

			return true;
		} else {
			return false;
		}
	}

	void Update()
	{
	
	}
}
