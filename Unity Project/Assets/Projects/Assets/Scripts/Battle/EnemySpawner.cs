using UnityEngine;
using System.Collections;

public class EnemySpawner : MonoBehaviour {



	public int count;
	public static bool noBattle;

	// Use this for initialization
	void Start () {
	

	}
	
	// Update is called once per frame
	void Update () 
	{

		if (count == 0)
		{
			noBattle = true;
		}
		else noBattle = false;

		if (count < 0)
			count = 0;



	}


	public void Spawn ()
	{
		if (count == 0)
		{
			StartCoroutine(PlayerHealth.Regen());
			StartCoroutine(PetHealth.Regen());
		
		}
	

	
		if (count == 1)
		{
			GameObject Clone = Instantiate (Resources.Load ("Prefabs/Enemies/Monster1")) as GameObject;
			Clone.transform.SetParent ((GameObject.Find ("Battle").transform), false);
		}
		else Destroy(GameObject.Find ("Monster1(Clone)"));

		if (count == 2) 
		{
			GameObject Clone = Instantiate (Resources.Load ("Prefabs/Enemies/Monster2")) as GameObject;
			Clone.transform.SetParent ((GameObject.Find ("Battle").transform), false);
		} 
		else Destroy (GameObject.Find ("Monster2(Clone)"));
		

		

		if (count == 3) 
		{
			GameObject Clone = Instantiate (Resources.Load ("Prefabs/Enemies/Monster3")) as GameObject;
			Clone.transform.SetParent ((GameObject.Find ("Battle").transform), false);
		} 
		else Destroy (GameObject.Find ("Monster3(Clone)"));
		
		if (count == 4) 
		{
			GameObject Clone = Instantiate (Resources.Load ("Prefabs/Enemies/Monster4")) as GameObject;
			Clone.transform.SetParent ((GameObject.Find ("Battle").transform), false);
		} 
		else Destroy (GameObject.Find ("Monster4(Clone)"));

		if (count == 5) 
		{
			GameObject Clone = Instantiate (Resources.Load ("Prefabs/Enemies/Monster5")) as GameObject;
			Clone.transform.SetParent ((GameObject.Find ("Battle").transform), false);
		} 
		else Destroy (GameObject.Find ("Monster5(Clone)"));
		if (count == 6) 
		{
			GameObject Clone = Instantiate (Resources.Load ("Prefabs/Enemies/Monster6")) as GameObject;
			Clone.transform.SetParent ((GameObject.Find ("Battle").transform), false);
		} 
		else Destroy (GameObject.Find ("Monster6(Clone)"));
		if (count == 7) 
		{
			GameObject Clone = Instantiate (Resources.Load ("Prefabs/Enemies/Monster7")) as GameObject;
			Clone.transform.SetParent ((GameObject.Find ("Battle").transform), false);
		} 
		else Destroy (GameObject.Find ("Monster7(Clone)"));
		if (count == 8) 
		{
			GameObject Clone = Instantiate (Resources.Load ("Prefabs/Enemies/Monster8")) as GameObject;
			Clone.transform.SetParent ((GameObject.Find ("Battle").transform), false);
		} 
		else Destroy (GameObject.Find ("Monster8(Clone)"));
		if (count == 9) 
		{
			GameObject Clone = Instantiate (Resources.Load ("Prefabs/Enemies/Monster9")) as GameObject;
			Clone.transform.SetParent ((GameObject.Find ("Battle").transform), false);
		} 
		else Destroy (GameObject.Find ("Monster9(Clone)"));
		if (count == 10) 
		{
			GameObject Clone = Instantiate (Resources.Load ("Prefabs/Enemies/Monster10")) as GameObject;
			Clone.transform.SetParent ((GameObject.Find ("Battle").transform), false);
		} 
		else Destroy (GameObject.Find ("Monster10(Clone)"));
		if (count == 11) 
		{
			GameObject Clone = Instantiate (Resources.Load ("Prefabs/Enemies/Monster11")) as GameObject;
			Clone.transform.SetParent ((GameObject.Find ("Battle").transform), false);
		} 
		else Destroy (GameObject.Find ("Monster11(Clone)"));
		if (count == 12) 
		{
			GameObject Clone = Instantiate (Resources.Load ("Prefabs/Enemies/Monster12")) as GameObject;
			Clone.transform.SetParent ((GameObject.Find ("Battle").transform), false);
		} 
		else Destroy (GameObject.Find ("Monster12(Clone)"));
		if (count == 13) 
		{
			GameObject Clone = Instantiate (Resources.Load ("Prefabs/Enemies/Monster13")) as GameObject;
			Clone.transform.SetParent ((GameObject.Find ("Battle").transform), false);
		} 
		else Destroy (GameObject.Find ("Monster13(Clone)"));
		if (count == 14) 
		{
			GameObject Clone = Instantiate (Resources.Load ("Prefabs/Enemies/Monster14")) as GameObject;
			Clone.transform.SetParent ((GameObject.Find ("Battle").transform), false);
		} 
		else Destroy (GameObject.Find ("Monster14(Clone)"));
		if (count == 15) 
		{
			GameObject Clone = Instantiate (Resources.Load ("Prefabs/Enemies/Monster15")) as GameObject;
			Clone.transform.SetParent ((GameObject.Find ("Battle").transform), false);
		} 
		else Destroy (GameObject.Find ("Monster15(Clone)"));
		if (count == 16) 
		{
			GameObject Clone = Instantiate (Resources.Load ("Prefabs/Enemies/Monster16")) as GameObject;
			Clone.transform.SetParent ((GameObject.Find ("Battle").transform), false);
		} 
		else Destroy (GameObject.Find ("Monster16(Clone)"));
		if (count == 17) 
		{
			GameObject Clone = Instantiate (Resources.Load ("Prefabs/Enemies/Monster17")) as GameObject;
			Clone.transform.SetParent ((GameObject.Find ("Battle").transform), false);
		} 
		else Destroy (GameObject.Find ("Monster17(Clone)"));
		if (count == 18) 
		{
			GameObject Clone = Instantiate (Resources.Load ("Prefabs/Enemies/Monster18")) as GameObject;
			Clone.transform.SetParent ((GameObject.Find ("Battle").transform), false);
		} 
		else Destroy (GameObject.Find ("Monster18(Clone)"));
		if (count == 19) 
		{
			GameObject Clone = Instantiate (Resources.Load ("Prefabs/Enemies/Monster19")) as GameObject;
			Clone.transform.SetParent ((GameObject.Find ("Battle").transform), false);
		} 
		else Destroy (GameObject.Find ("Monster19(Clone)"));
		if (count == 20) 
		{
			GameObject Clone = Instantiate (Resources.Load ("Prefabs/Enemies/Monster20")) as GameObject;
			Clone.transform.SetParent ((GameObject.Find ("Battle").transform), false);
		} 
		else Destroy (GameObject.Find ("Monster20(Clone)"));
	}
	
}
