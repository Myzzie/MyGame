using UnityEngine;
using System.Collections;

public class Container
{
	private static Container instance;
	private int sampleVariable;
	public OreUpgradeManager oreUpgradeManager;
	public CopperOre copperOre;
	
	private Container() {}
	
	public static Container getInstance()
	{
		if(instance == null)
			instance = new Container();
		
		return instance;
	}
}