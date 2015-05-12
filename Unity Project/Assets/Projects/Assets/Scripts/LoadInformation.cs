using UnityEngine;
using System.Collections;

public class LoadInformation {







	public static void LoadAllInformation()
	{

	
		Materials.materials.wood = PlayerPrefs.GetFloat("Wood");
		
		Materials.materials.gold = PlayerPrefs.GetFloat("Gold");
		
		Materials.materials.copperOre = PlayerPrefs.GetFloat("CopperOre");
		Materials.materials.ironOre = PlayerPrefs.GetFloat("IronOre");
		Materials.materials.coalOre = PlayerPrefs.GetFloat("CoalOre");
		Materials.materials.silverOre = PlayerPrefs.GetFloat("SilverOre");
		Materials.materials.goldOre = PlayerPrefs.GetFloat("GoldOre");
		Materials.materials.mithrilOre = PlayerPrefs.GetFloat("MithrilOre");
		Materials.materials.adamantiteOre = PlayerPrefs.GetFloat("AdamantiteOre");
		Materials.materials.runiteOre = PlayerPrefs.GetFloat("RuniteOre");
		//Ore Duration
		OreDuration.copperDuration = PlayerPrefs.GetFloat("CopperOreDuration");
		OreDuration.ironDuration = PlayerPrefs.GetFloat("IronOreDuration");
		OreDuration.silverDuration = PlayerPrefs.GetFloat("SilverOreDuration");
		OreDuration.goldDuration = PlayerPrefs.GetFloat("GoldOreDuration");
		OreDuration.mithrilDuration = PlayerPrefs.GetFloat("MithrilOreDuration");
		OreDuration.adamantiteDuration = PlayerPrefs.GetFloat("AdamantiteOreDuration");
		OreDuration.runiteDuration = PlayerPrefs.GetFloat("RuniteOreDuration");

		
		Materials.materials.mineExp = PlayerPrefs.GetFloat("MineExp");
		MiningExperience.count = PlayerPrefs.GetInt("MineExpCount");
		Materials.materials.mineLevel = PlayerPrefs.GetInt("MineLevel");
		GetOre.oreAmount = PlayerPrefs.GetFloat("OreAmount");
		GetOre.baseOreAmount = PlayerPrefs.GetFloat("BaseOreAmount");
		DoubleOre.doubleChance = PlayerPrefs.GetFloat("DoubleOreChance");

		
		Materials.materials.battleExp = PlayerPrefs.GetFloat("BattleExp");
		BattleExperience.count = PlayerPrefs.GetInt("BattleExpCount");
		Materials.materials.battleLevel = PlayerPrefs.GetInt("BattleLevel");
		Materials.materials.critExp = PlayerPrefs.GetFloat("CritExp");
		CriticalExperience.count = PlayerPrefs.GetInt("CritExpCount");
		Materials.materials.critLevel = PlayerPrefs.GetInt("CritLevel");
		Materials.materials.evasionExp = PlayerPrefs.GetFloat("EvasionExp");
		EvasionExperience.count = PlayerPrefs.GetInt("EvasionExpCount");
		Materials.materials.evasionLevel = PlayerPrefs.GetInt("EvasionLevel");
		Materials.materials.lifeExp = PlayerPrefs.GetFloat("LifeExp");
		LifeExperience.count = PlayerPrefs.GetInt("LifeExpCount");
		Materials.materials.lifeLevel = PlayerPrefs.GetInt("LifeLevel");
		LifeExperience.lifeLevelHealth = PlayerPrefs.GetFloat("LifeLevelHealth");
		
		Materials.materials.fishExp = PlayerPrefs.GetFloat("FishExp");
		FishingExperience.count = PlayerPrefs.GetInt("FishExpCount");
		Materials.materials.fishLevel = PlayerPrefs.GetInt("FishLevel");
		Materials.materials.fish1 = PlayerPrefs.GetInt("Fish1");
		Materials.materials.fishAmount = PlayerPrefs.GetInt("FishAmount");
		
		Materials.materials.woodCuttingExp = PlayerPrefs.GetFloat("WoodCuttingExp");
		WoodCuttingExperience.count = PlayerPrefs.GetInt("WoodCuttingExpCount");
		Materials.materials.woodCuttingLevel = PlayerPrefs.GetInt("WoodCuttingLevel");
		GetWood.woodAmount = PlayerPrefs.GetFloat("WoodAmount");
		GetWood.baseWoodAmount = PlayerPrefs.GetFloat("BaseWoodAmount");
		DoubleWood.doubleChance = PlayerPrefs.GetFloat("DoubleWoodChance");

	



		//Warrior Skills
		WarriorDamageBoost.damageBoostChance = PlayerPrefs.GetFloat("WarriorSkillChance1");
		WarriorDamageBoost.cost = PlayerPrefs.GetInt("WarriorSkillCost1");
		WarriorDamageBoost.curSkillNum = PlayerPrefs.GetInt("WarriorSkillNum1");

		HardHitSkill.hardHitChance = PlayerPrefs.GetFloat("WarriorSkillChance2");
		HardHitSkill.cost = PlayerPrefs.GetInt("WarriorSkillCost2");
		HardHitSkill.curSkillNum = PlayerPrefs.GetInt("WarriorSkillNum2");

		WarriorHealthBoost.healthBoostChance = PlayerPrefs.GetFloat("WarriorSkillChance3");
		WarriorHealthBoost.cost = PlayerPrefs.GetInt("WarriorSkillCost3");
		WarriorHealthBoost.curSkillNum = PlayerPrefs.GetInt("WarriorSkillNum3");

		RegenSkill.regenChance = PlayerPrefs.GetFloat("WarriorSkillChance4");
		RegenSkill.cost = PlayerPrefs.GetInt("WarriorSkillCost4");
		RegenSkill.curSkillNum = PlayerPrefs.GetInt("WarriorSkillNum4");

		WarriorSpikeShield.spikeShieldChance = PlayerPrefs.GetFloat("WarriorSkillChance5");
		WarriorSpikeShield.cost = PlayerPrefs.GetInt("WarriorSkillCost5");
		WarriorSpikeShield.curSkillNum = PlayerPrefs.GetInt("WarriorSkillNum5");

		WarriorStoneShield.stoneShieldChance = PlayerPrefs.GetFloat("WarriorSkillChance6");
		WarriorStoneShield.cost = PlayerPrefs.GetInt("WarriorSkillCost6");
		WarriorStoneShield.curSkillNum = PlayerPrefs.GetInt("WarriorSkillNum6");

		//Assassin Skills
		AttackSpeedBoost.speedChance = PlayerPrefs.GetFloat("AssassinSkillChance1");
		AttackSpeedBoost.cost = PlayerPrefs.GetInt("AssassinSkillCost1");
		AttackSpeedBoost.curSkillNum = PlayerPrefs.GetInt("AssassinSkillNum1");
		
		BleedEffect.bleedEffectChance = PlayerPrefs.GetFloat("AssassinSkillChance2");
		BleedEffect.cost = PlayerPrefs.GetInt("AssassinSkillCost2");
		BleedEffect.curSkillNum = PlayerPrefs.GetInt("AssassinSkillNum2");
		
		CritChanceBoost.critChance = PlayerPrefs.GetFloat("AssassinSkillChance3");
		CritChanceBoost.cost = PlayerPrefs.GetInt("AssassinSkillCost3");
		CritChanceBoost.curSkillNum = PlayerPrefs.GetInt("AssassinSkillNum3");
		
		CritDamageBoost.critDamage = PlayerPrefs.GetFloat("AssassinSkillChance4");
		CritDamageBoost.cost = PlayerPrefs.GetInt("AssassinSkillCost4");
		CritDamageBoost.curSkillNum = PlayerPrefs.GetInt("AssassinSkillNum4");
		
		EvasionBoost.evadeChance = PlayerPrefs.GetFloat("AssassinSkillChance5");
		EvasionBoost.cost = PlayerPrefs.GetInt("AssassinSkillCost5");
		EvasionBoost.curSkillNum = PlayerPrefs.GetInt("AssassinSkillNum5");
		
		SinLifeSteal.lifeStealChance = PlayerPrefs.GetFloat("AssassinSkillChance6");
		SinLifeSteal.cost = PlayerPrefs.GetInt("AssassinSkillCost6");
		SinLifeSteal.curSkillNum = PlayerPrefs.GetInt("AssassinSkillNum6");

		Rampage.rampageChance = PlayerPrefs.GetFloat("AssassinSkillChance7");
		Rampage.cost = PlayerPrefs.GetInt("AssassinSkillCost7");
		Rampage.curSkillNum = PlayerPrefs.GetInt("AssassinSkillNum7");
	
		
		//Wizard Skills

		WizardFreeze.freezeChance = PlayerPrefs.GetFloat("WizardSkillChance1");
		WizardFreeze.cost = PlayerPrefs.GetInt("WizardSkillCost1");
		WizardFreeze.curSkillNum = PlayerPrefs.GetInt("WizardSkillNum1");

		WizardHealSkill.healChance = PlayerPrefs.GetFloat("WizardSkillChance2");
		WizardHealSkill.cost = PlayerPrefs.GetInt("WizardSkillCost2");
		WizardHealSkill.curSkillNum = PlayerPrefs.GetInt("WizardSkillNum2");

		WizardPetHealSkill.petHealChance = PlayerPrefs.GetFloat("WizardSkillChance3");
		WizardPetHealSkill.cost = PlayerPrefs.GetInt("WizardSkillCost3");
		WizardPetHealSkill.curSkillNum = PlayerPrefs.GetInt("WizardSkillNum3");
		
		WizardPetRageSkill.petRageChance = PlayerPrefs.GetFloat("WizardSkillChance4");
		WizardPetRageSkill.cost = PlayerPrefs.GetInt("WizardSkillCost4");
		WizardPetRageSkill.curSkillNum = PlayerPrefs.GetInt("WizardSkillNum4");

		WizardPetTauntSkill.petTauntChance = PlayerPrefs.GetFloat("WizardSkillChance5");
		WizardPetTauntSkill.cost = PlayerPrefs.GetInt("WizardSkillCost5");
		WizardPetTauntSkill.curSkillNum = PlayerPrefs.GetInt("WizardSkillNum5");

		//Pet Stats
		PetDamage.baseMinDamage = PlayerPrefs.GetFloat("PetMinDamage");
		PetDamage.baseMaxDamage = PlayerPrefs.GetFloat("PetMaxDamage");
		PetDamage.basePetAttackSpeed = PlayerPrefs.GetFloat("PetAttackSpeed");
		PetDamage.petAttackSpeedEnhance = PlayerPrefs.GetFloat("PetAttackSpeedEnhance");
		PetDamage.petDamageEnhance = PlayerPrefs.GetFloat("PetDamageEnhance");
		PetCriticalDamage.critEnhance = PlayerPrefs.GetFloat("PetCritEnhance");
		PetEvasion.evadeEnhance = PlayerPrefs.GetFloat("PetEvadeEnhance");


		//Daggers
		Dagger1.count = PlayerPrefs.GetInt("Dagger1Count");
		Dagger2.count = PlayerPrefs.GetInt("Dagger2Count");
		Dagger1.dagger1MinDamage = PlayerPrefs.GetFloat("Dagger1MinDamage");
		Dagger2.dagger2MinDamage = PlayerPrefs.GetFloat("Dagger2MinDamage");
		Dagger1.dagger1MaxDamage = PlayerPrefs.GetFloat("Dagger1MaxDamage");
		Dagger2.dagger2MaxDamage = PlayerPrefs.GetFloat("Dagger2MaxDamage");
		Dagger1.dagger1AttackSpeed = PlayerPrefs.GetFloat("Dagger1AttackSpeed");
		Dagger2.dagger2AttackSpeed = PlayerPrefs.GetFloat("Dagger2AttackSpeed");


		//Staff
		Staff.count = PlayerPrefs.GetInt("StaffCount");
		Staff.staffMinDamage = PlayerPrefs.GetFloat("StaffMinDamage");
		Staff.staffMaxDamage = PlayerPrefs.GetFloat("StaffMaxDamage");
		Staff.staffAttackSpeed = PlayerPrefs.GetFloat("StaffAttackSpeed");
		Staff.maxPurchased = (PlayerPrefs.GetInt("StaffMaxPurchased") != 0);
		
		//TwoHand
		TwoHandSword.count = PlayerPrefs.GetInt("TwoHandSwordCount");
		TwoHandSword.twoHandSwordMinDamage = PlayerPrefs.GetFloat("TwoHandMinDamage");
		TwoHandSword.twoHandSwordMaxDamage = PlayerPrefs.GetFloat("TwoHandMaxDamage");
		TwoHandSword.twoHandSwordAttackSpeed = PlayerPrefs.GetFloat("TwoHandAttackSpeed");
		TwoHandSword.maxPurchased = (PlayerPrefs.GetInt("TwoHandSwordMaxPurchased") != 0);
		
		//Ring
		Ring.count = PlayerPrefs.GetInt("RingCount");
		Ring.ringAttackSpeed = PlayerPrefs.GetFloat("RingAttackSpeed");
		//Helmet
		Helmet.count = PlayerPrefs.GetInt("HelmetCount");
		Helmet.helmetBonus = PlayerPrefs.GetFloat("HelmetBonus");
		//Armour
		Armour.count = PlayerPrefs.GetInt("ArmourCount");
		Armour.armourBonus = PlayerPrefs.GetFloat("ArmourBonus");
		//Boots
		Boots.count = PlayerPrefs.GetInt("BootsCount");
		Boots.bootsBonus = PlayerPrefs.GetFloat("BootsBonus");
		//Gloves
		Gloves.count = PlayerPrefs.GetInt("GlovesCount");
		Gloves.glovesBonus = PlayerPrefs.GetFloat("GlovesBonus");

		GameInformation.isWarriorClass = (PlayerPrefs.GetInt("Warrior") != 0);
		GameInformation.isWizardClass = (PlayerPrefs.GetInt("Wizard") != 0);
		GameInformation.isAssassinClass = (PlayerPrefs.GetInt("Assassin") != 0);
		
		CaptureMonster.pet1 = (PlayerPrefs.GetInt("Pet1") != 0);
		CaptureMonster.pet2 = (PlayerPrefs.GetInt("Pet2") != 0);
		CaptureMonster.pet3 = (PlayerPrefs.GetInt("Pet3") != 0);
		CaptureMonster.pet4 = (PlayerPrefs.GetInt("Pet4") != 0);
		CaptureMonster.pet5 = (PlayerPrefs.GetInt("Pet5") != 0);
		CaptureMonster.pet6 = (PlayerPrefs.GetInt("Pet6") != 0);
		CaptureMonster.pet7 = (PlayerPrefs.GetInt("Pet7") != 0);
		CaptureMonster.pet8 = (PlayerPrefs.GetInt("Pet8") != 0);
		CaptureMonster.pet9 = (PlayerPrefs.GetInt("Pet9") != 0);
		CaptureMonster.pet10 = (PlayerPrefs.GetInt("Pet10") != 0);
		CaptureMonster.pet11 = (PlayerPrefs.GetInt("Pet11") != 0);
		CaptureMonster.pet12 = (PlayerPrefs.GetInt("Pet12") != 0);
		CaptureMonster.pet13 = (PlayerPrefs.GetInt("Pet13") != 0);
		CaptureMonster.pet14 = (PlayerPrefs.GetInt("Pet14") != 0);
		CaptureMonster.pet15 = (PlayerPrefs.GetInt("Pet15") != 0);
		CaptureMonster.pet16 = (PlayerPrefs.GetInt("Pet16") != 0);
		CaptureMonster.pet17 = (PlayerPrefs.GetInt("Pet17") != 0);
		CaptureMonster.pet18 = (PlayerPrefs.GetInt("Pet18") != 0);
		CaptureMonster.pet19 = (PlayerPrefs.GetInt("Pet19") != 0);
		CaptureMonster.pet20 = (PlayerPrefs.GetInt("Pet20") != 0);

		Monster1.enemyDeathCount = PlayerPrefs.GetInt("Monster1DeathCount");
		Monster2.enemyDeathCount = PlayerPrefs.GetInt("Monster2DeathCount");
		Monster3.enemyDeathCount = PlayerPrefs.GetInt("Monster3DeathCount");
		Monster4.enemyDeathCount = PlayerPrefs.GetInt("Monster4DeathCount");
		Monster5.enemyDeathCount = PlayerPrefs.GetInt("Monster5DeathCount");
		Monster6.enemyDeathCount = PlayerPrefs.GetInt("Monster6DeathCount");
		Monster7.enemyDeathCount = PlayerPrefs.GetInt("Monster7DeathCount");
		Monster8.enemyDeathCount = PlayerPrefs.GetInt("Monster8DeathCount");
		Monster9.enemyDeathCount = PlayerPrefs.GetInt("Monster9DeathCount");
		Monster10.enemyDeathCount = PlayerPrefs.GetInt("Monster10DeathCount");
		Monster11.enemyDeathCount = PlayerPrefs.GetInt("Monster11DeathCount");
		Monster12.enemyDeathCount = PlayerPrefs.GetInt("Monster12DeathCount");
		Monster13.enemyDeathCount = PlayerPrefs.GetInt("Monster13DeathCount");
		Monster14.enemyDeathCount = PlayerPrefs.GetInt("Monster14DeathCount");
		Monster15.enemyDeathCount = PlayerPrefs.GetInt("Monster15DeathCount");
		Monster16.enemyDeathCount = PlayerPrefs.GetInt("Monster16DeathCount");
		Monster17.enemyDeathCount = PlayerPrefs.GetInt("Monster17DeathCount");
		Monster18.enemyDeathCount = PlayerPrefs.GetInt("Monster18DeathCount");
		Monster19.enemyDeathCount = PlayerPrefs.GetInt("Monster19DeathCount");
		Monster20.enemyDeathCount = PlayerPrefs.GetInt("Monster20DeathCount");


		Market.ironMarketUnlock = (PlayerPrefs.GetInt("IronMarketUnlock") != 0);
		Market.silverMarketUnlock = (PlayerPrefs.GetInt("SilveMarketUnlock") != 0);
		Market.goldOreMarketUnlock = (PlayerPrefs.GetInt("GoldMarketUnlock") != 0);
		Market.mithrilMarketUnlock = (PlayerPrefs.GetInt("MithrilMarketUnlock") != 0);
		Market.adamantiteMarketUnlock = (PlayerPrefs.GetInt("AdamantiteMarketUnlock") != 0);


		//Wood
		WoodItemManager.count = PlayerPrefs.GetInt("WoodItemManagerCount");
		DoubleWoodChanceManager.count = PlayerPrefs.GetInt("DoubleWoodChanceCount");
		WoodAmountManager.count = PlayerPrefs.GetInt("WoodAmountCount");
		WoodUpgradeManager.count = PlayerPrefs.GetInt("WoodUpgradeManagerCount");
		WoodUpgradeManager.count1 = PlayerPrefs.GetInt("WoodUpgradeManagerCount1");
		WoodPerSec.woodPower = PlayerPrefs.GetFloat("WoodPower");
		WoodPerSec.lumberJack1 = (PlayerPrefs.GetInt("LumberJack1") != 0);
		WoodPerSec.lumberJack2 = (PlayerPrefs.GetInt("LumberJack2") != 0);
		WoodPerSec.lumberJack3 = (PlayerPrefs.GetInt("LumberJack3") != 0);
		WoodPerSec.lumberJack4 = (PlayerPrefs.GetInt("LumberJack4") != 0);
		WoodPerSec.lumberJack5 = (PlayerPrefs.GetInt("LumberJack5") != 0);
		WoodPerSec.lumberJack6 = (PlayerPrefs.GetInt("LumberJack6") != 0);
		WoodPerSec.lumberJack7 = (PlayerPrefs.GetInt("LumberJack7") != 0);
		WoodItemManager.autoTick = (PlayerPrefs.GetInt("WoodAutoTick") != 0);

		//Mine
		OreItemManager.count = PlayerPrefs.GetInt("OreItemManagerCount");
		DoubleOreChanceManager.count = PlayerPrefs.GetInt("DoubleOreChanceCount");
		OreAmountManager.count = PlayerPrefs.GetInt("OreAmountCount");
		OreUpgradeManager.count = PlayerPrefs.GetInt("OreUpgradeManagerCount");
		OreUpgradeManager.count1 = PlayerPrefs.GetInt("OreUpgradeManagerCount1");
		OrePerSec.orePower = PlayerPrefs.GetFloat("OrePower");
		OreItemManager.autoTick = (PlayerPrefs.GetInt("OreAutoTick") != 0);
		OreItemManager.ironReady = (PlayerPrefs.GetInt("IronReady") != 0);
		OreItemManager.silverReady = (PlayerPrefs.GetInt("SilverReady") != 0);
		OreItemManager.goldOreReady = (PlayerPrefs.GetInt("GoldOreReady") != 0);
		OreItemManager.mithrilReady = (PlayerPrefs.GetInt("MithrilReady") != 0);
		OreItemManager.adamantiteReady = (PlayerPrefs.GetInt("AdamantiteReady") != 0);
		OreItemManager.runiteReady = (PlayerPrefs.GetInt("RuniteReady") != 0);

		Evasion.evadeEnhance = PlayerPrefs.GetFloat("PlayerEvadeEnhance");
		CriticalDamage.critEnhance = PlayerPrefs.GetFloat("PlayerCritEnhance");

	}


	
	public static void LoadPlayerStats()
	{


		Damage.baseMinDamage = PlayerPrefs.GetFloat("PlayerMinDamage");
		Damage.baseMaxDamage = PlayerPrefs.GetFloat("PlayerMaxDamage");

		Damage.basePlayerAttackSpeed = PlayerPrefs.GetFloat("PlayerAttackSpeed");
		Damage.playerAttackSpeedEnhance = PlayerPrefs.GetFloat("PlayerAttackSpeedEnhance");
		Damage.playerDamageEnhance = PlayerPrefs.GetFloat("PlayerDamageEnhance");
		PlayerHealth.baseMaxHealth = PlayerPrefs.GetFloat("PlayerMaxHealth");
		CriticalDamage.baseCritChance = PlayerPrefs.GetFloat("PlayerCritChance");
		Evasion.baseEvadeChance = PlayerPrefs.GetFloat("PlayerEvadeChance");


		Dagger1.maxPurchased = (PlayerPrefs.GetInt("Dagger1MaxPurchased") != 0);
		Dagger2.maxPurchased = (PlayerPrefs.GetInt("Dagger2MaxPurchased") != 0);


		GameInformation.AttackSpeed = PlayerPrefs.GetFloat("ATTACKSPEED");

	}






}
