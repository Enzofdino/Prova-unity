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


}
