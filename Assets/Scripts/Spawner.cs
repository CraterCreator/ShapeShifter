﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Spawner : MonoBehaviour
{
    public Transform spawnPos;
    public GameObject[] Spikes;

    private GameObject spike;
    private int index;

    public float spawnTime;

    // Use this for initialization
    void Start()
    {
        spawnTime = 2;
        StartCoroutine(Spawn());
    }

    // Update is called once per frame
    void Update()
    {
    }

    IEnumerator Spawn()
    {
        for (int i = 0; i < i + 1; i++)
        {
            index = Random.Range(0, Spikes.Length);
            spike = Spikes[index];
            Instantiate(spike, spawnPos.position, spawnPos.rotation);
            yield return new WaitForSeconds(spawnTime);
        }
    }
}
