using System;
using UnityEngine;

public class CannonShooter : MonoBehaviour
{
    [SerializeField] private GameObject cannonBallPrefab;
    [SerializeField] private Transform cannonShotPoint;
    [SerializeField] private float shootForce;
    [SerializeField] private CannonAmmo cannonAmmo;

    private void Awake()
    {
        cannonAmmo = GetComponent<CannonAmmo>();
    }

    private void Update()
    {
        if (Input.GetMouseButtonDown(0) && cannonAmmo.currentAmmo > 0)
        {
            Shoot();
        }
    }

    void Shoot()
    {
        GameObject cannonBall = Instantiate(cannonBallPrefab, cannonShotPoint.position, cannonShotPoint.rotation);
        cannonBall.GetComponent<Rigidbody>().AddForce(cannonBall.transform.forward * shootForce, ForceMode.Impulse);
        cannonAmmo.CurrentAmmo--;
    }
}
