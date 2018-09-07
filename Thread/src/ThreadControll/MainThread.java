package ThreadControll;

//import java.awt.Robot;
import java.util.Scanner;

public class MainThread {
	
	static Scanner myScanner= new Scanner(System.in);
	
	private static OurThread thread1 = new OurThread("Robot1", 10, 2, 500, null, true);
	private static OurThread thread2 = new OurThread("Robot2", 50, 5, 1000, thread1, true);
	private static OurThread thread3 = new OurThread("Robot3", 100, 10, 2000, thread2, true);

	public static void main(String[] args) {
		
		thread1.start();
		thread2.start();
		thread3.start();
		
		System.out.println("Please Enter a command: ");
		String commandString = myScanner.nextLine();
		
		if(!commandString.toLowerCase().equals("exit")) {
			
			if(commandString.equals("1")){
				System.out.println("Robot 1 is started...   "+thread1.getCounter());
				threadStatus();
			}
			else if (commandString.equals("2")) {
				System.out.println("Robot 2 is started...   "+thread2.getCounter());
				threadStatus();
			}
			else if (commandString.equals("3")) {
				System.out.println("Robot 3 is started...   "+thread3.getCounter());
				threadStatus();
			}
			
			
			else if (commandString.equals("1s")) {
				thread1.stopThread();
				System.out.println("Robot 1 is stopped...   "+thread1.getCounter());
				threadStatus();
			}
			else if (commandString.equals("2s")) {
				thread2.stopThread();
				System.out.println("Robot 2 is stopped...   "+thread2.getCounter());
				threadStatus();
			}
			else if (commandString.equals("3s")) {
				thread3.stopThread();
				System.out.println("Robot 3 is stopped...   "+thread3.getCounter());
				threadStatus();
			}
			
		
			
			else {
				System.out.println("Please enter a proper command.");
			}
			commandString = myScanner.nextLine();	
		}
		
	}
	
	private static void threadStatus(){
		System.out.println("Robot 1 is alive: "+thread1.isAlive());
		System.out.println("Robot 2 is alive: "+thread2.isAlive());
		System.out.println("Robot 3 is alive: "+thread3.isAlive());
	}

}
