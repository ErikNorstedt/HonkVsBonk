using UnityEngine;

public class TopdownCameraFollow : MonoBehaviour
{
    [SerializeField] private Transform target;
    [SerializeField] private Vector3 offset = new Vector3(0f, 20, -10f);
    [SerializeField] private float followSpeed = 10;

    private void LateUpdate()
    {
        if (target == null) return;

        transform.position = Vector3.Lerp(transform.position, target.position + offset, Time.deltaTime * followSpeed);
    }
}
