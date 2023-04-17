using System.Collections;
using System.Collections.Generic;
using UnityEngine;

// https://assetstore.unity.com/packages/vfx/particles/hit-impact-effects-free-218385
// https://www.youtube.com/watch?v=SLAYPZ7lukY

public class BulletProjectile : MonoBehaviour
{
    [SerializeField] private Transform vfxHit;
    
    private Rigidbody bulletRigidBody;

    private void Awake()
    {
        bulletRigidBody = GetComponent<Rigidbody>();
    }

    private void Start()
    {
        float speed = 25f;
        bulletRigidBody.velocity = transform.forward * speed;
    }

    private void OnTriggerEnter(Collider other)
    {
        Instantiate(vfxHit, transform.position, Quaternion.identity);
        Destroy(gameObject);
    } 
}
