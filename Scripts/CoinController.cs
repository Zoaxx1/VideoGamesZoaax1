using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CoinController : MonoBehaviour
{

    private void OnTriggerEnter2D(Collider2D collision)
    {
        ScoreManagement.scoreManagement.RaiseScore(1);

        Destroy(transform.parent.gameObject);
    }
}
