using UnityEngine;

public class Gyro : MonoBehaviour {
    private bool gyroActive = false;
    private Gyroscope gyro;
    [SerializeField] private Quaternion baseRotation = new Quaternion(0, 0, 1, 0);

    void Start() {
        if (SystemInfo.supportsGyroscope) {
            gyro = Input.gyro;
            gyro.enabled = true;
            gyroActive = true;
        }
        else {
            Debug.LogError("Gyro is not supported!");
        }
    }

    void Update() {
        if (gyroActive) {
            // transform.localRotation = baseRotation * gyro.attitude
            Vector3 gyroRotation = gyro.attitude.eulerAngles;
            Vector3 translatedRotation = new Vector3(-gyroRotation.y, 0, gyroRotation.x);
            transform.localEulerAngles = translatedRotation;
            // Debug.Log(gyro.attitude.eulerAngles);
        }
    }
}