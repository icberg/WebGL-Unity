// 11/1/2024 AI-Tag
// This was created with assistance from Muse, a Unity Artificial Intelligence product

using UnityEngine;

public class DayNightCycle : MonoBehaviour
{
    // Duration of a full day in seconds
    [SerializeField]
    private float dayDuration = 120.0f;

    // Update is called once per frame
    void Update()
    {
        // Calculate the rotation speed
        float rotationSpeed = 360.0f / dayDuration * Time.deltaTime;
        
        // Rotate the light around the X-axis
        transform.Rotate(Vector3.right, rotationSpeed);
    }
}