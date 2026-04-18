using UnityEngine;

public class CamMover : MonoBehaviour
{
    public Transform cam_pos;

    // Update is called once per frame
    void LateUpdate()
    {
       transform.position = cam_pos.position;
    }
}
