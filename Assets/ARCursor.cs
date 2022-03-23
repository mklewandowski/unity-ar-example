using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.XR.ARFoundation;

public class ARCursor : MonoBehaviour
{
    public GameObject CursorChildObject;
    public GameObject[] ObjectToPlace;
    public ARRaycastManager RaycastManager;

    public bool UseCursor = true;

    // Start is called before the first frame update
    void Start()
    {
        CursorChildObject.SetActive(UseCursor);
    }

    // Update is called once per frame
    void Update()
    {
        if (UseCursor)
        {
            UpdateCursor();
        }
        if (Input.touchCount > 0 && Input.GetTouch(0).phase == TouchPhase.Began) {
            if (UseCursor)
            {
                int index = Random.Range(0, ObjectToPlace.Length);
                GameObject.Instantiate(ObjectToPlace[index], transform.position, transform.rotation);
            }
            else
            {
                List<ARRaycastHit> hits = new List<ARRaycastHit>();
                RaycastManager.Raycast(Input.GetTouch(0).position, hits, UnityEngine.XR.ARSubsystems.TrackableType.Planes);
                if (hits.Count > 0)
                {
                    int index = Random.Range(0, ObjectToPlace.Length);
                    GameObject.Instantiate(ObjectToPlace[index], hits[0].pose.position, hits[0].pose.rotation);
                }
            }
        }
    }

    void UpdateCursor()
    {
        Vector2 screenPosition = Camera.main.ViewportToScreenPoint(new Vector2(.5f, .5f));
        List<ARRaycastHit> hits = new List<ARRaycastHit>();
        RaycastManager.Raycast(screenPosition, hits, UnityEngine.XR.ARSubsystems.TrackableType.Planes);

        if (hits.Count > 0)
        {
            transform.position = hits[0].pose.position;
            transform.rotation = hits[0].pose.rotation;
        }
    }
}
