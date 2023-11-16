using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.XR.ARFoundation;

public class PrefabCreator : MonoBehaviour
{

    [SerializeField] private GameObject shipPrefab;
    [SerializeField] private Vector3 prefabOffset;

    private GameObject ship; //ship insrtance

    private ARTrackedImageManager arTrackedImageManager;

    private void OnEnable()
    {
        arTrackedImageManager = gameObject.GetComponent<ARTrackedImageManager>();
        arTrackedImageManager.trackedImagesChanged += OnImageChanged;
    }

    private void OnImageChanged(ARTrackedImagesChangedEventArgs obj) //Generated
    {
        foreach (ARTrackedImage image in obj.added)
        {
            ship = Instantiate(shipPrefab, image.transform);
            ship.transform.position += prefabOffset;
        }
    }
}
