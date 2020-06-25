using System;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.XR.ARSubsystems;
using UnityEngine.XR.ARFoundation;

/// This component listens for images detected by the <c>XRImageTrackingSubsystem</c>
/// and overlays some information as well as the source Texture2D on top of the
/// detected image.

[RequireComponent(typeof(ARTrackedImageManager))]
public class TrackedImageInfoManager : MonoBehaviour
{
    // [SerializeField]
    //
    // [Tooltip("The camera to set on the world space UI canvas for each instantiated image info.")]
    // Camera m_WorldSpaceCanvasCamera;
    //
    // /// <summary>
    // /// The prefab has a world space UI canvas,
    // /// which requires a camera to function properly.
    // /// </summary>
    // public Camera worldSpaceCanvasCamera
    // {
    //     get { return m_WorldSpaceCanvasCamera; }
    //     set { m_WorldSpaceCanvasCamera = value; }
    // }
    //
    // [SerializeField]
    // [Tooltip("If an image is detected but no source texture can be found, this texture is used instead.")]
    // Texture2D m_DefaultTexture;
    //
    // /// <summary>
    // /// If an image is detected but no source texture can be found,
    // /// this texture is used instead.
    // /// </summary>
    // public Texture2D defaultTexture
    // {
    //     get { return m_DefaultTexture; }
    //     set { m_DefaultTexture = value; }
    // }

    [SerializeField]
    private GameObject[] arObjectsToPlace;

    [SerializeField]
    private Vector3 scaleFactor = new Vector3(0.3f,0.3f,0.3f);

    ARTrackedImageManager m_TrackedImageManager;

    private Dictionary<string, GameObject> arObjects = new Dictionary<string, GameObject>();

    void Awake()
    {
        m_TrackedImageManager = GetComponent<ARTrackedImageManager>();

        // setup all game objects in dictionary
        foreach(GameObject arObject in arObjectsToPlace)
        {
            GameObject newARObject = Instantiate(arObject, Vector3.zero, Quaternion.identity);
            newARObject.name = arObject.name;
            arObjects.Add(arObject.name, newARObject);
        }
    }

    void OnEnable()
    {
        m_TrackedImageManager.trackedImagesChanged += OnTrackedImagesChanged;
    }

    void OnDisable()
    {
        m_TrackedImageManager.trackedImagesChanged -= OnTrackedImagesChanged;
    }

    void OnTrackedImagesChanged(ARTrackedImagesChangedEventArgs eventArgs)
    {
        foreach (ARTrackedImage trackedImage in eventArgs.added)
        {
            UpdateARImage(trackedImage);
        }

        foreach (ARTrackedImage trackedImage in eventArgs.updated)
        {
            UpdateARImage(trackedImage);
        }

        foreach (ARTrackedImage trackedImage in eventArgs.removed)
        {
            arObjects[trackedImage.name].SetActive(false);
        }
    }

    private void UpdateARImage(ARTrackedImage trackedImage)
    {
        // Assign and Place Game Object
        AssignGameObject(trackedImage.referenceImage.name, trackedImage.transform.position);

        Debug.Log($"trackedImage.referenceImage.name: {trackedImage.referenceImage.name}");
    }

    void AssignGameObject(string name, Vector3 newPosition)
    {
        if(arObjectsToPlace != null)
        {
            GameObject goARObject = arObjects[name];
            goARObject.SetActive(true);
            goARObject.transform.position = newPosition;
            goARObject.transform.localScale = scaleFactor;
            foreach(GameObject go in arObjects.Values)
            {
                Debug.Log($"Go in arObjects.Values: {go.name}");
                if(go.name != name)
                {
                    go.SetActive(false);
                }
            }
        }
    }

    // void UpdateInfo(ARTrackedImage trackedImage)
    // {
    //     // Set canvas camera
    //     var canvas = trackedImage.GetComponentInChildren<Canvas>();
    //     canvas.worldCamera = worldSpaceCanvasCamera;
    //
    //     // Update information about the tracked image
    //     var text = canvas.GetComponentInChildren<Text>();
    //     text.text = string.Format(
    //         "{0}\ntrackingState: {1}\nGUID: {2}\nReference size: {3} cm\nDetected size: {4} cm",
    //         trackedImage.referenceImage.name,
    //         trackedImage.trackingState,
    //         trackedImage.referenceImage.guid,
    //         trackedImage.referenceImage.size * 100f,
    //         trackedImage.size * 100f);
    //
    //     var planeParentGo = trackedImage.transform.GetChild(0).gameObject;
    //     var planeGo = planeParentGo.transform.GetChild(0).gameObject;
    //
    //     // Disable the visual plane if it is not being tracked
    //     if (trackedImage.trackingState != TrackingState.None)
    //     {
    //         planeGo.SetActive(true);
    //
    //         // The image extents is only valid when the image is being tracked
    //         trackedImage.transform.localScale = new Vector3(trackedImage.size.x, 1f, trackedImage.size.y);
    //
    //         // Set the texture
    //         var material = planeGo.GetComponentInChildren<MeshRenderer>().material;
    //         material.mainTexture = (trackedImage.referenceImage.texture == null) ? defaultTexture : trackedImage.referenceImage.texture;
    //     }
    //     else
    //     {
    //         planeGo.SetActive(false);
    //     }
    // }


    // void OnTrackedImagesChanged(ARTrackedImagesChangedEventArgs eventArgs)
    // {
    //     foreach (var trackedImage in eventArgs.added)
    //     {
    //         // Give the initial image a reasonable default scale
    //         trackedImage.transform.localScale = new Vector3(0.3f, 0.3f, 0.3f);
    //         UpdateInfo(trackedImage);
    //     }
    //
    //     foreach (var trackedImage in eventArgs.updated)
    //         UpdateInfo(trackedImage);
    // }
}
