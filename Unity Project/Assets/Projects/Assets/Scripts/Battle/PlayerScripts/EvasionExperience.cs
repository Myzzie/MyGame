using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class EvasionExperience : MonoBehaviour {
	
	
	public UnityEngine.UI.Text hoverExp;
	public static float maxExp;
	public static int count;
	private float baseExp = 100;
	
	
	void Start()
	{
		
	
	}
	
	public void Update()
	{
		hoverExp.text = (Materials.materials.evasionExp + ("/") + maxExp);
		

		maxExp = Mathf.Round (baseExp * Mathf.Pow (1.2f, count)); // Multiplies maxExp by 2
		
		if (Materials.materials.evasionExp <= 0) {
			Materials.materials.evasionExp = 0;
		}
		
		if (Materials.materials.evasionExp >= maxExp) 
		{
			Materials.materials.evasionLevel += 1; // Level Up on full Exp
			count += 1; // Count times Leveled Up
			Evasion.evadeEnhance += 0.05f;
			Materials.materials.evasionExp -= maxExp;

		}

	}
	
}