using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ControllerBehavior : MonoBehaviour
{
    public float followSpeed = 3f;
    public float mouseSpeed = 2f;
    public float cameraDist = 3f;

    public Transform target; // The player or object the camera follows
    public Transform pivot;  // Pivot for rotation (set this in the inspector or dynamically)
    public Camera attachedCamera; // The specific camera this manager controls

    float turnSmoothing = 0.1f;
    public float minAngle = -35f;
    public float maxAngle = 35f;

    float smoothX, smoothY;
    float smoothXvelocity, smoothYvelocity;
    public float lookAngle;
    public float tiltAngle;

    void Awake()
    {
        if (attachedCamera == null)
        {
            attachedCamera = GetComponentInChildren<Camera>();
        }

        if (pivot == null && attachedCamera != null)
        {
            pivot = attachedCamera.transform.parent;
        }
    }

    void FixedUpdate()
    {
        float h = Input.GetAxis("RightStickHorizontal"); // e.g., Joystick Axis 4
        float v = Input.GetAxis("RightStickVertical");
        float targetSpeed = mouseSpeed;

         // Debug.Log($"H: {h}, V: {v}");      debug testing...

        FollowTarget(Time.deltaTime);
        HandleRotations(Time.deltaTime, v, h, targetSpeed);
    }

    void LateUpdate()
    {
        if (attachedCamera == null || pivot == null) return;

        float dist = cameraDist + 1.0f;
        Ray ray = new Ray(pivot.position, attachedCamera.transform.position - pivot.position);
        RaycastHit hit;

        if (Physics.Raycast(ray, out hit, dist) && hit.transform.CompareTag("Wall"))
        {
            dist = hit.distance - 0.25f;
        }

        if (dist > cameraDist) dist = cameraDist;
        attachedCamera.transform.localPosition = new Vector3(0, 0, -dist);
    }

    void FollowTarget(float delta)
    {
        if (target == null) return;

        float speed = delta * followSpeed;
        Vector3 targetPosition = Vector3.Lerp(transform.position, target.position, speed);
        transform.position = targetPosition;
    }

    void HandleRotations(float delta, float v, float h, float targetSpeed)
    {
        if (pivot == null) return;

        if (turnSmoothing > 0)
        {
            smoothX = Mathf.SmoothDamp(smoothX, h, ref smoothXvelocity, turnSmoothing);
            smoothY = Mathf.SmoothDamp(smoothY, v, ref smoothYvelocity, turnSmoothing);
        }
        else
        {
            smoothX = h;
            smoothY = v;
        }

        tiltAngle -= smoothY * targetSpeed;
        tiltAngle = Mathf.Clamp(tiltAngle, minAngle, maxAngle);
        pivot.localRotation = Quaternion.Euler(tiltAngle, 0, 0);

        lookAngle += smoothX * targetSpeed;
        transform.rotation = Quaternion.Euler(0, lookAngle, 0);
    }
}
