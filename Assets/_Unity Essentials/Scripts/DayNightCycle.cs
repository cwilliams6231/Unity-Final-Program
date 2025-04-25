using UnityEngine;

public class DayNightCycle : MonoBehaviour
{
    // The duration of a full day in seconds (editable in Inspector)
    [SerializeField]
    private float dayDurationInSeconds = 120f; // Default is 2 minutes for a full day

    // The current time of day (0 to 1, where 0 is sunrise and 1 is the end of the day)
    private float timeOfDay;

    void Update()
    {
        // Calculate the amount of time that has passed relative to a full day
        timeOfDay += Time.deltaTime / dayDurationInSeconds;

        // Clamp the time of day to loop from 0 to 1 (0 is the start of the day, 1 is the end)
        if (timeOfDay > 1f)
        {
            timeOfDay = 0f;
        }

        // Rotate the directional light (sun) based on the time of day
        float rotationAngle = timeOfDay * 360f; // Full rotation of the light over the day
        transform.rotation = Quaternion.Euler(rotationAngle, 0f, 0f);
    }
}
