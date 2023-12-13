using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyBehaviorChaser : MonoBehaviour
{
    [SerializeField] public GameObject playerReference;
    [SerializeField] private Transform moveToTarget;
    [SerializeField] private WalkLogic walkLogic;
    private bool isChasing = false;
    void Start()
    {
        playerReference = GameObject.FindGameObjectWithTag("Player");
        moveToTarget = playerReference.transform;
        walkLogic = GetComponent<WalkLogic>();
        StartChase();
    }
    // Update is called once per frame
    void Update()
    {
        if (isChasing)
        {
            var directionTowardsTarget = (moveToTarget.position - transform.position).normalized;
            walkLogic.MoveTo(directionTowardsTarget);
        }
        
    }

    public void StartChase()
    {
        isChasing = true;
    }

    public void StopChase()
    {
        isChasing = false;
    }
}