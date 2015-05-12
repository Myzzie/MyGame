using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class CutWood : MonoBehaviour {
	
	
	public static int expperclick = 1;
	public int woodAmount = 1;
	public bool Delay;
	public Transform button;

	

	void Start ()
	{
	
	}

	void Update()
	{
		

	

	}
	
	public void Clicked(){
		if (!Delay) {
			Materials.materials.woodCuttingExp += expperclick;
			StartCoroutine (ClickDelay ());
		}
	}

	public IEnumerator ClickDelay()//This is delay to prevent clicking faster than playerAttackSpeed
	{
		
		Delay = true;
		button.GetComponent<Button>().interactable = false;
		animation.Play ("MineShake");
		animation["MineShake"].wrapMode = WrapMode.Loop;
		yield return new WaitForSeconds(TreeDuration.WoodDuration());
		Delay = false; 
		button.GetComponent<Button>().interactable = true;
		animation.Stop ("MineShake");
		CutTree ();
	
		
	}

	public static void CutTree()
	{
		
		//Exp
		Materials.materials.woodCuttingExp += expperclick;
		// Get Ore
		Materials.materials.wood += GetWood.CutWood(); 
		GameObject FloatingWood = Instantiate (Resources.Load ("Prefabs/WoodAmount")) as GameObject;
		FloatingWood.GetComponent<FloatingOre> ().DisplayOre ((GetWood.CutWood() + (" Wood")).ToString ());
		FloatingWood.transform.SetParent ((GameObject.Find ("CanvasWood").transform), false);
	
	}


	
}
