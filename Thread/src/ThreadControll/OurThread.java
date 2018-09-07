package ThreadControll;

public class OurThread extends Thread{
	
	private String threadName;
	private int startingPoint;
	private int counter;
	private int adder;
	private int timeDiff;
	private OurThread dependentThread;
	private boolean threadAliveFlag;
	
	
	public OurThread(String threadName, int startingPoint, int adder, int timeDiff,
			OurThread dependentThread, boolean threadAliveFlag) {
		super();
		this.threadName = threadName;
		this.startingPoint = startingPoint;
		this.adder = adder;
		this.timeDiff = timeDiff;
		this.dependentThread = dependentThread;
		this.threadAliveFlag = threadAliveFlag;
	}
	
	
	public void run(){
		counter=startingPoint;
		
		if (dependentThread!=null) {
			try {
				dependentThread.join();
			} catch (InterruptedException e) {
				// TODO Auto-generated catch block
				e.printStackTrace();
			}
		}
		
		
		while(threadAliveFlag){
			counter+=adder;
			try {
				Thread.sleep(timeDiff);
			} catch (InterruptedException e) {
				// TODO Auto-generated catch block
				e.printStackTrace();
			}
		}
	}
	
	
	public void stopThread(){
		threadAliveFlag=false;
	}
	
	
	////////////////////////////////////////
	
	
	

	public String getThreadName() {
		return threadName;
	}

	public void setThreadName(String threadName) {
		this.threadName = threadName;
	}

	public int getStartingPoint() {
		return startingPoint;
	}

	public void setStartingPoint(int startingPoint) {
		this.startingPoint = startingPoint;
	}

	public int getCounter() {
		return counter;
	}

	public void setCounter(int counter) {
		this.counter = counter;
	}

	public int getAdder() {
		return adder;
	}

	public void setAdder(int adder) {
		this.adder = adder;
	}

	public int getTimeDiff() {
		return timeDiff;
	}

	public void setTimeDiff(int timeDiff) {
		this.timeDiff = timeDiff;
	}

	public OurThread getDependentThread() {
		return dependentThread;
	}

	public void setDependentThread(OurThread dependentThread) {
		this.dependentThread = dependentThread;
	}

	public boolean isThreadAliveFlag() {
		return threadAliveFlag;
	}

	public void setThreadAliveFlag(boolean threadAliveFlag) {
		this.threadAliveFlag = threadAliveFlag;
	}
	

}
