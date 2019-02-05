using flynoob;
using System;

public partial class HandleConnMsg
{
	//心跳
	public void MsgHeatBeat(Conn conn, ProtocolBase protoBase)
	{
		conn.lastTickTime = Sys.GetTimeStamp();
		Console.WriteLine("[更新心跳时间]" + conn.GetAdress());
	}

	//注册
	public void MsgRegister(Conn conn, ProtocolBase protoBase)
	{
		
	}

	//登录
	public void MsgLogin(Conn conn, ProtocolBase protoBase)
	{
		
	}

	//下线
	public void MsgLogout(Conn conn, ProtocolBase protoBase)
	{
	}
}