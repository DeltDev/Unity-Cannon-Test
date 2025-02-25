using UnityEngine;

public class CannonController : MonoBehaviour
{
    [SerializeField] private float rotationSpeed;
    [SerializeField] private Transform cannonBody;
    [SerializeField] private float xDegrees, yDegrees;
    
    // Update is called once per frame
    void Update()
    {
        CannonMovement();
    }
    
    void CannonMovement()
    {
        float horizontalInput = Input.GetAxis("Horizontal");
        float verticalInput = Input.GetAxis("Vertical");
        xDegrees += horizontalInput * rotationSpeed * Time.deltaTime;
        yDegrees += verticalInput * rotationSpeed * Time.deltaTime;
        xDegrees = Mathf.Clamp(xDegrees, -43f, 43f);
        yDegrees = Mathf.Clamp(yDegrees, -7f, 48f);
        cannonBody.localEulerAngles = new Vector3(0, yDegrees, xDegrees);
    }    
}
