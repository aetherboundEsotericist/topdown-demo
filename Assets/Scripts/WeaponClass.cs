using System.Collections;
using System.Collections.Generic;
using Unity.Mathematics;
using Unity.VisualScripting;
using UnityEngine;

// Base class for all weapons (attacks). Variables must be set in the editor. Projectile data goes here because attacks control how projectiles should move.
public class WeaponClass : MonoBehaviour
{
    [SerializeField] public GameObject projectilePrefab;
    public float attackCooldown = 0.5f;
    private float bulletSpeed = 10;
    private float bulletLifetime = 0.5f;
    private float projectileSpeed = 10;

    public void WeaponFire(Vector3 spawnPosition, Quaternion bulletRotation, Vector3 bulletDirection)
    {
        // First, instantiate the projectile
        GameObject spawnedProjectile = Instantiate(projectilePrefab, spawnPosition, bulletRotation);

        // Then, store it in 'spawnedProjectile' and add velocity to it.
        spawnedProjectile.GetComponent<Rigidbody2D>().velocity = new Vector2 (bulletDirection.x, bulletDirection.y).normalized * bulletSpeed;

        // Last, start a coroutine to despawn it after some time.
        StartCoroutine(DespawnProjectile(bulletLifetime, spawnedProjectile));
    }

    IEnumerator DespawnProjectile(float bulletLifetime, GameObject bulletObject)
    {
        yield return new WaitForSeconds(bulletLifetime);
        if(bulletObject)
        {
            Destroy(bulletObject);
        }
    }
}