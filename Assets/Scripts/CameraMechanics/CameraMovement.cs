using UnityEngine;
using System.Collections;

public class CameraMovement : MonoBehaviour {
    public Transform target;

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
        Vector3 goalPosition = new Vector3(target.position.x, target.position.y, transform.position.z);
        transform.position = Vector3.Slerp(transform.position, goalPosition, .2f);
        

    }

    public void setTarget(Transform target)
    {
        this.target = target;
    }
}
