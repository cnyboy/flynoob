using System;
using System.Net.Sockets;
namespace flynoob
{
    public class Conn
    {
        //缓存大小
        public const int BUFFER_SIZE = 1024;
        //持有一个socket的对象
        public Socket socket;
        //是否使用
        public bool isUse = false;
        //读取缓存
        public byte[] readBuff = new byte[BUFFER_SIZE];
        public int buffCount = 0;
        public byte[] lenBytes = new byte[sizeof(UInt32)];
        public Int32 msgLength = 0;
        //心跳时间
        public long lastTickTime = long.MinValue;
        //对应的Player
        public Player player;

        public Conn()
        {
            readBuff = new byte[BUFFER_SIZE];

        }
        //初始化
        public void Init(Socket socket)
        {
            this.socket = socket;
            isUse = true;
            buffCount = 0;
            lastTickTime = Sys.GetTimeStamp();
        }
        //剩余的Buff
        public int BuffRemain()
        {
            return BUFFER_SIZE - buffCount;
        }
        //获取客户端地址
        public string GetAdress()
        {
            if (!isUse)
                return "无法获取地址";
            return socket.RemoteEndPoint.ToString();
        }
        //关闭
        public void Close()
        {
            if (!isUse)
                return;
            if (player != null)
            {
                player.Logout();
                return;
            }
            Console.WriteLine("[断开链接]" + GetAdress());
            socket.Shutdown(SocketShutdown.Both);
            socket.Close();
            isUse = false;
        }
        public void Send(ProtocolBase protocol)
        {
            ServNet.instance.Send(this, protocol);
        }
    }
}
