package server;

import java.io.BufferedReader;
import java.io.InputStreamReader;
import java.net.DatagramPacket;
import java.net.DatagramSocket;
import java.net.InetAddress;

public class Client {

	public static void main(String[] args) throws Exception
	{
		
		BufferedReader br = new BufferedReader(new InputStreamReader(System.in));
		InetAddress IP = InetAddress.getLocalHost();  //--->> getByName("127.0.0.1");
		DatagramSocket ds = new DatagramSocket();
		
		while (true) 
		{
			byte[] sendbufferArray = new byte[1024];
			byte[] receivebuffer = new byte[1024];

			System.out.print("\nClient: ");
			String clientData = br.readLine();
			sendbufferArray = clientData.getBytes();
			
			DatagramPacket dp = new DatagramPacket(sendbufferArray, sendbufferArray.length, IP, 6626);
			ds.send(dp);
			
			if (clientData.equalsIgnoreCase("bye")) {
				System.out.println("Connection ended by client");
				break;
			}
			DatagramPacket dp1 = new DatagramPacket(receivebuffer, receivebuffer.length);
			ds.receive(dp1);
			
			String serverData = new String(dp1.getData());
			System.out.print("Server: " + serverData);

		}
		ds.close();

	}

}
