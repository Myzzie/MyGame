using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class WoodCuttingExperience : MonoBehaviour {
	
	public UnityEngine.UI.Text expDisplay;
	public UnityEngine.UI.Text levelDisplay;

	public UnityEngine.UI.Text hoverExp;
	public CutWood cutWood;
	public Image healthBar;
	public static float maxExp;
	public WoodPurchase woodPurchase;
	public static int count;
	private float baseExp = 100;
	
	
	void Start()
	{


	}
	
	public void Update()
	{
		hoverExp.text = (Materials.materials.woodCuttingExp.ToString("f0") + ("/") + maxExp);
		expDisplay.text = "Exp: " + Materials.materials.woodCuttingExp;
		levelDisplay.text = "Level: " + Materials.materials.woodCuttingLevel;

		expDisplay.text = ((Materials.materials.woodCuttingExp/maxExp) * 100).ToString ("f0") + "%";

		healthBar.fillAmount = (float)Materials.materials.woodCuttingExp / (float)maxExp;
	

		maxExp = Mathf.Round (baseExp * Mathf.Pow (1.2f, count));

		if (Materials.materials.woodCuttingExp <= 0)
		{
			Materials.materials.woodCuttingExp = 0;
		}
		
		if (Materials.materials.woodCuttingExp >= maxExp)
		{
			Materials.materials.woodCuttingExp -= maxExp;
			Materials.materials.woodCuttingLevel += 1;
			count += 1;

		}

	
	
		

		

	
	}
	

	
}