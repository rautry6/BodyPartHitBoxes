using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TestBullet : MonoBehaviour
{
    private float damage = 20f;
    private float speed = 3f;
    private PlayerStats player;

    // Start is called before the first frame update
    void Start()
    {
        player = GameObject.Find("Player").GetComponent<PlayerStats>();
    }

    // Update is called once per frame
    void Update()
    {
        transform.position += transform.forward * Time.deltaTime * speed;
    }


    /// <summary>
    /// Each body part has been give a tag respective to what part it is (i.e. the player's head has the Head tag) and this bullet checks what tag the object has when
    /// colliding and does damage to that part of the body. Also destroys the bullet after colliding as not to have it keep going through the body.
    /// Can deal damage to multiple parts at once.
    /// </summary>
    /// <param name="other"></param>
    private void OnTriggerEnter(Collider other)
    {
        
        if(other.tag == "Head")
        {
            player.HeadHit(damage);
            Destroy(gameObject);
        }
        else if(other.tag == "Body")
        {
            player.BodyHit(damage);
            Destroy(gameObject);
        }
        else if (other.tag == "RightArm")
        {
            player.RightArmHit(damage);
            Destroy(gameObject);
        }
        else if (other.tag == "LeftArm")
        {
            player.LeftArmHit(damage);
            Destroy(gameObject);
        }
        else if (other.tag == "RightLeg")
        {
            player.RightLegHit(damage);
            Destroy(gameObject);
        }
        else if (other.tag == "LeftLeg")
        {
            player.LeftLegHit(damage);
            Destroy(gameObject);
        }
    }
}
