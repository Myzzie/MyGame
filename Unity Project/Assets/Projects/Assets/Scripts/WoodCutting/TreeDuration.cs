using UnityEngine;
using System.Collections;

public class TreeDuration : MonoBehaviour {


	public static float treeDuration = 10;








	public static float WoodDuration()
	{
		if (treeDuration < 1) 
		{
			return 1;
		}
		else
		treeDuration = 5;
		return treeDuration = treeDuration / WoodPerSec.woodPower;
	}
}
