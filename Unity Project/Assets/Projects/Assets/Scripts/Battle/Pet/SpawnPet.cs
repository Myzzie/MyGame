using UnityEngine;
using System.Collections;
using UnityEngine.UI;
public class SpawnPet : MonoBehaviour {

	public GameObject pet1;
	public GameObject pet2;
	public GameObject pet3;
	public GameObject pet4;
	public GameObject pet5;
	public GameObject pet6;
	public GameObject pet7;
	public GameObject pet8;
	public GameObject pet9;
	public GameObject pet10;


	public static bool pet1Spawn;
	public static bool pet2Spawn;
	public static bool pet3Spawn;
	public static bool pet4Spawn;
	public static bool pet5Spawn;
	public static bool pet6Spawn;
	public static bool pet7Spawn;
	public static bool pet8Spawn;
	public static bool pet9Spawn;
	public static bool pet10Spawn;
	public static bool petSpawned;
	public static bool petSummoned;





	// Use this for initialization
	void Start () 
	{
		
		pet1.GetComponent<Button>().interactable = false;
		pet2.GetComponent<Button>().interactable = false;
		pet3.GetComponent<Button>().interactable = false;
		pet4.GetComponent<Button>().interactable = false;
		pet5.GetComponent<Button>().interactable = false;
		pet6.GetComponent<Button>().interactable = false;
		pet7.GetComponent<Button>().interactable = false;
		pet8.GetComponent<Button>().interactable = false;
		pet9.GetComponent<Button>().interactable = false;
		pet10.GetComponent<Button>().interactable = false;
	}
	
	// Update is called once per frame
	void Update () 
	{
		if (CaptureMonster.pet1)
		{
			pet1.GetComponent<Button>().interactable = true;
		}
		if (CaptureMonster.pet2)
		{
			pet2.GetComponent<Button>().interactable = true;
		}
		if (CaptureMonster.pet3)
		{
			pet3.GetComponent<Button>().interactable = true;
		}
		if (CaptureMonster.pet4)
		{
			pet4.GetComponent<Button>().interactable = true;
		}
		if (CaptureMonster.pet5)
		{
			pet5.GetComponent<Button>().interactable = true;
		}
		if (CaptureMonster.pet6)
		{
			pet6.GetComponent<Button>().interactable = true;
		}
		if (CaptureMonster.pet7)
		{
			pet7.GetComponent<Button>().interactable = true;
		}
		if (CaptureMonster.pet8)
		{
			pet8.GetComponent<Button>().interactable = true;
		}
		if (CaptureMonster.pet9)
		{
			pet9.GetComponent<Button>().interactable = true;
		}
		if (CaptureMonster.pet10)
		{
			pet10.GetComponent<Button>().interactable = true;
		}
		
	}
	
