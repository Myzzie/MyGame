using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class FishingExperience : MonoBehaviour {
	
	public UnityEngine.UI.Text expDisplay;
	public UnityEngine.UI.Text levelDisplay;
	public UnityEngine.UI.Text hoverExp;
	public Image expBar;
	public static float maxExp;
	public static int count;
	private float baseExp = 100;
	
	
	void Start()
	{

	}
	
	public void Update()
	{
		hoverExp.text = (Materials.materials.fishExp + ("/") + maxExp);
		expDisplay.text = (Materials.materials.fishExp + "/" + maxExp);
		levelDisplay.text = "Level: " + Materials.materials.fishLevel;
		expDisplay.text = ((Materials.materials.fishExp/maxExp) * 100).ToString ("f0") + "%";
		expBar.fillAmount = (float)Materials.materials.fishExp / (float)maxExp;
		
		maxExp = Mathf.Round (baseExp * Mathf.Pow (1.1f, count)); // Multiplies maxExp by 2

		if (Materials.materials.fishExp <= 0) 
			Materials.materials.fishExp = 0;
		
		if (Materials.materials.fishExp >= maxExp) 
		{
			Materials.materials.fishExp -= maxExp;
			Materials.materials.fishLevel += 1; // Level Up on full Exp
			count += 1; // Count times Leveled Up

		}

		
	



		
		

		
		
		
		
	}
	
}