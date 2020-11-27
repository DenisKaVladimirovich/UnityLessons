using System.Collections;
using UnityEngine;

public class FolllowCamera : MonoBehaviour
{
    public Transform target;
    public Vector3 offset;
    [Range(4, 20)]
    public int SmoothSpeed;
    // Use this for initialization
    void Start()
    {
        GameObject player = GameObject.FindGameObjectWithTag("Player");
        if (player != null)
        {
            target = player.transform;
        }
    }

    // Update is called once per frame
    void Update()
    {
        Vector3 newPosition;
        newPosition.x = target.position.x + offset.x;
        newPosition.y = target.position.y + offset.y;
        newPosition.z = target.position.z + offset.z;
        transform.position = Vector3.Lerp(transform.position, newPosition, Time.deltaTime * SmoothSpeed);
    }
}