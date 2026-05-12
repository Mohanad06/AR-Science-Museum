using UnityEngine;
using UnityEngine.UI;

public class HelpPanelController : MonoBehaviour
{
    [Header("Panel")]
    public GameObject helpPanel;

    [Header("Help Button")]
    public Button helpButton;

    [Header("Animation (Optional)")]
    public bool useAnimation = true;
    public float animationDuration = 0.3f;

    private CanvasGroup _panelCanvasGroup;

    void Start()
    {
        // إضافة CanvasGroup للأنيميشن
        if (helpPanel != null && useAnimation)
        {
            _panelCanvasGroup = helpPanel.GetComponent<CanvasGroup>();
            if (_panelCanvasGroup == null)
                _panelCanvasGroup = helpPanel.AddComponent<CanvasGroup>();
        }

        // إخفاء البانل في البداية
        if (helpPanel != null)
            helpPanel.SetActive(false);
    }

    public void ShowHelp()
    {
        if (helpPanel == null) return;

        helpPanel.SetActive(true);

        if (useAnimation && _panelCanvasGroup != null)
            StartCoroutine(FadeIn());
    }

    System.Collections.IEnumerator FadeIn()
    {
        _panelCanvasGroup.alpha = 0f;
        float elapsed = 0f;

        while (elapsed < animationDuration)
        {
            elapsed += Time.deltaTime;
            _panelCanvasGroup.alpha = Mathf.Lerp(0f, 1f, elapsed / animationDuration);
            yield return null;
        }

        _panelCanvasGroup.alpha = 1f;
    }
}