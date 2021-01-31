
using UnityEngine;
using UnityEngine.UI;

public class ColorPick2 : MonoBehaviour
{
    public SpriteRenderer coloringobject;

    public ColorPicker colorPicker;

    private void Start()
    {
        if (coloringobject != null){
            coloringobject.color = colorPicker.color;
            colorPicker.onColorChanged += OnColorChanged;
            this.gameObject.GetComponent<SpriteRenderer>().color = coloringobject.color;
        }
    }

    public void OnColorChanged(Color c)
    {
        coloringobject.color = c;
    }

    private void OnDestroy()
    {
        if (colorPicker != null)
            colorPicker.onColorChanged -= OnColorChanged;
    }
}