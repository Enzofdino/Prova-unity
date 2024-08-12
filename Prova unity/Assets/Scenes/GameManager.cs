using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour
{

    // Start is called before the first frame update
    static public GameManager instance;
    int cordavez, acertos, erros;
    [SerializeField] int[] segencia;
    [SerializeField] string[] nomes;
    #region
    private void Awake()
    {
        instance = this;
    }
    #endregion
}
