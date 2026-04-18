using UnityEngine;

public class PlayerCamera : MonoBehaviour
{
    public float y_sensitivity;
    public float x_sensitivity;

    public Transform orientation;

    float x_rotation;
    float y_rotation;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        Cursor.lockState = CursorLockMode.Locked;
        Cursor.visible = false;
    }

    // Update is called once per frame
    void LateUpdate()
    {
        float mouse_x = Input.GetAxisRaw("Mouse X") * Time.deltaTime * x_sensitivity;
        float mouse_y = Input.GetAxisRaw("Mouse Y") * Time.deltaTime * y_sensitivity;

        y_rotation += mouse_x;

        x_rotation -= mouse_y;

        x_rotation = Mathf.Clamp(x_rotation, -90f, 90f);

        transform.rotation = Quaternion.Euler(x_rotation, y_rotation, 0);
        orientation.rotation = Quaternion.Euler(0, y_rotation, 0);
    }
}
