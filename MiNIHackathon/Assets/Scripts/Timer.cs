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
        int random = Random.Range(0, 60);

        if (random == 1)
        {
            float randomRange = Random.Range(1, 3);
            var TreeGameObject = GameObject.FindWithTag("choinka");
            
            if (TreeGameObject != null) {
                var position = TreeGameObject.transform.position;

                float alpha = Random.Range(0, 360);
                float beta = Random.Range(0, 360);
                float R = 3;

                position.x = position.x + R * Mathf.Cos(alpha) * Mathf.Sin(beta);

                position.y = position.y + R * Mathf.Cos(beta);
                position.z = position.z + R * Mathf.Sin(alpha) * Mathf.Sin(beta);
                
                enemy.GetComponent<Move>().setTree(TreeGameObject.transform);
                gameController.Spawn(enemy, position, Quaternion.identity);
                
                var rigidbody = enemy.GetComponent<Rigidbody>();
                if(rigidbody != null)
                {
                    Debug.Log("");
                }
            }
            

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
