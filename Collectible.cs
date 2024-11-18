using UnityEngine;

public class Collectible : MonoBehaviour
{

    public float rotationSpeed;

    public GameObject onCollectionEffect;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        transform.Rotate(0, rotationSpeed, 0);
    }

    private void OnTriggerEnter(Collider other){

        if (other.CompareTag("Player")){
            Destroy(gameObject);

            Instantiate(onCollectionEffect, transform.position, transform.rotation);
        }



        //Destroy the collectible


    }




}
