using UnityEngine.AI;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    private Camera cam;
    private Rigidbody rb;
    private NavMeshAgent agent;

    private void Awake()
    {
        cam = Camera.main;
        rb = GetComponent<Rigidbody>();
        agent = GetComponent<NavMeshAgent>();
    }

    private void Update()
    {
        Vector3 mouseWorldPos = cam.ScreenToWorldPoint(Input.mousePosition);
    }
}
