using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bgmiferenciator : MonoBehaviour
{
    #region Cosas Cambiables
    private float distance;
    [SerializeField] private float distance2Crazy;
    [SerializeField] private float ElVolumen;
    #endregion
    #region ObjectsandSourcer
    [SerializeField] private GameObject ants;
    [SerializeField] private AudioSource calmaoSource;
    [SerializeField] private AudioSource locoSource;
    [SerializeField] private AudioClip calmao;
    [SerializeField] private AudioClip loco;
    #endregion
    // Start is called before the first frame update
    void Start()
    {
        calmaoSource.PlayOneShot(calmao, ElVolumen);
        locoSource.PlayOneShot(loco, ElVolumen);
    }

    // Update is called once per frame
    void Update()
    {
        distance = Vector3.Distance(gameObject.transform.position, ants.transform.position);
        if (distance > distance2Crazy)
        {
            calmaoSource.volume = 1;
            locoSource.volume = 0;
            Debug.Log("Calmao");
        }
        else
        {
            Debug.Log("loco");
            calmaoSource.volume = 0;
            locoSource.volume = 1;
        }
    }
}
