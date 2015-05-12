using UnityEngine;
using System.Collections;

public class FishCircleAnim : MonoBehaviour {


	public static bool Delay;
	public float coolDown = 10f;
	public float coolingDown;
	private int totalFish = 1;




	// Use this for initialization
	void Start () {
		StartCoroutine (ClickDelay ());
	}
	
	// Update is called once per frame
	void Update () 
	{
		if (Fish1.Delay == true) {
			
			animation.Play ("FishingCircle");
		} else 
		{
			Destroy (gameObject);
		}
	}



	
	public IEnumerator ClickDelay()//This is delay to prevent clicking faster than playerAttackSpeed
	{
		Delay = true;
		

		yield return new WaitForSeconds(coolDown);
		Delay = false;
		//This happens after coolDown
		Materials.materials.fish1 += totalFish;
		Materials.materials.fishExp += 5;
		GameObject FloatingOre = Instantiate (Resources.Load ("Prefabs/Fishes/FishAmount")) as GameObject;
		FloatingOre.GetComponent<FloatingOre> ().DisplayOre ((totalFish + (" Fish")).ToString ());
		FloatingOre.transform.SetParent ((GameObject.Find ("FishHolder").transform), false);

	}






}
