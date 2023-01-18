using ClientServerProjects;

Thread.Sleep(1000);
TcpHelper.StartServer(5000);
TcpHelper.Listen(); // Start listening