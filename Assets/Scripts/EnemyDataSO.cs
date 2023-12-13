using UnityEngine;

[CreateAssetMenu(fileName = "EnemyScriptableObject", menuName = "Scriptable Objects/Enemy")]
public class EnemyDataSO : ScriptableObject
{
    [SerializeField] public int maxHealth;
    [SerializeField] public float moveSpeed;
}
