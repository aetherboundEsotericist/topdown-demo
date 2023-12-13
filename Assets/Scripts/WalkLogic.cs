using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WalkLogic : MonoBehaviour {
    [SerializeField] public EnemyDataSO enemyData;
    private const float ForcePower = 10f;
    public new Rigidbody2D rigidbody;
    public float speed;
    public float force = 2f;
    private Vector2 direction;

    void Start(){
        speed = enemyData.moveSpeed;
        rigidbody = GetComponent<Rigidbody2D>();
    }
    public void MoveTo (Vector2 direction) {
        this.direction = direction;
    }

    public void Stop() {
        MoveTo(Vector2.zero);
    }

    private void FixedUpdate() {
        var desiredVelocity = direction * speed;
        var deltaVelocity = desiredVelocity - rigidbody.velocity;
        Vector3 moveForce = deltaVelocity * (force * ForcePower * Time.fixedDeltaTime);
        rigidbody.AddForce(moveForce);
    }
}
