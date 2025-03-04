using TMPro;
using UnityEngine;

public class CannonAmmo : MonoBehaviour
{
    [SerializeField] private TextMeshProUGUI ammoText;
    public int totalAmmo;
    public int currentAmmo;

    public int CurrentAmmo
    {
        get { return currentAmmo; }
        set
        {
            currentAmmo = value;
            ammoText.text = "Ammo: " + currentAmmo.ToString() + "/" + totalAmmo.ToString();
            Debug.Log("Current Ammo: " + currentAmmo);
            if (currentAmmo <= 0 && GameManager.instance.fallenBricksAmount < GameManager.instance.fallenBricksRequired)
            {
                GameManager.instance.statusMessage.text = "You Lose!";
            }
        }
    }
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        currentAmmo = totalAmmo;
        ammoText.text = "Ammo: " + currentAmmo.ToString() + "/" + totalAmmo.ToString();
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
