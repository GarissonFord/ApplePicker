using UnityEngine;
using System.Collections;

public class Basket : MonoBehaviour 
{
	void OnTriggerEnter(Collider other) 
	{
		Destroy(other.gameObject);
	}
}
