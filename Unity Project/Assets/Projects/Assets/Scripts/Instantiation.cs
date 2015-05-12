using UnityEngine;
using System.Collections;

public class Instantiation : MonoBehaviour {


	public GameObject enemy;



	void Start (){

		InstantiateEnemy ();

	}


	void InstantiateEnemy()
	{
		enemy.transform.parent = gameObject.transform;
		Instantiate (enemy);
	}
}
