using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MG2_Coin : MonoBehaviour
{
    // Start is called before the first frame update
    public void Update()
    {
        transform.Translate(Vector3.left * 3f * Time.deltaTime);
    }
}
