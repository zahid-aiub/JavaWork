
public class myThread implements Runnable{

	public static void main(String[] args) {
		
		myThread mThread = new myThread();
		
		Thread t1 = new Thread(mThread);
			t1.start();
			
			/*
			public void run(){
				for(int i=0;i<10;i++){
					System.out.println("Printing..... " + i);
  				    try{
						sleep(1000);
					}
					catch (Exception e) {
						// TODO: handle exception
					}
				
				}
			}
			*/
		
		
		
	}

	@Override
	public void run() {
		// TODO Auto-generated method stub
		for(int i=0;i<10;i++){
			System.out.println("Printing..... " + i);
			    try{
				Thread.sleep(1000);
			}
			catch (Exception e) {
				// TODO: handle exception
			}
		
		}
	}
	

}
