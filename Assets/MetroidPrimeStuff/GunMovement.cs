using UnityEngine;

public class GunMovement : MonoBehaviour
{
    public Transform follow_this;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void LateUpdate()
    {
        transform.rotation = follow_this.rotation;
        transform.position = follow_this.position;
    }
}
