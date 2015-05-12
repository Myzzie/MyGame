using UnityEngine;
using UnityEngine.UI;
using System.Collections;

public class CaptureMonster : MonoBehaviour {



	public EnemySpawner enemySpawner;
	public static bool pet1;
	public static bool pet2;
	public static bool pet3;
	public static bool pet4;
	public static bool pet5;
	public static bool pet6;
	public static bool pet7;
	public static bool pet8;
	public static bool pet9;
	public static bool pet10;
	public static bool pet11;
	public static bool pet12;
	public static bool pet13;
	public static bool pet14;
	public static bool pet15;
	public static bool pet16;
	public static bool pet17;
	public static bool pet18;
	public static bool pet19;
	public static bool pet20;
	public Button button;






	public void CaptureMonster1()
	{

		if (enemySpawner.count == 1)
		{
		
			int randomTemp = Random.Range (0, 101);
			if (randomTemp <= (int)Monster1.captureChance) 
			{
				pet1 = true;
				Destroy (GameObject.Find("Monster1(Clone)"));
				GameObject FloatingCapture = Instantiate (Resources.Load ("Prefabs/CaptureMonster")) as GameObject;
				FloatingCapture.GetComponent<FloatingCaptureMonster> ().DisplayDamage (("Success").ToString ());
				FloatingCapture.transform.SetParent ((GameObject.Find ("TextDisplay").transform), false);

				GameObject Clone = Instantiate (Resources.Load ("Prefabs/Enemies/Monster1")) as GameObject;
				Clone.transform.SetParent ((GameObject.Find ("Battle").transform), false);


			} 
			else {	
				Destroy (GameObject.Find("Monster1(Clone)"));
			GameObject FloatingCapture = Instantiate (Resources.Load ("Prefabs/CaptureMonster")) as GameObject;
			FloatingCapture.GetComponent<FloatingCaptureMonster> ().DisplayDamage (("Failed").ToString ());
			FloatingCapture.transform.SetParent ((GameObject.Find ("TextDisplay").transform), false);
			
			GameObject Clone = Instantiate (Resources.Load ("Prefabs/Enemies/Monster1")) as GameObject;
			Clone.transform.SetParent ((GameObject.Find ("Battle").transform), false);

			}
		}
		if (enemySpawner.count == 2)
		{
			
			int randomTemp = Random.Range (0, 101);
			if (randomTemp <= (int)Monster2.captureChance) 
			{
				pet2 = true;
				Destroy (GameObject.Find("Monster2(Clone)"));
				GameObject FloatingCapture = Instantiate (Resources.Load ("Prefabs/CaptureMonster")) as GameObject;
				FloatingCapture.GetComponent<FloatingCaptureMonster> ().DisplayDamage (("Success").ToString ());
				FloatingCapture.transform.SetParent ((GameObject.Find ("TextDisplay").transform), false);

				GameObject Clone = Instantiate (Resources.Load ("Prefabs/Enemies/Monster2")) as GameObject;
				Clone.transform.SetParent ((GameObject.Find ("Battle").transform), false);

			} 
			else {	
				Destroy (GameObject.Find("Monster2(Clone)"));
				GameObject FloatingCapture = Instantiate (Resources.Load ("Prefabs/CaptureMonster")) as GameObject;
				FloatingCapture.GetComponent<FloatingCaptureMonster> ().DisplayDamage (("Failed").ToString ());
				FloatingCapture.transform.SetParent ((GameObject.Find ("TextDisplay").transform), false);

				GameObject Clone = Instantiate (Resources.Load ("Prefabs/Enemies/Monster2")) as GameObject;
				Clone.transform.SetParent ((GameObject.Find ("Battle").transform), false);

			}

		}
		if (enemySpawner.count == 3)
		{
			
			int randomTemp = Random.Range (0, 101);
			if (randomTemp <= (int)Monster3.captureChance) 
			{
				pet3 = true;
				Destroy (GameObject.Find("Monster3(Clone)"));
				GameObject FloatingCapture = Instantiate (Resources.Load ("Prefabs/CaptureMonster")) as GameObject;
				FloatingCapture.GetComponent<FloatingCaptureMonster> ().DisplayDamage (("Success").ToString ());
				FloatingCapture.transform.SetParent ((GameObject.Find ("TextDisplay").transform), false);

				GameObject Clone = Instantiate (Resources.Load ("Prefabs/Enemies/Monster3")) as GameObject;
				Clone.transform.SetParent ((GameObject.Find ("Battle").transform), false);

			} 
			else {	
				Destroy (GameObject.Find("Monster3(Clone)"));
				GameObject FloatingCapture = Instantiate (Resources.Load ("Prefabs/CaptureMonster")) as GameObject;
				FloatingCapture.GetComponent<FloatingCaptureMonster> ().DisplayDamage (("Failed").ToString ());
				FloatingCapture.transform.SetParent ((GameObject.Find ("TextDisplay").transform), false);

				GameObject Clone = Instantiate (Resources.Load ("Prefabs/Enemies/Monster3")) as GameObject;
				Clone.transform.SetParent ((GameObject.Find ("Battle").transform), false);

			}

		}
		if (enemySpawner.count == 4)
		{
			
			int randomTemp = Random.Range (0, 101);
			if (randomTemp <= (int)Monster4.captureChance) 
			{
				pet4 = true;
				Destroy (GameObject.Find("Monster4(Clone)"));
				GameObject FloatingCapture = Instantiate (Resources.Load ("Prefabs/CaptureMonster")) as GameObject;
				FloatingCapture.GetComponent<FloatingCaptureMonster> ().DisplayDamage (("Success").ToString ());
				FloatingCapture.transform.SetParent ((GameObject.Find ("TextDisplay").transform), false);
			
				GameObject Clone = Instantiate (Resources.Load ("Prefabs/Enemies/Monster4")) as GameObject;
				Clone.transform.SetParent ((GameObject.Find ("Battle").transform), false);

			} 
			else {	
				Destroy (GameObject.Find("Monster4(Clone)"));
				GameObject FloatingCapture = Instantiate (Resources.Load ("Prefabs/CaptureMonster")) as GameObject;
				FloatingCapture.GetComponent<FloatingCaptureMonster> ().DisplayDamage (("Failed").ToString ());
				FloatingCapture.transform.SetParent ((GameObject.Find ("TextDisplay").transform), false);

				GameObject Clone = Instantiate (Resources.Load ("Prefabs/Enemies/Monster4")) as GameObject;
				Clone.transform.SetParent ((GameObject.Find ("Battle").transform), false);
			}
		}
		if (enemySpawner.count == 5)
		{
			
			int randomTemp = Random.Range (0, 101);
			if (randomTemp <= (int)Monster5.captureChance) 
			{
				pet5 = true;
				Destroy (GameObject.Find("Monster5(Clone)"));
				GameObject FloatingCapture = Instantiate (Resources.Load ("Prefabs/CaptureMonster")) as GameObject;
				FloatingCapture.GetComponent<FloatingCaptureMonster> ().DisplayDamage (("Success").ToString ());
				FloatingCapture.transform.SetParent ((GameObject.Find ("TextDisplay").transform), false);
			
				GameObject Clone = Instantiate (Resources.Load ("Prefabs/Enemies/Monster5")) as GameObject;
				Clone.transform.SetParent ((GameObject.Find ("Battle").transform), false);

			} 
			else {	
				Destroy (GameObject.Find("Monster5(Clone)"));
				GameObject FloatingCapture = Instantiate (Resources.Load ("Prefabs/CaptureMonster")) as GameObject;
				FloatingCapture.GetComponent<FloatingCaptureMonster> ().DisplayDamage (("Failed").ToString ());
				FloatingCapture.transform.SetParent ((GameObject.Find ("TextDisplay").transform), false);
			
				GameObject Clone = Instantiate (Resources.Load ("Prefabs/Enemies/Monster5")) as GameObject;
				Clone.transform.SetParent ((GameObject.Find ("Battle").transform), false);

			}
		}
		if (enemySpawner.count == 6)
		{
			
			int randomTemp = Random.Range (0, 101);
			if (randomTemp <= (int)Monster6.captureChance) 
			{
				pet6 = true;
				Destroy (GameObject.Find("Monster6(Clone)"));
				GameObject FloatingCapture = Instantiate (Resources.Load ("Prefabs/CaptureMonster")) as GameObject;
				FloatingCapture.GetComponent<FloatingCaptureMonster> ().DisplayDamage (("Success").ToString ());
				FloatingCapture.transform.SetParent ((GameObject.Find ("TextDisplay").transform), false);
				
				GameObject Clone = Instantiate (Resources.Load ("Prefabs/Enemies/Monster6")) as GameObject;
				Clone.transform.SetParent ((GameObject.Find ("Battle").transform), false);
				
			} 
			else {	
				Destroy (GameObject.Find("Monster6(Clone)"));
				GameObject FloatingCapture = Instantiate (Resources.Load ("Prefabs/CaptureMonster")) as GameObject;
				FloatingCapture.GetComponent<FloatingCaptureMonster> ().DisplayDamage (("Failed").ToString ());
				FloatingCapture.transform.SetParent ((GameObject.Find ("TextDisplay").transform), false);
				
				GameObject Clone = Instantiate (Resources.Load ("Prefabs/Enemies/Monster6")) as GameObject;
				Clone.transform.SetParent ((GameObject.Find ("Battle").transform), false);
				
			}
		}
		if (enemySpawner.count == 7)
		{
			
			int randomTemp = Random.Range (0, 101);
			if (randomTemp <= (int)Monster7.captureChance) 
			{
				pet7 = true;
				Destroy (GameObject.Find("Monster7(Clone)"));
				GameObject FloatingCapture = Instantiate (Resources.Load ("Prefabs/CaptureMonster")) as GameObject;
				FloatingCapture.GetComponent<FloatingCaptureMonster> ().DisplayDamage (("Success").ToString ());
				FloatingCapture.transform.SetParent ((GameObject.Find ("TextDisplay").transform), false);
				
				GameObject Clone = Instantiate (Resources.Load ("Prefabs/Enemies/Monster7")) as GameObject;
				Clone.transform.SetParent ((GameObject.Find ("Battle").transform), false);
				
			} 
			else {	
				Destroy (GameObject.Find("Monster7(Clone)"));
				GameObject FloatingCapture = Instantiate (Resources.Load ("Prefabs/CaptureMonster")) as GameObject;
				FloatingCapture.GetComponent<FloatingCaptureMonster> ().DisplayDamage (("Failed").ToString ());
				FloatingCapture.transform.SetParent ((GameObject.Find ("TextDisplay").transform), false);
				
				GameObject Clone = Instantiate (Resources.Load ("Prefabs/Enemies/Monster7")) as GameObject;
				Clone.transform.SetParent ((GameObject.Find ("Battle").transform), false);
				
			}
		}
		if (enemySpawner.count == 8)
		{
			
			int randomTemp = Random.Range (0, 101);
			if (randomTemp <= (int)Monster8.captureChance) 
			{
				pet8 = true;
				Destroy (GameObject.Find("Monster8(Clone)"));
				GameObject FloatingCapture = Instantiate (Resources.Load ("Prefabs/CaptureMonster")) as GameObject;
				FloatingCapture.GetComponent<FloatingCaptureMonster> ().DisplayDamage (("Success").ToString ());
				FloatingCapture.transform.SetParent ((GameObject.Find ("TextDisplay").transform), false);
				
				GameObject Clone = Instantiate (Resources.Load ("Prefabs/Enemies/Monster8")) as GameObject;
				Clone.transform.SetParent ((GameObject.Find ("Battle").transform), false);
				
			} 
			else {	
				Destroy (GameObject.Find("Monster8(Clone)"));
				GameObject FloatingCapture = Instantiate (Resources.Load ("Prefabs/CaptureMonster")) as GameObject;
				FloatingCapture.GetComponent<FloatingCaptureMonster> ().DisplayDamage (("Failed").ToString ());
				FloatingCapture.transform.SetParent ((GameObject.Find ("TextDisplay").transform), false);
				
				GameObject Clone = Instantiate (Resources.Load ("Prefabs/Enemies/Monster8")) as GameObject;
				Clone.transform.SetParent ((GameObject.Find ("Battle").transform), false);
				
			}
		}
		if (enemySpawner.count == 9)
		{
			
			int randomTemp = Random.Range (0, 101);
			if (randomTemp <= (int)Monster9.captureChance) 
			{
				pet9 = true;
				Destroy (GameObject.Find("Monster9(Clone)"));
				GameObject FloatingCapture = Instantiate (Resources.Load ("Prefabs/CaptureMonster")) as GameObject;
				FloatingCapture.GetComponent<FloatingCaptureMonster> ().DisplayDamage (("Success").ToString ());
				FloatingCapture.transform.SetParent ((GameObject.Find ("TextDisplay").transform), false);
				
				GameObject Clone = Instantiate (Resources.Load ("Prefabs/Enemies/Monster9")) as GameObject;
				Clone.transform.SetParent ((GameObject.Find ("Battle").transform), false);
				
			} 
			else {	
				Destroy (GameObject.Find("Monster9(Clone)"));
				GameObject FloatingCapture = Instantiate (Resources.Load ("Prefabs/CaptureMonster")) as GameObject;
				FloatingCapture.GetComponent<FloatingCaptureMonster> ().DisplayDamage (("Failed").ToString ());
				FloatingCapture.transform.SetParent ((GameObject.Find ("TextDisplay").transform), false);
				
				GameObject Clone = Instantiate (Resources.Load ("Prefabs/Enemies/Monster9")) as GameObject;
				Clone.transform.SetParent ((GameObject.Find ("Battle").transform), false);
				
			}
		}
		if (enemySpawner.count == 10)
		{
			
			int randomTemp = Random.Range (0, 101);
			if (randomTemp <= (int)Monster10.captureChance) 
			{
				pet10 = true;
				Destroy (GameObject.Find("Monster10(Clone)"));
				GameObject FloatingCapture = Instantiate (Resources.Load ("Prefabs/CaptureMonster")) as GameObject;
				FloatingCapture.GetComponent<FloatingCaptureMonster> ().DisplayDamage (("Success").ToString ());
				FloatingCapture.transform.SetParent ((GameObject.Find ("TextDisplay").transform), false);
				
				GameObject Clone = Instantiate (Resources.Load ("Prefabs/Enemies/Monster10")) as GameObject;
				Clone.transform.SetParent ((GameObject.Find ("Battle").transform), false);
				
			} 
			else {	
				Destroy (GameObject.Find("Monster10(Clone)"));
				GameObject FloatingCapture = Instantiate (Resources.Load ("Prefabs/CaptureMonster")) as GameObject;
				FloatingCapture.GetComponent<FloatingCaptureMonster> ().DisplayDamage (("Failed").ToString ());
				FloatingCapture.transform.SetParent ((GameObject.Find ("TextDisplay").transform), false);
				
				GameObject Clone = Instantiate (Resources.Load ("Prefabs/Enemies/Monster10")) as GameObject;
				Clone.transform.SetParent ((GameObject.Find ("Battle").transform), false);
				
			}
		}
		if (enemySpawner.count == 11)
		{
			
			int randomTemp = Random.Range (0, 101);
			if (randomTemp <= (int)Monster1.captureChance) 
			{
				pet11 = true;
				Destroy (GameObject.Find("Monster11(Clone)"));
				GameObject FloatingCapture = Instantiate (Resources.Load ("Prefabs/CaptureMonster")) as GameObject;
				FloatingCapture.GetComponent<FloatingCaptureMonster> ().DisplayDamage (("Success").ToString ());
				FloatingCapture.transform.SetParent ((GameObject.Find ("TextDisplay").transform), false);
				
				GameObject Clone = Instantiate (Resources.Load ("Prefabs/Enemies/Monster11")) as GameObject;
				Clone.transform.SetParent ((GameObject.Find ("Battle").transform), false);
				
			} 
			else {	
				Destroy (GameObject.Find("Monster11(Clone)"));
				GameObject FloatingCapture = Instantiate (Resources.Load ("Prefabs/CaptureMonster")) as GameObject;
				FloatingCapture.GetComponent<FloatingCaptureMonster> ().DisplayDamage (("Failed").ToString ());
				FloatingCapture.transform.SetParent ((GameObject.Find ("TextDisplay").transform), false);
				
				GameObject Clone = Instantiate (Resources.Load ("Prefabs/Enemies/Monster11")) as GameObject;
				Clone.transform.SetParent ((GameObject.Find ("Battle").transform), false);
				
			}
		}
		if (enemySpawner.count == 12)
		{
			
			int randomTemp = Random.Range (0, 101);
			if (randomTemp <= (int)Monster2.captureChance) 
			{
				pet12 = true;
				Destroy (GameObject.Find("Monster12(Clone)"));
				GameObject FloatingCapture = Instantiate (Resources.Load ("Prefabs/CaptureMonster")) as GameObject;
				FloatingCapture.GetComponent<FloatingCaptureMonster> ().DisplayDamage (("Success").ToString ());
				FloatingCapture.transform.SetParent ((GameObject.Find ("TextDisplay").transform), false);
				
				GameObject Clone = Instantiate (Resources.Load ("Prefabs/Enemies/Monster12")) as GameObject;
				Clone.transform.SetParent ((GameObject.Find ("Battle").transform), false);
				
			} 
			else {	
				Destroy (GameObject.Find("Monster12(Clone)"));
				GameObject FloatingCapture = Instantiate (Resources.Load ("Prefabs/CaptureMonster")) as GameObject;
				FloatingCapture.GetComponent<FloatingCaptureMonster> ().DisplayDamage (("Failed").ToString ());
				FloatingCapture.transform.SetParent ((GameObject.Find ("TextDisplay").transform), false);
				
				GameObject Clone = Instantiate (Resources.Load ("Prefabs/Enemies/Monster12")) as GameObject;
				Clone.transform.SetParent ((GameObject.Find ("Battle").transform), false);
				
			}
		}
		if (enemySpawner.count == 13)
		{
			
			int randomTemp = Random.Range (0, 101);
			if (randomTemp <= (int)Monster3.captureChance) 
			{
				pet13 = true;
				Destroy (GameObject.Find("Monster13(Clone)"));
				GameObject FloatingCapture = Instantiate (Resources.Load ("Prefabs/CaptureMonster")) as GameObject;
				FloatingCapture.GetComponent<FloatingCaptureMonster> ().DisplayDamage (("Success").ToString ());
				FloatingCapture.transform.SetParent ((GameObject.Find ("TextDisplay").transform), false);
				
				GameObject Clone = Instantiate (Resources.Load ("Prefabs/Enemies/Monster13")) as GameObject;
				Clone.transform.SetParent ((GameObject.Find ("Battle").transform), false);
				
			} 
			else {	
				Destroy (GameObject.Find("Monster13(Clone)"));
				GameObject FloatingCapture = Instantiate (Resources.Load ("Prefabs/CaptureMonster")) as GameObject;
				FloatingCapture.GetComponent<FloatingCaptureMonster> ().DisplayDamage (("Failed").ToString ());
				FloatingCapture.transform.SetParent ((GameObject.Find ("TextDisplay").transform), false);
				
				GameObject Clone = Instantiate (Resources.Load ("Prefabs/Enemies/Monster13")) as GameObject;
				Clone.transform.SetParent ((GameObject.Find ("Battle").transform), false);
				
			}
		}
		if (enemySpawner.count == 14)
		{
			
			int randomTemp = Random.Range (0, 101);
			if (randomTemp <= (int)Monster4.captureChance) 
			{
				pet14 = true;
				Destroy (GameObject.Find("Monster14(Clone)"));
				GameObject FloatingCapture = Instantiate (Resources.Load ("Prefabs/CaptureMonster")) as GameObject;
				FloatingCapture.GetComponent<FloatingCaptureMonster> ().DisplayDamage (("Success").ToString ());
				FloatingCapture.transform.SetParent ((GameObject.Find ("TextDisplay").transform), false);
				
				GameObject Clone = Instantiate (Resources.Load ("Prefabs/Enemies/Monster14")) as GameObject;
				Clone.transform.SetParent ((GameObject.Find ("Battle").transform), false);
				
			} 
			else {	
				Destroy (GameObject.Find("Monster14(Clone)"));
				GameObject FloatingCapture = Instantiate (Resources.Load ("Prefabs/CaptureMonster")) as GameObject;
				FloatingCapture.GetComponent<FloatingCaptureMonster> ().DisplayDamage (("Failed").ToString ());
				FloatingCapture.transform.SetParent ((GameObject.Find ("TextDisplay").transform), false);
				
				GameObject Clone = Instantiate (Resources.Load ("Prefabs/Enemies/Monster14")) as GameObject;
				Clone.transform.SetParent ((GameObject.Find ("Battle").transform), false);
				
			}
		}
		if (enemySpawner.count == 15)
		{
			
			int randomTemp = Random.Range (0, 101);
			if (randomTemp <= (int)Monster5.captureChance) 
			{
				pet15 = true;
				Destroy (GameObject.Find("Monster15(Clone)"));
				GameObject FloatingCapture = Instantiate (Resources.Load ("Prefabs/CaptureMonster")) as GameObject;
				FloatingCapture.GetComponent<FloatingCaptureMonster> ().DisplayDamage (("Success").ToString ());
				FloatingCapture.transform.SetParent ((GameObject.Find ("TextDisplay").transform), false);
				
				GameObject Clone = Instantiate (Resources.Load ("Prefabs/Enemies/Monster15")) as GameObject;
				Clone.transform.SetParent ((GameObject.Find ("Battle").transform), false);
				
			} 
			else {	
				Destroy (GameObject.Find("Monster15(Clone)"));
				GameObject FloatingCapture = Instantiate (Resources.Load ("Prefabs/CaptureMonster")) as GameObject;
				FloatingCapture.GetComponent<FloatingCaptureMonster> ().DisplayDamage (("Failed").ToString ());
				FloatingCapture.transform.SetParent ((GameObject.Find ("TextDisplay").transform), false);
				
				GameObject Clone = Instantiate (Resources.Load ("Prefabs/Enemies/Monster15")) as GameObject;
				Clone.transform.SetParent ((GameObject.Find ("Battle").transform), false);
				
			}
		}
		if (enemySpawner.count == 16)
		{
			
			int randomTemp = Random.Range (0, 101);
			if (randomTemp <= (int)Monster6.captureChance) 
			{
				pet16 = true;
				Destroy (GameObject.Find("Monster16(Clone)"));
				GameObject FloatingCapture = Instantiate (Resources.Load ("Prefabs/CaptureMonster")) as GameObject;
				FloatingCapture.GetComponent<FloatingCaptureMonster> ().DisplayDamage (("Success").ToString ());
				FloatingCapture.transform.SetParent ((GameObject.Find ("TextDisplay").transform), false);
				
				GameObject Clone = Instantiate (Resources.Load ("Prefabs/Enemies/Monster16")) as GameObject;
				Clone.transform.SetParent ((GameObject.Find ("Battle").transform), false);
				
			} 
			else {	
				Destroy (GameObject.Find("Monster16(Clone)"));
				GameObject FloatingCapture = Instantiate (Resources.Load ("Prefabs/CaptureMonster")) as GameObject;
				FloatingCapture.GetComponent<FloatingCaptureMonster> ().DisplayDamage (("Failed").ToString ());
				FloatingCapture.transform.SetParent ((GameObject.Find ("TextDisplay").transform), false);
				
				GameObject Clone = Instantiate (Resources.Load ("Prefabs/Enemies/Monster16")) as GameObject;
				Clone.transform.SetParent ((GameObject.Find ("Battle").transform), false);
				
			}
		}
		if (enemySpawner.count == 17)
		{
			
			int randomTemp = Random.Range (0, 101);
			if (randomTemp <= (int)Monster7.captureChance) 
			{
				pet17 = true;
				Destroy (GameObject.Find("Monster17(Clone)"));
				GameObject FloatingCapture = Instantiate (Resources.Load ("Prefabs/CaptureMonster")) as GameObject;
				FloatingCapture.GetComponent<FloatingCaptureMonster> ().DisplayDamage (("Success").ToString ());
				FloatingCapture.transform.SetParent ((GameObject.Find ("TextDisplay").transform), false);
				
				GameObject Clone = Instantiate (Resources.Load ("Prefabs/Enemies/Monster17")) as GameObject;
				Clone.transform.SetParent ((GameObject.Find ("Battle").transform), false);
				
			} 
			else {	
				Destroy (GameObject.Find("Monster17(Clone)"));
				GameObject FloatingCapture = Instantiate (Resources.Load ("Prefabs/CaptureMonster")) as GameObject;
				FloatingCapture.GetComponent<FloatingCaptureMonster> ().DisplayDamage (("Failed").ToString ());
				FloatingCapture.transform.SetParent ((GameObject.Find ("TextDisplay").transform), false);
				
				GameObject Clone = Instantiate (Resources.Load ("Prefabs/Enemies/Monster17")) as GameObject;
				Clone.transform.SetParent ((GameObject.Find ("Battle").transform), false);
				
			}
		}
		if (enemySpawner.count == 18)
		{
			
			int randomTemp = Random.Range (0, 101);
			if (randomTemp <= (int)Monster8.captureChance) 
			{
				pet18 = true;
				Destroy (GameObject.Find("Monster18(Clone)"));
				GameObject FloatingCapture = Instantiate (Resources.Load ("Prefabs/CaptureMonster")) as GameObject;
				FloatingCapture.GetComponent<FloatingCaptureMonster> ().DisplayDamage (("Success").ToString ());
				FloatingCapture.transform.SetParent ((GameObject.Find ("TextDisplay").transform), false);
				
				GameObject Clone = Instantiate (Resources.Load ("Prefabs/Enemies/Monster18")) as GameObject;
				Clone.transform.SetParent ((GameObject.Find ("Battle").transform), false);
				
			} 
			else {	
				Destroy (GameObject.Find("Monster18(Clone)"));
				GameObject FloatingCapture = Instantiate (Resources.Load ("Prefabs/CaptureMonster")) as GameObject;
				FloatingCapture.GetComponent<FloatingCaptureMonster> ().DisplayDamage (("Failed").ToString ());
				FloatingCapture.transform.SetParent ((GameObject.Find ("TextDisplay").transform), false);
				
				GameObject Clone = Instantiate (Resources.Load ("Prefabs/Enemies/Monster18")) as GameObject;
				Clone.transform.SetParent ((GameObject.Find ("Battle").transform), false);
				
			}
		}
		if (enemySpawner.count == 19)
		{
			
			int randomTemp = Random.Range (0, 101);
			if (randomTemp <= (int)Monster9.captureChance) 
			{
				pet19 = true;
				Destroy (GameObject.Find("Monster19(Clone)"));
				GameObject FloatingCapture = Instantiate (Resources.Load ("Prefabs/CaptureMonster")) as GameObject;
				FloatingCapture.GetComponent<FloatingCaptureMonster> ().DisplayDamage (("Success").ToString ());
				FloatingCapture.transform.SetParent ((GameObject.Find ("TextDisplay").transform), false);
				
				GameObject Clone = Instantiate (Resources.Load ("Prefabs/Enemies/Monster19")) as GameObject;
				Clone.transform.SetParent ((GameObject.Find ("Battle").transform), false);
				
			} 
			else {	
				Destroy (GameObject.Find("Monster19(Clone)"));
				GameObject FloatingCapture = Instantiate (Resources.Load ("Prefabs/CaptureMonster")) as GameObject;
				FloatingCapture.GetComponent<FloatingCaptureMonster> ().DisplayDamage (("Failed").ToString ());
				FloatingCapture.transform.SetParent ((GameObject.Find ("TextDisplay").transform), false);
				
				GameObject Clone = Instantiate (Resources.Load ("Prefabs/Enemies/Monster19")) as GameObject;
				Clone.transform.SetParent ((GameObject.Find ("Battle").transform), false);
				
			}
		}
		if (enemySpawner.count == 20)
		{
			
			int randomTemp = Random.Range (0, 101);
			if (randomTemp <= (int)Monster10.captureChance) 
			{
				pet20 = true;
				Destroy (GameObject.Find("Monster20(Clone)"));
				GameObject FloatingCapture = Instantiate (Resources.Load ("Prefabs/CaptureMonster")) as GameObject;
				FloatingCapture.GetComponent<FloatingCaptureMonster> ().DisplayDamage (("Success").ToString ());
				FloatingCapture.transform.SetParent ((GameObject.Find ("TextDisplay").transform), false);
				
				GameObject Clone = Instantiate (Resources.Load ("Prefabs/Enemies/Monster20")) as GameObject;
				Clone.transform.SetParent ((GameObject.Find ("Battle").transform), false);
				
			} 
			else {	
				Destroy (GameObject.Find("Monster20(Clone)"));
				GameObject FloatingCapture = Instantiate (Resources.Load ("Prefabs/CaptureMonster")) as GameObject;
				FloatingCapture.GetComponent<FloatingCaptureMonster> ().DisplayDamage (("Failed").ToString ());
				FloatingCapture.transform.SetParent ((GameObject.Find ("TextDisplay").transform), false);
				
				GameObject Clone = Instantiate (Resources.Load ("Prefabs/Enemies/Monster20")) as GameObject;
				Clone.transform.SetParent ((GameObject.Find ("Battle").transform), false);
				
			}
		}



		if (enemySpawner.count >= 1)
		{
		
		StartCoroutine (AutoTick());
		GameObject CaptureCoolDown = Instantiate (Resources.Load ("Prefabs/CaptureMonsterCoolDown")) as GameObject;
		CaptureCoolDown.transform.SetParent ((GameObject.Find ("TextDisplay").transform), false);
		}
	}


	IEnumerator AutoTick ()
	{
		button.GetComponent<Button>().interactable = false;
		yield return new WaitForSeconds (30);
		button.GetComponent<Button>().interactable = true;

	}





}
