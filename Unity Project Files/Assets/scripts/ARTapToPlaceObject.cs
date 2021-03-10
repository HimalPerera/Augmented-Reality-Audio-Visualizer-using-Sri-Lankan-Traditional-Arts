using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.XR.ARFoundation;
using UnityEngine.XR.ARSubsystems;

[RequireComponent(typeof(ARRaycastManager))]
[RequireComponent(typeof(ARReferencePointManager))]
[RequireComponent(typeof(ARPlaneManager))]

public class ARTapToPlaceObject : MonoBehaviour
{

    public GameObject gameObjectToInstantiate;

    private GameObject spawnedObject;
    private ARRaycastManager arRaycastManager;
    private ARReferencePointManager arReferencePointManager;
    private Vector2 touchPosition;
    private ARReferencePoint referencePoint0;
    private ARReferencePoint referencePoint1;
    private ARPlaneManager arPlaneManager;

    //private Vector3 scaleChange;

    static List<ARRaycastHit> hits = new List<ARRaycastHit>();



    private void Awake()
    {
        arRaycastManager = GetComponent<ARRaycastManager>();
        arReferencePointManager = GetComponent<ARReferencePointManager>();
        arPlaneManager = GetComponent<ARPlaneManager>();
    }

    /*bool TryGetTouchPosition(out Vector2 touchPosition)
    {
        if(Input.touchCount > 0)
        {
            touchPosition = Input.GetTouch(0).position;
            return true;
        }

        touchPosition = default;

        return false;
    }*/

    // Update is called once per frame
    void Update()
    {


        if (Input.touchCount > 0)
        {
            Touch touch = Input.GetTouch(0);
            touchPosition = touch.position;

            if (arRaycastManager.Raycast(touchPosition, hits, TrackableType.PlaneWithinPolygon))
            {
                var hitPose = hits[0].pose;


                if (spawnedObject == null)
                {
                    referencePoint0 = arReferencePointManager.AddReferencePoint(hitPose);
                    Quaternion rotation90 = Quaternion.Euler(90,0,0);
                    spawnedObject = Instantiate(gameObjectToInstantiate, referencePoint0.transform.position, rotation90, referencePoint0.transform);
                    



                    arPlaneManager.enabled = false;
                    foreach (ARPlane plane in arPlaneManager.trackables)
                    {
                        plane.gameObject.SetActive(false);
                    }
                }
                else
                {
                    referencePoint1 = arReferencePointManager.AddReferencePoint(hitPose);
                    //Quaternion rotation90 = Quaternion.Euler(90,0,0);
                    spawnedObject.transform.parent = referencePoint1.transform;
                    spawnedObject.transform.position = referencePoint1.transform.position;
                    //spawnedObject.transform.rotation = referencePoint1.transform.rotation;
                    
                }
            }
        }




    }
}
