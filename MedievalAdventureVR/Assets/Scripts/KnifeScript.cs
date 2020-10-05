using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class KnifeScript : MonoBehaviour
{
    private void Start()
    {
        Invoke("DestroyKnife", 5.0f);
    }

    private void DestroyKnife()
    {
        Destroy(gameObject);
    }
}
