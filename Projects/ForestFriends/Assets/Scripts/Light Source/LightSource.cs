using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[ExecuteInEditMode]
public class LightSource : MonoBehaviour
{
    [SerializeField] Transform lightSource;
    [SerializeField] Material[] materials;

    void Update()
    {
        for (int i = 0; i < materials.Length; i++)
        {
            materials[i].SetVector("_Light_Source", lightSource.position);
        }
    }

    private void OnDestroy()
    {
        for (int i = 0; i < materials.Length; i++)
        {
            materials[i] = null;
        }
    }
}
