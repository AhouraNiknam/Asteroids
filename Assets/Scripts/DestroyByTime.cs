using UnityEngine;
using System.Collections;
using UnityEngine.UI;
using UnityEngine.SceneManagement;


public class DestroyByTime : MonoBehaviour
{
    public float lifetime;


    void Start()
    {
        Destroy(gameObject, lifetime);
    }
}