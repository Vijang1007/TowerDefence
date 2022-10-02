using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BuildTower : MonoBehaviour
{
    public GameObject TowerUI;

    public void Build()
    {
        TowerUI.SetActive(true);
        TowerUI.transform.position = transform.position;
    }
}
