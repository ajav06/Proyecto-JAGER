using System.Collections;
using System.Collections.Generic;
using UnityEngine.XR.ARFoundation;
using UnityEngine.XR.ARSubsystems;

using UnityEngine;

[RequireComponent(typeof(ARRaycastManager))]
public class TapToPlaceObjects : MonoBehaviour
{
    public GameObject gameObjecToInstantiate;

    private GameObject SpawnedObject;
    private ARRaycastManager _aRRaycastManager;
    private Vector2 touchPosition;
    private ARPlaneManager aRPlaneManager;
    
    static List<ARRaycastHit> hits = new List<ARRaycastHit>();

    

    // Start is called before the first frame update
    
    private void Awake()
    {
        _aRRaycastManager = GetComponent<ARRaycastManager>();
        aRPlaneManager = GetComponent<ARPlaneManager>();
    }

    bool TryGetToGetTP(out Vector2 touchPosition)
    {

        if (Input.touchCount > 0)
        {
            touchPosition = Input.GetTouch(0).position;
            return true;
        }
        else
            touchPosition = default;
        return false;
    }
    // Update is called once per frame
    void Update()
    {
        foreach (ARPlane plane in aRPlaneManager.trackables)
        {
            plane.gameObject.SetActive(false);
        }

        if (!TryGetToGetTP(out Vector2 touchPosition))
        {
            return;
        }
        if (_aRRaycastManager.Raycast(touchPosition, hits, TrackableType.PlaneWithinPolygon))
        {
            var hitpose = hits[0].pose;

            if (SpawnedObject == null)
            {
                SpawnedObject = Instantiate(gameObjecToInstantiate, hitpose.position, hitpose.rotation);
            }
            else
            {
                SpawnedObject.transform.position = hitpose.position;
            }
        }
    }
}
