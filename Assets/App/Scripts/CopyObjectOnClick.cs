using UnityEngine;
using Photon.Pun;

public class CopyObjectOnClick : MonoBehaviour
{
	public GameObject objectToCopy;
	public GameObject copiedObjectPrefab;
	public DeleteObjectTracker deleteObjectTracker;

	private GameObject copiedObject;

	public void CopyObject()
	{
		if (objectToCopy != null && copiedObjectPrefab != null)
		{
			Transform originalParent = objectToCopy.transform.parent;
			copiedObject = PhotonNetwork.Instantiate(copiedObjectPrefab.name, objectToCopy.transform.position, objectToCopy.transform.rotation);
			copiedObject.transform.SetParent(originalParent, false);

			// Apply a specific rotation to the copied object relative to its parent
			copiedObject.transform.localPosition = new Vector3(0f, .5f, 0f);
			copiedObject.transform.localRotation = Quaternion.Euler(0f, 0f, 0f);
			copiedObject.transform.localScale = objectToCopy.transform.localScale;

			// Activate the copied object
			copiedObject.SetActive(true);

			// Get Photon View Component
			PhotonView copiedPhotonView = copiedObject.GetComponent<PhotonView>();
			PhotonView originalPhotonView = objectToCopy.GetComponent<PhotonView>();
			if (copiedPhotonView != null && originalPhotonView != null)
			{
				copiedPhotonView.Synchronization = originalPhotonView.Synchronization;
				copiedPhotonView.OwnershipTransfer = originalPhotonView.OwnershipTransfer;
			}

			// Add the copied object to the list
			deleteObjectTracker.createdObjects.Add(copiedObject);
		}
	}
}
