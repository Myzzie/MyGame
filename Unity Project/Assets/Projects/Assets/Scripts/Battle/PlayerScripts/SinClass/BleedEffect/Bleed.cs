using UnityEngine;
using System.Collections;

public class Bleed : MonoBehaviour {

	public MonsterHealth monsterHealth;
	public static bool startCoroutine;
	public static float bleedDamage;

	// Use this for initialization
	void Start () 
	{
		StartCoroutine (Bleeding ());
	}
	
	// Update is called once per frame
	void Update () {
	
	}



	IEnumerator Bleeding()
	{
		while (true)
		{

			yield return new WaitForSeconds(1);
			if (startCoroutine)
			{
				if (!PlayerDamage.holdAttack && !PlayerHealth.playerIsDead)
				{
				Damage.PlayerAttackDamage();
				bleedDamage = Damage.playerDamage*0.25f;
				monsterHealth.currentHealth -= bleedDamage;

				GameObject FloatingBleed = Instantiate (Resources.Load ("Prefabs/SinSkills/BleedingText")) as GameObject;
				FloatingBleed.GetComponent<BleedText> ().DisplayDamage (("+" + bleedDamage.ToString("f0")).ToString ());
				FloatingBleed.transform.SetParent ((GameObject.Find ("CanvasBattle").transform), false);
				}
			}
		}

	}
}
