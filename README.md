# 1151VR-HW3-414262284-張智瑜

## 專案截圖

![專案截圖](1151VR-HW3-414262284-張智瑜.png)

## GitHub 連結

https://github.com/cychang1688-sketch/1151VR-HW3-414262284-CCY.git

## YouTube 連結

https://youtube.com/shorts/yKaAb8zQwAM

## 製作流程及相關操作說明

首先在 Unity 建立 2D 專案，匯入輪盤及指針圖片，並調整物件的位置與大小。接著建立 RouletteController.cs 腳本，將程式掛載到輪盤物件上，透過 Input.GetMouseButtonDown(0) 偵測滑鼠點擊或手機觸控，使用 transform.Rotate() 控制輪盤旋轉，並利用 rotSpeed *= 0.988f 讓輪盤逐漸減速停止。另外，加入 Audio Source 元件及旋轉音效，設定音效播放時間與速度，使輪盤轉動時能播放聲音。接著調整 Main Camera 的顯示範圍，避免輪盤超出手機螢幕，最後將 Build Profile 切換為 Android，輸出 APK 檔案並安裝至手機測試。操作方式為使用滑鼠左鍵或手指點擊螢幕，輪盤便會開始旋轉並播放音效，隨後逐漸減速直到停止，指針所指向的區域即為結果，再次點擊即可重新旋轉。
