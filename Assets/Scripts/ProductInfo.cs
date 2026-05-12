using UnityEngine;
using TMPro;
using Vuforia;
using UnityEngine.UI;

public class ProductInfo : MonoBehaviour
{
    [Header("UI Elements")]
    public GameObject infoPanel;
    public TextMeshProUGUI productNameText;
    public TextMeshProUGUI productInfoText;

    [Header("Product Data")]
    public string productName;
    [TextArea(3, 8)]
    public string productDescription;

    private ObserverBehaviour mObserverBehaviour;
    private ModelTouchController _touchController;

    void Start()
    {
        // Vuforia
        mObserverBehaviour = GetComponent<ObserverBehaviour>();
        if (mObserverBehaviour)
            mObserverBehaviour.OnTargetStatusChanged += OnTargetStatusChanged;

        // بنجيب السكريبت من الموديل اللي جوا
        _touchController = GetComponentInChildren<ModelTouchController>();

        // Panel مخفي في البداية
        if (infoPanel != null)
            infoPanel.SetActive(false);
    }

    private void OnTargetStatusChanged(ObserverBehaviour behaviour, TargetStatus targetStatus)
    {
        bool isVisible = targetStatus.Status == Status.TRACKED ||
                         targetStatus.Status == Status.EXTENDED_TRACKED;

        if (isVisible) ShowInfo();
        else HideInfo();
    }

    public void ShowInfo()
    {
        if (infoPanel == null) return;

        infoPanel.SetActive(true);
        productNameText.text = productName;
        productInfoText.text = productDescription;

        // ━━━ الحل: تحديث الـ Layout بشكل صحيح ━━━
        // جبر الـ Canvas يحسب الـ Layout من الأول
        LayoutRebuilder.ForceRebuildLayoutImmediate(infoPanel.GetComponent<RectTransform>());

        // إذا كان الـ Panel جوا ScrollView، نعيّد الموضع للأعلى
        ScrollRect scrollRect = infoPanel.GetComponentInParent<ScrollRect>();
        if (scrollRect != null)
        {
            Canvas.ForceUpdateCanvases();
            LayoutRebuilder.ForceRebuildLayoutImmediate(scrollRect.GetComponent<RectTransform>());
        }
    }

    public void HideInfo()
    {
        if (infoPanel != null)
            infoPanel.SetActive(false);

        // نرجع الموديل لوضعه الأصلي
        if (_touchController != null)
            _touchController.ResetTransform();
    }

    void OnDestroy()
    {
        if (mObserverBehaviour)
            mObserverBehaviour.OnTargetStatusChanged -= OnTargetStatusChanged;
    }
}