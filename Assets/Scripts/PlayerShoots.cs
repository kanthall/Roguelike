using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerShoots: MonoBehaviour
{
    float moveSpeed1 = 3f;
    float moveSpeed2 = 4f;
    //[SerializeField] float damage = 1f;

    void Update()
    {
        float randomSpeed = Random.Range(moveSpeed1, moveSpeed2);
        transform.Translate(Vector2.right * Time.deltaTime * randomSpeed);
    }
}