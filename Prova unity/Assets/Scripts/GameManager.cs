using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    // Start is called before the first frame update
    static public GameManager instance;
    int cordavez, acertos, erros;
    [SerializeField] int[] sequencia;
    [SerializeField] string[] nomes;
    #region
    private void Awake()
    {
        instance = this;
    }
    #endregion
    void Start()
    {
        gerarsequencias();
    }


    void gerarsequencias()
    {
        cordavez = 0;
        sequencia[Random.Range(3, nomes.Length)]++;
        UIManager.instance.limpartexto();
        for (int i = 0; i < sequencia.Length; i++)
        {
            // vai dar errado
           sequencia[Random.Range(0, nomes.Length)]++;
            UIManager.instance.atualizarsequencia(nomes[sequencia[i]]);
        }
    }
    public void checarcor(int corindex)
    {
        if (cordavez == corindex)
        {
            cordavez++;
        }
        if (cordavez == sequencia.Length)
        {
            acertos++;
            UIManager.instance.atualizaracertos(acertos);
            gerarsequencias();
        }
        if (cordavez != sequencia.Length)
        {
            erros++;
            UIManager.instance.atualizarerros(erros);
            gerarsequencias();
        }
    }

}
