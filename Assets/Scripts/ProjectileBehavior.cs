using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;
using System.Linq;

public class ProjectileBehavior : MonoBehaviour
{
    [SerializeField] private int projectileDamage;
    [SerializeField] private string[] ignoreTags;


    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void OnTriggerEnter2D(Collider2D col)
    {
        if (!ignoreTags.Contains(col.tag))
        {
            if (col.tag == "Enemy" || col.tag =="Player")
            {
                damageObject(col.gameObject);
                Destroy(gameObject);
            }
        }
    }

    void damageObject(GameObject hitObject)
    {
        HealthManager objectHealthManager = hitObject.GetComponent<HealthManager>();
        if(objectHealthManager)
        {
            objectHealthManager.updateHealth(projectileDamage);
        }
        else Debug.Log("Hit something else");
    }
}
