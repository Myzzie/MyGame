using UnityEngine;
using System.Collections;

public class LifeExperience : MonoBehaviour {

		
	public UnityEngine.UI.Text hoverExp;
	public static float maxExp;
	public static int count;
	private float baseExp = 100;
	public static float lifeLevelHealth = 1;
		
		
		void Start()
		{
	
		}
		
		public void Update()
		{
			hoverExp.text = (Materials.materials.lifeExp + ("/") + maxExp);
	
		maxExp = Mathf.Round (baseExp * Mathf.Pow (1.2f, count)); // Multiplies maxExp by 2

		if (Materials.materials.lifeExp <= 0) {
			Materials.materials.lifeExp = 0;
		}

		if (Materials.materials.lifeExp >= maxExp) 
			{
			Materials.materials.lifeExp -= maxExp;
			Materials.materials.lifeLevel += 1; // Level Up on full Exp

			lifeLevelHealth += 0.1f;
			count += 1; // Count times Leveled Up
			}
			
			
			

				

			
			
			
			
			
			
			
		}
		
	}