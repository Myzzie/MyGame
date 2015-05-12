using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class Fish1 : MonoBehaviour {

	public Image fishes;
	public Transform button;
	public float coolDown = 10f;
	public float coolDown1 = 60f;
	public float coolingDown;
	public static bool Delay;
	private int fishCoolDown;
	
	
	// Use this for initialization
	void Start () 
	{
		coolingDown = coolDown;

	}
	
	// Update is called once per frame
	void Update () 
	{
		

		
		if (Delay) {
			coolingDown -= 1 * Time.time;
		}
		
		if (coolingDown >= coolDown) {
			coolingDown = coolDown;
		}
		if (coolingDown < 0) {
			coolingDown = coolDown;
		}

	
	}
	
	

	
	public void CatchFish1 ()
	{
		if (Delay == false)	
		{
			Materials.materials.fishExp += 5;
			StartCoroutine (ClickDelay ());
			GameObject Clone = Instantiate (Resources.Load ("Prefabs/Fishes/FishCircle")) as GameObject;
			Clone.transform.SetParent ((GameObject.Find ("FishHolder").transform), false);
			fishes.enabled = false;
		}
	}

	public IEnumerator ClickDelay()//This is delay to prevent clicking faster than playerAttackSpeed
	{
		Delay = true;

		button.GetComponent<Button>().interactable = false;
		yield return new WaitForSeconds(coolDown);
		Delay = false;
		button.GetComponent<Button>().interactable = true;

		StartCoroutine (FishDelay ());

	}
	public IEnumerator FishDelay()//This is delay to prevent clicking faster than playerAttackSpeed
	{

		fishCoolDown = Random.Range (1, 181);
	
		yield return new WaitForSeconds(fishCoolDown);

		
		fishes.enabled = true;
		
	}




}
