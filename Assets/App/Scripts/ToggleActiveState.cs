using UnityEngine;

public class ToggleActiveState : MonoBehaviour
{
	public GameObject objectToToggle;

	public void ToggleObjectActiveState()
	{
		if (objectToToggle != null)
		{
			objectToToggle.SetActive(!objectToToggle.activeSelf);
		}
	}
}