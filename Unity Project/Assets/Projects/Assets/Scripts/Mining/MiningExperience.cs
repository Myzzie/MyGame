using UnityEngine;
using System.Collections;
using UnityEngine.UI;

[System.Serializable]
public class MiningExperience : MonoBehaviour {
	

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
		hoverExp.text = (Materials.materials.mineExp.ToString("f0") + ("/") + maxExp);
		expDisplay.text = "Exp: " + Materials.materials.mineExp;
		levelDisplay.text = "Level: " + Materials.materials.mineLevel;

		expDisplay.text = ((Materials.materials.mineExp/maxExp) * 100).ToString ("f0") + "%";
		expBar.fillAmount = (float)Materials.materials.mineExp / (float)maxExp;

		maxExp = Mathf.Round (baseExp * Mathf.Pow (1.2f, count));

		if (Materials.materials.mineExp <= 0) 
		{
			Materials.materials.mineExp = 0;
		}

		if (Materials.materials.mineExp >= maxExp)
		{
			Materials.materials.mineExp -= maxExp;
			Materials.materials.mineLevel += 1;
			count += 1;

		}
	

		
		
			

		

	}
	

	
}
