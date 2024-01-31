using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class CloudgameDirector : MonoBehaviour
{
    [SerializeField] private Text velocityText;

    public void UpdatevelocityText(Vector2 velocity)
    {
        float velocityX = Mathf.Abs(velocity.x);
        this.velocityText.text = velocity.ToString();
    }
    
}
