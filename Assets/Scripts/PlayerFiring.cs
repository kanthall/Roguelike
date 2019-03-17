using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerFiring : MonoBehaviour
{
    [SerializeField] GameObject projectiles;
    [SerializeField] Transform weapon;
    [SerializeField] AudioClip projectileSound;
    private bool canFire = true;

    void Start()
    {
      
    }

    private void Update()
    {

    if (Input.GetKeyDown(KeyCode.Space) && canFire == true)
        {
            Fire();
            canFire = false;
        }

    if (Input.GetKeyUp(KeyCode.Space))
        {
            canFire = true;
        }
    }

    public void Fire()
        {
            var newObject = Instantiate(projectiles, weapon.transform.position, transform.rotation);
            AudioSource.PlayClipAtPoint(projectileSound, new Vector3(0, 0, 0));
            Debug.Log("Fire");
        }
    }