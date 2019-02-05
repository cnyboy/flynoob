# flynoob 简介 
  [flynoob](https://github.com/cnyboy/flynoob) 是一套通用服务端框架。目标是作为“平行世界”式服务器架构。该框架为单进程多线程结构，使用异步TCP处理网络连接，实现粘包分包处理，心跳机制，消息分发等功能，理论上单个服务端进程可承受数百名玩家。github:https://github.com/cnyboy/flynoob
  
#### 设计说明 :

**1.服务端层级说明**
  该框架把服务端程序分为逻辑层，中间层和底层个层次。
  逻辑层：与游戏内容相关的层级。制作不同的游戏时，只需要更改逻辑层。它包含玩家数据，连接消息，玩家消息，玩家事件4个类。
  中间层：将连接抽象成对玩家的操作。例如：向玩家发送数据，登出游戏，被踢下线。
  底层：包含网络和数据库两个模块。网络模块以异步Socket处理连接，数据库模块封装对MySql的操作。
**2.项目结构说明**
 1.逻辑层：  
    HandlePlayerMsg类：处理角色消息，具体是登陆成功后的逻辑。  
    HandleConnMsg类：处理连接消息，具体是登陆前的逻辑，例如：密码校验，注册账号。  
    HandlePlayerEvent类：处理玩家事件，某个事件发生时需要处理的事情，例如：玩家登陆。  
 2.中间层：  
    Player类：游戏中的角色，功能包括：给角色发消息，踢下线，保存角色数据。  
 3.底层：  
    ServNet类：网络底层，使用异步TCP处理客户端连接，读取客户端消息后分发给HandlleConnMsg和HandlePlayerMsg处理。  
    DataMsg类：数据库封装，操作MySql数据库。  
 4.其他：  
    ProtocolBase类：框架需要支持多种协议格式，它规定了协议中编码，解码等方法的格式。可以按照ProtocolBase的接口实现其他协议格式。  
    ProtocolBytes类：提供一种基于字节流的协议。  
    ProtocolStr类：提供一种基于字符串的协议（不推荐使用）。  
    Sys类：辅助方法类。  




#### 下载地址 Download:

* [下载](https://github.com/cnyboy/flynoob)

### 运行环境
* .Net Core2.1


