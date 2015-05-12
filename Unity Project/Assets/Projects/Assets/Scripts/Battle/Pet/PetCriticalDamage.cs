using UnityEngine;
using System.Collections;

public class PetCriticalDamage : MonoBehaviour {
	
	
	public static float petCritChance;
	public static float petCritDamage = 1.5f;
	public static float baseCritChance;
	public static float critEnhance;
	public static bool petCritChance1;




	void Update()
	{


	}






	public static float GetCritHit()
	{
		if (petCritChance1)
		{
		
			return (float)petCritDamage;


			
		} 
		else 
		{

			return 0;
			
		}
	}
	
	
	public static void CritChance ()
	{
		int randomTemp = Random.Range (1, 101);
		if (randomTemp <= (int)petCritChance) {
			petCritChance1 = true;
		} else 
		{
			petCritChance1 = false;
		}
		
	

}
}
