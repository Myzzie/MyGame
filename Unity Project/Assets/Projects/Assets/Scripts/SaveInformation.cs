using UnityEngine;
using System.Collections;

public class SaveInformation  {




	public static void SaveAllInformation()
	{
	
		PlayerPrefs.SetFloat("Gold", Materials.materials.gold);
		PlayerPrefs.SetFloat("Wood", Materials.materials.wood);
		PlayerPrefs.SetFloat("CopperOre", Materials.materials.copperOre);
		PlayerPrefs.SetFloat("IronOre", Materials.materials.ironOre);
		PlayerPrefs.SetFloat("CoalOre", Materials.materials.coalOre);
		PlayerPrefs.SetFloat("SilverOre", Materials.materials.silverOre);
		PlayerPrefs.SetFloat("GoldOre", Materials.materials.goldOre);
		PlayerPrefs.SetFloat("MithrilOre", Materials.materials.mithrilOre);
		PlayerPrefs.SetFloat("AdamantiteOre", Materials.materials.adamantiteOre);
		PlayerPrefs.SetFloat("RuniteOre", Materials.materials.runiteOre);
		PlayerPrefs.SetFloat("CopperOreDuration", OreDuration.copperDuration);
		PlayerPrefs.SetFloat("IronOreDuration", OreDuration.ironDuration);
		PlayerPrefs.SetFloat("SilverOreDuration", OreDuration.silverDuration);
		PlayerPrefs.SetFloat("GoldOreDuration", OreDuration.goldDuration);
		PlayerPrefs.SetFloat("MithrilOreDuration", OreDuration.mithrilDuration);
		PlayerPrefs.SetFloat("AdamantiteOreDuration", OreDuration.adamantiteDuration);
		PlayerPrefs.SetFloat("RuniteOreDuration", OreDuration.runiteDuration);
		
		PlayerPrefs.SetFloat("MineExp", Materials.materials.mineExp);
		PlayerPrefs.SetInt("MineExpCount", MiningExperience.count);
		PlayerPrefs.SetInt("MineLevel", Materials.materials.mineLevel);
		PlayerPrefs.SetFloat("OreAmount", GetOre.oreAmount);
		PlayerPrefs.SetFloat("BaseOreAmount", GetOre.baseOreAmount);
		PlayerPrefs.SetFloat("DoubleOreChance", DoubleOre.doubleChance);
		
		PlayerPrefs.SetFloat("BattleExp", Materials.materials.battleExp);
		PlayerPrefs.SetInt("BattleExpCount", BattleExperience.count);
		PlayerPrefs.SetInt("BattleLevel", Materials.materials.battleLevel);
		PlayerPrefs.SetFloat("CritExp", Materials.materials.critExp);
		PlayerPrefs.SetInt("CritExpCount", CriticalExperience.count);
		PlayerPrefs.SetInt("CritLevel", Materials.materials.critLevel);
		PlayerPrefs.SetFloat("EvasionExp", Materials.materials.evasionExp);
		PlayerPrefs.SetInt("EvasionExpCount", EvasionExperience.count);
		PlayerPrefs.SetInt("EvasionLevel", Materials.materials.evasionLevel);
		PlayerPrefs.SetFloat("LifeExp", Materials.materials.lifeExp);
		PlayerPrefs.SetInt("LifeExpCount", LifeExperience.count);
		PlayerPrefs.SetInt("LifeLevel", Materials.materials.lifeLevel);
		PlayerPrefs.SetFloat("LifeLevelHealth", LifeExperience.lifeLevelHealth);
		
		
		
		PlayerPrefs.SetFloat("FishExp", Materials.materials.fishExp);
		PlayerPrefs.SetInt("FishExpCount", FishingExperience.count);
		PlayerPrefs.SetInt("FishLevel", Materials.materials.fishLevel);
		PlayerPrefs.SetInt("Fish1", Materials.materials.fish1);
		PlayerPrefs.SetInt("FishAmount", Materials.materials.fishAmount);
		
		PlayerPrefs.SetFloat("WoodCuttingExp", Materials.materials.woodCuttingExp);
		PlayerPrefs.SetInt("WoodCuttingExpCount", WoodCuttingExperience.count);
		PlayerPrefs.SetInt("WoodCuttingLevel", Materials.materials.woodCuttingLevel);
		PlayerPrefs.SetFloat("WoodAmount", GetWood.woodAmount);
		PlayerPrefs.SetFloat("BaseWoodAmount", GetWood.baseWoodAmount);
		PlayerPrefs.SetFloat("DoubleWoodChance", DoubleWood.doubleChance);


		//Warrior Skills
		PlayerPrefs.SetFloat("WarriorSkillChance1", WarriorDamageBoost.damageBoostChance);
		PlayerPrefs.SetInt("WarriorSkillNum1", WarriorDamageBoost.curSkillNum);

		PlayerPrefs.SetFloat("WarriorSkillChance2", HardHitSkill.hardHitChance);
		PlayerPrefs.SetInt("WarriorSkillNum2", HardHitSkill.curSkillNum);

		PlayerPrefs.SetFloat("WarriorSkillChance3", WarriorHealthBoost.healthBoostChance);
		PlayerPrefs.SetInt("WarriorSkillNum3", WarriorHealthBoost.curSkillNum);

		PlayerPrefs.SetFloat("WarriorSkillChance4", RegenSkill.regenChance);
		PlayerPrefs.SetInt("WarriorSkillNum4", RegenSkill.curSkillNum);

		PlayerPrefs.SetFloat("WarriorSkillChance5", WarriorSpikeShield.spikeShieldChance);
		PlayerPrefs.SetInt("WarriorSkillNum5", WarriorSpikeShield.curSkillNum);

		PlayerPrefs.SetFloat("WarriorSkillChance6", WarriorStoneShield.stoneShieldChance);
		PlayerPrefs.SetInt("WarriorSkillNum6", WarriorStoneShield.curSkillNum);
	
		//Assassin Skills
		PlayerPrefs.SetFloat("AssassinSkillChance1", AttackSpeedBoost.speedChance);
		PlayerPrefs.SetInt("AssassinSkillNum1", AttackSpeedBoost.curSkillNum);

		PlayerPrefs.SetFloat("AssassinSkillChance2", BleedEffect.bleedEffectChance);
		PlayerPrefs.SetInt("AssassinSkillNum2", BleedEffect.curSkillNum);

		PlayerPrefs.SetFloat("AssassinSkillChance3", CritChanceBoost.critChance);
		PlayerPrefs.SetInt("AssassinSkillNum3", CritChanceBoost.curSkillNum);
		PlayerPrefs.SetInt("AssassinSkillCost3", CritChanceBoost.cost);

		PlayerPrefs.SetFloat("AssassinSkillChance4", CritDamageBoost.critDamage);
		PlayerPrefs.SetInt("AssassinSkillNum4", CritDamageBoost.curSkillNum);
		
		PlayerPrefs.SetFloat("AssassinSkillChance5", EvasionBoost.evadeChance);
		PlayerPrefs.SetInt("AssassinSkillNum5", EvasionBoost.curSkillNum);
		
		PlayerPrefs.SetFloat("AssassinSkillChance6", SinLifeSteal.lifeStealChance);
		PlayerPrefs.SetInt("AssassinSkillNum6", SinLifeSteal.curSkillNum);
		
		PlayerPrefs.SetFloat("AssassinSkillChance7", Rampage.rampageChance);
		PlayerPrefs.SetInt("AssassinSkillNum7", Rampage.curSkillNum);
		
		//Wizard Skills
		PlayerPrefs.SetFloat("WizardSkillChance1", WizardFreeze.freezeChance);
		PlayerPrefs.SetInt("WizardSkillNum1", WizardFreeze.curSkillNum);
		
		PlayerPrefs.SetFloat("WizardSkillChance2", WizardHealSkill.healChance);
		PlayerPrefs.SetInt("WizardSkillNum2", WizardHealSkill.curSkillNum);
		
		PlayerPrefs.SetFloat("WizardSkillChance3", WizardPetHealSkill.petHealChance);
		PlayerPrefs.SetInt("WizardSkillNum3", WizardPetHealSkill.curSkillNum);
		
		PlayerPrefs.SetFloat("WizardSkillChance4", WizardPetRageSkill.petRageChance);
		PlayerPrefs.SetInt("WizardSkillNum4", WizardPetRageSkill.curSkillNum);

		PlayerPrefs.SetFloat("WizardSkillChance5", WizardPetTauntSkill.petTauntChance);
		PlayerPrefs.SetInt("WizardSkillNum5", WizardPetTauntSkill.curSkillNum);

		PlayerPrefs.SetFloat("WizardSkillChance6", WizardPetDamageEnhanceSkill.petDamageEnhance);
		PlayerPrefs.SetInt("WizardSkillNum6", WizardPetDamageEnhanceSkill.curSkillNum);
	
		//Pet Stats
		PlayerPrefs.SetFloat("PetMinDamage", PetDamage.baseMinDamage);
		PlayerPrefs.SetFloat("PetMaxDamage", PetDamage.baseMaxDamage);
		PlayerPrefs.SetFloat("PetAttackSpeed", PetDamage.basePetAttackSpeed);
		PlayerPrefs.SetFloat("PetAttackSpeedEnhance", PetDamage.petAttackSpeedEnhance);
		PlayerPrefs.SetFloat("PetDamageEnhance", PetDamage.petDamageEnhance);
		PlayerPrefs.SetFloat("PetCritEnhance", PetCriticalDamage.critEnhance);
		PlayerPrefs.SetFloat("PetEvadeEnhance", PetEvasion.evadeEnhance);
	
		//Upgrades
		PlayerPrefs.SetFloat("PetMinDamage", PetDamage.baseMinDamage);
		PlayerPrefs.SetFloat("PetMaxDamage", PetDamage.baseMaxDamage);
		PlayerPrefs.SetFloat("PetAttackSpeed", PetDamage.basePetAttackSpeed);
		PlayerPrefs.SetFloat("PetAttackSpeedEnhance", PetDamage.petAttackSpeedEnhance);
		PlayerPrefs.SetFloat("PetDamageEnhance", PetDamage.petDamageEnhance);


		//Daggers
		PlayerPrefs.SetInt("Dagger1Count", Dagger1.count);
		PlayerPrefs.SetInt("Dagger2Count", Dagger2.count);
		PlayerPrefs.SetFloat("Dagger1MinDamage", Dagger1.dagger1MinDamage);
		PlayerPrefs.SetFloat("Dagger2MinDamage", Dagger2.dagger2MinDamage);
		PlayerPrefs.SetFloat("Dagger1MaxDamage", Dagger1.dagger1MaxDamage);
		PlayerPrefs.SetFloat("Dagger2MaxDamage", Dagger2.dagger2MaxDamage);
		PlayerPrefs.SetFloat("Dagger1AttackSpeed", Dagger1.dagger1AttackSpeed);
		PlayerPrefs.SetFloat("Dagger2AttackSpeed", Dagger2.dagger2AttackSpeed);

		//Staff
		PlayerPrefs.SetInt("StaffCount", Staff.count);
		PlayerPrefs.SetFloat("StaffMinDamage", Staff.staffMinDamage);
		PlayerPrefs.SetFloat("StaffMaxDamage", Staff.staffMaxDamage);
		PlayerPrefs.SetFloat("StaffAttackSpeed", Staff.staffAttackSpeed);
		PlayerPrefs.SetInt("StaffMaxPurchased", (Staff.maxPurchased ? 1 : 0));
		
		//TwoHand
		PlayerPrefs.SetInt("TwoHandSwordCount", TwoHandSword.count);
		PlayerPrefs.SetFloat("TwoHandMinDamage", TwoHandSword.twoHandSwordMinDamage);
		PlayerPrefs.SetFloat("TwoHandMaxDamage", TwoHandSword.twoHandSwordMaxDamage);
		PlayerPrefs.SetFloat("TwoHandAttackSpeed", TwoHandSword.twoHandSwordAttackSpeed);
		PlayerPrefs.SetInt("TwoHandMaxPurchased", (TwoHandSword.maxPurchased ? 1 : 0));

		//Ring
		PlayerPrefs.SetInt("RingCount", Ring.count);
		PlayerPrefs.SetFloat("RingAttackSpeed", Ring.ringAttackSpeed);
		//Helmet
		PlayerPrefs.SetInt("HelmetCount", Helmet.count);
		PlayerPrefs.SetFloat("HelmetBonus", Helmet.helmetBonus);
		//Armour
		PlayerPrefs.SetInt("ArmourCount", Armour.count);
		PlayerPrefs.SetFloat("ArmourBonus", Armour.armourBonus);
		//Boots
		PlayerPrefs.SetInt("BootsCount", Boots.count);
		PlayerPrefs.SetFloat("BootsBonus", Boots.bootsBonus);
		//Gloves
		PlayerPrefs.SetInt("GlovesCount", Gloves.count);
		PlayerPrefs.SetFloat("GlovesBonus", Gloves.glovesBonus);

		PlayerPrefs.SetInt("Warrior", (GameInformation.isWarriorClass ? 1 : 0));
		PlayerPrefs.SetInt("Wizard", (GameInformation.isWizardClass ? 1 : 0));
		PlayerPrefs.SetInt("Assassin", (GameInformation.isAssassinClass ? 1 : 0));


		PlayerPrefs.SetInt("Pet1", (CaptureMonster.pet1 ? 1 : 0));
		PlayerPrefs.SetInt("Pet2", (CaptureMonster.pet2 ? 1 : 0));
		PlayerPrefs.SetInt("Pet3", (CaptureMonster.pet3 ? 1 : 0));
		PlayerPrefs.SetInt("Pet4", (CaptureMonster.pet4 ? 1 : 0));
		PlayerPrefs.SetInt("Pet5", (CaptureMonster.pet5 ? 1 : 0));
		PlayerPrefs.SetInt("Pet6", (CaptureMonster.pet6 ? 1 : 0));
		PlayerPrefs.SetInt("Pet7", (CaptureMonster.pet7 ? 1 : 0));
		PlayerPrefs.SetInt("Pet8", (CaptureMonster.pet8 ? 1 : 0));
		PlayerPrefs.SetInt("Pet9", (CaptureMonster.pet9 ? 1 : 0));
		PlayerPrefs.SetInt("Pet10", (CaptureMonster.pet10 ? 1 : 0));
		PlayerPrefs.SetInt("Pet11", (CaptureMonster.pet11 ? 1 : 0));
		PlayerPrefs.SetInt("Pet12", (CaptureMonster.pet12 ? 1 : 0));
		PlayerPrefs.SetInt("Pet13", (CaptureMonster.pet13 ? 1 : 0));
		PlayerPrefs.SetInt("Pet14", (CaptureMonster.pet14 ? 1 : 0));
		PlayerPrefs.SetInt("Pet15", (CaptureMonster.pet15 ? 1 : 0));
		PlayerPrefs.SetInt("Pet16", (CaptureMonster.pet16 ? 1 : 0));
		PlayerPrefs.SetInt("Pet17", (CaptureMonster.pet17 ? 1 : 0));
		PlayerPrefs.SetInt("Pet18", (CaptureMonster.pet18 ? 1 : 0));
		PlayerPrefs.SetInt("Pet19", (CaptureMonster.pet19 ? 1 : 0));
		PlayerPrefs.SetInt("Pet20", (CaptureMonster.pet20 ? 1 : 0));


		PlayerPrefs.SetInt("Monster1DeathCount", Monster1.enemyDeathCount);
		PlayerPrefs.SetInt("Monster2DeathCount", Monster2.enemyDeathCount);
		PlayerPrefs.SetInt("Monster3DeathCount", Monster3.enemyDeathCount);
		PlayerPrefs.SetInt("Monster4DeathCount", Monster4.enemyDeathCount);
		PlayerPrefs.SetInt("Monster5DeathCount", Monster5.enemyDeathCount);
		PlayerPrefs.SetInt("Monster6DeathCount", Monster6.enemyDeathCount);
		PlayerPrefs.SetInt("Monster7DeathCount", Monster7.enemyDeathCount);
		PlayerPrefs.SetInt("Monster8DeathCount", Monster8.enemyDeathCount);
		PlayerPrefs.SetInt("Monster9DeathCount", Monster9.enemyDeathCount);
		PlayerPrefs.SetInt("Monster10DeathCount", Monster10.enemyDeathCount);
		PlayerPrefs.SetInt("Monster11DeathCount", Monster11.enemyDeathCount);
		PlayerPrefs.SetInt("Monster12DeathCount", Monster12.enemyDeathCount);
		PlayerPrefs.SetInt("Monster13DeathCount", Monster13.enemyDeathCount);
		PlayerPrefs.SetInt("Monster14DeathCount", Monster14.enemyDeathCount);
		PlayerPrefs.SetInt("Monster15DeathCount", Monster15.enemyDeathCount);
		PlayerPrefs.SetInt("Monster16DeathCount", Monster16.enemyDeathCount);
		PlayerPrefs.SetInt("Monster17DeathCount", Monster17.enemyDeathCount);
		PlayerPrefs.SetInt("Monster18DeathCount", Monster18.enemyDeathCount);
		PlayerPrefs.SetInt("Monster19DeathCount", Monster19.enemyDeathCount);
		PlayerPrefs.SetInt("Monster20DeathCount", Monster20.enemyDeathCount);


		PlayerPrefs.SetInt("IronMarketUnlock", (Market.ironMarketUnlock ? 1 : 0));
		PlayerPrefs.SetInt("SilveMarketUnlock", (Market.silverMarketUnlock ? 1 : 0));
		PlayerPrefs.SetInt("GoldMarketUnlock", (Market.goldOreMarketUnlock ? 1 : 0));
		PlayerPrefs.SetInt("MithrilMarketUnlock", (Market.mithrilMarketUnlock ? 1 : 0));
		PlayerPrefs.SetInt("AdamantiteMarketUnlock", (Market.adamantiteMarketUnlock ? 1 : 0));
	

		//Wood
		PlayerPrefs.SetInt("WoodItemManagerCount", WoodItemManager.count);
		PlayerPrefs.SetInt("DoubleWoodChanceCount", DoubleWoodChanceManager.count);
		PlayerPrefs.SetInt("WoodAmountCount", WoodAmountManager.count);
		PlayerPrefs.SetInt("WoodUpgradeManagerCount", WoodUpgradeManager.count);
		PlayerPrefs.SetInt("WoodUpgradeManagerCount1", WoodUpgradeManager.count1);
		PlayerPrefs.SetFloat("WoodPower", WoodPerSec.woodPower);
		PlayerPrefs.SetInt("LumberJack1", (WoodPerSec.lumberJack1 ? 1 : 0));
		PlayerPrefs.SetInt("LumberJack2", (WoodPerSec.lumberJack2 ? 1 : 0));
		PlayerPrefs.SetInt("LumberJack3", (WoodPerSec.lumberJack3 ? 1 : 0));
		PlayerPrefs.SetInt("LumberJack4", (WoodPerSec.lumberJack4 ? 1 : 0));
		PlayerPrefs.SetInt("LumberJack5", (WoodPerSec.lumberJack5 ? 1 : 0));
		PlayerPrefs.SetInt("LumberJack6", (WoodPerSec.lumberJack6 ? 1 : 0));
		PlayerPrefs.SetInt("LumberJack7", (WoodPerSec.lumberJack7 ? 1 : 0));
		PlayerPrefs.SetInt("WoodAutoTick", (WoodItemManager.autoTick ? 1 : 0));
		//Mine
		PlayerPrefs.SetInt("OreItemManagerCount", OreItemManager.count);
		PlayerPrefs.SetInt("DoubleOreChanceCount", DoubleOreChanceManager.count);
		PlayerPrefs.SetInt("OreAmountCount", OreAmountManager.count);
		PlayerPrefs.SetInt("OreUpgradeManagerCount", OreUpgradeManager.count);
		PlayerPrefs.SetInt("OreUpgradeManagerCount1", OreUpgradeManager.count1);
		PlayerPrefs.SetFloat("OrePower", OrePerSec.orePower);
		PlayerPrefs.SetInt("OreAutoTick", (OreItemManager.autoTick ? 1 : 0));
		PlayerPrefs.SetInt("IronReady", (OreItemManager.ironReady ? 1 : 0));
		PlayerPrefs.SetInt("SilverReady", (OreItemManager.silverReady ? 1 : 0));
		PlayerPrefs.SetInt("GoldOreReady", (OreItemManager.goldOreReady ? 1 : 0));
		PlayerPrefs.SetInt("MithrilReady", (OreItemManager.mithrilReady ? 1 : 0));
		PlayerPrefs.SetInt("AdamantiteReady", (OreItemManager.adamantiteReady ? 1 : 0));
		PlayerPrefs.SetInt("RuniteReady", (OreItemManager.runiteReady ? 1 : 0));
	
		PlayerPrefs.SetFloat("PlayerEvadeEnhance", Evasion.evadeEnhance);
		PlayerPrefs.SetFloat("PlayerCritEnhance", CriticalDamage.critEnhance);
	}
		

