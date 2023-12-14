using UnityEngine;

public class ResetSize : MonoBehaviour
{
	private Quaternion initialRotation;
	private Vector3 initialScale;

	private void Start()
	{
		initialScale = transform.localScale;
	}

	public void ResetToInitialTransform()
	{
		transform.localScale = initialScale;
	}
}