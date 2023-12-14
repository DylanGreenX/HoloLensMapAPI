using UnityEngine;

public class TransformSynchronizer : MonoBehaviour
{
	public Transform sourceTransform;
	public Transform targetTransform;

	public void SynchronizeTransform()
	{
		if (sourceTransform != null && targetTransform != null)
		{
			targetTransform.position = sourceTransform.position;
			targetTransform.rotation = sourceTransform.rotation;
			targetTransform.localScale = sourceTransform.localScale;
		}
	}
}