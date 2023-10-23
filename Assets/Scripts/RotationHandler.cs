using UnityEngine;

public class RotationHandler : MonoBehaviour
{
    public GameObject planetObject;
    public Vector3 rotationAxis;
    private void Update() {
        planetObject.transform.Rotate(rotationAxis);    
    }
}
