using UnityEngine;
using System.Collections;

public class DoubleOre : MonoBehaviour {

	
	public static float doubleChance;
	public static bool doubleChance1;
	public static float moreOre = 2;


	public static float GetDoubleOre()
	{
		if (doubleChance1) 
		{

			return moreOre;

		} 
		else 
		{
		
			return 0;

		}
	}


	public static void DoubleOreChance ()
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

