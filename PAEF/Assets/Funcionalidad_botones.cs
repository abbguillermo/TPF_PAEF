using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Funcionalidad_botones : MonoBehaviour
{

    public GameObject menus;
    public GameObject btntienda_1;
    public GameObject btntienda_2;
    // Start is called before the first frame update
    void Start()
    {
        
    }

  public void movmenus()
    {
        menus.transform.LeanMoveLocal(new Vector3(0, 1000, 0), 1).setEaseOutBack();
    }

    public void btn_tienda()
    {
        movmenus();
        btntienda_1.SetActive(true);
        btntienda_2.SetActive(false);
    }
}
