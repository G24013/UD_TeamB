using UnityEngine;

public class CharacterSelector : MonoBehaviour
{
    [Header("UI設定")]
    public RectTransform selectionFrame;   // 黄色い枠
    public RectTransform[] buttonPositions; // 各ボタンのRectTransform（6個）

    [Header("3Dモデル設定")]
    public GameObject[] characterModels;   // 左側の3Dモデル（6体）

    void Start()
    {
        // 1人目（0番）を強制的に選択した状態にする
        // characterModels が空（Size 0）でないかだけ確認
        if (characterModels != null && characterModels.Length > 0)
        {
            OnPlayerClick(0);
        }
    }

    public void OnPlayerClick(int index)
    {
        // indexが範囲外なら何もしない
        if (characterModels == null || index < 0 || index >= characterModels.Length) return;

        // --- キャラの切り替え ---
        for (int i = 0; i < characterModels.Length; i++)
        {
            // ここが重要！中身が入っているときだけ実行する
            if (characterModels[i] != null)
            {
                characterModels[i].SetActive(i == index);
            }
        }

        // 枠の移動
        if (selectionFrame != null && buttonPositions[index] != null)
        {
            // 世界の座標(position)ではなく、UIの座標(anchoredPosition)を直接合わせる
            selectionFrame.anchoredPosition = buttonPositions[index].anchoredPosition;

            // 念のため、枠が最前面に来るように設定（他のボタンに隠れないように）
            selectionFrame.SetAsLastSibling();
        }

        // 保存
        PlayerData.selectedCharacterIndex = index;
        PlayerPrefs.SetInt("SavedCharacter", index);
    }
}