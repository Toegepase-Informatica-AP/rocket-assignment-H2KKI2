using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MissileController : MonoBehaviour
{
    [SerializeField]
    private float speed = 10f;

    [SerializeField]
    private GameObject target;

    [SerializeField]
    private ParticleSystem explosion;


    // Update is called once per frame
    void Update()
    {
        transform.position = Vector2.MoveTowards(transform.position, target.transform.position, speed * Time.deltaTime);

        transform.LookAt(target.transform.position);
    }

    private void OnCollisionEnter()
    {

        explosion.transform.parent = null;
        Destroy(gameObject);

        bool withChildren = true;
        explosion.Play(withChildren);
       

    }
}
