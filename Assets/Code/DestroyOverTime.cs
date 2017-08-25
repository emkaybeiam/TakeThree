using UnityEngine;
using System.Collections;

class DestroyOverTime : MonoBehaviour
{
    public float lifeTime;

    private void Start()
    {
        
    }

    private void Update()
    {
        lifeTime = lifeTime - Time.deltaTime;

        if(lifeTime <= 0f)
        {
            Destroy(gameObject);
        }
    }
}

