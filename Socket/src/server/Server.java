package server;

import java.io.BufferedReader;
import java.io.IOException;
import java.io.InputStreamReader;
import java.net.DatagramPacket;
import java.net.DatagramSocket;
import java.net.InetAddress;
import java.net.SocketException;

public class Server {

	public static void main(String[] args) throws SocketException, IOException {

		DatagramSocket serverSocket = new DatagramSocket(6626);
		boolean bye = false;
		
		while (true) 
		{
			byte[] receivebufferArray = new byte[1024];
			byte[] sendbufferArray = new byte[1024];
			
			DatagramPacket recvdpkt = new DatagramPacket(receivebufferArray, receivebufferArray.length);
			serverSocket.receive(recvdpkt);
			
			InetAddress IP = recvdpkt.getAddress();
			int portno = recvdpkt.getPort();
			
			String clientdata = new String(recvdpkt.getData());
			System.out.println("\nClient : " + clientdata);
			System.out.print("Server : ");
			
			BufferedReader br = new BufferedReader(new InputStreamReader(System.in));
			String serverdata = br.readLine();

			sendbufferArray = serverdata.getBytes();
			DatagramPacket sendPacket = new DatagramPacket(sendbufferArray, sendbufferArray.length, IP, portno);
			serverSocket.send(sendPacket);
			
			if (serverdata.equalsIgnoreCase("bye")) {
				System.out.println("connection ended by server");
				break;
			}

		}
		serverSocket.close();
	}

}