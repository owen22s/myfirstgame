using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class prefabspawn : MonoBehaviour
{
    [SerializeField] public GameObject prefab;
    [SerializeField] private Vector3 spawnPosition;
    private void Start()
    {
        Instantiate(prefab); 
    }



}