using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class ChangeScene : MonoBehaviour
{
    // 다시하기 버튼 클릭 시 호출될 함수
    public void OnRetryButtonClick()
    {
        // InGame 씬을 로드
        SceneManager.LoadScene("InGame");
    }

    // 메인 버튼 클릭 시 호출될 함수
    public void OnMainMenuButtonClick()
    {
        // MainMenu 씬을 로드합니다.
        SceneManager.LoadScene("Main");
    }
}
