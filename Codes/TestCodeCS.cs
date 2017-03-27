using UnityEngine;
using System.Collections;
public class TestCodeCS : MonoBehaviour
{
    public int numSelectors = 5;
    public GameObject[] selectorArr;
    public GameObject selector; //selected in the editor
    void Start()
    {
        selectorArr = new GameObject[numSelectors];
        for (int i = 0; i < numSelectors; i++)
        {
            GameObject go = Instantiate(selector, new Vector3((float)i, 1, 0), Quaternion.identity) as GameObject;
            go.transform.localScale = Vector3.one;
            selectorArr[i] = go;
        }
    }
}