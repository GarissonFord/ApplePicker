using UnityEngine;
using System.Collections;

public class ApplePicker : MonoBehaviour {

	public GameObject tree, treeSpawn;

	void Start () 
	{
		Instantiate (tree, treeSpawn.transform);
	}
	
	// Update is called once per frame
	void Update () 
	{
		
	}
}
