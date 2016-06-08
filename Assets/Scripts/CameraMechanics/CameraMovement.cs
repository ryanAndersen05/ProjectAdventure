using UnityEngine;
using System.Collections;

public class CameraMovement : MonoBehaviour {
    public Transform target;
    public float offsetX = 0;
    public float offsetY = 0;
    public float movementScale = 1;

    void Start()
    {
        target = GameObject.FindObjectOfType<PlayerController>().transform;
    }

    void Update()
    {
        updateCameraPosition();
    }

    void updateCameraPosition()
    {
        Vector3 goalPosition = new Vector3(target.position.x + offsetX, target.position.y + offsetY, transform.position.z);
        transform.position = Vector3.Slerp(transform.position, goalPosition, movementScale * Time.deltaTime);
        

    }

    public void setTarget(Transform target)
    {
        this.target = target;
    }
}
