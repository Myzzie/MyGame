using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class CopperOre : MonoBehaviour {



	public static int expperclick = 5;
	public bool Delay;
	public Transform button;
	static int getCoal;
	private int doubleAmount;
	private int totalOre;




	void Start ()
	{
	}

	void Update(){

	
	
		}





	public void Clicked(){
		if (Delay == false) {
			Materials.materials.mineExp += expperclick;
			StartCoroutine (ClickDelay ());
		}
	}



		
		
		
	
	public IEnumerator ClickDelay()//This is delay to prevent clicking faster than playerAttackSpeed
	{

		Delay = true;
		button.GetComponent<Button>().interactable = false;
		animation.Play ("MineShake");
		animation["MineShake"].wrapMode = WrapMode.Loop;
		yield return new WaitForSeconds(OreDuration.CopperDuration());
		Delay = false; 
		button.GetComponent<Button>().interactable = true;
		animation.Stop ("MineShake");
		BreakOre ();


	}

	public static void BreakOre()
	{




		//Exp
		Materials.materials.mineExp += expperclick;
		// Get Ore

		Materials.materials.copperOre += GetOre.MineOre(); 
		GameObject FloatingOre = Instantiate (Resources.Load ("Prefabs/Ore/CopperOreAmount")) as GameObject;
		FloatingOre.GetComponent<FloatingOre> ().DisplayOre ((GetOre.MineOre() + (" Copper Ore")).ToString ());
		FloatingOre.transform.SetParent ((GameObject.Find ("CanvasMining").transform), false);

		getCoal = Random.Range (0, 100);
		if (getCoal < 1) 
		{
			Materials.materials.coalOre += GetOre.MineOre();
			GameObject FloatingCoal = Instantiate (Resources.Load ("Prefabs/Ore/CoalOreAmount")) as GameObject;
			FloatingCoal.GetComponent<FloatingOre> ().DisplayOre (((int)GetOre.MineOre() + (" Coal Ore")).ToString ());
			FloatingCoal.transform.SetParent ((GameObject.Find ("CanvasMining").transform), false);
		}
	}
	

	
}




