using UnityEngine;
using System.Collections;

public class BasePlayer : MonoBehaviour {
	

	private BaseCharacterClass playerClass;
	private float baseMinDamage;
	private float baseMaxDamage;
	private float attackSpeed;
	private float maxHealth;
	private float baseCritChance;
	private float baseEvadeChance;



	public BaseCharacterClass PlayerClass { get; set;}
	public float BaseMinDamage { get; set;}
	public float BaseMaxDamage { get; set;}
	public float AttackSpeed { get; set;}
	public float MaxHealth { get; set;}
	public float BaseCritChance { get; set;}
	public float BaseEvadeChance { get; set;}





}
