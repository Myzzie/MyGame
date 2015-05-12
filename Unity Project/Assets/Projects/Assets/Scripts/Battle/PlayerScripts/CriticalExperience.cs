using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class CriticalExperience : MonoBehaviour {
	

	public UnityEngine.UI.Text hoverExp;
	public static float maxExp;
	public static int count;
	private float baseExp = 100;
	
	
	void Start()
	{
	}
	
	public void Update()
	{
		hoverExp.text = (Materials.materials.critExp + ("/") + maxExp);


		maxExp = Mathf.Round (baseExp * Mathf.Pow (1.2f, count)); // Multiplies maxExp by 2
		
		if (Materials.materials.critExp <= 0) 
			Materials.materials.critExp = 0;
		if (Materials.materials.critExp >= maxExp) 
			Materials.materials.critExp = maxExp;
		
		if (Materials.materials.critExp >= maxExp) 
		{
			Materials.materials.critLevel += 1; // Level Up on full Exp
			Materials.materials.critExp -= maxExp; // Reset current Exp to 0
			CriticalDamage.critEnhance += 0.02f;
			count += 1; // Count times Leveled Up

		}

	}
}