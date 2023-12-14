using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DeleteObjectTracker : MonoBehaviour
{
	public List<GameObject> createdObjects = new List<GameObject>();
	public void DeleteMostRecentObject()
	{
		if (createdObjects.Count > 0)
		{
			int lastIndex = createdObjects.Count - 1;
			Destroy(createdObjects[lastIndex]);	
			createdObjects.RemoveAt(lastIndex);
		}
	}
	public void DeleteAllClones()
	{
	foreach (GameObject clone in createdObjects) 
		{
			Destroy(clone);
		}
	}
}
