# C# 学习笔记（11）蓝屏小工具
>加载界面参考 [C# Winform 现代化扁平化启动界面设计](https://www.bilibili.com/video/BV17E41147wM)https://www.bilibili.com/video/BV17E41147wM

1. PS做一张图 700*400像素的
![在这里插入图片描述](https://img-blog.csdnimg.cn/20210601222058160.png?x-oss-process=image/watermark,type_ZmFuZ3poZW5naGVpdGk,shadow_10,text_aHR0cHM6Ly9ibG9nLmNzZG4ubmV0L3dlaXhpbl80MjM3ODMxOQ==,size_16,color_FFFFFF,t_70)  

2. 新建一个工程winForm工程
3. 设置窗体属性
>设置窗体格式（无边框）
>设置窗体出现位置（屏幕中心）
>设置窗体不会出现在任务栏上
>设置窗体在桌面最顶层（不会被其他应用程序界面遮住）
>设置窗体背景透明色（和窗体背景色一样）
>设置窗体大小（和图片大小相同即可）
>设置鼠标光标样式
>设置背景图片  

![在这里插入图片描述](https://img-blog.csdnimg.cn/20210601222917513.png?x-oss-process=image/watermark,type_ZmFuZ3poZW5naGVpdGk,shadow_10,text_aHR0cHM6Ly9ibG9nLmNzZG4ubmV0L3dlaXhpbl80MjM3ODMxOQ==,size_16,color_FFFFFF,t_70)  

4.  添加一个label控件，显示加载信息
>拖一个label控件到窗体合适位置
>禁止label自动修改大小并手动修改大小
>设置背景颜色和图片颜色一样
>设置文本对齐方式，居中对齐  
>
![在这里插入图片描述](https://img-blog.csdnimg.cn/20210601223922203.png?x-oss-process=image/watermark,type_ZmFuZ3poZW5naGVpdGk,shadow_10,text_aHR0cHM6Ly9ibG9nLmNzZG4ubmV0L3dlaXhpbl80MjM3ODMxOQ==,size_16,color_FFFFFF,t_70)


5. 拖一个定时器控件，动态修改label文本
![在这里插入图片描述](https://img-blog.csdnimg.cn/20210601224254558.png?x-oss-process=image/watermark,type_ZmFuZ3poZW5naGVpdGk,shadow_10,text_aHR0cHM6Ly9ibG9nLmNzZG4ubmV0L3dlaXhpbl80MjM3ODMxOQ==,size_16,color_FFFFFF,t_70)  
>使能定时器
>修改定时器定时周期 1000ms  
>
![在这里插入图片描述](https://img-blog.csdnimg.cn/20210601224411902.png?x-oss-process=image/watermark,type_ZmFuZ3poZW5naGVpdGk,shadow_10,text_aHR0cHM6Ly9ibG9nLmNzZG4ubmV0L3dlaXhpbl80MjM3ODMxOQ==,size_16,color_FFFFFF,t_70)
>添加定时事件

![在这里插入图片描述](https://img-blog.csdnimg.cn/20210601224527516.png?x-oss-process=image/watermark,type_ZmFuZ3poZW5naGVpdGk,shadow_10,text_aHR0cHM6Ly9ibG9nLmNzZG4ubmV0L3dlaXhpbl80MjM3ODMxOQ==,size_16,color_FFFFFF,t_70)

```csharp
public partial class Form1 : Form
{
    public Form1()
    {
        InitializeComponent();
    }

    //要显示的信息
    List<string> strLog = new List<string> { "加载配置信息", "增加首选项", "正在初始化", "增加脚本支持" };
    private void timerLog_Tick(object sender, EventArgs e)
    {
        if(strLog.Count > 0)
        {
            //更换显示信息
            labLog.Text = strLog[0];
            strLog.RemoveAt(0);
        }
        else
        {
            //返回OK
            this.DialogResult = DialogResult.OK;
            timerLog.Stop();
        }
    }
}
```

6.  加载完毕弹出蓝屏界面
>添加新窗体

![在这里插入图片描述](https://img-blog.csdnimg.cn/20210601231413395.png?x-oss-process=image/watermark,type_ZmFuZ3poZW5naGVpdGk,shadow_10,text_aHR0cHM6Ly9ibG9nLmNzZG4ubmV0L3dlaXhpbl80MjM3ODMxOQ==,size_16,color_FFFFFF,t_70)
>设置窗体默认最大化显示
>设置窗体不会出现在任务栏上
>设置窗体在桌面最顶层（不会被其他应用程序界面遮住）
>设置窗体背景图片及图片显示格式Stretch
>设置窗体无边框
>
![在这里插入图片描述](https://img-blog.csdnimg.cn/20210601231737709.png?x-oss-process=image/watermark,type_ZmFuZ3poZW5naGVpdGk,shadow_10,text_aHR0cHM6Ly9ibG9nLmNzZG4ubmV0L3dlaXhpbl80MjM3ODMxOQ==,size_16,color_FFFFFF,t_70)

>修改main函数，将该窗体显示出来

![在这里插入图片描述](https://img-blog.csdnimg.cn/20210601234720374.png?x-oss-process=image/watermark,type_ZmFuZ3poZW5naGVpdGk,shadow_10,text_aHR0cHM6Ly9ibG9nLmNzZG4ubmV0L3dlaXhpbl80MjM3ODMxOQ==,size_16,color_FFFFFF,t_70)




7.  禁止窗体关闭
> 防止使用 alt+tab 关闭蓝屏窗体 ，注册窗体正在关闭事件，当检测到窗体正在关闭时，取消关闭

![在这里插入图片描述](https://img-blog.csdnimg.cn/20210601233208405.png?x-oss-process=image/watermark,type_ZmFuZ3poZW5naGVpdGk,shadow_10,text_aHR0cHM6Ly9ibG9nLmNzZG4ubmV0L3dlaXhpbl80MjM3ODMxOQ==,size_16,color_FFFFFF,t_70)

```csharp
private void FormBlue_FormClosing(object sender, FormClosingEventArgs e)
{
    e.Cancel = true;
}
```

10.  禁用任务管理器
>这个时候已经有点意思了，但是还可以通过 win+tab创建新桌面，利用任务管理器关掉
>创建一个禁止使用任务管理器的类
```csharp
public static class TaskmgrKill
{
    public static void Run()
    {
        Thread thread = new Thread(Kill);
        thread.IsBackground = true;
        thread.Start();
    }

    static void Kill()
    {
        while (true)
        {
            try
            {
                //获取任务管理器进程句柄
                Process[] process = Process.GetProcessesByName("Taskmgr");
                foreach (var item in process)
                {
                    //关闭任务管理器
                    item.Kill();
                    Thread.Sleep(100);
                }
            }
            catch
            {

            }
        }
    }
}
```
>调用Run方法禁用任务管理器

![在这里插入图片描述](https://img-blog.csdnimg.cn/20210601235756263.png?x-oss-process=image/watermark,type_ZmFuZ3poZW5naGVpdGk,shadow_10,text_aHR0cHM6Ly9ibG9nLmNzZG4ubmV0L3dlaXhpbl80MjM3ODMxOQ==,size_16,color_FFFFFF,t_70)
>现在想关闭，可以通过 win+tab 新建桌面， 然后通过 cmd命令行   taskkill /f /t /im CSharp_蓝屏小工具.exe 