	public void SpawnPet1()
	{
		if (!pet1Spawn){
			petSummoned = true;
			if (!PetHealth.petDead){

				if (CaptureMonster.pet1){
					Destroy(GameObject.FindGameObjectWithTag ("Pet"));
				GameObject Pet1 = Instantiate (Resources.Load ("Prefabs/Pets/Pet1")) as GameObject;
				Pet1.transform.SetParent ((GameObject.Find ("PetHolder").transform), false);
				}

				if (CaptureMonster.pet11){
					Destroy(GameObject.FindGameObjectWithTag ("Pet"));
					GameObject Pet1 = Instantiate (Resources.Load ("Prefabs/Pets/Pet11")) as GameObject;
					Pet1.transform.SetParent ((GameObject.Find ("PetHolder").transform), false);
				}
					petSpawned = true;
			pet1Spawn = true;
			pet2Spawn = false;
			pet3Spawn = false;
			pet4Spawn = false;
			pet5Spawn = false;
				pet6Spawn = false;
				pet7Spawn = false;
				pet8Spawn = false;
				pet9Spawn = false;
				pet10Spawn = false;
			}
		}
	}
	public void SpawnPet2()
	{
		if (!pet2Spawn){
			if (!PetHealth.petDead){
				petSummoned = true;

				if (CaptureMonster.pet2){
					Destroy(GameObject.FindGameObjectWithTag ("Pet"));
					GameObject Pet1 = Instantiate (Resources.Load ("Prefabs/Pets/Pet2")) as GameObject;
					Pet1.transform.SetParent ((GameObject.Find ("PetHolder").transform), false);
				}
			
				if (CaptureMonster.pet12){
					Destroy(GameObject.FindGameObjectWithTag ("Pet"));
					GameObject Pet1 = Instantiate (Resources.Load ("Prefabs/Pets/Pet12")) as GameObject;
					Pet1.transform.SetParent ((GameObject.Find ("PetHolder").transform), false);
				}
			petSpawned = true;

			pet1Spawn = false;
			pet2Spawn = true;
			pet3Spawn = false;
			pet4Spawn = false;
			pet5Spawn = false;
				pet6Spawn = false;
				pet7Spawn = false;
				pet8Spawn = false;
				pet9Spawn = false;
				pet10Spawn = false;
			}
		}
	}
	public void SpawnPet3()
	{
		if (!pet3Spawn){
			if (!PetHealth.petDead){
				petSummoned = true;
			
				if (CaptureMonster.pet3){
					Destroy(GameObject.FindGameObjectWithTag ("Pet"));
					GameObject Pet1 = Instantiate (Resources.Load ("Prefabs/Pets/Pet3")) as GameObject;
					Pet1.transform.SetParent ((GameObject.Find ("PetHolder").transform), false);
				}

				if (CaptureMonster.pet13){
					Destroy(GameObject.FindGameObjectWithTag ("Pet"));
					GameObject Pet1 = Instantiate (Resources.Load ("Prefabs/Pets/Pet13")) as GameObject;
					Pet1.transform.SetParent ((GameObject.Find ("PetHolder").transform), false);
				}
			petSpawned = true;

			pet1Spawn = false;
			pet2Spawn = false;
			pet3Spawn = true;
			pet4Spawn = false;
			pet5Spawn = false;
				pet6Spawn = false;
				pet7Spawn = false;
				pet8Spawn = false;
				pet9Spawn = false;
				pet10Spawn = false;
			}
		}
	}
	public void SpawnPet4()
	{
		if (!pet4Spawn){
			if (!PetHealth.petDead){
				petSummoned = true;

				if (CaptureMonster.pet4){
					Destroy(GameObject.FindGameObjectWithTag ("Pet"));
					GameObject Pet1 = Instantiate (Resources.Load ("Prefabs/Pets/Pet4")) as GameObject;
					Pet1.transform.SetParent ((GameObject.Find ("PetHolder").transform), false);
				}
			
				if (CaptureMonster.pet14){
					Destroy(GameObject.FindGameObjectWithTag ("Pet"));
					GameObject Pet1 = Instantiate (Resources.Load ("Prefabs/Pets/Pet14")) as GameObject;
					Pet1.transform.SetParent ((GameObject.Find ("PetHolder").transform), false);
				}
			petSpawned = true;

			pet1Spawn = false;
			pet2Spawn = false;
			pet3Spawn = false;
			pet4Spawn = true;
			pet5Spawn = false;
				pet6Spawn = false;
				pet7Spawn = false;
				pet8Spawn = false;
				pet9Spawn = false;
				pet10Spawn = false;
			}
		}
	}
	public void SpawnPet5()
	{
		if (!pet5Spawn){
			if (!PetHealth.petDead){
				petSummoned = true;
		
				if (CaptureMonster.pet5){
					Destroy(GameObject.FindGameObjectWithTag ("Pet"));
					GameObject Pet1 = Instantiate (Resources.Load ("Prefabs/Pets/Pet5")) as GameObject;
					Pet1.transform.SetParent ((GameObject.Find ("PetHolder").transform), false);
				}
		
				if (CaptureMonster.pet15){
					Destroy(GameObject.FindGameObjectWithTag ("Pet"));
					GameObject Pet1 = Instantiate (Resources.Load ("Prefabs/Pets/Pet15")) as GameObject;
					Pet1.transform.SetParent ((GameObject.Find ("PetHolder").transform), false);
				}
			petSpawned = true;

			pet1Spawn = false;
			pet2Spawn = false;
			pet3Spawn = false;
			pet4Spawn = false;
			pet5Spawn = true;
				pet6Spawn = false;
				pet7Spawn = false;
				pet8Spawn = false;
				pet9Spawn = false;
				pet10Spawn = false;
			}
		}
	}
	public void SpawnPet6()
	{
		if (!pet6Spawn){
			if (!PetHealth.petDead){
				petSummoned = true;

				if (CaptureMonster.pet6){
					Destroy(GameObject.FindGameObjectWithTag ("Pet"));
					GameObject Pet1 = Instantiate (Resources.Load ("Prefabs/Pets/Pet6")) as GameObject;
					Pet1.transform.SetParent ((GameObject.Find ("PetHolder").transform), false);
				}
			
				if (CaptureMonster.pet16){
					Destroy(GameObject.FindGameObjectWithTag ("Pet"));
					GameObject Pet1 = Instantiate (Resources.Load ("Prefabs/Pets/Pet16")) as GameObject;
					Pet1.transform.SetParent ((GameObject.Find ("PetHolder").transform), false);
				}
				petSpawned = true;
				
				pet1Spawn = false;
				pet2Spawn = false;
				pet3Spawn = false;
				pet4Spawn = false;
				pet5Spawn = false;
				pet6Spawn = true;
				pet7Spawn = false;
				pet8Spawn = false;
				pet9Spawn = false;
				pet10Spawn = false;

			}
		}
	}
	public void SpawnPet7()
	{
		if (!pet7Spawn){
			if (!PetHealth.petDead){
				petSummoned = true;
			
				if (CaptureMonster.pet7){
					Destroy(GameObject.FindGameObjectWithTag ("Pet"));
					GameObject Pet1 = Instantiate (Resources.Load ("Prefabs/Pets/Pet7")) as GameObject;
					Pet1.transform.SetParent ((GameObject.Find ("PetHolder").transform), false);
				}

				if (CaptureMonster.pet17){
					Destroy(GameObject.FindGameObjectWithTag ("Pet"));
					GameObject Pet1 = Instantiate (Resources.Load ("Prefabs/Pets/Pet17")) as GameObject;
					Pet1.transform.SetParent ((GameObject.Find ("PetHolder").transform), false);
				}
				petSpawned = true;
				
				pet1Spawn = false;
				pet2Spawn = false;
				pet3Spawn = false;
				pet4Spawn = false;
				pet5Spawn = false;
				pet6Spawn = false;
				pet7Spawn = true;
				pet8Spawn = false;
				pet9Spawn = false;
				pet10Spawn = false;
				
			}
		}
	}
	public void SpawnPet8()
	{
		if (!pet8Spawn){
			if (!PetHealth.petDead){
				petSummoned = true;

				if (CaptureMonster.pet8){
					Destroy(GameObject.FindGameObjectWithTag ("Pet"));
					GameObject Pet1 = Instantiate (Resources.Load ("Prefabs/Pets/Pet8")) as GameObject;
					Pet1.transform.SetParent ((GameObject.Find ("PetHolder").transform), false);
				}
			
				if (CaptureMonster.pet18){
					Destroy(GameObject.FindGameObjectWithTag ("Pet"));
					GameObject Pet1 = Instantiate (Resources.Load ("Prefabs/Pets/Pet18")) as GameObject;
					Pet1.transform.SetParent ((GameObject.Find ("PetHolder").transform), false);
				}
				petSpawned = true;
				
				pet1Spawn = false;
				pet2Spawn = false;
				pet3Spawn = false;
				pet4Spawn = false;
				pet5Spawn = false;
				pet6Spawn = false;
				pet7Spawn = false;
				pet8Spawn = true;
				pet9Spawn = false;
				pet10Spawn = false;
				
			}
		}
	}
	public void SpawnPet9()
	{
		if (!pet9Spawn){
			if (!PetHealth.petDead){
				petSummoned = true;

				if (CaptureMonster.pet9){
					Destroy(GameObject.FindGameObjectWithTag ("Pet"));
					GameObject Pet1 = Instantiate (Resources.Load ("Prefabs/Pets/Pet9")) as GameObject;
					Pet1.transform.SetParent ((GameObject.Find ("PetHolder").transform), false);
				}

				if (CaptureMonster.pet19){
					Destroy(GameObject.FindGameObjectWithTag ("Pet"));
					GameObject Pet1 = Instantiate (Resources.Load ("Prefabs/Pets/Pet19")) as GameObject;
					Pet1.transform.SetParent ((GameObject.Find ("PetHolder").transform), false);
				}
				petSpawned = true;
				
				pet1Spawn = false;
				pet2Spawn = false;
				pet3Spawn = false;
				pet4Spawn = false;
				pet5Spawn = false;
				pet6Spawn = false;
				pet7Spawn = false;
				pet8Spawn = false;
				pet9Spawn = true;
				pet10Spawn = false;
				
			}
		}
	}
	public void SpawnPet10()
	{
		if (!pet10Spawn){
			if (!PetHealth.petDead){
				petSummoned = true;

				if (CaptureMonster.pet10){
					Destroy(GameObject.FindGameObjectWithTag ("Pet"));
					GameObject Pet1 = Instantiate (Resources.Load ("Prefabs/Pets/Pet10")) as GameObject;
					Pet1.transform.SetParent ((GameObject.Find ("PetHolder").transform), false);
				}

				if (CaptureMonster.pet20){
					Destroy(GameObject.FindGameObjectWithTag ("Pet"));
					GameObject Pet1 = Instantiate (Resources.Load ("Prefabs/Pets/Pet20")) as GameObject;
					Pet1.transform.SetParent ((GameObject.Find ("PetHolder").transform), false);
				}
				petSpawned = true;
				
				pet1Spawn = false;
				pet2Spawn = false;
				pet3Spawn = false;
				pet4Spawn = false;
				pet5Spawn = false;
				pet6Spawn = false;
				pet7Spawn = false;
				pet8Spawn = false;
				pet9Spawn = false;
				pet10Spawn = true;
				
			}
		}
	}
}
