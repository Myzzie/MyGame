using UnityEngine;
using System.Collections;

public class MonsterDamage : MonoBehaviour {


	public static int monsterDamage;
	public  int minDamage;
	public  int maxDamage;


	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () 
	{


	}

	public void EnemyDamage()
	{

		monsterDamage = Random.Range (minDamage, (maxDamage + 1));

		if (WarriorStoneShield.stoneShieldOn)
		{
			monsterDamage = monsterDamage / 2;
		}
		if (PetDealDamage.petTaunting)
		{
			monsterDamage = monsterDamage / 2;
		}
	}
}
