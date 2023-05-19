using System.Collections;
using System.Collections.Generic;
using System.Runtime.InteropServices.WindowsRuntime;
using Unity.VisualScripting;
using UnityEngine;

public class PlayerProjectiles : MonoBehaviour
{

    public GameObject projectilePrefab;
    private bool cooldown = false;

    private void Update()
    {
        if (Input.GetKeyDown(KeyCode.P) && cooldown == false)
        {
            StartCoroutine(handleCooldown());
            createProjectile();
        }
    }

    private void createProjectile()
    {
        GameObject cloneProjectile = Instantiate(projectilePrefab, transform.position, transform.rotation);
    }

    IEnumerator handleCooldown()
    {
        cooldown = true;
        yield return new WaitForSeconds(0.5f);
        cooldown = false;
    }

}
