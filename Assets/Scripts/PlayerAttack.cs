using System.Collections;
using System.Collections.Generic;
using Unity.Mathematics;
using UnityEngine;

public class PlayerAttack : MonoBehaviour
{
    [SerializeField] public WeaponClass currentWeapon;
    [SerializeField] public WeaponRotate weaponRotation;
    private bool isAttacking = false;
    private bool canAttack = true;

    void Start()
    {
        //mainCamera = GameObject.FindGameObjectWithTag("MainCamera").GetComponent<Camera>();
        //playerRB = GetComponent<Rigidbody2D>();
        //currentWeapon = currentWeapon.GetComponent<WeaponClass>();
    }

    // Update is called once per frame
    void Update()
    {        
        isAttacking = Input.GetMouseButton(0);
        if (isAttacking && canAttack)
        {
            Vector3 weaponPosition = transform.position;
            Quaternion bulletRotation = weaponRotation.GetRotation(); //I could access the object's rotation directly, but let's try out a getter function.
            Vector3 bulletDirection = weaponRotation.GetMousePosition() - transform.position;
            currentWeapon.WeaponFire(weaponPosition, bulletRotation, bulletDirection);  
            StartCoroutine(CountCooldown(currentWeapon.attackCooldown));
            canAttack = false;  
        }
    }

    IEnumerator CountCooldown(float attackCooldown)
    {
        yield return new WaitForSeconds(attackCooldown);
        canAttack = true;
    }
}