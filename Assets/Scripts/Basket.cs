using UnityEngine;
using System.Collections;

public class Basket : MonoBehaviour 
{
	void OnTriggerEnter(Collider other) 
	{
		if(other.gameObject.CompareTag("Apple"))
			Destroy(other.gameObject);
	}
}
