using UnityEngine;
using System.Collections;

public class DoubleWood : MonoBehaviour {
	
	public static float doubleChance = 5;
	public static bool doubleChance1;
	public static float moreWood = 2;
	
	
	public static float GetDoubleWood()
	{
		if (doubleChance1) 
		{
			
			return moreWood;
			
		} 
		else 
		{
			
			return 0;
			
		}
	}
	
	
	public static void DoubleWoodChance ()
	{
		int randomTemp = Random.Range (1, 101);
		if (randomTemp <= doubleChance) {
			doubleChance1 = true;
		} else 
		{
			doubleChance1 = false;
		}
		
		
		
	}
}
