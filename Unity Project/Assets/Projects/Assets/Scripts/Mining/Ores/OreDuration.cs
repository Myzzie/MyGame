using UnityEngine;
using System.Collections;

public class OreDuration : MonoBehaviour {



	public static float copperDuration = 5;
	public static float ironDuration = 10; 
	public static float silverDuration = 20; 
	public static float goldDuration = 40; 
	public static float mithrilDuration = 80; 
	public static float adamantiteDuration = 160; 
	public static float runiteDuration = 320;





	public static float CopperDuration()
	{
		if (copperDuration < 1) 
		{
			return 1;
		}
		else
			copperDuration = 5;
		return copperDuration = copperDuration / OrePerSec.orePower;
	}
	public static float IronDuration()
	{
		if (ironDuration < 1) 
		{
			return 1;
		}
		else
		ironDuration = 10;
		return ironDuration = ironDuration / OrePerSec.orePower;
	}
	public static float SilverDuration()
	{
		if (silverDuration < 1) 
		{
			return 1;
		}
		else
		silverDuration = 20;
		return silverDuration = silverDuration / OrePerSec.orePower;
	}
	public static float GoldDuration()
	{
		if (goldDuration < 1) 
		{
			return 1;
		}
		else
		goldDuration = 40;
		return goldDuration = goldDuration / OrePerSec.orePower;
	}
	public static float MithrilDuration()
	{
		if (mithrilDuration < 1) 
		{
			return 1;
		}
		else
		mithrilDuration = 80;
		return mithrilDuration = mithrilDuration / OrePerSec.orePower;
	}
	public static float AdamantiteDuration()
	{
		if (adamantiteDuration < 1) 
		{
			return 1;
		}
		else
		adamantiteDuration = 160;
		return adamantiteDuration = adamantiteDuration / OrePerSec.orePower;
	}
	public static float RuniteDuration()
	{
		if (runiteDuration < 1) 
		{
			return 1;
		}
		else
		runiteDuration = 320;
		return runiteDuration = runiteDuration / OrePerSec.orePower;
	}

	



}
