package SimpleSocket;

import java.net.*;
import java.io.*;

class MyClient {
	public static void main(String args[]) throws Exception {
		Socket s = new Socket("localhost", 8888);
		DataInputStream din = new DataInputStream(s.getInputStream());
		
		DataOutputStream dout = new DataOutputStream(s.getOutputStream());
		BufferedReader br = new BufferedReader(new InputStreamReader(System.in));

		String str = "", str2 = "";
		while (!str.equals("stop")) {
			str = br.readLine();
			dout.writeUTF(str);
			dout.flush();  //---> send packet
			
			str2 = din.readUTF();  //--->> receive packet
			System.out.println("Server : " + str2);
		}

		dout.close();
		s.close();
	}
}