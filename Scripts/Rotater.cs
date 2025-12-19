using UnityEngine;

public class Rotater : MonoBehaviour
{
    public Transform rotatingBody;
    public float rotationSpeed = 5f;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {

    }

    // Update is called once per frame
    void FixedUpdate()
    {
        rotatingBody.Rotate(0, 0, rotationSpeed * Time.deltaTime);
    }
}
