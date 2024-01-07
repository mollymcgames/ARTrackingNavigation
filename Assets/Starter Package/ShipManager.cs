using System.Collections;

using UnityEngine;
using UnityEngine.XR.ARFoundation;

/**
 * Spawns a <see cref="ShipBehaviour"/> when a plane is tapped.
 */
public class ShipManager : MonoBehaviour
{
    public GameObject ShipPrefab;
    public ReticleBehaviour Reticle;
    public DrivingSurfaceManager DrivingSurfaceManager;

    public ShipBehaviour Ship;

    private void Update()
    {
        if (Ship == null && WasTapped() && Reticle.CurrentPlane != null)
        {
            // Spawn our car at the reticle location.
            var obj = GameObject.Instantiate(ShipPrefab);
            Ship = obj.GetComponent<ShipBehaviour>();
            Ship.Reticle = Reticle;
            Ship.transform.position = Reticle.transform.position;
            DrivingSurfaceManager.LockPlane(Reticle.CurrentPlane);
        }
    }

    private bool WasTapped()
    {
        if (Input.GetMouseButtonDown(0))
        {
            return true;
        }

        if (Input.touchCount == 0)
        {
            return false;
        }

        var touch = Input.GetTouch(0);
        if (touch.phase != TouchPhase.Began)
        {
            return false;
        }

        return true;
    }
}
