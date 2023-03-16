# Simple-MediaArt
OpenCV와 게임엔진을 활용한 미디어아트를 목표로 필요한 기능을 개발합니다.  


- 23.03.16
```
python에서 원하는 이미지를 불러와서 자유롭게 drawing 할 수 있습니다.
unity에서 drawing 하는 좌표를 UDP를 통해 전달받습니다.
```

### free draw
![Image](/OpenCV/Resources/Result_1.png)
- opencv를 이용하여 이미지를 입력 받습니다.
- 마우스 좌클릭을 감지하여 이벤트 처리합니다.
- circle을 그려내면서 draw할 수 있도록 합니다.
- 그려지는 좌표는 UDP를 통해 Unity로 전달됩니다.


![Image](/OpenCV/Resources/Result_1_Log.png)
- 전달된 좌표의 log