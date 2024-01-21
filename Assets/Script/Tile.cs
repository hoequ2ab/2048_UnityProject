using System.Collections;
using UnityEngine;
using UnityEngine.UI;
using TMPro;
public class Tile : MonoBehaviour
{
    public TitleState state { get; private set; }
    public TileCell cell { get; private set; }
    public int number { get; private set; }
    private Image background;
    private TextMeshProUGUI text;
    private void Awake() 
    {
        background = GetComponentInChildren<Image>();
        text = GetComponentInChildren<TextMeshProUGUI>();    
    }

    public void SetState(TitleState state, int number){
        this.state = state;
        this.number = number;

        background.color = state.backgroundColor;
        text.color = state.textColor;
        text.text = number.ToString();
    }
    public void Spawn(TileCell cell)
    {
        if(this.cell != null){
            this.cell = null;
        }

        this.cell = cell;
        this.cell.tile = this;

        transform.position = cell.transform.position;
    }
    public void MoveTo(TileCell cell)
    {
        if(this.cell != null){
            this.cell = null;
        }

        this.cell = cell;
        this.cell.tile = this;
        transform.position = cell.transform.position;
    }
    private IEnumerator Animate(Vector3 to)
    {
        float elapsed = 0f;
        float duration = 0.1f;

        Vector3 from = transform.position;
        while (elapsed < duration)
        {
            
        }
    }
}
