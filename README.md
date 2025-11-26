## 使用方法
- 下载release里的DLL文件
- 将DLL文件放入LiveSplit的Components文件夹中（通常在C:\Program Files (x86)\LiveSplit\Components）
- 启动LiveSplit
- 在LiveSplit中，右键点击计时器，选择“Edit Split”
- 在“Edit Splits”窗口中，在Game Name中填入“Path of Exile 2”，正确识别后会有提示“An auto Splits...”
- 点击Activate，点击Settings进行自定义设置
- 选择日志文件的路径，一般是游戏文件里logs文件夹的“Client.txt”文件
- AutoSplitter 提供了多种分割模式：活动（100%）、活动（任意%）和等级。
	- Campaign (100%)包含战役中的所有区域，直至通天塔避难所。
	- Campaign (Any%) 仅包含必要的战役区域和升华区域。
	- Level 达到下一个等级时将自动分割。
- 勾选“Enable Auto Splitting”后，当您首次进入指定的战役区域时，自动分割器将进行分割。如果您按等级进行分割，则会在升级时进行分割。
- 进入区域的顺序很重要，因为分段器目前无法区分进入的是哪个区域以及当前分段索引的位置。如果你计划采用与预设不同的顺序，请在开始游戏前通过“编辑分段”菜单调整你的分段设置。
- 启用“Enable New Character Auto Start”后，当你进入河岸区域时将自动开始计时。

## 即将推出的功能 

- 首领对话分段情况，以实现更精确的分段时间（永恒墓地）
- 首领突袭设置，适用于所有首领和仅限必要首领。
- 非线性分段，允许无序进度推进。
- 测验 / 实现与此存档并退出组件的兼容性：https://github.com/Shotnex4/LiveSplit.TimeAttackPause
- 布局设置上的工具提示。
- 移除读档时间（希望如此！）

## 已知问题和限制
- AutoSplitter 正在读取 Client.txt 文件，目前未考虑加载时间。当战役区域开始加载时触发分段。
- 由于需要多次重返并击杀拉克兰，“永恒墓地”的分段不准确。需要添加“首领对话”分段事件以获得更精确的分段（进入“阴郁纠缠”时分段，击杀拉克兰时增加独立事件）。
- 不确定第二幕中两个哈拉尼之门实例会如何表现

### 感谢

This is my first LiveSplit component and I learned a lot from the following repos and tutorial
- https://github.com/brandondong/POE-LiveSplit-Component/tree/master
- https://github.com/Tazdraperm/Poe2AutoSplit
- https://gist.github.com/TheSoundDefense/cf85fd68ae582faa5f1cc95f18bba4ec
