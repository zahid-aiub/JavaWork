package user;

import java.util.*;
import product_pkg.Shopping_cart;

public class Customer {

	private String c_id;
	private String u_type;
	public String c_name;
	private String c_phn_no;
	private String c_address;
	private String c_creditNo;
	protected String c_memberNo;
	ArrayList<Shopping_cart> s_cart;
	//Order o1;
	
	public Customer(){};
	
	public Customer(String c_id,String c_type,String c_name,String c_phn_no,String c_address,String c_creditNo,double c_creditBalance,String c_passwordNo){

	this.c_id=c_id;
	//this.c_type=c_type;
	this.c_name=c_name;
	this.c_phn_no=c_phn_no;
	this.c_address=c_address;
	this.c_creditNo=c_creditNo;
    //this.c_passwordNo=c_passwordNo;	
	/////////database connection thakbe and getData method thakbe
	}
	private void register(){
		
		
		
	}
	private void pay(){
		
		
	}
	
	
     

	
	
}
