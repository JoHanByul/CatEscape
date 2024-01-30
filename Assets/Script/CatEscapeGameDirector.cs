using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class CatEscapeGameDirector : MonoBehaviour
{

    [SerializeField] private Image hpGuage; //À§¿¡ 
  
   public void DecreaseHp()
    {
        this.hpGuage.fillAmount -= 0.1f ;
    }
}
