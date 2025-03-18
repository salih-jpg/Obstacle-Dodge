using UnityEngine;
using UnityEngine.Assertions.Comparers;

public class Spin : MonoBehaviour
{
    [SerializeField] float rx;
    [SerializeField] float ry;
    [SerializeField] float rz;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {   
    }

    // Update is called once per frame
    void Update()
    {
        transform.Rotate(rx, ry, rz);
    }
}