	public static void SavePlayerStats()
	{


	
		PlayerPrefs.SetFloat("PlayerMinDamage", Damage.baseMinDamage);
		PlayerPrefs.SetFloat("PlayerMaxDamage", Damage.baseMaxDamage);

		PlayerPrefs.SetFloat("PlayerAttackSpeed", Damage.basePlayerAttackSpeed);
		PlayerPrefs.SetFloat("PlayerAttackSpeedEnhance", Damage.playerAttackSpeedEnhance);
		PlayerPrefs.SetFloat("PlayerDamageEnhance", Damage.playerDamageEnhance);
		PlayerPrefs.SetFloat("PlayerMaxHealth", PlayerHealth.baseMaxHealth);
		PlayerPrefs.SetFloat("PlayerCritChance", CriticalDamage.baseCritChance);
	
		PlayerPrefs.SetFloat("PlayerEvadeChance", Evasion.baseEvadeChance);
	
		PlayerPrefs.SetInt("Dagger1MaxPurchased", (Dagger1.maxPurchased ? 1 : 0));
		PlayerPrefs.SetInt("Dagger2MaxPurchased", (Dagger2.maxPurchased ? 1 : 0));


		PlayerPrefs.SetFloat("ATTACKSPEED", GameInformation.AttackSpeed);

	}






}
