using UnityEngine;
using System.Collections;

public class BaseCharacterClass  {


	private string characterClassName;
	private string characterClassDescription;

	//Stats
	private int baseMaxDamage;
	private int baseMinDamage;
	private float attackSpeed;
	private float maxHealth;
	private float baseCritChance;
	private float baseEvadeChance;


	public string CharacterClassName 
	{
		get{ return characterClassName;}
		set{characterClassName = value;}
		}
	public string CharacterClassDescription 
	{
		get{ return characterClassDescription;}
		set{characterClassDescription = value;}
	}
	public int BaseMinDamage 
	{
		get{ return baseMinDamage;}
		set{baseMinDamage = value;}
	}
	public int BaseMaxDamage 
	{
		get{ return baseMaxDamage;}
		set{baseMaxDamage = value;}
	}
	public float AttackSpeed 
	{
		get{ return attackSpeed;}
		set{attackSpeed = value;}
	}
	public float MaxHealth 
	{
		get{ return maxHealth;}
		set{maxHealth = value;}
	}
	public float BaseCritChance
	{
		get{ return baseCritChance;}
		set{baseCritChance = value;}
	}
	public float BaseEvadeChance
	{
		get{ return baseEvadeChance;}
		set{baseEvadeChance = value;}
	}




}



