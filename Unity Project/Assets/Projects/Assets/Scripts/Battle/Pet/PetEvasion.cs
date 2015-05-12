using UnityEngine;
using System.Collections;

public class PetEvasion : MonoBehaviour {


	public static float petEvadeChance;
	public static float baseEvadeChance;
	public static float evadeEnhance;


	public static bool EvadeChance ()
	{
		int randomTemp = Random.Range (1, 101);
		if (randomTemp <= (int)petEvadeChance) {

			return true;
		} else {
			return false;
		}
	}

	void Update()
	{
		if (petEvadeChance == 75) 
		{
			petEvadeChance = 75;
		}
	}
}
