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

    void Start()
    {
        gerarseguencias();
    }
    void gerarseguencias()
    {
        cordavez = 0;
        segencia[Random.Range(3, nomes.Length)].ToString();
        UIManager.instance.limpartexto();
        for (int i = 0; i < segencia.Length; i++)
        {
            // vai dar errado
            segencia[Random.Range(0, nomes.Length)].ToString();
            UIManager.instance.atualizarseguencia(nomes[segencia[i]]);
        }
    }

}
