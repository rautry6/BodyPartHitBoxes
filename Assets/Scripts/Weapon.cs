using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public abstract class Weapon : MonoBehaviour
{
    protected string name;
    protected int ammo;
    protected bool isRanged;
    protected bool isMelee;
    protected bool isEquiped;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public abstract void Attack();

    private void OnTriggerEnter(Collider other)
    {
         
    }

}
