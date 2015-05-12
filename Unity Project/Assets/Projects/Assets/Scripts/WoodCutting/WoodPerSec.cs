using UnityEngine;
using System.Collections;

public class WoodPerSec : MonoBehaviour {
	
	public UnityEngine.UI.Text wpcDisplay;
	public UnityEngine.UI.Text axeSpeedDisplay;
	public UnityEngine.UI.Text doubleWoodChanceDisplay;
	public static float woodPower = 1f;
	public static int lumberJacks;
	public static bool lumberJack1;
	public static bool lumberJack2;
	public static bool lumberJack3;
	public static bool lumberJack4;
	public static bool lumberJack5;
	public static bool lumberJack6;
	public static bool lumberJack7;
	



	void Start ()
	{


	}
	
	void Update(){

	
		wpcDisplay.text = "Axe Power: " + woodPower.ToString ("f1");
		axeSpeedDisplay.text = "Lumberjacks: " + lumberJacks;
		doubleWoodChanceDisplay.text = "Double Wood Chance: " + DoubleWood.doubleChance.ToString ("f0") + "%";
	}
	

	




	public static IEnumerator FirstLumberJack()
	{
		while (lumberJack1) 
		{
			if(WoodItemManager.autoTick)
			{
				yield return new WaitForSeconds(TreeDuration.WoodDuration());
				CutWood.expperclick = 1;
				CutWood.CutTree();
			}
			else yield return null;
		}
	}
	public static IEnumerator SecondLumberJack()
	{
		while (lumberJack2) 
		{
			if(WoodItemManager.autoTick)
			{
				yield return new WaitForSeconds(TreeDuration.WoodDuration());
				CutWood.expperclick = 10;
				CutWood.CutTree();
			}
			else yield return null;
		}
	}
	public static IEnumerator ThirdLumberJack()
	{
		while (lumberJack3) 
		{
			if(WoodItemManager.autoTick)
			{
				yield return new WaitForSeconds(TreeDuration.WoodDuration());
				CutWood.expperclick = 20;
				CutWood.CutTree();
			}
			else yield return null;
		}
	}
	public static IEnumerator FourthLumberJack()
	{
		while (lumberJack4) 
		{
			if(WoodItemManager.autoTick)
			{
				yield return new WaitForSeconds(TreeDuration.WoodDuration());
				CutWood.expperclick = 30;
				CutWood.CutTree();
			}
			else yield return null;
		}
	}
	public static IEnumerator FifthLumberJack()
	{
		while (lumberJack5) 
		{
			if(WoodItemManager.autoTick)
			{
				yield return new WaitForSeconds(TreeDuration.WoodDuration());
				CutWood.expperclick = 40;
				CutWood.CutTree();
			}
			else yield return null;
		}
	}
	public static IEnumerator SixthLumberJack()
	{
		while (lumberJack6) 
		{
			if(WoodItemManager.autoTick)
			{
				yield return new WaitForSeconds(TreeDuration.WoodDuration());
				CutWood.expperclick = 50;
				CutWood.CutTree();
			}
			else yield return null;
		}
	}
	public static 	IEnumerator SeventhLumberJack()
	{
		while (lumberJack7) 
		{
			if(WoodItemManager.autoTick)
			{
				yield return new WaitForSeconds(TreeDuration.WoodDuration());
				CutWood.expperclick = 60;
				CutWood.CutTree();
			}
			else yield return null;
		}
	}
}


