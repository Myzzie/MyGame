using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class BattleExperience : MonoBehaviour {
	
	public UnityEngine.UI.Text expDisplay;
	public UnityEngine.UI.Text levelDisplay;
	public UnityEngine.UI.Text hoverExp;
	public Image expBar;
	public static float maxExp;
	public static int count;
	public static float baseExp = 100;
	
	
	void Start()
	{

	}
	
	public void Update()
	{
		hoverExp.text = (Materials.materials.battleExp.ToString("f0") + ("/") + maxExp);
		expDisplay.text = (Materials.materials.battleExp + "/" + maxExp);
		levelDisplay.text = "Level: " + Materials.materials.battleLevel;
		expDisplay.text = ((Materials.materials.battleExp/maxExp) * 100).ToString ("f0") + "%";
		expBar.fillAmount = (float)Materials.materials.battleExp / (float)maxExp;
	
		maxExp = Mathf.Round (baseExp * Mathf.Pow (1.2f, count)); // Multiplies maxExp by 2

		if (Materials.materials.battleExp <= 0) 
		{
			Materials.materials.battleExp = 0;
		}

		if (Materials.materials.battleExp >= maxExp)
		{
			Materials.materials.battleExp -= maxExp;

			Materials.materials.battleLevel += 1; // Level Up on full Exp
			Damage.playerDamageEnhance += 0.01f;
			PlayerHealth.currentHealth = PlayerHealth.maxHealth;
			count += 1; // Count times Leveled Up

		}





		
		
	}

}