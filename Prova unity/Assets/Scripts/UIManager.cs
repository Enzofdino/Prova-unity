using System.Collections;
using System.Collections.Generic;
using System.Linq;
using TMPro;
using Unity.Mathematics;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.UI;
public class UIManager : MonoBehaviour
{
    //sington 
    #region 
    static public UIManager instance;
    // Start is called before the first frame update
    private void Awake()
    {
        instance = this;
    }
    #endregion
    [SerializeField] Button[] butons;
    [SerializeField] TextMeshProUGUI segenciatexto, acertotexto, erroutexto;
    void Start()
    {
        for (int i = 0; i < butons.Length; i++)
        {
            int x = i;
            butons[i].onClick.AddListener(() => GameManager.instance.checarcor(x));
        }
    }

    // Update is called once per frame
    void Update()
    {

    }
    public void atualizaracertos(int acerto)
    {
        acertotexto.text = acerto.ToString();
    }
    public void atualizarerros(int erros)
    {
        erroutexto.text = erros.ToString();
    }
    public void limpartexto()
    {
        segenciatexto.text = null;
    }
    public void atualizarsequencia(string color)
    {
        color += segenciatexto.text;
    }

}
