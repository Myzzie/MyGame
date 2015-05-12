using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class RuniteOre : MonoBehaviour {
	
	
	
	static RuniteOre runiteOre;
	public GameObject instance;
	
	public static int expperclick = 800;
	public bool Delay;
	public Transform button;
	static int getCoal;
	private int doubleAmount;
	private int totalOre;
	public static int oreDuration = 320;
	
	
	
	void Awake ()
	{
		runiteOre = this;
		runiteOre.instance.SetActive (false);
	}
	
	void Start ()
	{
		oreDuration = 320;
	}
	
	void Update(){
		
	}
	
	public static void ShowRuniteOre()
	{
		//if instance does not exists return from this function
		
		//enable the loading image object 
		runiteOre.instance.SetActive(true);
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
		yield return new WaitForSeconds(OreDuration.RuniteDuration());
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
		Materials.materials.runiteOre += GetOre.MineOre(); 
		GameObject FloatingOre1 = Instantiate (Resources.Load ("Prefabs/Ore/RuniteOreAmount")) as GameObject;
		FloatingOre1.GetComponent<FloatingOre> ().DisplayOre (((int)GetOre.MineOre() + (" Runite Ore")).ToString ());
		FloatingOre1.transform.SetParent ((GameObject.Find ("CanvasMining").transform), false);
		
		getCoal = Random.Range (0, 100);
		if (getCoal < 7) 
		{
			Materials.materials.coalOre += GetOre.MineOre();
			GameObject FloatingCoal = Instantiate (Resources.Load ("Prefabs/Ore/CoalOreAmount")) as GameObject;
			FloatingCoal.GetComponent<FloatingOre> ().DisplayOre (((int)GetOre.MineOre() + (" Coal Ore")).ToString ());
			FloatingCoal.transform.SetParent ((GameObject.Find ("CanvasMining").transform), false);
		}
	}
}







