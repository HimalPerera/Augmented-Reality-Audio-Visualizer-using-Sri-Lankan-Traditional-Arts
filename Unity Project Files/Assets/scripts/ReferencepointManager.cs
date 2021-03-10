using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.XR.ARFoundation;
using UnityEngine.XR.ARSubsystems;


[RequireComponent (typeof(ARReferencePointManager))]

public class ReferencepointManager : MonoBehaviour
{

	[SerializeField]
	private Camera arCamera;

	public GameObject placedPrefab;
	private GameObject spawnedObject;
	private ARReferencePointManager arReferencePointManager;

	private ARReferencePoint referencePoint0;
    private ARReferencePoint referencePoint1;

	


	void Awake ()
	{
		arReferencePointManager = GetComponent<ARReferencePointManager> ();
	}

	void Update ()
	{
	    
		if (Input.touchCount > 0) {

			Touch touch = Input.GetTouch(0);
			//Vector2 RawPosition = new Vector2 (touch.rawPosition);
			Vector3 position = arCamera.ScreenToWorldPoint (new Vector3 (touch.position.x, touch.position.y, 1.0f));
			Pose pose = new Pose (position, Quaternion.identity);


				if(spawnedObject == null){
					referencePoint0 = arReferencePointManager.AddReferencePoint (pose);
					spawnedObject = Instantiate (placedPrefab, referencePoint0.transform.position, referencePoint0.transform.rotation, referencePoint0.transform);
				} else
				{
					referencePoint1 = arReferencePointManager.AddReferencePoint (pose);
					spawnedObject.transform.position = referencePoint1.transform.position;
					spawnedObject.transform.rotation = referencePoint1.transform.rotation;
                   // spawnedObject.transform.parent = referencePoint1.transform;
				}
			
			
			/*if (arRaycastManager.Raycast(touch.position, hits, TrackableType.PlaneWithinPolygon))
				{
					var hitPose = hits[0].pose;
					var anchorPoint = arAnchorManager.AddAnchor(hitPose);
					var spawnObject = Instantiate(placedPrefab, hitPose.position, hitPose.rotation);
					spawnObject.transform.parent = anchorPoint.transform;
				}
			}*/


		} else
		{
			return;
		}
	}



}



