using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Timer : MonoBehaviour {
    GameController gameController;
    Spawnable enemy;
	// Use this for initialization
	void Start () {
        gameController = this.GetComponent<GameController>();
        enemy = gameController.getEnemy();

	}
	
	// Update is called once per frame
	void Update () {
        int random = Random.Range(0, 40);
        Vector3 position;

        if (random == 1)
        {
            float randomRange = Random.Range(1, 3);
            position = GameObject.FindWithTag("choinka").transform.position;
            float alpha = Random.Range(0, 360);
            float beta = Random.Range(0, 360);
            float R = 3;

            position.x = position.x + R * Mathf.Cos(alpha) * Mathf.Sin(beta);
            position.y = position.y + R * Mathf.Cos(beta);
            position.z = position.z + R * Mathf.Sin(alpha) * Mathf.Sin(beta);

            //modifyPosition(position.x, randomRange);
            //position.y = modifyPosition(position.y, randomRange);
            //position.z = modifyPosition(position.z, randomRange);

            gameController.Spawn(enemy,position, Quaternion.identity);
        }
	}
    private float modifyPosition(float current, float range)
    {
        int random = Random.Range(0,10);
        float result;

        if(random%2 == 0)
        {
            result = current + range;
        }
        else
        {
            result = current - range;
        }

        return result;

    }
}
