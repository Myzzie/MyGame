using UnityEngine;
using System.Collections;

public class Hover : MonoBehaviour {

	public GameObject tooltip;
	public UnityEngine.UI.Text Tooltip;

	// Use this for initialization
	void Start () {
		tooltip.SetActive (false);
	
	}
	
	// Update is called once per frame
	void Update () {
	
	}

	//Purchase info
	public void PickAxeUpgrade () 
	{
		tooltip.SetActive(true);
		Tooltip.text = "Pickaxe will provide more power";
	}
	public void MinerUpgrade () 
	{
		tooltip.SetActive(true);
		Tooltip.text = "Allows you to mine higher tier ore";
	}
	public void DoubleOreChanceUpgrade () 
	{
		tooltip.SetActive(true);
		Tooltip.text = "Chance to return home with a magical MineCart";
	}
	public void OreAmountUpgrade () 
	{
		tooltip.SetActive(true);
		Tooltip.text = "Abandon a fellow Miner in order to return home with more ores";
	}
	public void AxeUpgrade () 
	{
		tooltip.SetActive(true);
		Tooltip.text = "Sharper axe means more power";
	}
	public void LumberJackUpgrade () 
	{
		tooltip.SetActive(true);
		Tooltip.text = "Did someone call for a Lumberjack?";
	}
	public void DoubleWoodChanceUpgrade () 
	{
		tooltip.SetActive(true);
		Tooltip.text = "Lumberjack often find a glass of ol'Whiskey in a tree..";
	}
	public void WoodAmountUpgrade () 
	{
		tooltip.SetActive(true);
		Tooltip.text = "Oh look, I can fit a wood in this pocket";
	}
	public void Dagger1Upgrade () 
	{
		if (!Dagger1.maxPurchased){
		tooltip.SetActive(true);
		}
	}
	public void Dagger1Info () 
	{
			tooltip.SetActive(true);
			Tooltip.text = "Damage: " + Dagger1.dagger1MinDamage + " - " + Dagger1.dagger1MaxDamage;
	}
	public void Dagger2Upgrade () 
	{
		if (!Dagger2.maxPurchased){
			tooltip.SetActive(true);
		}
	}
	public void Dagger2Info () 
	{
		tooltip.SetActive(true);
		Tooltip.text = "Damage: " + Dagger2.dagger2MinDamage + " - " + Dagger2.dagger2MaxDamage;
	}
	public void RingUpgrade () 
	{
		if (!Ring.maxPurchased){
			tooltip.SetActive(true);
		}
	}
	public void RingInfo () 
	{
			tooltip.SetActive(true);
			Tooltip.text = "Provides more attack speed";
	
	}
	public void HelmetUpgrade () 
	{
		if (!Helmet.maxPurchased){
			tooltip.SetActive(true);
		}
	}
	public void HelmetInfo () 
	{
	
			tooltip.SetActive(true);
			Tooltip.text = "Provides higher health";

	}
	public void ArmourUpgrade () 
	{
		if (!Armour.maxPurchased){
			tooltip.SetActive(true);
		}
	}
	public void ArmourInfo () 
	{
		
		tooltip.SetActive(true);
		Tooltip.text = "Provides higher health regeneration";
		
	}
	public void BootsUpgrade () 
	{
		if (!Boots.maxPurchased){
			tooltip.SetActive(true);
		}
	}
	public void BootsInfo () 
	{

			tooltip.SetActive(true);
			Tooltip.text = "Provides higher evasion";

	}
	public void GlovesUpgrade () 
	{
		if (!Gloves.maxPurchased){
			tooltip.SetActive(true);
		}
	}
	public void GlovesInfo () 
	{

			tooltip.SetActive(true);
			Tooltip.text = "Provides higher critical chance";

	}
	public void StaffUpgrade () 
	{
		if (!Staff.maxPurchased){
		tooltip.SetActive(true);
		}
	}
	public void StaffDamage () 
	{
	
			tooltip.SetActive(true);
			Tooltip.text = "Damage: " + Staff.staffMinDamage + " - " + Staff.staffMaxDamage;
	
	}
	public void TwoHandSwordUpgrade () 
	{
		if (!TwoHandSword.maxPurchased){
			tooltip.SetActive(true);
		}
	}
	public void TwoHandSwordDamage () 
	{
		tooltip.SetActive(true);
		Tooltip.text = "Damage: " + TwoHandSword.twoHandSwordMinDamage + " - " + TwoHandSword.twoHandSwordMaxDamage;
	}
	public void PetUpgrade () 
	{
		tooltip.SetActive(true);
		Tooltip.text = "Alongside you, this pet will fight";
	}
	//Inactive
	public void BattleSideWindow () 
	{
		tooltip.SetActive(true);

	}
	//Show Image name
	public void CopperOre () 
	{
		tooltip.SetActive(true);
		Tooltip.text = "Copper Ore";
	}
	public void IronOre () 
	{
		tooltip.SetActive(true);
		Tooltip.text = "Iron Ore";
	}
	public void CoalOre () 
	{
		tooltip.SetActive(true);
		Tooltip.text = "Coal Ore";
	}
	public void SilverOre () 
	{
		tooltip.SetActive(true);
		Tooltip.text = "Silver Ore";
	}
	public void GoldOre () 
	{
		tooltip.SetActive(true);
		Tooltip.text = "Gold Ore";
	}
	public void MithrilOre () 
	{
		tooltip.SetActive(true);
		Tooltip.text = "Mithril Ore";
	}
	public void AdamantiteOre () 
	{
		tooltip.SetActive(true);
		Tooltip.text = "Adamantite Ore";
	}
	public void RuniteOre () 
	{
		tooltip.SetActive(true);
		Tooltip.text = "Runite Ore";
	}
	public void Wood () 
	{
		tooltip.SetActive(true);
		Tooltip.text = "Wood";
	}
	//Exp bar hover
	public void MiningExp () 
	{
		tooltip.SetActive(true);
	}
	public void WoodExp () 
	{
		tooltip.SetActive(true);
	}
	public void BattleExp () 
	{
		tooltip.SetActive(true);
	}
	public void CritExp () 
	{
		tooltip.SetActive(true);
	}
	public void EvasionExp()
	{
		tooltip.SetActive (true);
	}
	public void LifeExp () 
	{
		tooltip.SetActive(true);
	}
	//Warrior Skill Info
	public void RegenSkill () 
	{
		tooltip.SetActive(true);
	}
	public void HardHitSkill () 
	{
		tooltip.SetActive(true);
	}
	public void DamageBoostSkill () 
	{
		tooltip.SetActive(true);
	}
	public void HealthBoostSkill () 
	{
		tooltip.SetActive(true);
	}
	public void StoneShieldSkill () 
	{
		tooltip.SetActive(true);
	}
	public void SpikeShieldSkill () 
	{
		tooltip.SetActive(true);
	}
	//Assassin Skill Info
	public void EvasionBoostSkill () 
	{
		tooltip.SetActive(true);
	}
	public void LifeStealSkill () 
	{
		tooltip.SetActive(true);
	}
	public void CritChanceSkill () 
	{
		tooltip.SetActive(true);
	}
	public void CritDamageSkill () 
	{
		tooltip.SetActive(true);
	}
	public void Rampage () 
	{
		tooltip.SetActive(true);
	}
	public void BleedEffect () 
	{
		tooltip.SetActive(true);
	}

	//Wizard Skill Info
	public void HealSkill () 
	{
		tooltip.SetActive(true);
	}
	public void PetHealSkill () 
	{
		tooltip.SetActive(true);
	}
	public void PetRageSkill () 
	{
		tooltip.SetActive(true);
	}
	public void FreezeSkill () 
	{
		tooltip.SetActive(true);
	}
	public void PetTauntSkill () 
	{
		tooltip.SetActive(true);
	}
	public void PetDamageSkill () 
	{
		tooltip.SetActive(true);
	}


	//OnMouseExit
	public void OnMouseExit ()
	{
		tooltip.SetActive(false);
	}




}
