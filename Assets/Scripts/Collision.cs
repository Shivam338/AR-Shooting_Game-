using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Collision : MonoBehaviour
{
    void OnTriggerEnter(Collider col)
    {
        GameObject explosion = Instantiate(Resources.Load("BigExplosion", typeof(GameObject))) as GameObject;
        explosion.transform.position = transform.position; ;
        Destroy(col.gameObject);
        Destroy(explosion, 2);

        if(GameObject.FindGameObjectsWithTag("Player").Length == 0)
        {
            GameObject enemy = Instantiate(Resources.Load("enemy1", typeof(GameObject))) as GameObject;
            GameObject enemy1 = Instantiate(Resources.Load("enemy2", typeof(GameObject))) as GameObject;
            GameObject enemy2 = Instantiate(Resources.Load("enemy3", typeof(GameObject))) as GameObject;
            GameObject enemy3 = Instantiate(Resources.Load("enemy4", typeof(GameObject))) as GameObject;
        }

        Destroy(gameObject);
    }
}
