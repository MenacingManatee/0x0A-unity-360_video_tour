using UnityEngine;
 
public class CameraController : MonoBehaviour {
    public float speed = 3.5f;
    private float X;
    private float Y;
 
    void Update() {
        if(Input.GetMouseButton(0)) {
            transform.Rotate(new Vector3(Input.GetAxis("Mouse Y") * speed, -Input.GetAxis("Mouse X") * speed, 0));
            X = transform.rotation.eulerAngles.x;
            Y = transform.rotation.eulerAngles.y;
            transform.rotation = Quaternion.Euler(X, Y, 0);
        }
    }
    public void LivingRoom() {
        transform.position = new Vector3(0, 0, 0);
    }
    public void Cantina() {
        transform.position = new Vector3(50, 0, 0);
    }
    public void Cube() {
        transform.position = new Vector3(0, 0, 50);
    }
    public void Mezzanine() {
        transform.position = new Vector3(0, 0, 100);
    }
}