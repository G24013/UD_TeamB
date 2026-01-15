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
        if (characterModels != null && characterModels.Length > 0)
        {
            // PlayerDataに保存されている「今のゲーム中の選択」を呼び出す
            // まだ一度も選んでいなければ、PlayerDataの初期値である「0」が使われます
            OnPlayerClick(PlayerData.selectedCharacterIndex);
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

            // 枠を一番奥（背景側）に移動させる命令
            selectionFrame.SetAsFirstSibling();
        }

        // 保存
        PlayerData.selectedCharacterIndex = index;
    }
}