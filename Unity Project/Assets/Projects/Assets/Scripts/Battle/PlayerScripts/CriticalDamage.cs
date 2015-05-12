using UnityEngine;
using System.Collections;

public class CriticalDamage : MonoBehaviour {
	
	
	public static float critChance;
	public static float baseCritChance;
	public static float critDamage = 1.5f;
	public static bool critChance1;
	public static float critEnhance = 1;



	void Start()
	{
		critEnhance = 1;

	}






	public static float GetCritHit()
	{
		if (critChance1)
		{
			return (float)critDamage;
		} 
		else 
		{
			return 0;
		}
	}
	
	
	public static void CritChance ()
	{
		int randomTemp = Random.Range (0, 101);
		if (randomTemp <= (int)critChance) {
			critChance1 = true;
		} else 
		{
			critChance1 = false;
		}
		
	

}
}
