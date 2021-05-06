using UnityEngine;
using UnityEngine.UI;


public class ColorButton : MonoBehaviour
{
    private Image _colorImg;
    private Button _colorBtn;


    // Start is called before the first frame update
    private void Awake()
    {
        _colorBtn = GetComponent<Button>();
        _colorImg = GetComponent<Image>();
    }

  // usamos lambda ya que el metodo add listener no me permite enviar parametros,
  // utilizando lambda "hackeamos" la funcion para que nos permita envar parametros.
    private void Start()
    {
        _colorBtn.onClick.AddListener(() => GameManager.Instance.ChangeColor(_colorImg.color));
    }

}
