using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SocialPlatforms.Impl;

public class Crown : MonoBehaviour
{
    public GameObject explosion;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    void OnCollisionEnter(Collision collision)
    {
        print("Crown Collides with " +  collision.gameObject.name);
        if (collision.gameObject.CompareTag("ground")) 
        {
            Score score = FindObjectOfType<Score>();
            if (score) 
            {
                score.EndLevel();
            }
            Destroy(gameObject);
            Instantiate(explosion, transform.position, Quaternion.identity);
        }
    }
    // Update is called once per frame
    void Update()
    {
        
    }
}
