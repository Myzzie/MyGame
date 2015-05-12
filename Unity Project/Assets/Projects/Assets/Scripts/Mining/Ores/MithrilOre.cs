using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class MithrilOre : MonoBehaviour {
	
	
	
	static MithrilOre mithrilOre;
	public GameObject instance;
	
	public static int expperclick = 200;
	public bool Delay;
	public Transform button;
	static int getCoal;
	private int doubleAmount;
	private int totalOre;
	public static int oreDuration = 80;
	
	
	
	void Awake ()
	{
		mithrilOre = this;
		mithrilOre.instance.SetActive (false);
	}
	
	
	void Start ()
	{
		oreDuration = 80;
	}
	void Update(){
		
	}
	
	public static void ShowMithrilOre()
	{
		//if instance does not exists return from this function
		
		//enable the loading image object 
		mithrilOre.instance.SetActive(true);
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
		yield return new WaitForSeconds(OreDuration.MithrilDuration());
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
		GetOre.MineOre(); 
		Materials.materials.mithrilOre += GetOre.MineOre(); 
		GameObject FloatingOre1 = Instantiate (Resources.Load ("Prefabs/Ore/MithrilOreAmount")) as GameObject;
		FloatingOre1.GetComponent<FloatingOre> ().DisplayOre (((int)GetOre.MineOre() + (" Mithril Ore")).ToString ());
		FloatingOre1.transform.SetParent ((GameObject.Find ("CanvasMining").transform), false);
		
		getCoal = Random.Range (0, 100);
		if (getCoal < 5) 
		{
			Materials.materials.coalOre += GetOre.MineOre();
			GameObject FloatingCoal = Instantiate (Resources.Load ("Prefabs/Ore/CoalOreAmount")) as GameObject;
			FloatingCoal.GetComponent<FloatingOre> ().DisplayOre (((int)GetOre.MineOre() + (" Coal Ore")).ToString ());
			FloatingCoal.transform.SetParent ((GameObject.Find ("CanvasMining").transform), false);
		}
	}
}







