using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ShadowBolt : BaseSpell
{
    public GameObject shadowBolt;
    public float minDamage;
    public float maxDamage;
    public float projectileForce;

    private void Start()
    {
        minDamage = 50;
        maxDamage = 100;
    }

    private void Update()
    {
        if (Input.GetMouseButtonDown(1))
        {
            Vector3 worldMousePos = Camera.main.ScreenToWorldPoint(Input.mousePosition);
            Vector2 direction = ((worldMousePos - transform.position));
            direction.Normalize();
            GameObject spell = Instantiate(shadowBolt, transform.position + (Vector3)(direction * 0.1f), Quaternion.identity);
            spell.GetComponent<Rigidbody2D>().velocity = direction * projectileForce;
            spell.GetComponent<BaseSpell>().damage = minDamage;
        }
    }
}
 