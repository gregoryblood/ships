using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[RequireComponent(typeof(Camera))]
public class CameraController : MonoBehaviour
{
    public GameObject[] targets;
    public Vector3 offset;
    public float smoothing = 0.5f;
    public float minZoom = 30f;
    public float maxZoom = 120f;
    public float zoomLimiter = 50f;
    

    private Vector3 velocity;
    private Camera cam;

    private void Awake()
    {
        cam = GetComponent<Camera>();
        
    }
    private void Start()
    {
        targets = GameObject.FindGameObjectsWithTag("Boat");
    }
    private void Update()
    {
        targets = GameObject.FindGameObjectsWithTag("Boat");
    }
    // Update is called once per frame
    void LateUpdate()
    {
        if (targets.Length == 0)
            return;
        Move();
        Zoom();
    }
    Vector3 GetCenterPoint ()
    {
        if (targets.Length == 1)
        {
            return targets[0].transform.position;
        }
        var bounds = new Bounds(targets[0].transform.position, Vector3.zero);
        for (int i = 0; i < targets.Length; i++)
        {
            bounds.Encapsulate(targets[i].transform.position);
        }
        return bounds.center;
    }
    void Move()
    {
        Vector3 centerPoint = GetCenterPoint();
        Vector3 newPosition = centerPoint + offset;
        transform.position = Vector3.SmoothDamp(transform.position, newPosition, ref velocity, smoothing);
    }
    void Zoom()
    {
        float newZoom = Mathf.Lerp(maxZoom, minZoom, GetGreatestDistance() / zoomLimiter);
        cam.orthographicSize = Mathf.Lerp(cam.orthographicSize, newZoom, Time.deltaTime);
        
    }
    float GetGreatestDistance ()
    {
        var bounds = new Bounds(targets[0].transform.position, Vector3.zero);
        for (int i = 0; i < targets.Length; i++)
        {
            bounds.Encapsulate(targets[i].transform.position);
        }
        return bounds.size.z + bounds.size.x;
    }
}
