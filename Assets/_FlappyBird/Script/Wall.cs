using System;
using System.Collections;
using System.Collections.Generic;
using GameTool;
using UnityEngine;
using Random = UnityEngine.Random;

public class Wall : BasePooling
{

    public float size;
    public float speed = 2.0f;
    private float[] posY = new float[4];
    private float[] height = new float[4];

    private void OnEnable()
    {
        size = Camera.main.orthographicSize;
        CreateBlocks();
    }

    private void CreateBlocks()
    {
        height[0] = Random.Range(1, 4);
        height[1] = size - height[0];
        height[2] = Random.Range(1, 4);
        height[3] = size - height[2];

        posY[0] = size - height[0] / 2;
        posY[1] = height[1] / 2;
        posY[2] = -height[2] / 2;
        posY[3] = -size + height[3] / 2;

        for (int i = 0; i < 4; i++)
        {
            var position = transform.position;
            var block = (Block) PoolingManager.Instance.GetObject(NamePrefabPool.Block, position: new Vector3(position.x, posY[i], position.z), parent:transform);
            SpriteRenderer sr = block.gameObject.GetComponent<SpriteRenderer>();
            sr.size = new Vector2(1, height[i]);
            BoxCollider2D bc = block.gameObject.GetComponent<BoxCollider2D>();
            bc.size = sr.size;
            bc.offset = Vector2.zero;
        }
    }

    private void Update()
    {
        var position = transform.position;
        transform.Translate(new Vector3(-speed * Time.deltaTime, position.y, position.z));
    }
}
